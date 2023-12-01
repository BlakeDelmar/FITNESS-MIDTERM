using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Members
    {
        public abstract string CheckIn();
        
    }

    class MultiMember : Members
    {
        public string MemberName { get; set; }
        public int MemberId { get; set; }
        public override string CheckIn()
        {   
            int membershipPoints = 0;
            int membershipPointsAdded = membershipPoints + 1;
            return membershipPointsAdded.ToString();

            //Need to merge to implement checking of Club
            
        }
        public MultiMember(string memberName, int usersID)
        {
            MemberName = memberName;
            MemberId = usersID;
        }
        

    }
    class SingleMember : Members
    {
        public string MemberName { get; set; }
        public int MemberId { get; set; }
        public override string CheckIn()
        {
            return string.Empty;

            //Need to merge to implement checking of Club
        }
        public SingleMember(string memberName, int usersID)
        {
            MemberName = memberName;
            MemberId = usersID;
        }

    }

}
