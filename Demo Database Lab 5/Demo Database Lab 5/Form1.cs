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
using System.Collections;

namespace Demo_Database_Lab_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string cname = tbCName.Text;
            string ccode = tbCCode.Text;


            string connString = @"Server=DESKTOP-JP14209\SQLEXPRESS;Database=Demo Database Lab 5;Integrated Security=true;Trusted_Connection=True;MultipleActiveResultSets=true;";
            SqlConnection conn = new SqlConnection(connString);

            conn.Open();
            string query = string.Format("insert into courses values('{0}', '{1}')", cname, ccode);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Course Inserted");
            }
            else
            {
                MessageBox.Show("Failed to insert Course");
            }
            conn.Close();
            var courses = GetAllCourses();
            dtCourses.DataSource = courses;

        }

        private void loadData_Click(object sender, EventArgs e)
        {
            var courses = GetAllCourses();
            dtCourses.DataSource = courses;
        }

        List<Course> GetAllCourses()
        {
            string connString = @"Server=DESKTOP-JP14209\SQLEXPRESS;Database=Demo Database Lab 5;Integrated Security=true;Trusted_Connection=True;MultipleActiveResultSets=true;";
            SqlConnection conn = new SqlConnection(connString);
            List<Course> courses = new List<Course>();
            conn.Open();
            string query = "select * from courses";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Course c = new Course();
                c.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                c.CourseName = reader.GetString(reader.GetOrdinal("CourseName"));
                c.CourseCode = reader.GetString(reader.GetOrdinal("CourseCode"));
                courses.Add(c);

            }


            conn.Close();
            return courses;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var courses = GetAllCourses();
            dtCourses.DataSource = courses;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string connString = @"Server=DESKTOP-JP14209\SQLEXPRESS;Database=Demo Database Lab 5;Integrated Security=true;Trusted_Connection=True;MultipleActiveResultSets=true;";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            int id = Int32.Parse(tbSrchId.Text);
            string query = "select *  from courses where id = " + id;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            Course c = new Course();
            while (reader.Read())
            {
                c.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                c.CourseCode = reader.GetString(reader.GetOrdinal("CourseCode"));
                c.CourseName = reader.GetString(reader.GetOrdinal("CourseName"));
            }

            conn.Close();
            tbCCodeUpdate.Text = c.CourseCode;
            tbCnameUpdate.Text = c.CourseName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(tbSrchId.Text);
            string cCode = tbCCodeUpdate.Text;
            string cName = tbCnameUpdate.Text;

            string connString = @"Server=DESKTOP-JP14209\SQLEXPRESS;Database=Demo Database Lab 5;Integrated Security=true;Trusted_Connection=True;MultipleActiveResultSets=true;";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string query = string.Format("update courses set CourseName= '{0}', CourseCode= '{1}' where id='{2}'", cName, cCode, id);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            var courses = GetAllCourses();
            dtCourses.DataSource = courses;

        }
    }
}
