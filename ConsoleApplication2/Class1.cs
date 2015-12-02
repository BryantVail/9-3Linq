using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Class1
    {
        string partDescription;
        int quantity;
        double price;
        string partNumber;

        //public Class1();

        public Class1(string partDescriptionC, int quantityC,string partNumberC,double priceC)
        {
            partDescription = partDescriptionC;
            Quantity = quantityC;
            partNumber = partNumberC;
            Price = priceC;

        }
        public string PartDescription
        {
            get
            {
                return partDescription;
            }
        }//end Property PartDescription

        public string PartNumber
        {
            get
            {
                return partNumber;
            }
        }//end Property PartNumber

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if(value>0)
                {
                    price = value;
                }
                else
                {
                    ArgumentOutOfRangeException priceException = new ArgumentOutOfRangeException("Price", "Price cannot be negative");
                    throw priceException;
                }//end if
            }//end GetSet

        }//end property Price

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value > 0)
                    quantity = value;
                else
                {
                    ArgumentOutOfRangeException quantityException = new ArgumentOutOfRangeException();
                    throw quantityException;
                }
            }//end if
        }//end PRoperty Quantity


    }//end class
}//end namespace
