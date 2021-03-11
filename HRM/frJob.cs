using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalHRM
{
    public partial class frJob : MetroFramework.Forms.MetroForm
    {
        BindingSource JobProfile = new BindingSource();
        FinalHRMEntities6 db = new FinalHRMEntities6();
        public frJob()
        {
            InitializeComponent();
            Load1();
        }
        public void Load1()
        {
            jobmetroGrid1.DataSource = JobProfile;
            JobProfile.DataSource = db.output_AllProfile();
        }

        private void jobsearchbtt_Click(object sender, EventArgs e)
        {
            string search = jobsearchtxt.Text;
            jobmetroGrid1.DataSource = db.Profile_Search(search);
        }
    }
}
