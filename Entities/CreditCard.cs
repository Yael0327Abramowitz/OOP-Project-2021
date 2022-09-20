using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class CreditCard
    {//class CreditCard, initializing the properties necessary
        public string OwnerName { get; set; }
        public string CardNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public double Charges { get; set; }

        //constructor to initialize CreditCard
        public CreditCard(string ownerName, string cardNum, DateTime expiration, double charge=0)
        {
            OwnerName = ownerName;
            if (expiration == default(DateTime))
            { ExpirationDate = DateTime.Now.AddYears(5); }
            else
            { ExpirationDate = expiration; }

            if (is16Digit(cardNum) && isNumeric(cardNum))
            {
                CardNumber = cardNum;
             }
            else
            {
                throw new Exception("Please enter a 16 digit credit card number. ");
            }
            Charges = charge;
        }
        public bool isNumeric(string s)
        {
            return ulong.TryParse(s, out ulong n);
        }
        public bool is16Digit(string s)//mskin sure credit card has 16 digits. 
        {
            if (s.Length == 16)
                return true;
            else
                return false;
        }
        public override string ToString()   //ToString method for creditCard. 
        {
            return $"Name on card: { OwnerName} \r\n Card number is: {CardNumber}\r\n Expires: {ExpirationDate.ToShortDateString()} \r\n Charges:{Charges} \r\n";

        }

    }
}
