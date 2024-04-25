using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnWin.ChildFormWorker;
using DoAnWin.DAOClass;
using DoAnWin.PropertyClass;
using DoAnWin.UserControls;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace DoAnWin.ChildFormUser
{
    public partial class FUserSeekWorker : Form
    {
        WorkerDAO workerDAO = new WorkerDAO();
        FormDAO fd = new FormDAO();
        private bool isbtnHaNoi = false;
        private bool isbtnHCM = false;
        private bool isbtnHue = false;
        private bool isbtnNoiKhac = false;
        private bool isbtn80 = false;
        private bool isbtn80120 = false;
        private bool isbtn120200 = false;
        private bool isbtn200 = false;
        private bool isbtn1sao = false;
        private bool isbtn2sao = false;
        private bool isbtn3sao = false;
        private bool isbtn4sao = false;
        private bool isbtn5sao = false;
        private bool isbtn1618 = false;
        private bool isbtn1825 = false;
        private bool isbtn25 = false;
        private bool isbtnTopRevenue = false;
        private bool isbtnTopRate = false;
        private bool isbtnTopBooking = false;
        private bool isbtnMinVen = false;
        public FUserSeekWorker(string title)
        {
            InitializeComponent();
            lblTitle.Text = title;
        }

        private void FUserSeekWorker_Load(object sender, EventArgs e)
        {
            LoadListWorker();
        }

        private void LoadListWorker()
        {
            List<Worker> workers = new List<Worker>();
            workers = workerDAO.LoadListWorker(lblTitle);
            foreach (Worker worker in workers)
            {
                UCWorkerUploadInfo uc = new UCWorkerUploadInfo(worker, lblTitle.Text);
                fd.loadWorkerInfo(uc, flowPanelContain);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fd.OpenChildForm(new ChildFormUser.FUserHome(), ref FormDAO.activeForm, FUser.panelUserContain);
        }

        bool isBtnAddressExpand = false;
        private void RollBtnAddress_Tick(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.ExpandButton(ref isBtnAddressExpand, panelComboAddress, btnAddress, RollBtnAddress);
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            RollBtnAddress.Start();
        }

        private void btnHaNoi_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtnHaNoi, btnHaNoi);

        }

        private void btnHCM_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtnHCM, btnHCM);
        }

        private void btnHue_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtnHue, btnHue);
        }

        private void btnNoiKhac_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtnNoiKhac, btnNoiKhac);
        }

        bool isBtnHireCostExpand = false;
        private void RollBtnHireCost_Tick(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.ExpandButton(ref isBtnHireCostExpand, panelComboHireCost, btnHireCost, RollBtnHireCost);
        }

        private void btnHireCost_Click(object sender, EventArgs e)
        {
            RollBtnHireCost.Start();
        }

        private void btn80_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtn80, btn80);
        }

        private void btn80120_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtn80120, btn80120);
        }

        private void btn120200_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtn120200, btn120200);
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtn200, btn200);
        }

        bool isBtnRateExpand = false;
        private void RollBtnRate_Tick(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.ExpandButton(ref isBtnRateExpand, panelComboRate, btnRate, RollBtnRate);
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            RollBtnRate.Start();
        }

        private void btn1Star_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtn1sao, btn1Star);
        }

        private void btn2Star_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtn2sao, btn2Star);
        }

        private void btn3Star_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtn3sao, btn3Star);
        }

        private void btn4Star_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtn4sao, btn4Star);
        }

        private void btn5Star_Click(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.CheckButtonActivate(ref isbtn5sao, btn5Star);
        }

        bool isBtnAgeExpand = false;
        private void RollBtnAge_Tick(object sender, EventArgs e)
        {
            FormDAO formDAO = new FormDAO();
            formDAO.ExpandButton(ref isBtnAgeExpand, panelComboAge, btnAge, RollBtnAge);
        }

        private void btnAge_Click(object sender, EventArgs e)
        {
            RollBtnAge.Start();
        }

        private void btnTopRevenue_Click(object sender, EventArgs e)
        {
            //FormDAO formDAO = new FormDAO();
            //formDAO.CheckButtonActivate(ref isbtnTopRevenue, btnTopRevenue);
            isbtnTopRate = false;
            isbtnTopBooking = false;
            isbtnMinVen = false;

            btnTopRate.BackColor = SystemColors.Control;
            btnTopBooking.BackColor = SystemColors.Control;
            flowPanelContain.Controls.Clear();
            List<Worker> workers = new List<Worker>();
            workers = workerDAO.LoadListWorkerTOPRevenue(lblTitle);
            foreach (Worker worker in workers)
            {
                UCWorkerUploadInfo uc = new UCWorkerUploadInfo(worker, lblTitle.Text);
                fd.loadWorkerInfo(uc, flowPanelContain);
            }
        }

        private void btnTopRate_Click(object sender, EventArgs e)
        {
            //FormDAO formDAO = new FormDAO();
            //formDAO.CheckButtonActivate(ref isbtnTopRate, btnTopRate);
            isbtnTopRevenue = false;
            isbtnTopBooking = false;
            isbtnMinVen = false;

            btnTopRevenue.BackColor = SystemColors.Control;
            btnTopBooking.BackColor = SystemColors.Control;

            flowPanelContain.Controls.Clear();
            List<Worker> workers = new List<Worker>();
            workers = workerDAO.LoadListWorkerTOP(lblTitle);
            foreach (Worker worker in workers)
            {
                UCWorkerUploadInfo uc = new UCWorkerUploadInfo(worker, lblTitle.Text);
                fd.loadWorkerInfo(uc, flowPanelContain);
            }
        }

        private void btnTopBooking_Click(object sender, EventArgs e)
        {
            //FormDAO formDAO = new FormDAO();
            //formDAO.CheckButtonActivate(ref isbtnTopBooking, btnTopBooking);
            isbtnTopRevenue = false;
            isbtnTopRate = false;
            isbtnMinVen = false;

            btnTopRevenue.BackColor = SystemColors.Control;
            btnTopRate.BackColor = SystemColors.Control;

            flowPanelContain.Controls.Clear();
            List<Worker> workers = new List<Worker>();
            workers = workerDAO.LoadListWorkerTOPBook(lblTitle);
            foreach (Worker worker in workers)
            {
                UCWorkerUploadInfo uc = new UCWorkerUploadInfo(worker, lblTitle.Text);
                fd.loadWorkerInfo(uc, flowPanelContain);
            }
        }

        private void btnMinVen_Click(object sender, EventArgs e)
        {
            isbtnTopBooking = false;
            isbtnTopRate = false;
            isbtnTopRevenue = false;

            btnTopRate.BackColor = SystemColors.Control;
            btnTopBooking.BackColor = SystemColors.Control;
            flowPanelContain.Controls.Clear();
            List<Worker> workers = new List<Worker>();
            workers = workerDAO.LoadListWorkerMinRevenue(lblTitle);
            foreach (Worker worker in workers)
            {
                UCWorkerUploadInfo uc = new UCWorkerUploadInfo(worker, lblTitle.Text);
                fd.loadWorkerInfo(uc, flowPanelContain);
            }
        }
    }
}
