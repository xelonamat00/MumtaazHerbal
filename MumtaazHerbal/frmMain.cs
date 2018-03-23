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
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
            //faisal
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(dftrItem))
                {
                    form.Activate();
                    return;
                }
            }
            dftrItem item = new dftrItem();
            item.MdiParent = this;
            item.Show();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
            item.MdiParent = this;
            item.Show();
        }

        private void btnDftrSupp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(dftrSupp))
                {
                    form.Activate();
                    return;
                }
            }

            dftrSupp supp = new dftrSupp();
            supp.MdiParent = this;
            supp.Show();
        }

        private void btnDftrPel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(dftrPel))
                {
                    form.Activate();
                    return;
                }
            }

            dftrPel pel = new dftrPel();
            pel.MdiParent = this;
            pel.Show();
        }

        private void btnMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(kasir))
                {
                    form.Activate();
                    return;
                }
            }

            kasir ksr = new kasir();
            ksr.MdiParent = this;
            ksr.Show();
        }
    }
}