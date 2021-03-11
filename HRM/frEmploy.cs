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
    public partial class frEmploy : MetroFramework.Forms.MetroForm
    {
        BindingSource NhanVienNowList = new BindingSource();
        BindingSource NhanVienHisList = new BindingSource();
        FinalHRMEntities6 db = new FinalHRMEntities6();
        public frEmploy()
        {
            InitializeComponent();
            Load1();
        }

        public void Load1()
        {
            LoadEmNow();
            LoadEmHis();

        }

        public void LoadEmNow()
        {
            employnowmetroGrid1.DataSource = NhanVienNowList;
            NhanVienNowList.DataSource = db.output_Employnow();
        }

        public void LoadEmHis()
        {
            employhismetroGrid1.DataSource = NhanVienHisList;
            NhanVienHisList.DataSource = db.output_HistoryEmploy();
        }

        private void employnowsearchbtt_Click(object sender, EventArgs e)
        {
            string search = employnowsearchtxt.Text;
            employnowmetroGrid1.DataSource = db.Employ_Search(search);
        }

        private void employnowaddbtt_Click(object sender, EventArgs e)
        {
            frEmployAdd emadd = new frEmployAdd();
            emadd.ShowDialog();
        }

        private void employnoweditbtt_Click(object sender, EventArgs e)
        {
            frEmployeditdel edit = new frEmployeditdel();
            edit.ShowDialog();
        }

        private void employhissearchbtt_Click(object sender, EventArgs e)
        {
            string search = employhissearchtxt.Text;
            employhismetroGrid1.DataSource = db.Employ_Search_History(search);
        }
    }
}
