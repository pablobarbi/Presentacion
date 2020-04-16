
using AppService.Helper;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace AppDesktop
{
    public partial class MDIForm : Form
    { 
        public MDIForm()
        { 
            InitializeComponent();
            ServicesHelper.URL = ConfigurationManager.AppSettings["serviceUrl"].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void storesToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            FrmStores frmStores = new FrmStores();
            frmStores.Show();
            frmStores.MdiParent = this; 
        }

        private void MDIForm_Load(object sender, EventArgs e)
        {

        }

        private void articlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArticles frmArticles = new FrmArticles();
            frmArticles.Show();
            frmArticles.MdiParent = this;
            
        }
    }
}
