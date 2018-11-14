using System;
using DiplomaResultCalculatorApp.BLL;
using DiplomaResultCalculatorApp.DAO;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiplomaResultCalculatorApp.BLL
{
    public class StudentGradeBll
    {
        public string GetGrade(StudentCgpaClassDao studentCgpaDao)
        {
            //StudentResultCgpaBll studentResultCgpaBll = new StudentResultCgpaBll();

            if (studentCgpaDao.ResultInCgpa >= 4.00)
                studentCgpaDao.ResultInGrade = "A+";
            else if (studentCgpaDao.ResultInCgpa >= 3.75)
                studentCgpaDao.ResultInGrade = "A";
            else if (studentCgpaDao.ResultInCgpa >= 3.50)
                studentCgpaDao.ResultInGrade = "A-";
            else if (studentCgpaDao.ResultInCgpa >= 3.25)
                studentCgpaDao.ResultInGrade = "B+";
            else if (studentCgpaDao.ResultInCgpa >= 3.00)
                studentCgpaDao.ResultInGrade = "B";
            else if (studentCgpaDao.ResultInCgpa >= 2.75)
                studentCgpaDao.ResultInGrade = "B-";
            else if (studentCgpaDao.ResultInCgpa >= 2.50)
                studentCgpaDao.ResultInGrade = "C+";
            else if (studentCgpaDao.ResultInCgpa >= 2.25)
                studentCgpaDao.ResultInGrade = "C";
            else if (studentCgpaDao.ResultInCgpa >= 2.00)
                studentCgpaDao.ResultInGrade = "D";
            else
                studentCgpaDao.ResultInGrade = "You are failed!";

            return studentCgpaDao.ResultInGrade;
        }
    }
}