using System;
namespace   Proxy_Patterns.IServices
{
    public interface ISMSServices
    {
        string SendMSG(string custId,int mobile,string msg);
    }
}