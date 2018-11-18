using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaoShan.Tools
{
    public class SendMessage : ISendMessage
    {
        public string Url { get;private set; }
        public string Account { get; private set; }
        public string Password { get; private set; }

        private SendMessage() { IsInit = false; }

        private static SendMessage _Instance = null;
        public static SendMessage Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new SendMessage();
                }

                return _Instance;
            }
        }


        public bool IsInit { get; private set; }
        public void Init(string url,string account,string password)
        {
            this.Url = url;
            this.Account = account;
            this.Password = password;

            IsInit = true;
        }


        public bool Send(string msg, params string[] phones)
        {
            if (!IsInit) { throw new Exception("send msg is not init"); }

            StringBuilder sbPhone = new StringBuilder();
            foreach(var v in phones)
            {
                if (sbPhone.Length > 0)
                {
                    sbPhone.Append(",");
                }

                sbPhone.Append(v);
            }

            //string sendUrl = string.Format("{0}?action=send&userid=&account={1}&password={2}&mobile={3}&content={4}&sendTime=&extno=",this.Url,this.Account,this.Password, sbPhone.ToString(), msg);

            var client = new RestClient(this.Url);
            var request = new RestRequest(Method.POST);
            request.AddParameter("action", "send");
            request.AddParameter("userid", "");
            request.AddParameter("account", this.Account);
            request.AddParameter("password", this.Password);
            request.AddParameter("mobile", sbPhone.ToString());
            request.AddParameter("content", msg);
            request.AddParameter("sendTime", "");
            request.AddParameter("extno", "");

            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string

            if(content.Contains("Success"))
            {
                return true;
            }
            else
            {
                MessageBox.Show(content);
                return false;
            }
        }
    }
}
