using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BL
{
    public class OrderBLL
    {
        OrderDal orDAL = new OrderDal();
        CustomerBLL custo = new CustomerBLL();
        ProductBL prob = new ProductBL();

        //create  an order
        public void Create (string productNum, string customerId, 
            int quantity)
        {//throwing everything into a try and catch, in case it doesnt work it throws an exception. 
            Product productExists=null;
            bool customerExists = false;
            bool amountEnough = false;
            try
           {
                //finds the product with prodcutNum
                foreach (Product pr in prob.ReadAll())
                {
                    if (productNum == pr.Product_Number)
                    {
                        productExists = pr;
                        break;
                    }
                }
                foreach (Customer cus in custo.ReadAll())//checks if a customer with that customer id exists. 
                {
                    if (customerId == cus.ID)
                    {
                        customerExists = true;

                        break;
                    }
                }
                if (productExists != null && productExists.AmountInStock >= quantity && customerExists == true) //if the product and customer i want exist and i have enough amount in stock, create the order. 
                {
                    amountEnough = true;
                                    orDAL.Create(productNum, customerId, quantity);
                    prob.Update(productExists.Product_Number, new Product(productExists.Product_Number, productExists.Product_Name, productExists.Cost_Per_Unit, productExists.AmountInStock - quantity));//updates the quantity
               }
            }
            catch (Exception ex )
            {
                throw ex;
            }
            if (productExists.Product_Number=="")
            {
                throw new Exception("Oops! Something went wrong! Please check that you entered the product number correctly. ");
            }
             if (customerExists == false)
            {
                throw new Exception(" Dear customer- please become a member of our family! Become a member to make online orders and get whopping daily discounts!");
            }
             if (amountEnough == false)
            {
                throw new Exception("Oops! Something went wrong! We don't have enough in stock!");
            }
        }

        //read specific order
        public Order Read(int toSee)
        {
            return orDAL.Read(toSee);
        }


        //read all orders
        public List<Order> ReadAll() 
        {
            return orDAL.ReadEverything();
        }
        public List<Order> ReadbyID(string CustomerID)//reads an order by giving in a customer ID. 
        {
            if (orDAL.ReadEverything().FindAll(x => x.CustomerID == CustomerID).Count != 0)
                return orDAL.ReadEverything().FindAll(x => x.CustomerID == CustomerID);
            else
            {
                throw new Exception("You dont have any orders.");
            }

        }
        //updates an order. 
        public bool Update (int orderID, Order updatedOrder, int newQuantity)
        {//checking if the order quantity is less than or equal to the quantity allowed, meaning the amount in stock for this particular product.

            if (prob.Read(updatedOrder.ProductNumber).AmountInStock + orDAL.Read(orderID).OrderQuantity < newQuantity)//checking if i have enough in stock
                  throw new Exception("Not enough in stock.");
            else
            {
                // Order update;
                foreach (Order ord in orDAL.ReadEverything())
                {
                    if (orderID == ord.OrderID)
                    {
                        foreach (Product pr in prob.ReadAll())
                        {
                            if (pr.Product_Number == ord.ProductNumber)
                            {
                                pr.AmountInStock += ord.OrderQuantity;
                                prob.Update(pr.Product_Number, pr);
                                pr.AmountInStock -= newQuantity;
                                prob.Update(pr.Product_Number, pr);
                                return orDAL.Update(orderID, new Order(updatedOrder.OrderID, updatedOrder.ProductNumber, updatedOrder.CustomerID, newQuantity));
                            }
                        }
                    }
                }
            }
            return false;
        }

        //delete order
        public bool Delete(int toDelete)
        //returning the deleted order. 
        {
            foreach (Order ord in orDAL.ReadEverything())
            { 
                if (toDelete  == ord.OrderID)
                {
                    foreach (Product pr in prob.ReadAll())
                    {
                        if (pr.Product_Number==ord.ProductNumber)
                        {
                            pr.AmountInStock += ord.OrderQuantity;
                            prob.Update(pr.Product_Number, pr);
                            break;
                        }                                   
                    }   
                } 
            }
           return orDAL.DeleteOrder(toDelete);
        }


    }
}
