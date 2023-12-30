
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_winForm.Forms
{
    public partial class frmEdit : Form
    {
       
        public frmEdit(int contactId)
        {
            InitializeComponent();
            
        }

        private void editContactDto_Load(object sender, EventArgs e)
        {
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
          

        }
    }
}
