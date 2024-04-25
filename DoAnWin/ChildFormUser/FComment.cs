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

namespace DoAnWin.ChildFormUser
{
    public partial class FComment : Form
    {
        Job job;
        public FComment()
        {
            InitializeComponent();
        }

        public FComment(Job job)
        {
            InitializeComponent();
            this.job = job;
        }

        private void FComment_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
