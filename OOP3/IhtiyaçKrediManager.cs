using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyaçKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("ihtiyaç kredisi ödeme planı hesaplandı");
            //throw new NotImplementedException();
        }
    }
}
