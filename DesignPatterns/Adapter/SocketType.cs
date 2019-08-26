using System;

namespace DesignPatterns.Adapter
{
    class SocketType : Sockets
    {
        private SocketsTypes _sockets;
        
        public SocketType(string name)
          : base(name)
        {
        }

        public override void Display()
        {
            _sockets = new SocketsTypes();
            _pinNumber = _sockets.GetPinNumbers(_name);
            _comercialname = _sockets.GetSocketsNames(_name);
            base.Display();           
            Console.WriteLine(" Pin count     : {0}", _pinNumber);
            Console.WriteLine(" Comercial Name: {0}", _comercialname);
        }
    }
}


