using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Customer:Person
    {
        public CreditCard MyCard { get; set; }
        // <summary>
        /// ctor to set customer properties 
        /// </summary>
        /// <param name="nname"> name of customer</param>
        /// <param name="iid"> id of customer</param>
        public Customer (CreditCard card, string nname, string iid):base (nname,  iid)
        {
            CreditCard copy;
            copy = new CreditCard(card.OwnerName, card.CardNumber, card.ExpirationDate);
            MyCard = copy;
        }

        public override string ToString() //ToString method for customer. 
        {
            return "\r\n Customer Name: "+ Name + "\r\n Cutomer ID: " +ID + "\r\n"+ MyCard;
        }
    }
}
