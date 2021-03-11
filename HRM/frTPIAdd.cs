using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalHRM
{
    public partial class frTPIAdd : MetroFramework.Forms.MetroForm
    {
        FinalHRMEntities6 db = new FinalHRMEntities6();
        public frTPIAdd()
        {
            InitializeComponent();
            Load_CBB();
        }

        public void Load_CBB()
        {
            employmetroComboBox2.DataSource = db.EmployeeNows.Select(p => p).ToList();
            employmetroComboBox2.DisplayMember = ("Employ_ID");
            employmetroComboBox2.ValueMember = ("Employ_ID");

            projmetroComboBox1.DataSource = db.Projects.Select(p => p).ToList();
            projmetroComboBox1.DisplayMember = ("Proj_Name");
            projmetroComboBox1.ValueMember = ("Proj_ID");
        }

        private void employmetroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3LOSOBS\SQLEXPRESS;Initial Catalog=FinalHRM;Integrated Security=True");
            string sqlQuery = "SELECT Employ_Name FROM HistoryEmployee where Employ_ID= '" + employmetroComboBox2.Text + "'";
            SqlCommand objCommand = new SqlCommand(sqlQuery, con);
            con.Open();
            objCommand.ExecuteNonQuery();
            SqlDataReader dr;
            dr = objCommand.ExecuteReader();
            while (dr.Read())
            {
                string name = (string)dr["Employ_Name"].ToString();
                emnametxt.Text = name;
            }
        }

        private void tpiaddcancelbtt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tpiaddyesbtt_Click(object sender, EventArgs e)
        {
            db.new_tpi(projmetroComboBox1.SelectedValue.ToString(), employmetroComboBox2.SelectedValue.ToString(), joindate.Value);
            this.Close();
        }
    }
}