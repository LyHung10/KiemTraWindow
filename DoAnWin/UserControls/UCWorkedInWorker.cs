using DoAnWin.PropertyClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWin.UserControls
{
    public partial class UCWorkedInWorker : UserControl
    {
        private Job job;
        public UCWorkedInWorker()
        {
            InitializeComponent();
        }

        public UCWorkedInWorker(Job job)
        {
            InitializeComponent();
            this.job = job;
            lblName.Text = job.NameUser;
            lblID.Text = job.IdUser;
        }

        private void btnComment_Click(object sender, EventArgs e)
        {

        }
    }
}
