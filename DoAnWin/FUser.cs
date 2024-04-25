using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnWin.ChildFormUser;
using DoAnWin.DAOClass;
using DoAnWin.NormalClass;
using DoAnWin.PropertyClass;

namespace DoAnWin
{
    public partial class FUser : Form
    {
        UserDAO userDAO = new UserDAO();
        public FUser()
        {
            InitializeComponent();
        }

        private void FUser_Load(object sender, EventArgs e)
        {
            FormDAO fd = new FormDAO();
            guna2ShadowForm1.SetShadowForm(this);
            fd.OpenChildForm(new ChildFormUser.FUserHome(), ref FormDAO.activeForm, panelUserContain);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FormDAO fd = new FormDAO();
            lblVal.Text = btnHome.Text;
            picVal.Image = Properties.Resources.icons8_google_home_64;
            fd.OpenChildForm(new ChildFormUser.FUserHome(), ref FormDAO.activeForm, panelUserContain);
        }

        private void btnPostJob_Click(object sender, EventArgs e)
        {
            FormDAO fd = new FormDAO();
            lblVal.Text = btnPostJob.Text;
            picVal.Image = Properties.Resources.tuyenthogra;
            fd.OpenChildForm(new ChildFormUser.FUserPostJob(), ref FormDAO.activeForm, panelUserContain);
        }

        private void btnHired_Click(object sender, EventArgs e)
        {
            FormDAO fd = new FormDAO();
            lblVal.Text = btnHired.Text;
            picVal.Image = Properties.Resources.history;
            fd.OpenChildForm(new ChildFormUser.FUserHired(), ref FormDAO.activeForm, panelUserContain);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            User us = new User();
            us = userDAO.UserInfo();
            FormDAO fd = new FormDAO();
            lblVal.Text = btnUser.Text;
            picVal.Image = Properties.Resources.user;
            fd.OpenChildForm(new ChildFormUser.FUserInfo(us), ref FormDAO.activeForm, panelUserContain);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                FLogin login = new FLogin();
                login.ShowDialog();
                this.Close();
            }
        }
    }
}
