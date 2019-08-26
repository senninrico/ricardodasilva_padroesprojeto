namespace DesignPatterns.Adapter
{
    /// <summary>



    class SocketsTypes
    {


        public int GetPinNumbers(string sockets)
        {

            switch (sockets)
            {
                case "3Pin":
                    return 3;
                case "3PinY":
                    return 3;
                case "2Pin":
                default:
                    return 2;
            }
        }

        public string GetSocketsNames(string sockets)
        {

            switch (sockets)
            {
                case "3Pin":
                    return "Tomada de 3 Pinos BR";
                case "3PinY":
                    return "Tomada de 3 Pinos AR";
                case "2Pin":
                default:
                    return "Tomada de 2 Pinos modelo antigo BR";
            }
        }
    }
}


