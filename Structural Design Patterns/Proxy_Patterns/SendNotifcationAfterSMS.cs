using System;
using Proxy_Patterns.IServices;

namespace Proxy_Patterns
{
    public class SendNotifcationAfterSMS
    {
        private readonly INotifcationServices _notify;
        private readonly ProxydesignPattern _sms;

        public SendNotifcationAfterSMS(INotifcationServices notify)
        {
            _notify = notify;
            _sms = new ProxydesignPattern(new SMSServices());
        }

        public bool Notifies(string custId, int mobile, string msg)
        {
            if (custId == null || msg == null)
                return false;

            _sms.SendMSG(custId, mobile, msg);
            _notify.SendNotifcation(custId, mobile, msg);
            return true;
        }
    }
}
