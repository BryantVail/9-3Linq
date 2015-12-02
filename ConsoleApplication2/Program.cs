using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1[] PartList = new Class1[8];
           PartList[0] = new Class1("electric Sander", 7,"83", 57.95 );
           PartList[1] = new Class1("Power Saw", 18,"24", 99.99 );
           PartList[2] = new Class1("Sledge Hammer", 11,"7", 21.50 );
           PartList[3] = new Class1("Hammer", 76, "77", 11.99 );
           PartList[4] = new Class1("Lawn Mower", 3, "39",79.50 );
           PartList[5] = new Class1("Jug Saw", 21, "56", 11.00 );
           PartList[6] = new Class1("Screwdriver", 106, "68", 6.99 );
                   
           PartList[7] = new Class1( "Wrench", 34,"3",7.50);

            List<Class1> PowerTools = new List<Class1>();
           
            PowerTools.Add(PartList[0]);
            PowerTools.Add(PartList[1]);
            PowerTools.Add(PartList[2]);
            PowerTools.Add(PartList[3]);
            PowerTools.Add(PartList[4]);
            PowerTools.Add(PartList[5]);
            PowerTools.Add(PartList[6]);
            PowerTools.Add(PartList[7]);

            var PriceList=
                from tool in PowerTools
                orderby tool.Price
                select PowerTools;

            var quantityCheck =
                from tool in PowerTools
                orderby tool.PartDescription
                select new {quantityCheck = QuantityResult };
            int quantitycheck = quantityCheck;
                Console.WriteLine(PriceList +":"+ quantityCheck);
            bool loop = true;
            //while(loop == true)
            Console.Read();



        }//end main

    }//end class
}//end namespace
