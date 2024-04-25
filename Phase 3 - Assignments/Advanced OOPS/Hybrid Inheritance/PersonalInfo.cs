using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid_Inheritance
{
    public class PersonalInfo
    {
        private static int s_registrationNumber=2000;
        public string RegistrationNumber{get;}
        public string Name { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public PersonalInfo(){
            ++s_registrationNumber;
            RegistrationNumber="SID"+s_registrationNumber;
        }
        
    }
}