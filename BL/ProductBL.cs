using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BL
{
    public class ProductBL
    {
        //creating a new object of type ProductDal
        ProductDAL proDal = new ProductDAL();

        //create product
        public void Create(string productNum1, string productName1, double cost1, int amountIn1)//giving it the parameters of product attribute: product number, product name, cost per unit and amount in stock. 
        {//throwing everything into a try and catch, in case it doesnt work it throws an exception. 
            try              
            {
                proDal.Create(productNum1, productName1, cost1, amountIn1);
            }
            catch
            {
                throw;
            }
        }

        //read specific product
        public Product Read (string toSee)
        {
           return proDal.Read (toSee);
        }
        //read all products
        public List<Product> ReadAll()
            //returning all info for proDal, through the ReadAll method. 
        {
           return proDal.ReadAll();
        }
        //update product
        public bool Update(string toUpdate1, Product prod1)
        {
           return proDal.Update(toUpdate1, prod1);
        }
        //delete product
        public bool Delete(string toDelete)
            //returning the deleted ProductDal
        {
            return proDal.Delete(toDelete);
        }
    }
}
