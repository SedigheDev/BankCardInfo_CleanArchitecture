
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

namespace UI_winForm.Forms
{
    public partial class frmAddBankCardInfo : Form
    {
        private readonly IAddNewBankCardInfoService addNewBankCardInfoService;

        public frmAddBankCardInfo(IAddNewBankCardInfoService addNewBankCardInfoService)
        {
            InitializeComponent();
            this.addNewBankCardInfoService = addNewBankCardInfoService;
        }

        private void frmAddContact_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var result = addNewBankCardInfoService.Execute(new AddNewBankCardInfoDto
            {
                BankName = txtBankName.Text,
                BankCardNumber = txtBankCardNumber.Text,
                BankAccountNumber = txtBankAccountNumber.Text,
                BankCvv2 = txtBankCvv2.Text,
                ExpireDate = txtExpireDate.Text
            });
            if (result.IsSuccess)
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
