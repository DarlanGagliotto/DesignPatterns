using System;
using System.Runtime.Remoting.Channels;

namespace Command
{
    public abstract class Command
    {
        protected Receiver reicever;

        public Command(Receiver rc)
        {
            this.reicever = rc;
        }

        public abstract void Execute();
    }
}
