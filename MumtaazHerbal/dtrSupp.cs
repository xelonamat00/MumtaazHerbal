using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MumtaazHerbal
{
    public partial class dftrSupp : DevExpress.XtraEditors.XtraForm
    {
        public dftrSupp()
        {
            InitializeComponent();
        }

        private void dftrSupp_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(tmbhSupp))
                {
                    form.Activate();
                    return;
                }
            }
            tmbhSupp supp = new tmbhSupp();
            supp.MdiParent = this.ParentForm;
            supp.Show();
        }
    }
}