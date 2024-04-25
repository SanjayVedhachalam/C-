using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class EmployeeInfo:FamilyInfo
    {
        private static int s_employeeID;
        public string EmployeeID { get; }
        public DateTime DateOfJoining{ get ;}
        public EmployeeInfo(DateTime dateOfJoining){
            ++s_employeeID;
            EmployeeID="EID"+s_employeeID;
            DateOfJoining=dateOfJoining;
        }
        public override void Update(){ //cannot override inherited member 'FamilyInfo.Update()' because it is sealed
            base.Update();
        }
        public override void DisplayInfo(){ //cannot override inherited member 'FamilyInfo.DisplayInfo()' because it is sealed
            System.Console.WriteLine($"Employee ID: {EmployeeID}");
            System.Console.WriteLine($"Date of Joining: {DateOfJoining}");
            base.DisplayInfo();
        }
    }
}