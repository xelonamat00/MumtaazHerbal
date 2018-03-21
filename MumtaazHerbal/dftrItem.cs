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
    public partial class dftrItem : DevExpress.XtraEditors.XtraForm
    {
        public dftrItem()
        {
            InitializeComponent();
        }

        private void dftrItem_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(tmbhItem))
                {
                    form.Activate();
                    return;
                }
            }
            tmbhItem item = new tmbhItem();
            item.MdiParent = this.ParentForm;
            item.Show();
        }
    }
}