using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    public class Order

    {
        public static  int orderIdStarting = 1;//properties for this class 
        public string ProductNumber { get; set; }
        public string CustomerID { get; set; }
        public int OrderQuantity { get; set; }
        public DateTime TimeofOrder { get; set; }
        public int OrderID { get; private set;}
        //constructor for this class, giving the properties defalut values besides for DateTime that we imply in the constructor. 
        public Order(int orderid, string productnr="", string customerid="", int orderquant=0, DateTime datetime= default(DateTime))
        {
            ProductNumber = productnr;
            CustomerID = customerid;
            OrderQuantity = orderquant;
           if (datetime == default(DateTime))
            {
                TimeofOrder = DateTime.Now;
            }
            //if the order already exists in the Orderlist.txt, he should give it the original dateTime
            else
            {
                TimeofOrder = datetime;
            }
            OrderID= orderid;


        }
        public Order( string productnr = "", string customerid = "", int orderquant = 0, DateTime datetime = default(DateTime))
        {
            ProductNumber = productnr;
            CustomerID = customerid;
            OrderQuantity = orderquant;
            //DateTime should get the value of the current time of order^.
            //if the order doesnt exist in orderlist.txt and were creating a new order
            if (datetime == default(DateTime))
            {
                TimeofOrder = DateTime.Now;
            }
            //if the order already exists in the Orderlist.txt, he should give it the original dateTime
            else
            {
                TimeofOrder = datetime;
            }
        }
        //ToString method for this class. 
        public override string ToString()
        {
            return "  Product Number:  " + ProductNumber + "\r\n  Customer ID :  " + CustomerID +"\r\n  Amount Ordered :  " + OrderQuantity +"\r\n"  +"  Time of order:  "+ TimeofOrder+ "\r\n   Order ID:  " + OrderID;
        }
    }
}


