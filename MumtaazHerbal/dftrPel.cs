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
    public partial class dftrPel : DevExpress.XtraEditors.XtraForm
    {
        public dftrPel()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(tmbhPel))
                {
                    form.Activate();
                    return;
                }
            }

            tmbhPel tmbh = new tmbhPel();
            tmbh.MdiParent = this.ParentForm;
            tmbh.Show();
        }

        private void dftrPel_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}