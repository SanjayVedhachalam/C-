using System;

namespace Phase_2_College_Application
{
    public class DepartmentDetails
    {
        /// <summary>
        /// A unique ID details assigned and incremented when each Department is created <see cref="DepartmentDetails"
        /// </summary> 
        private static int s_deptID=100;
         /// <summary>
        /// Holds the ID value of the respective Department which is unique for each department. Used to hold the Department ID of instance class <see cref="DepartmentDetails"/>
        /// </summary>
        public string DepartmentID{get;set;}
        /// <summary>
        /// Stores the Department name of each Department of instance class <see cref="DepartmentDetails"/>
        /// </summary>
        public string DepartmentName{get;set;}
        /// <summary>
        /// Stores the number of seats in each Student of instance class <see cref="DepartmentDetails"/>
        /// </summary>
        public int NumberOfSeats=30;
        /// <summary>
        /// Parameterized Constructor which is used to initialize the parameter values to its properties.
        /// </summary>
        /// <param name="departmentID">departmentID parameter used to assign its value to associated property that is DepartmentID</param>
        /// <param name="departmentName">departmentName parameter used to assign its value to associated property that is DepartmentName</param>
        /// <param name="numberOfSeats">numberofSeats parameter used to assign its value to associated property that is NumberOfSeats</param> <summary>
       
        public DepartmentDetails(string departmentID,string departmentName,int numberOfSeats)
        {
            ++s_deptID;
            DepartmentID="DID"+s_deptID.ToString();
            DepartmentName=departmentName;
            NumberOfSeats=numberOfSeats;    
        }

        
    }
}
