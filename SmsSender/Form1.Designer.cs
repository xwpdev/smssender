namespace SmsSender
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Load = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ListView_Contacts = new System.Windows.Forms.ListView();
            this.TextBox_Message = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(13, 18);
            this.btn_Load.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(527, 35);
            this.btn_Load.TabIndex = 0;
            this.btn_Load.Text = "Load from CSV";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.Btn_Load_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ListView_Contacts
            // 
            this.ListView_Contacts.CheckBoxes = true;
            this.ListView_Contacts.Location = new System.Drawing.Point(13, 63);
            this.ListView_Contacts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListView_Contacts.Name = "ListView_Contacts";
            this.ListView_Contacts.RightToLeftLayout = true;
            this.ListView_Contacts.Size = new System.Drawing.Size(527, 259);
            this.ListView_Contacts.TabIndex = 1;
            this.ListView_Contacts.UseCompatibleStateImageBehavior = false;
            this.ListView_Contacts.View = System.Windows.Forms.View.List;
            // 
            // TextBox_Message
            // 
            this.TextBox_Message.Location = new System.Drawing.Point(13, 383);
            this.TextBox_Message.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox_Message.MaxLength = 140;
            this.TextBox_Message.Multiline = true;
            this.TextBox_Message.Name = "TextBox_Message";
            this.TextBox_Message.Size = new System.Drawing.Size(527, 262);
            this.TextBox_Message.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 358);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add message";
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(13, 657);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(527, 35);
            this.btn_Send.TabIndex = 4;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 706);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_Message);
            this.Controls.Add(this.ListView_Contacts);
            this.Controls.Add(this.btn_Load);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS Sender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView ListView_Contacts;
        private System.Windows.Forms.TextBox TextBox_Message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Send;
    }
}

