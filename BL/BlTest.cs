using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BL
{
    class BlTest
    {
        static void Main(string[] args)
        {
            {
                try
                {
                   //main to test methods of BLL layer .
                    OrderBLL orderDal = new OrderBLL();
                    
                    orderDal.Create("123", "1234567687987", 4);
                    foreach (var ord in orderDal.ReadAll())
                    {
                        Console.WriteLine(ord);
                    }
                    Order or = new Order("123", "576", 7);
                    foreach (var ord in orderDal.ReadAll())
                    {
                        Console.WriteLine(ord);
                    }
                    Console.WriteLine("READ \n");
                    Console.WriteLine(orderDal.Read(1)); 
                    orderDal.Create("123", "44444", 3);
                    Console.WriteLine("CREATED\n");
                    Console.WriteLine("deleted #2 \n");
                    Console.WriteLine("updated order");
                    foreach (var ord in orderDal.ReadAll())
                    {
                        Console.WriteLine(ord);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
