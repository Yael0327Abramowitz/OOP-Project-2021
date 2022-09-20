using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.IO;
using DAL;

namespace BL
{
   public class CustomerBLL
    {
         CustomerDAL crDAL = new CustomerDAL();//creating an object of type customerDal

        //create customer
        public void Create(string crID, string crName, CreditCard crCard)//giving it the parameters of customer attribute
        {//throwing everything into a try and catch, in case it doesnt work it throws an exception. 
            try
                
            {
                crDAL.Create(crID, crName, crCard);
            }
            catch
            {
                throw;
            }
        }

        //read specific customer
        public Customer Read (string toSee)
        {
           return crDAL.Read(toSee);
        }
        //read all customers
        public List<Customer> ReadAll()
        //returning all info for customerDal, through the ReadAll method. 
        { 
           return crDAL.ReadAll();
        }
        public Customer ReadbyID(string CustomerID)
        {
            if (crDAL.ReadAll().FirstOrDefault(x => x.ID == CustomerID) != null)
                return crDAL.ReadAll().FirstOrDefault(x => x.ID == CustomerID);
            else
            {
                throw new Exception("Your customer ID was not found.\n Please enter a new one. ");
            }
            
        }

        //update customer
        public bool Update(string CustomerID, Customer customer1)
        {
           return crDAL.Update(CustomerID, customer1);//returning the updated customer. 
        }
 
        //delete customer
        public bool Delete(string toDelete)
        {
            return crDAL.Delete(toDelete);
        }
    }
}
