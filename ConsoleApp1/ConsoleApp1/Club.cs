using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Club
    {
        //FitnessAreUs, Florida 253 Easy ave
        //ClubFitness, BritishColumbia 376 Donald Rd
        //PlanetFitness, Texas 34 Columbia Dr
        //BallsOfSteel, Pheonix 68 Rambo Rd


        public string FitnessAreUs()
        {
            string name = "FitnessAreUs";
            string address = " 253 Easy Ave Floria";

            return name + address;



        }
        public string ClubFitness()
        {
            string name = "ClubFitness";
            string address = " 376 Donald Rd BritishColumbia";

            return name + address;
        }
        public string PlanetFitness()
        {
            string name = "PlanetFitness";
            string address = " 68 Rambo Rd Pheonix";

            return name + address;

        }
        public string BallsOfSteel()
        {
            string name = "BallsOfSteel";
            string address = "Pheonix 68 Rambo Rd";

            return name + address;


        }

        public string SingleUsersClub()
        {
            Console.WriteLine("What Club is the member apart of? You may pick from:");
            Console.WriteLine("FitnessAreUs, ClubFitness, PlanetFitness, BallsOfSteel");
            string ValidLocation1 = DataValidator.ValidLocation();
            Console.WriteLine($"You picked {ValidLocation1}");
            return ValidLocation1;

        }

        public string MultiUserClub()
            //Club club = new Club();
        {
            Console.WriteLine("What Club is the member apart of? You may pick from:");
            Console.WriteLine("FitnessAreUs, ClubFitness, PlanetFitness, BallsOfSteel");
            string ValidLocation = DataValidator.ValidLocation();
            Console.WriteLine($"You picked {ValidLocation}");
            return ValidLocation;
        }


    }


}
