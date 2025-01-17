﻿using OOP3;

class Program
{
    static void Main(string[] args)
    {
        IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
        IKrediManager tasitKrediManager = new TasitKrediManager();
        IKrediManager konutKrediManager=new KonutKrediManager();

        ILoggerService databaseLoggerService = new DatabaseLoggerService();
        ILoggerService fileLoggerService = new FileLoggerService();
        
        BasvuruManager basvuruManager = new BasvuruManager();
        basvuruManager.BasvuruYap(new EsnafKredisiManager(),new SmsLoggerService());

        List<IKrediManager> krediler=new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager};

        //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
      



        
    }
}