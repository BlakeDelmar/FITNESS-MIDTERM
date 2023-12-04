    using ConsoleApp1;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.IO.Pipes;
using System.Net;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

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
            
            List<GymMember> membersList = new List<GymMember>();
           
            string yesOrNo;
            while (true)
            {   
                
                Console.WriteLine("Please enter member name");
                string memberName = Console.ReadLine().Trim().ToUpper();
                //ENTERING MEMBER NAME
                
                Console.WriteLine("Please enter member ID");
                int usersID = DataValidator.GetValidationOfUserID();
                //ENTERING MEMBER ID

                Console.WriteLine("What Club is the member apart of? You may pick from:");
                Console.WriteLine("FitnessAreUs, ClubFitness, PlanetFitness, BallsOfSteel");
                string ValidLocation1 = DataValidator.ValidLocation();
                Console.WriteLine($"You picked {ValidLocation1}");
                string address = string.Empty;               
                if (ValidLocation1 == "FITNESSAREUS")
                {
                    address = "FLORIDA 253 EASY AVE";
                    
                }
                if (ValidLocation1 == "CLUBFITNESS")
                {
                    address = "BRITISHCOLUMBIA 376 DONALD RD";
                    
                }
                if (ValidLocation1 == "PLANETFITNESS")
                {
                    address = "TEXAS 34 COLUMBIA DR";
                    
                }
                if (ValidLocation1 == "BALLSOFSTEEL")
                {
                   address = "PHEONIX 68 RAMBO RD";
                                      
                }
                Club club = new Club(ValidLocation1, address);

                //ENTERING A VALID LOCATION

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
                GymMember member;
                if (memberType == "MULTI")
                {
                    member = new MultipleMembershipGymMember(memberName, usersID);
                    membersList.Add(member);
                }

                if (memberType == "SINGLE")
                {
                    member = new SingleMembershipGymMember(memberName, usersID);
                    membersList.Add(member);

                }
                //ENTERING MEMBER TYPE

                
                Console.WriteLine("Would you like to view the member list? [Y/N]");
                string yesOrNo3 = DataValidator.YesOrNo();

                if (yesOrNo3 == "Y")
                {
                    foreach (var listMember in membersList)
                    {
                        Console.Write($"{listMember.Name} "); //IMPORTANT
                        Console.Write($"{listMember.Id}\n");    
                    }
                }
                

                Console.WriteLine("Would you like to add another member? [Y/N]");
                string yesOrNo2 = DataValidator.YesOrNo();

                if (yesOrNo2 != "Y")
                {
                    break;
                }

            }

            //int id;
            //while (true)
            //{
            //    Console.WriteLine("Please enter a user ID to learn more about them [0-]");

            //    string idInput = Console.ReadLine();

            //    if (int.TryParse(idInput, out id))
            //    {
            //        break;
            //    }
            //    Console.WriteLine("Please enter valid id NUMBER");
            //}
                // NOT IMPLEMENTED
        }
    }
}