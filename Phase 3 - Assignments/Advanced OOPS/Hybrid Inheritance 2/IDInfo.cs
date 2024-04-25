using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid_Inheritance_2
{
    public class IDInfo:PersonalInfo
    {
        protected static string _voterID;
        protected static string _aadharID;
        protected static string _panNumber;
        public string VoterID { get; }
        public string AadharID { get; }
        public string PANNumber { get; }
    }
}