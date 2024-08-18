using System;
using System.Collections.Concurrent;
using Proxy_Patterns.IServices;

namespace Proxy_Patterns
{
    public class ProxydesignPattern
    {
        private readonly ISMSServices _smsService;
        private readonly int _maxMessages = 2; // Configurable limit for the number of messages
        private readonly ConcurrentDictionary<string, int> _numberMSG =
            new ConcurrentDictionary<string, int>();

        public ProxydesignPattern(ISMSServices smsService)
        {
            _smsService = smsService ?? throw new ArgumentNullException(nameof(smsService));
        }

        public string SendMSG(string custId, int mobile, string msg)
        {
            if (_numberMSG.TryGetValue(custId, out int messageCount))
            {
                _numberMSG[custId] = messageCount + 1;
            }
            else
            {
                _numberMSG[custId] = 1;
            }

            return _smsService.SendMSG(custId, mobile, msg);
        }
    }
}
