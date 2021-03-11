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
namespace FinalHRM
{
    public partial class frEmployeditdel : MetroFramework.Forms.MetroForm
    {
        FinalHRMEntities6 db = new FinalHRMEntities6();
        public frEmployeditdel()
        {
            InitializeComponent();
            Load_CBB();
            
        }
        public void Load_CBB()
        {
            empleditdelidcbb.DataSource = db.EmployeeNows.Select(p => p).ToList();
            empleditdelidcbb.DisplayMember = ("Employ_ID");
            empleditdelidcbb.ValueMember = ("Employ_ID");

            employeditcareer.DataSource = db.JobOfDeps.Select(p => p).ToList();
            employeditcareer.DisplayMember = ("name");
            employeditcareer.ValueMember = ("id");     
        }
        private void empleditdelidcbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3LOSOBS\SQLEXPRESS;Initial Catalog=FinalHRM;Integrated Security=True");
            string sqlQuery = "SELECT EmployeeNow.Employ_ID,Employ_Name,DoB,Sex,Email,Phone_Number,joindate,Career_ID,salary FROM EmployeeNow,HistoryEmployee where EmployeeNow.Employ_ID=HistoryEmployee.Employ_ID and EmployeeNow.Employ_ID = '" + empleditdelidcbb.Text + "'";
            SqlCommand objCommand = new SqlCommand(sqlQuery, con);
            con.Open();
            objCommand.ExecuteNonQuery();
            SqlDataReader dr;
            dr = objCommand.ExecuteReader();
            while (dr.Read())
            {
                string name = (string)dr["Employ_Name"].ToString();
                empleditnametxt.Text = name;

                DateTime dob = (DateTime)dr["DoB"];
                employeditdob.Value = dob;

                string gt = (string)dr["Sex"].ToString();
                if (gt == "Nam")
                {
                    radmale.Checked = true;
                }
                else
                {
                    radmale.Checked = false;
                    radfemale.Checked = true;
                }
                
                string mail = dr["Email"].ToString();
                employeditemail.Text = mail;
                string phone = (string)dr["Phone_Number"].ToString();
                employeditphone.Text = phone;
                DateTime join = (DateTime)dr["joindate"];
                employeditjoin.Value = join;
                string care = (string)dr["Career_ID"].ToString();
                employeditcareer.SelectedValue = care;
                int sal = (int)dr["Salary"];
                employeditsal.Text = System.Convert.ToString(sal);


            }
            
        }
     
        private void employeditcancelbtt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void employedityesbtt_Click(object sender, EventArgs e)
        {
            string id = empleditdelidcbb.SelectedValue.ToString();
            string name = empleditnametxt.Text;
            DateTime dob = employeditdob.Value;
            string email = employeditemail.Text;
            string gt = (radmale.Checked == true) ? "Nam" : "Nữ";
            string phone = employeditphone.Text;
            string sal = employeditsal.Text;
            string career = employeditcareer.SelectedValue.ToString();
            DateTime join = employeditjoin.Value;
            db.update_empl(id, name, dob, gt, email, phone, join, career, System.Convert.ToInt32(sal));
            this.Close();
            
        }

        private void employeditdelbtt_Click(object sender, EventArgs e)
        {
            string id = empleditdelidcbb.SelectedValue.ToString();
            db.del_EmplowNow(id);
            this.Close();
        }
    }
}
