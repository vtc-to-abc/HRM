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
    public partial class frEmployAdd : MetroFramework.Forms.MetroForm
    {
        //BindingSource NhanVienNowList = new BindingSource();
        FinalHRMEntities6 db = new FinalHRMEntities6();
        public frEmployAdd()
        {
            InitializeComponent();
            Load_AddCBB();
        }

        public void Load_AddCBB() {
            employaddcareer.DataSource = db.JobOfDeps.Select (p => p).ToList();
            employaddcareer.DisplayMember=("name");
            employaddcareer.ValueMember = ("id");
            
        }
        private void frEmployAdd_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void employaddcancelbtt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void employaddyesbtt_Click(object sender, EventArgs e)
        {
            try {
                string id = employaddidtxt.Text;
                string name = emploaddnametxt.Text;
                DateTime dob = employadddob.Value;
                string email = employaddemail.Text;
                string gt = (radmale.Checked == true) ? "Nam" : "Nữ";
                string phone = employaddphone.Text;
                string sal = employaddsal.Text;
                string career = employaddcareer.SelectedValue.ToString();
                DateTime join = employaddjoin.Value;
                db.new_Employee(id, name, dob, gt, email, phone, join, career, System.Convert.ToInt32(sal));
                this.Close(); }
            catch 
            {
                MessageBox.Show("Kiểm tra dữ liệu nhập vào");
            }
        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void employaddcareer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
