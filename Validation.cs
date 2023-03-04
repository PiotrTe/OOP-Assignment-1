using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_1
{
    internal class Validation
    {
        public int ValidateInt(string input)
        {
            int number;
            bool isValid = int.TryParse(input, out number);
            if (isValid == false)
            {
                Console.WriteLine($"Value of '{input}' is not integer");
                return -1;
            }
            else
            {
                return number;
            }

        }

        public bool ValidateIntRange(int input, int min, int max)
        {
            if (input < min || input > max)
            {
                Console.WriteLine($"Value of {input} is outside of acceptable boundaries ({min}-{max})");
                return false;
            }
            else
            {
                return true;
            }
        }
        public int GetIntInput(string inputMessage, int min, int max)
        {
            string input;
            int intInput;
            while (true)
            {
                Console.WriteLine($"{inputMessage}");
                input = Console.ReadLine();
                intInput = ValidateInt(input);
                if (intInput == -1)
                {
                    continue;
                }
                else
                {
                    if (ValidateIntRange(intInput, min, max))
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

            }
            return intInput;
        }

    }
}
