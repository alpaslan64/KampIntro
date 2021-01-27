using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyaçKrediManager = new IhtiyaçKrediManager();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new SmsLoggerService());


            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyaçKrediManager, tasıtKrediManager };

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
