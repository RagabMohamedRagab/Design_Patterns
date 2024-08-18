using System;

namespace Proxy_Patterns.IServices
{
    public interface INotifcationServices
    {
        string SendNotifcation(string custId, int mobile, string MSg);
    }
}
