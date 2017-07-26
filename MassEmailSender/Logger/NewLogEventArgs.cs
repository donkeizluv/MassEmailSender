using System;

namespace Log
{
    public class NewLogEventArgs : EventArgs
    {
        public NewLogEventArgs(string log)
        {
            Log = log;
        }

        public string Log { get; private set; }
    }
}