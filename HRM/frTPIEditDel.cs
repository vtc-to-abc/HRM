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
    public partial class frTPIEditDel : MetroFramework.Forms.MetroForm
    {
        FinalHRMEntities6 db = new FinalHRMEntities6();
        public frTPIEditDel()
        {
            InitializeComponent();
            Load_CBB();
        }

        public void Load_CBB()
        {
            projeditmetroComboBox1.DataSource = db.Projects.Select(p => p).ToList();
            projeditmetroComboBox1.DisplayMember = ("Proj_Name");
            projeditmetroComboBox1.ValueMember = ("Proj_ID");

            employeditmetroComboBox2.DataSource = db.TakePartInNows.Select(p => p).ToList();
            employeditmetroComboBox2.DisplayMember = ("Employ_ID");
            employeditmetroComboBox2.ValueMember = ("Employ_ID");
        }

        private void projeditmetroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3LOSOBS\SQLEXPRESS;Initial Catalog=FinalHRM;Integrated Security=True");
            string sqlQuery = "SELECT Employ_ID FROM TakePartInNow where Proj_ID= '" + projeditmetroComboBox1.SelectedValue.ToString() + "'";
            SqlCommand objCommand = new SqlCommand(sqlQuery, con);
            con.Open();
            objCommand.ExecuteNonQuery();
            SqlDataReader dr;
           
            dr = objCommand.ExecuteReader();
            

            while (dr.Read())
            {
                string em = dr["Employ_ID"].ToString();
                employeditmetroComboBox2.SelectedValue = em;
            }
        }

        private void employeditmetroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3LOSOBS\SQLEXPRESS;Initial Catalog=FinalHRM;Integrated Security=True");
            string sqlQuery = "SELECT Employ_Name FROM HistoryEmployee where Employ_ID= '" + employeditmetroComboBox2.SelectedValue.ToString() + "'";
            SqlCommand objCommand = new SqlCommand(sqlQuery, con);
            con.Open();
            objCommand.ExecuteNonQuery();
            SqlDataReader dr;

            dr = objCommand.ExecuteReader();


            while (dr.Read())
            {
                string em = dr["Employ_Name"].ToString();
                emnameedittxt.Text = em;
            }
        }
        private void editcancelButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edityesButton2_Click(object sender, EventArgs e)
        {
            try {
                db.update_TPI(projeditmetroComboBox1.SelectedValue.ToString(), employeditmetroComboBox2.SelectedValue.ToString(), joindateedit.Value, Note.Text);
                MessageBox.Show("sửa thành công");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Kiểm tra dữ liệu nhập vào");
            }
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void editdelButton3_Click(object sender, EventArgs e)
        {
            try {
                db.del_TakePartInNow(projeditmetroComboBox1.SelectedValue.ToString(), employeditmetroComboBox2.SelectedValue.ToString());
                MessageBox.Show("xóa thành công");
                this.Close();
            }
            catch
            {
                
                MessageBox.Show("Kiểm tra dữ liệu nhập vào");
            }
        }
    }
}
