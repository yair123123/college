using Guest_Shabbat_Host_App.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EmployeeClock;
using Microsoft.VisualBasic.Devices;

namespace college
{
    public partial class Cart : Form
    {
        DBContext db = new DBContext(DBContext.GetConnString("secrets.json", "connecction"));
        string _text;
        string coursNames;
        public Cart(string text)
        {
            InitializeComponent();
            _text = text;
            FillData();
            label2.Text = SumCoust();
        }

        private void FillData()
        {
            DataTable dt = db.ExecuteQuery("select * from cart");
            dataGridView.DataSource = dt;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            db.ExecuteNonQuery("delete from cart");
            MessageBox.Show("סל נמחק בהצלחה");
            FillData();
            label2.Text = SumCoust();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {

            int row = db.ExecuteNonQuery("delete from cart where namecourse = @name", new SqlParameter("@name", coursNames));
            if (row > 0) { MessageBox.Show("פריט נמחק בהצלחה"); }
            else { MessageBox.Show("לא נבחר מוצר"); }
            FillData();
            label2.Text = SumCoust();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                coursNames = dataGridView.Rows[e.RowIndex].Cells["namecourse"].Value.ToString();
            }
        }

        private void button_back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            int a = 0;
            int sum = 0;
            foreach (DataGridViewRow item in dataGridView.Rows)
            {
                if (item == null)
                {
                    MessageBox.Show("DataGridViewRow is null.");
                    continue;
                }

                var cellValue = item.Cells["namecourse"].Value;

                if (cellValue == null || cellValue == DBNull.Value)
                {
                    
                    continue;
                }
                sum += int.Parse(item.Cells["coust"].Value.ToString());
                string courseName = cellValue.ToString();
                a += db.ExecuteNonQuery(@"
                declare @phone varchar(100);
                select @phone = phone from lids where name = @name;

                insert into Students(StudentName, StudentPhone)
                values(@name, @phone);

                declare @id int;
                declare @courseid int;
                select @id = StudentId from Students where StudentName = @name;
                select @courseid = courseid from Courses where CoursName = @coursename;

                insert into StudentCourse
                values(@id, @courseid);"
,               [new SqlParameter("@name", _text),new SqlParameter("@coursename", courseName)]);
            }
            if (a>0) 
            { MessageBox.Show("נוספת בהצלחה!");
                db.ExecuteNonQuery("update Students set DueBalance = @coust where StudentName = @name", [new SqlParameter("@coust", sum), new SqlParameter("@name", _text)]);
                db.ExecuteNonQuery("delete from cart");
                FillData();
            }

        }
        private string SumCoust()
        {
            
            int a = 0;

            foreach (DataGridViewRow item in dataGridView.Rows)
            {
                if (item.Cells["namecourse"].Value != null)
                {
                    int number;
                    if (int.TryParse(item.Cells["coust"].Value.ToString(), out number))
                    {
                        a += number;
                    }
                }
            }


            return a.ToString();

        }
    }
}
