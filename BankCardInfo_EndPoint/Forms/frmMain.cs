
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationBankCardInfo.Services.AddNewBankCardInfo;
using ApplicationBankCardInfo.Services.DeleteBankCardInfo;
using ApplicationBankCardInfo.Services.GetListBankCard;
using BankCardInfo_EndPoint;

namespace UI_winForm.Forms
{
    public partial class frmMain : Form
    {
        private readonly IGetListBankCardService getListBankCardService;
        private readonly IDeleteBankCardInfoService _deleteBankCardInfoService;

        public frmMain(IGetListBankCardService getListBankCardService, IDeleteBankCardInfoService DeleteBankCardInfoService)
        {
            this.getListBankCardService = getListBankCardService;
            _deleteBankCardInfoService = DeleteBankCardInfoService;
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            var ListContacts = getListBankCardService.Execute();
            SettingGridview(ListContacts);
            this.Cursor = Cursors.Default;
        }
        private void SettingGridview(List<BankCardListDto> ListContacts)
        {
            dataGridView1.DataSource = ListContacts;
            dataGridView1.Columns[0].HeaderText = "شناسه";
            dataGridView1.Columns[1].HeaderText = "نام بانک";
            dataGridView1.Columns[2].HeaderText = "شماره کارت";
            dataGridView1.Columns[3].HeaderText = "تاریخ انقضا";

            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 200;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            var ListContacts = getListBankCardService.Execute(txtSearchKey.Text);
            SettingGridview(ListContacts);
            this.Cursor = Cursors.Default;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var result = _deleteBankCardInfoService.Execute(Id);
            if (result.IsSuccess == true)
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain_Load(null, null);
            }
            else
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            ShowDetail();
        }

        private void ShowDetail()
        {
            var Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            frmDetailContact frmDetailContact = new frmDetailContact(Id);
            frmDetailContact.ShowDialog();
        }

        private void frmMain_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ShowDetail();
        }

        private void btnAddNewContact_Click(object sender, EventArgs e)
        {
            var ServiceAdd =
                (IAddNewBankCardInfoService)Program.ServiceProvider.GetService(typeof(IAddNewBankCardInfoService));
            frmAddBankCardInfo frmAddContact = new frmAddBankCardInfo(ServiceAdd);
            frmAddContact.ShowDialog();
            frmMain_Load(null, null);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var Id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            frmEdit frmEdit = new frmEdit(Id);
            frmEdit.ShowDialog();
            frmMain_Load(null, null);
        }
    }
}
