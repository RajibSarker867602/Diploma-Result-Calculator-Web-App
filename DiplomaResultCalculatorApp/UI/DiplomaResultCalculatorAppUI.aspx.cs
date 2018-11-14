using System;
using DiplomaResultCalculatorApp.DAO;
using DiplomaResultCalculatorApp.BLL;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiplomaResultCalculatorApp.UI
{
    public partial class DiplomaResultCalculatorAppUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        StudentCgpaClassDao studentCgpaClassDao = new StudentCgpaClassDao();
        
        protected void cgpaButton_Click(object sender, EventArgs e)
        {
            StudentResultCgpaBll studentResultCgpaBll = new StudentResultCgpaBll();
            studentCgpaClassDao.FirstSemesterGpa = Convert.ToSingle(firstSemesterGpaTextBox.Text);
            studentCgpaClassDao.SecondSemesterGpa = Convert.ToSingle(secondSemesterGpaTextBox.Text);
            studentCgpaClassDao.ThirdSemesterGpa = Convert.ToSingle(thirdSemesterGpaTextBox.Text);
            studentCgpaClassDao.FourthSemesterGpa = Convert.ToSingle(fourthSemesterGpaTextBox.Text);
            studentCgpaClassDao.FifthSemesterGpa = Convert.ToSingle(fifthSemesterGpaTextBox.Text);
            studentCgpaClassDao.SixthSemesterGpa = Convert.ToSingle(sixthSemesterGpaTextBox.Text);
            studentCgpaClassDao.SeventhSemesterGpa = Convert.ToSingle(seventhSemesterGpaTextBox.Text);
            studentCgpaClassDao.EightSemesterGpa = Convert.ToSingle(eightSemesterGpaTextBox.Text);

            studentCgpaClassDao.ResultInCgpa = studentResultCgpaBll.GetCgpa(studentCgpaClassDao);
            
            //if(studentCgpaClassDao.ResultInCgpa>0)
            //{
                cgpaResutlTextBox.Text = studentCgpaClassDao.ResultInCgpa.ToString();
            //}
            //else
            //{
            //    cgpaResutlTextBox.Text = "Incorrect values!";
            //}
        }

        protected void gradeButton_Click(object sender, EventArgs e)
        {
            StudentGradeBll studentGradeBll = new StudentGradeBll();
            studentCgpaClassDao.ResultInCgpa =Convert.ToSingle(cgpaResutlTextBox.Text);
            studentCgpaClassDao.ResultInGrade = studentGradeBll.GetGrade(studentCgpaClassDao);
            gradeResultTextBox.Text = studentCgpaClassDao.ResultInGrade;
        }
    }
}