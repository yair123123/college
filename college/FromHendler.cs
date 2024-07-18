
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Guest_Shabbat_Host_App.DAL;
using college;


namespace EmployeeClock
{

    internal static class FromHandler
    {

        static DBContext db = new DBContext(DBContext.GetConnString("secrets.json", "connecction"));
        public static void CloseAllForms()
        {
            while (Application.OpenForms.Count > 0)
            {
                Application.OpenForms[0].Close();
            }

        }
        public static void ShowFrom(string formName, string text = "defult")

        {
            login.check = true;
            CloseAllForms();


            Form form = formName switch
            {
                "courses" => new courses(text),
                "login" => new login(),
                "lids" => new lids(),
                "Student" => new Student(text),
                _ => throw new ArgumentException("Invalid", nameof(formName)),
            };
            form.Show();
            
        }
        public static void ShowFromi(string formName, string text = "defult")


        {
            login.check = true;
            Form form = formName switch
            {
                "courses" => new courses(text),
                "login" => new login(),
                "cart" => new Cart(text),
                "lids" => new lids(),
                _ => throw new ArgumentException("Invalid", nameof(formName)),
            };
            form.Show();
        }


    }
}
