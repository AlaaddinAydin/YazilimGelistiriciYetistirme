﻿namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName= "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 10;

            Product product2 = new Product {Id = 2, ProductName= "Kalem" ,
                CategoryId = 5 , UnitInStock = 5 , UnitPrice = 35};

            ProductManager productManager = new ProductManager();

            productManager.Add(product1);

        }
    }
}