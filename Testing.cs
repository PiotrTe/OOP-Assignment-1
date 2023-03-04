using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_1
{
    internal class Testing
    {
        Validation validation = new Validation();

        public Testing()
        {
            Pack pack = new Pack();

            int userChoice = validation.GetIntInput("Select between 0 and 5",0,5);
            Console.WriteLine(userChoice);
        }
    }

}
