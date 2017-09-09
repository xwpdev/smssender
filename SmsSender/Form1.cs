using System;
using System.IO;
using System.Windows.Forms;
using TextItWrapper;

namespace SmsSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Load_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filename = openFileDialog1.FileName;
                    string filelines = File.ReadAllText(filename);
                    if (!string.IsNullOrEmpty(filelines))
                    {
                        var items = ListView_Contacts.Items;
                        foreach (var number in filelines.Split(','))
                        {
                            if (!string.IsNullOrEmpty(number))
                            {
                                // check duplicates
                                items.Add(number);
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (ListViewItem number in ListView_Contacts.CheckedItems)
            {
                var message = TextBox_Message.Text.Trim();
                if (!SendSms(number.Text, message))
                    continue;
                else count++;
            }
            var dialogResult = MessageBox.Show(string.Format("{0} sms sent", count), "Success");
            if (dialogResult == DialogResult.OK)
            {
                this.Controls.Clear();
                this.InitializeComponent();
            }
        }

        private bool SendSms(string number, string message)
        {
            Send send = new Send("94719110252", "5466", 1);
            return send.SendSms(number, message);
        }
    }
}
