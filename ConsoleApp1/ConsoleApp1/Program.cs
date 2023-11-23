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

            Dictionary<int ,string> memberList= new Dictionary<int ,string>();
            Dictionary<int ,string> memberTypes= new Dictionary<int ,string>();
            Console.WriteLine("Welcome to the Fitness center program!");
            string yesOrNo;
            while (true)
            {   
           
                Console.WriteLine("Please enter member name");
                string memberName = Console.ReadLine().Trim().ToUpper();

                while (true)
                {
                    Console.WriteLine("Please enter member type [Single, Multi]");
                    string memberType = Console.ReadLine().Trim().ToUpper();

                    if (memberType == "SINGLE" || memberType == "MULTI")
                    {
                        memberTypes.Add(memberTypes.Count, memberType);
                        break;
                    }
                    Console.WriteLine("Please enter valid member type");
                }
                
                memberList.Add(memberList.Count, memberName);
                while (true)
                {

                    Console.WriteLine("Would you like to add another member? [Y/N]");
                    yesOrNo = Console.ReadLine().ToUpper();

                    if (yesOrNo == "Y" || yesOrNo == "N")
                    {
                        break;
                    }
                    Console.WriteLine("enter valid [Y/N]");
                }
                if (yesOrNo != "Y")
                {
                    break;
                }
            }
            string yesOrNo1;
            while (true)
            {
                Console.WriteLine("Would you like to view the member list? [Y/N]");
                yesOrNo1 = Console.ReadLine().ToUpper();

                if (yesOrNo1 == "Y" || yesOrNo1 == "N")
                {
                    break;
                }
                Console.WriteLine("enter valid [Y/N]");
            }
            if (yesOrNo1 == "Y")
            {
                DisplayMemberNames(memberList);

            }
            int id;
            while (true)
            {
                Console.WriteLine("Would you like to view more about a member? enter a valid ID :) [0-]");

                string idInput = Console.ReadLine();

                if (int.TryParse(idInput, out id))
                {
                    break;
                }
                Console.WriteLine("Please enter valid id NUMBER");
            }
            string memberViewer = memberList[id];
            string memberTypeViewer = memberTypes[id];
            Console.Write($"{memberViewer} ");
            Console.Write($"{memberTypeViewer}");
        }
        static void DisplayMemberNames(Dictionary<int, string> memberNames)
        {
            foreach(var member in memberNames)
            {
                Console.WriteLine(member);
            }           
        }
    }
}