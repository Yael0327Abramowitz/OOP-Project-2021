using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entities;
using DAL;



namespace DAL
{
   public class CustomerDAL
    {
        static bool listInit = false;
        //creating a customer list 
        static List<Customer> customerList = new List<Customer>();
        //initializing the list by reading in values
        public void Initializelist()
        {
            listInit = true;
            StreamReader file = new StreamReader(
                "NewCustomerTextFile.txt"); //finding the text file 
            string customer;
            for (int i = 0; (customer = file.ReadLine()) != null; i++) //checks if the textfile still contains people .
            {   //split method for every product of the textfile
                string[] array = customer.Split(',');
                //putting the info into a new product.
                CreditCard info = new CreditCard(array[0], array[1], DateTime.Parse(array[2]), double.Parse(array[3]));
                Customer cus = new Customer(info, array[4], array[5]);
                customerList.Add(cus);
            }

        }
        //ctor
        public CustomerDAL()
        {
            if(listInit == false)
                Initializelist();
        }
       // method to create a new customer
        public void Create(string id, string Name, CreditCard Card)
        {
            string idd = id;
            if (customerList.Find(x => (x.ID) == idd) != null)//if the id already exists in the list, it should throw an exception. 
            {
                throw new Exception("This product number already exists. Please enter a different one. ");

            }
            customerList.Add(new Customer(Card, Name, id)); //creating  a new product. 

        }
       // method to read the information about a customer.
        public Customer Read(string toread) 
        {
            bool seen = false;
            Customer copied;
            foreach (Customer cr in customerList)
            {
                if (cr.ID == toread)
                {
                    copied = new Customer(cr.MyCard,cr.Name,cr.ID);
                    return copied;
                    //returns a COPY of the customer information. 
                }

            }
            
            if (seen == false)
            {
                throw new Exception("This customer was not found on the list, please check your spelling.");
                //throws an exception if the customer couldnt be found. 
            }
            return null;
        }
        public List<Customer> ReadAll()//shows all information about a customer. 
        {
            List<Customer> crlist = customerList.ConvertAll(Customer => new Customer(Customer.MyCard, Customer.Name, Customer.ID));
            return crlist;
        }
        //method that updates a customer
        public bool Update(string CustomerID, Customer cust)
        {
            bool upDated = false;
            int indexToUpdate = 0;
            Customer copied;

            foreach (Customer cr in customerList)
            {
                if (cr.ID == CustomerID)
                {
                    customerList[indexToUpdate] = cust;
                    copied = new Customer(cust.MyCard, cust.Name, cust.ID);
                    upDated = true;
                    break;
                }
                indexToUpdate++;
            }

            if (upDated == false)
            {
                throw new Exception("The customer ID could not be found.");//throws an exception i product number couldnt be found. 
            }
            return upDated;
        }
        //method that deletes a customer
        public bool Delete(string toDelete)
        {
            bool deleted = false;
            foreach (Customer cr in customerList)
            {
                if (cr.ID == toDelete)
                {
                    customerList.Remove(cr);
                    deleted = true;
                    break;
                }
            }
            if (deleted == false)
            {
                throw new Exception("this customer was not on the list so it couldnt be deleted. Please check spelling.");
            }
            return true;
        }




    }
}
