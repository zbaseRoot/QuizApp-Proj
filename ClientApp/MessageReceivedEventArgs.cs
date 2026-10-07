using System;
using System.Collections.Generic;
using System.Text;

namespace ClientApp
{
    public class MessageReceivedEventArgs : EventArgs
    {
        public string Message { get; set; }
    }
}
