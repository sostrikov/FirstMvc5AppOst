using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Net;
namespace FirstMvc5App.Controllers
{
    public class MyIPController : IController
    {
        public void Execute(RequestContext requestContext)
        {
            //string ip = requestContext.HttpContext.Request.UserHostAddress;
            //if (ip == "::1") ip = "127.0.0.1";
            string addr = GetIP();
            var response = requestContext.HttpContext.Response;
            response.Write("<h2>Ваш IP-адрес: " + addr + "</h2>");
        }
        private string GetIP()
        {
            string strHostName = "";
            strHostName = System.Net.Dns.GetHostName();

            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);

            IPAddress[] addr = ipEntry.AddressList;

            return addr[addr.Length - 2].ToString();

        }
    }
}