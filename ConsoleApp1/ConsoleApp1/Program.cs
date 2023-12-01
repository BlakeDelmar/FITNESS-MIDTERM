using ConsoleApp1;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace FitnessMidterm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //get member id, and name
            //create a club class that has name, address
            //ask to add members (single club & multi club)
            //add members BOTH KINDS remove members, display members info
            //check if member is in specified club (checkin method) display error if member isnt in club
            //select a member and generate a bill of fees, include membership points for multi club members
            //main class takes input from user (ask user to select club, members should have option to select from 4 club locations and if multi membership


            Console.WriteLine("Welcome to the Fitness center program!");
            Club clubs = new Club();
            
            
            string yesOrNo;
            while (true)
            {   
           
                Console.WriteLine("Please enter member name");
                string memberName = Console.ReadLine().Trim().ToUpper();

                Console.WriteLine("Please enter member ID");
                int usersID = DataValidator.GetValidationOfUserID();


                string memberType;
                while (true)
                {
                    Console.WriteLine("Please enter member type [Single, Multi]");
                     memberType = Console.ReadLine().Trim().ToUpper();

                    if (memberType == "SINGLE" || memberType == "MULTI")
                    {
                        
                        break;
                    }
                    Console.WriteLine("Please enter valid member type");
                }
                if (memberType == "MULTI")
                {
                    MultiMember multiMember = new MultiMember(memberName, usersID);
                }
                if (memberType == "SINGLE")
                {
                    SingleMember singleMember = new SingleMember(memberName, usersID);
                }

                Console.WriteLine("What Club is the member apart of? You may pick from:");
                Console.WriteLine("FitnessAreUs, ClubFitness, PlanetFitness, BallsOfSteel");
                string ValidLocation1 = DataValidator.ValidLocation();
                Console.WriteLine($"You picked {ValidLocation1}");

             
                Console.WriteLine("Would you like to add another member? [Y/N]");
                string yesOrNo2 = DataValidator.YesOrNo();
            
                if (yesOrNo2 != "Y")
                {
                    break;
                }
            }
            

            Console.WriteLine("Would you like to view the member list? [Y/N]");
            string yesOrNo3 = DataValidator.YesOrNo();

            /////////// NOT IMPLEMENTED
            int id;
            while (true)
            {
                Console.WriteLine("Please enter a user ID to learn more about them [0-]");

                string idInput = Console.ReadLine();

                if (int.TryParse(idInput, out id))
                {
                    break;
                }
                Console.WriteLine("Please enter valid id NUMBER");
            }
            /////////// NOT IMPLEMENTED

        }
    
    }
}