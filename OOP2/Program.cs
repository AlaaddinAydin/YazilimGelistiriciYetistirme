namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Soyutlama
            IndivisualCustomer customer1 = new IndivisualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.Name = "Engin";
            customer1.Surname = "Naber";
            customer1.TcNo = "2222222222";

            //Kodlama.io

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.CustomerNumber = "54321";
            customer2.Id = 2;
            customer2.CompanyName = "Kodlama.io";
            customer2.VergiNo = "1234567890";



            // Gerçek Müşteri -  Tüzel Müşteri
            // musteri.musteriTipi =  1   , 2 
            // SO L ID 

                                // referans nosu demek
            Customer customer3 = new IndivisualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}