using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Members
    {
        public int MemberId { get; set; }

        public string MemberName { get; set; }

        public Members(string memberName, int usersID)
        {
            MemberName = memberName;

            MemberId = usersID;
        }


    }
     public class MemberType : Members
     {


        
       
     }

}
