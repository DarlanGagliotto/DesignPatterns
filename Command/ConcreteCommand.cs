﻿using System;
using System.Security.Cryptography;


namespace Command
{
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
            
        }
        public override void Execute()
        {
         reicever.Action();   
        }
    }
}
