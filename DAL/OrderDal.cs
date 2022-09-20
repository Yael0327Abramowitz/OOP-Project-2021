using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entities;


namespace DAL
{
    public class OrderDal
    {
        static bool listInited = false;
        ProductDAL proDAL = new ProductDAL();
        static int orderid = 0;
        //creating OrderID
        //every time we call the property OrderID when we make a new order, the orderID is gonna increase by 1

        //initializing an orderList
        static List<Product> productlist = new List<Product>();
        static List<Order> orderlist = new List<Order>();
        static List<Customer> customerList = new List<Customer>();
        #region ***c-tor*** 

        /// <summary>
        ///initialize list; read in values
        /// </summary>
        public void Initializelist()
        {

            StreamReader textfile = new StreamReader("OrderList.txt"); //finding the text file 
            string OrderString;
            for (int i = 0; (OrderString = textfile.ReadLine()) != null; i++) //checks if the textfile still contains order info .
            {   //split method for every product of the textfile
                orderid++;
                string[] array = OrderString.Split(',');
                //putting the info into a new product.
                Order info = new Order (orderid, array[0], array[1], int.Parse(array[2]), DateTime.Parse(array[3]));
               orderlist.Add(info);
            }
            listInited = true;
        }

        /// <summary>
        /// ctor to initialize order
        /// </summary>
        public OrderDal()
        {
            if (listInited == false)
                 Initializelist();
        }
        #endregion
        /// <summary>
        /// CRUD methods for order
        /// </summary>
        /// <param name="productNum"></param>
        /// <param name="productName"></param>
        /// <param name="cost"></param>
        /// <param name="amountIn"></param>
        /// method Insert 
        public void Create(string productNum, string CustomerId, int quantity)//create an order. 
        {
             orderid++;
            if (proDAL.Read(productNum).AmountInStock<quantity)//if there isnt enough of the quantity the customer wants, it should throw an exception.                                                   
            {
                throw new Exception($"There isn`t enough of this product. Currently there are only {quantity} in stock.  Please give in a lower number.  ");
            } 
            orderlist.Add(new Order(orderid,productNum, CustomerId, quantity)); //creating  a new order.
        }
        public Order Read(int orderId)//returns information about an order with a specific orderid. 
        {
            Order ordercopied = orderlist.FirstOrDefault((x)=>x.OrderID==orderId);
            if (ordercopied == null)
            {
                throw new Exception("This orderId could not be found.");
            }   
            return ordercopied;
        }


        public List<Order> ReadEverything()//returns a list of all order information . 
        {
            List<Order> orderlistCopied = orderlist.ConvertAll((order)=>new Order(order.OrderID,order.ProductNumber,order.CustomerID,order.OrderQuantity,order.TimeofOrder));
            return orderlistCopied;
        }

        public List <Order> ReadbyProduct(string productNumber)//returns a list of all orders with a particular productnumber.
        {
            List<Order> productsInOrder = new List<Order>();
            foreach (Order order in orderlist)
            {
                if (order.ProductNumber == productNumber)
                {
                    productsInOrder.Add(order);
                }        
            }
          return productsInOrder;
        }     
        public List <Order> ReadbyCustomer(string customerid)//returns a list of all orders with a particular CustomerID. 
        {
            List<Order> customersInorder = new List<Order>();
            foreach (Order order in orderlist)
            {
                if (order.CustomerID == customerid)
                {
                    customersInorder.Add(order);
                }
            }
            return customersInorder;
        }
        public bool Update(int orderID, Order updatedOrder)//updates the quantity of a certain product in an order. 
        {
            bool upDated = false;
            int indexToUpdate = 0;  //becuase a foreach does not have an index


            foreach (Order or in orderlist)
            {
                if (or.OrderID == orderID)
                {
                    orderlist[indexToUpdate] =updatedOrder;
                    upDated = true;
                    break;
                }
                indexToUpdate++;
            }
            if (upDated == false)//if he couldnt find an order with the orderid, throw an exception. 
            {
                throw new Exception("The orderID could not be found.");
            }
            return upDated;
        }
        public bool DeleteOrder(int orderId)// deletes an order. 
        {
            bool deleted = false;

            foreach (Order order in orderlist)
            {
                if (order.OrderID == orderId)
                {
                    orderlist.Remove(order);
                    deleted = true;
                    break;
                }

            }
            if (deleted == false)
            {
                throw new Exception("this order was not on the list. Please check order ID.");
            }
            return deleted;
        }
    }
}
