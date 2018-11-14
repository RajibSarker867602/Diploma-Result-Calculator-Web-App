using System;
using DiplomaResultCalculatorApp.DAO;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiplomaResultCalculatorApp.BLL
{
    public class StudentResultCgpaBll
    {
        public float GetCgpa(StudentCgpaClassDao studentCgpaClassDao)
        {
            //if (studentCgpaClassDao.FirstSemesterGpa >= 2.00 && studentCgpaClassDao.FirstSemesterGpa <= 4.00 && studentCgpaClassDao.SecondSemesterGpa >= 2.00 && studentCgpaClassDao.SecondSemesterGpa <= 4.00 && studentCgpaClassDao.ThirdSemesterGpa >= 2.00 && studentCgpaClassDao.ThirdSemesterGpa <= 4.00 && studentCgpaClassDao.FourthSemesterGpa >= 2.00 && studentCgpaClassDao.FourthSemesterGpa <= 4.00 && studentCgpaClassDao.FifthSemesterGpa >= 2.00 && studentCgpaClassDao.FifthSemesterGpa <= 4.00 && studentCgpaClassDao.SixthSemesterGpa >= 2.00 && studentCgpaClassDao.SixthSemesterGpa <= 4.00 && studentCgpaClassDao.SeventhSemesterGpa >= 2.00 && studentCgpaClassDao.SeventhSemesterGpa <= 4.00 && studentCgpaClassDao.EightSemesterGpa >= 2.00 && studentCgpaClassDao.EightSemesterGpa <= 4.00)
            //{
                studentCgpaClassDao.PFirstSemesterGpa = (studentCgpaClassDao.FirstSemesterGpa * 5) / 100;
                studentCgpaClassDao.PSecondSemesterGpa = (studentCgpaClassDao.SecondSemesterGpa * 5) / 100;
                studentCgpaClassDao.PThirdSemesterGpa = (studentCgpaClassDao.ThirdSemesterGpa * 5) / 100;
                studentCgpaClassDao.PFourthSemesterGpa = (studentCgpaClassDao.FourthSemesterGpa * 15) / 100;
                studentCgpaClassDao.PFifthSemesterGpa = (studentCgpaClassDao.FifthSemesterGpa * 15) / 100;
                studentCgpaClassDao.PSixthSemesterGpa = (studentCgpaClassDao.SixthSemesterGpa * 20) / 100;
                studentCgpaClassDao.PSeventhSemesterGpa = (studentCgpaClassDao.SeventhSemesterGpa * 25) / 100;
                studentCgpaClassDao.PEightSemesterGpa = (studentCgpaClassDao.EightSemesterGpa * 10) / 100;

                studentCgpaClassDao.ResultInCgpa = studentCgpaClassDao.PFirstSemesterGpa + studentCgpaClassDao.PSecondSemesterGpa + studentCgpaClassDao.PThirdSemesterGpa + studentCgpaClassDao.PFourthSemesterGpa + studentCgpaClassDao.PFifthSemesterGpa + studentCgpaClassDao.PSixthSemesterGpa + studentCgpaClassDao.PSeventhSemesterGpa + studentCgpaClassDao.PEightSemesterGpa;
                return studentCgpaClassDao.ResultInCgpa;
            //}
            //else
            //{
            //    return 0;
            //}
        }
    }
}