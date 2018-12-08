using System;
using System.Collections.Generic;
using UBF.Core;
using UBF.Ports;

namespace UBF
{
    public sealed class UniversalBot
    {
        public event EventHandler<Message> OnMessageReceived;
        public event EventHandler<Message> OnMessageSent;

        private readonly Dictionary<string, Port> ports = new Dictionary<string, Port>();

        public bool RegisterPort(Port port, bool unique = true)
        {
            if (unique && this.ports.ContainsKey(port.Name))
            {
                return false;
            }

            this.ports.Add(port.Name, port);

            return true;
        }

        public Port GetPort(string name)
        {
            return this.ports[name];
        }
    }
}
