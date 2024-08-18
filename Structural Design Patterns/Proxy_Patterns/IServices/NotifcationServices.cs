using System;

namespace Proxy_Patterns.IServices
{
    public class NotifcationServices : INotifcationServices
    {
        public string SendNotifcation(string custId, int mobile, string MSg)
        {
            return $"Done {custId} , {MSg} ";
        }
    }
}
