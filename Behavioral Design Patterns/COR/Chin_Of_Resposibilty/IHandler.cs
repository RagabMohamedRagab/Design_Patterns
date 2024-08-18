using System;

namespace COR.Chin_Of_Resposibilty
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        object Handle(object request);
    }
}
