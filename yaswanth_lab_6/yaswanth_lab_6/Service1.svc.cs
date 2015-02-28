using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace yaswanth_lab_6
{
    public class Service1 : IService1
    {

        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/login?userName={userName}")]
        public String login(String userName)
        {
            return "Welcome  " + userName;
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
    }

}
