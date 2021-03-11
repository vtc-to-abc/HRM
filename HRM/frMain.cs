using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalHRM
{
    public partial class frMain : MetroFramework.Forms.MetroForm
    {
      
        public frMain()
        {
           
            InitializeComponent();
            

        }

       
        private void employbtt_Click(object sender, EventArgs e)
        {
            this.metroPanel1.Controls.Clear();
            frEmploy em = new frEmploy();
            em.MdiParent = this;
            this.metroPanel1.Controls.Add(em);
            em.Dock = DockStyle.Fill;
            em.Show();
            
        }

        private void mainexit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void frMain_Load(object sender, EventArgs e)
        {

        }

     

       

        private void mainuser_Click(object sender, EventArgs e)
        {
            frLogin lo = new frLogin();
            lo.Show();
            this.Close();
        }

        private void Depbtt_Click(object sender, EventArgs e)
        {
            this.metroPanel1.Controls.Clear();
            frJob em = new frJob();
            em.MdiParent = this;
            this.metroPanel1.Controls.Add(em);
            em.Dock = DockStyle.Fill;
            em.Show();
        }

        private void DuAnbtt_Click(object sender, EventArgs e)
        {
            this.metroPanel1.Controls.Clear();
            frTakePartIn em = new frTakePartIn();
            em.MdiParent = this;
            this.metroPanel1.Controls.Add(em);
            em.Dock = DockStyle.Fill;
            em.Show();
        }
    }
}
