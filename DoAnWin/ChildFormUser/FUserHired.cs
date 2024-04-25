using DoAnWin.DAOClass;
using DoAnWin.PropertyClass;
using DoAnWin.UserControls;
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
    public partial class FUserHired : Form
    {
        private List<Job> listFinishWork = new List<Job>();
        private JobDAO jd = new JobDAO();
        public FUserHired()
        {
            InitializeComponent();
            listFinishWork = jd.LoadFinishWork();
            //foreach (Job job in listFinishWork)
            //{
            //    UCHiredInUser uc = new UCHiredInUser(job);
            //    uc.Margin = new Padding(10);
            //    flowPanelContain.Controls.Add(uc);
            //}
        }

        private void FUserHired_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(listFinishWork.Count.ToString());
            foreach (Job job in listFinishWork)
            {
                UCHiredInUser uc = new UCHiredInUser(job);
                //uc.Margin = new Padding(10);
                flowPanelContain.Controls.Add(uc);
            }
        }
    }
}
