using System;
namespace Proxy_Patterns.IServices{
    public class SMSServices:ISMSServices{
      public  string SendMSG(string custId,int mobile,string msg){
                  return $"send to {custId}, Message {msg}";
        }
    }
}