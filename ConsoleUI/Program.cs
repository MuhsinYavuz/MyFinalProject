using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            InMemoryProductDal InMermoryProductDal = new InMemoryProductDal();
            ProductManager productManager = new ProductManager(InMermoryProductDal);

            foreach (var item in productManager.GetAll()) 
            {
                Console.WriteLine(item.ProductId +" --- "  + item.ProductName); 
            }
        }
    }
}
