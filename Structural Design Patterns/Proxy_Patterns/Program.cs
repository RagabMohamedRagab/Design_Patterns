using System;
using Proxy_Patterns;
using Proxy_Patterns.IServices;

namespace Structural
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProxydesignPattern obj = new ProxydesignPattern(new SMSServices());
            System.Console.WriteLine(obj.SendMSG("Ahmed", 12345, "Nice"));
            System.Console.WriteLine(obj.SendMSG("Ahmed", 12345, "Nice"));
            System.Console.WriteLine(obj.SendMSG("Ahmed", 12345, "Nice"));
            System.Console.WriteLine(obj.SendMSG("Ahmed", 12345, "Nice"));

            SendNotifcationAfterSMS c = new SendNotifcationAfterSMS(
                new Proxy_Patterns.IServices.NotifcationServices()
            );
            string result = c.Notifies("aaa", 1234, "ddd") ? "Done" : "Failed";
            System.Console.WriteLine(result);
        }
    }
}
