using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceIearning
{
    class DecouplingRelation
    {

    }
    interface IPhone
    {
        void Deil();
        void PickUp();
        void Send();
        void Receive();
    }
    class NokiaPhone : IPhone
    {
        public void Deil()
        {
            Console.WriteLine("Deil");
        }

        public void PickUp()
        {
            Console.WriteLine("PickUp");
        }

        public void Receive()
        {
            Console.WriteLine("Receive");
        }

        public void Send()
        {
            Console.WriteLine("Send");
        }
    }

    class EricssonPhone : IPhone
    {
        public void Deil()
        {
            Console.WriteLine(" EricssonPhone Deil");
        }

        public void PickUp()
        {
            Console.WriteLine(" EricssonPhone PickUp");
        }

        public void Receive()
        {
            Console.WriteLine(" EricssonPhone Receive");
        }

        public void Send()
        {
            Console.WriteLine(" EricssonPhone Send");
        }
    }


    class PhoneUser
    {
        private IPhone _phone;
        public PhoneUser(IPhone phone)
        {
            _phone = phone;
        }
        public void UserPhone()
        {
            _phone.Deil();
            _phone.PickUp();
            _phone.Receive();
            _phone.Send();
        }
    }
}
