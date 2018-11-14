using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiplomaResultCalculatorApp.DAO
{
    public class StudentCgpaClassDao
    {
        public float FirstSemesterGpa { get; set; }
        public float SecondSemesterGpa { get; set; }
        public float ThirdSemesterGpa { get; set; }
        public float FourthSemesterGpa { get; set; }
        public float FifthSemesterGpa { get; set; }
        public float SixthSemesterGpa { get; set; }
        public float SeventhSemesterGpa { get; set; }
        public float EightSemesterGpa { get; set; }

        public float PFirstSemesterGpa { get; set; }
        public float PSecondSemesterGpa { get; set; }
        public float PThirdSemesterGpa { get; set; }
        public float PFourthSemesterGpa { get; set; }
        public float PFifthSemesterGpa { get; set; }
        public float PSixthSemesterGpa { get; set; }
        public float PSeventhSemesterGpa { get; set; }
        public float PEightSemesterGpa { get; set; }


        public float ResultInCgpa { get; set; }
        public string ResultInGrade { get; set; }
    }
}