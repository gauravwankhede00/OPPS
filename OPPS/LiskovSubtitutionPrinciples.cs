using System;

namespace OPPS
{
    
    class PaymentType
    {
        static void Main()
        {
            PayPal paypal = new PayPal();

            paypal.SendMoney();

            Cash cash = new Cash();
            cash.SendMoney();


        }
        public virtual void SendMoney()
        {
            Console.WriteLine("Pay");
        }
    }

    class PayPal : PaymentType
    {
        public override void SendMoney()
        {
            Console.WriteLine("Paypal");
        }
    }

    class MasterCard : PaymentType
    {
        public override void SendMoney()
        {
            Console.WriteLine("MasterCard");
        }
    }

    class Cash : PaymentType
    {
        public override void SendMoney()
        {
            throw new NotImplementedException();
        }
    }
}
