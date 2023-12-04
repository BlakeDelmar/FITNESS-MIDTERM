using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class GymMember
    {
        public abstract string CheckIn(Club club);
        

        public string Name { get; set; }
        public int Id { get; set; }

    }

    class MultipleMembershipGymMember : GymMember
    {
        public int MembershipPoints { get; set; }
        public override string CheckIn(Club club)
        {
           
            MembershipPoints += 1;

            return MembershipPoints.ToString();
        }
        public MultipleMembershipGymMember(string memberName, int usersID)
        {
            Name = memberName;
            Id = usersID;
        }

  
    }
    class SingleMembershipGymMember : GymMember
    {
        public SingleMembershipGymMember(string memberName, int usersID)
        {
            Name = memberName;
            Id = usersID;
            GymName = string.Empty;
        }


        public string GymName { get; set; }
        public override string CheckIn(Club club)
        {
            club.FitnessCenterName = GymName;


            return GymName;

        }
    }
}
