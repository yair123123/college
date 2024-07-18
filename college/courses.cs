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
using Microsoft.VisualBasic.Devices;
using EmployeeClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace college
{
    public partial class courses : Form
    {
        private string coursNames;
        private string coursCoust;
        static string _text;
        DBContext db = new DBContext(DBContext.GetConnString("secrets.json", "connecction"));
        public courses(string text)
        {
            _text = text;
            InitializeComponent();
            label_courses.Text = $"עסקה עבור {_text}";
            FillData();
        }
        Cart cart = new Cart(_text);

        private void FillData()
        {
            DataTable dt = db.ExecuteQuery("select * from Courses");
            dataGridView.DataSource = dt;
        }
        private void AddToCart(object sender, EventArgs e)
        {
            int row = db.ExecuteNonQuery("insert into cart values ( @name,@coust)", [new SqlParameter("name", coursNames), new SqlParameter("@coust", coursCoust)]);
            if (row > 0) { MessageBox.Show("נוסף בהצלחה!"); }
            else { MessageBox.Show("קיים כבר בסל"); }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                coursNames = dataGridView.Rows[e.RowIndex].Cells["coursName"].Value.ToString();
                coursCoust = dataGridView.Rows[e.RowIndex].Cells["coursecoust"].Value.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cart.Show();
        }
    }
}
