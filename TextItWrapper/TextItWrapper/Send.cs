using System;
using System.IO;
using System.Net;
namespace TextItWrapper
{
    public class Send
    {
        private string accountId;
        private string accountPassword;
        private int type;

        public Send(string accountId, string accountPassword, int type)
        {
            Config(accountId, accountPassword, type);
        }

        private void Config(string accountId, string accountPassword, int type)
        {
            try
            {
                this.accountId = accountId;
                this.accountPassword = accountPassword;
                this.type = type;
            }
            catch (Exception Ex)
            {
                throw;
            }
        }
        public bool SendSms(string number, string message)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    /// https://textit.biz/Docs/HTTP%20API%20Technical%20Manual%20Rev%201_5.pdf
                    client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                    client.QueryString.Add("id", accountId);                        //94719110252
                    client.QueryString.Add("pw", accountPassword);                  //5466
                    client.QueryString.Add("to", "94" + number.Substring(1));
                    client.QueryString.Add("text", message);
                    client.QueryString.Add("eco", (type == 1) ? "Y" : "N");         // 1- Eco, 2 - Default
                    string baseurl = "http://www.textit.biz/sendmsg/index.php ";    //string baseurl = "http://www.textit.biz/sendmsg";
                    Stream data = client.OpenRead(baseurl);
                    StreamReader reader = new StreamReader(data);
                    string s = reader.ReadToEnd();
                    data.Close();
                    reader.Close();
                    return true;
                }
            }
            catch (Exception Ex)
            {
                throw;
            }
        }
    }
}
