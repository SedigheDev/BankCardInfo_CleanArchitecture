
namespace UI_winForm.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            txtSearchKey = new TextBox();
            btnSearch = new Button();
            label1 = new Label();
            btnDelete = new Button();
            btnAddNewBankCardInfo = new Button();
            btnEdit = new Button();
            btnDetail = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(587, 406);
            dataGridView1.TabIndex = 0;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // txtSearchKey
            // 
            txtSearchKey.Location = new Point(322, 71);
            txtSearchKey.Name = "txtSearchKey";
            txtSearchKey.Size = new Size(169, 28);
            txtSearchKey.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(259, 128);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(169, 33);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "جستجو";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 69);
            label1.Name = "label1";
            label1.Size = new Size(81, 24);
            label1.TabIndex = 3;
            label1.Text = "جستجو کنید";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 147);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(163, 33);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "حذف اطلاعات کارت";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAddNewBankCardInfo
            // 
            btnAddNewBankCardInfo.Location = new Point(12, 69);
            btnAddNewBankCardInfo.Name = "btnAddNewBankCardInfo";
            btnAddNewBankCardInfo.Size = new Size(163, 33);
            btnAddNewBankCardInfo.TabIndex = 6;
            btnAddNewBankCardInfo.Text = "ثبت کارت جدید";
            btnAddNewBankCardInfo.UseVisualStyleBackColor = true;
            btnAddNewBankCardInfo.Click += btnAddNewContact_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(12, 26);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(163, 37);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "ویرایش اطلاعات کارت";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDetail
            // 
            btnDetail.Location = new Point(12, 108);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(163, 33);
            btnDetail.TabIndex = 5;
            btnDetail.Text = "نمایش جزئیات کارت";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 614);
            Controls.Add(btnEdit);
            Controls.Add(btnAddNewBankCardInfo);
            Controls.Add(btnDetail);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchKey);
            Controls.Add(dataGridView1);
            Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "frmMain";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "دفترچه تلفن";
            Load += frmMain_Load;
            DoubleClick += frmMain_DoubleClick;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtSearchKey;
        private Button btnSearch;
        private Label label1;
        private Button btnDelete;
        private Button btnAddNewBankCardInfo;
        private Button btnEdit;
        private Button btnDetail;
    }
}