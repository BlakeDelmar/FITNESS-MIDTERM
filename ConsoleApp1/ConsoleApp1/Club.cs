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

        public string FitnessCenterName { get; set; }
        public string FitnessCenterAddress { get; set; }

        public Club(string validLocation1, string address)
        {
            FitnessCenterName = validLocation1;

            FitnessCenterAddress = address;
        }


    }
}
