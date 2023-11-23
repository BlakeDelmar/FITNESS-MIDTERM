using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Validator
    {

        static public int GetValidationOfUserID()
        {
            //int usersID = Validator.GetValidationOfUserID();

            while (true)
            {
                string usersIDInput = Console.ReadLine();
                if (int.TryParse(usersIDInput, out int usersIDNumber))
                {
                    return usersIDNumber;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }


        static public void YesOrNo()
        {
            //string yesOrNo = Validator.YesOrNo();

            string yesOrNo = Console.ReadLine().ToUpper();
            while (true)
            {
                if (yesOrNo == "Y" || yesOrNo == "N" || yesOrNo == "YES" || yesOrNo == "NO")
                {
                    break;
                }
                Console.WriteLine("Please enter a valide [Yes/No]");
            }

        }


    }
}
