// See https://aka.ms/new-console-template for more information
using System;

namespace Hillel_HW1_Demchenko
{
    public class Program
    {
        static void Main()
        {
            int orderNumber;
            string clientName;
            string productName;
            string clientAdress;

            //Ордер №1
            Console.WriteLine("Order No ");
            orderNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Client: ");
            clientName = Console.ReadLine();
            Console.WriteLine("Product: ");
            productName = Console.ReadLine();
            Console.WriteLine("Adress: ");
            clientAdress = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Order No {orderNumber}. \nClient: {clientName}. \nProduct: {productName}. \nAdress: {clientAdress}.");
            Console.WriteLine();

            //Ордер №2
            Console.WriteLine("Order No ");
            orderNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Client: ");
            clientName = Console.ReadLine();
            Console.WriteLine("Product: ");
            productName = Console.ReadLine();
            Console.WriteLine("Adress: ");
            clientAdress = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Order No {orderNumber}. \nClient: {clientName}. \nProduct: {productName}. \nAdress: {clientAdress}.");
            Console.WriteLine();

            //Ордер №3
            Console.WriteLine("Order No ");
            orderNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Client: ");
            clientName = Console.ReadLine();
            Console.WriteLine("Product: ");
            productName = Console.ReadLine();
            Console.WriteLine("Adress: ");
            clientAdress = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Order No {orderNumber}. \nClient: {clientName}. \nProduct: {productName}. \nAdress: {clientAdress}.");
            Console.WriteLine();
        }
    }
}
    