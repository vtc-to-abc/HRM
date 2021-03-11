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
   
    public partial class frTakePartIn : MetroFramework.Forms.MetroForm
    {
        BindingSource TPINOWList = new BindingSource();
        BindingSource TPIHisList = new BindingSource();
        FinalHRMEntities6 db = new FinalHRMEntities6();
        public frTakePartIn()
        {
            InitializeComponent();
            Load1();
        }

        public void Load1()
        {
            LoadTPINow();
            LoadTPIHis();

        }

        public void LoadTPINow()
        {
            tpinowmetroGrid1.DataSource = TPINOWList;
            TPINOWList.DataSource = db.output_TPINow();
        }

        public void LoadTPIHis()
        {
            tpihismetroGrid1.DataSource = TPIHisList;
            TPIHisList.DataSource = db.output_TPIHistory();
        }

        private void tpinowsearchbtt_Click(object sender, EventArgs e)
        {
            string search = tpinowsearchtxt.Text;
            tpinowmetroGrid1.DataSource = db.Profile_Search(search);
        }

        private void tpihissearchbtt_Click(object sender, EventArgs e)
        {
            string search = tpihissearchtxt.Text;
            tpihismetroGrid1.DataSource = db.Profile_Search(search);
        }

        private void tpinowaddbtt_Click(object sender, EventArgs e)
        {
            frTPIAdd add = new frTPIAdd();
            add.ShowDialog();
        }

        private void tpinoweditbtt_Click(object sender, EventArgs e)
        {
            frTPIEditDel ed = new frTPIEditDel();
            ed.ShowDialog();
        }
    }
    }

