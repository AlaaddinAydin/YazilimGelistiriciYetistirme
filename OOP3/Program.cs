namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //interfacelerde implamete eden klasın referans numarasını tutabilir
            IKrediManager ihtiyacKrediManger = new IhtiyacKrediManger();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKredisiManager = new EsnafKredisiManager();
            
            ILoggerService databasloggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();
            ILoggerService smsLoggerServide = new SmsLoggerService();

            List<ILoggerService> loggerServices= new List<ILoggerService>
            { databasloggerService,smsLoggerServide};

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKredisiManager,loggerServices);

            List<IKrediManager> krediler = new List<IKrediManager>()
            {ihtiyacKrediManger, tasıtKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}