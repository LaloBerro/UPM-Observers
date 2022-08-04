using System;

namespace Observers.Core
{
    public interface INotifier
    {
        Action OnNotify { get; set; }
    }
}