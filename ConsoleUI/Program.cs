﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var productManager = new ProductManager(new EfProductDal());
            productManager.GetProductsByCategoryId(4).ForEach(Console.WriteLine);

        }
    }
}
