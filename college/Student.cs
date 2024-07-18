using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guest_Shabbat_Host_App.DAL;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace college
{
    public partial class Student : Form
    {
        object a;
        DBContext db = new DBContext(DBContext.GetConnString("secrets.json", "connecction"));
        string _text;

        public Student(string text)
        {
            InitializeComponent();
            _text = text;
            FillData();
            label_debt.Text = CalculateBalance();
            label_nane.Text = _text;
        }

        private void FillData()
        {
            DataTable dt = db.ExecuteQuery("select CoursName,CourseCoust,CoursDays,CoursHours,StartDate  from StudentCourse sc\r\njoin Students s on s.StudentID = sc.StudentID\r\njoin  Courses c on c.CourseID = sc.CourseID\r\nwhere StudentName = @name", new SqlParameter("@name", _text));
            dataGridView1.DataSource = dt;
        }

        private string CalculateBalance()
        {
            a = db.ExecuteScalar("select DueBalance from students where StudentName = @name", [new SqlParameter("@name", _text)]);
            return a.ToString();
        }

        private void button_Click_1(object sender, EventArgs e)
        {
            string b = Interaction.InputBox("הכנס סכום לתשלום");
            int sum = int.Parse(a.ToString()) - int.Parse(b);
            db.ExecuteNonQuery("update Students set DueBalance = @coust where StudentName = @name", [new SqlParameter("@coust", sum), new SqlParameter("@name", _text)]);
            label_debt.Text = CalculateBalance();
        }
    }

}

