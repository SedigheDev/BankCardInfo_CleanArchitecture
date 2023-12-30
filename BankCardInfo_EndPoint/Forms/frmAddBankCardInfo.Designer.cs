
namespace UI_winForm.Forms
{
    partial class frmAddBankCardInfo
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            label1 = new Label();
            txtExpireDate = new TextBox();
            txtBankCvv2 = new TextBox();
            txtBankCardNumber = new TextBox();
            txtBankAccountNumber = new TextBox();
            txtBankName = new TextBox();
            btnCancel = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-3, 261);
            label5.Name = "label5";
            label5.Size = new Size(121, 24);
            label5.TabIndex = 22;
            label5.Text = "تاریخ انقضا کارت";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 196);
            label4.Name = "label4";
            label4.Size = new Size(51, 24);
            label4.TabIndex = 23;
            label4.Text = "Cvv2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 141);
            label3.Name = "label3";
            label3.Size = new Size(84, 24);
            label3.TabIndex = 21;
            label3.Text = "شماره کارت";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 101);
            label2.Name = "label2";
            label2.Size = new Size(88, 24);
            label2.TabIndex = 20;
            label2.Text = "شماره حساب";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Yellow;
            label7.Location = new Point(139, 9);
            label7.Name = "label7";
            label7.Size = new Size(309, 29);
            label7.TabIndex = 18;
            label7.Text = "افزودن اطلاعات بانکی کارت جدید";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 55);
            label1.Name = "label1";
            label1.Size = new Size(55, 24);
            label1.TabIndex = 19;
            label1.Text = "نام بانک";
            label1.Click += label1_Click;
            // 
            // txtExpireDate
            // 
            txtExpireDate.AcceptsReturn = true;
            txtExpireDate.Location = new Point(125, 257);
            txtExpireDate.Margin = new Padding(4, 5, 4, 5);
            txtExpireDate.Multiline = true;
            txtExpireDate.Name = "txtExpireDate";
            txtExpireDate.Size = new Size(284, 28);
            txtExpireDate.TabIndex = 17;
            // 
            // txtBankCvv2
            // 
            txtBankCvv2.Location = new Point(125, 193);
            txtBankCvv2.Margin = new Padding(4, 5, 4, 5);
            txtBankCvv2.Name = "txtBankCvv2";
            txtBankCvv2.Size = new Size(284, 28);
            txtBankCvv2.TabIndex = 16;
            // 
            // txtBankCardNumber
            // 
            txtBankCardNumber.Location = new Point(125, 141);
            txtBankCardNumber.Margin = new Padding(4, 5, 4, 5);
            txtBankCardNumber.Name = "txtBankCardNumber";
            txtBankCardNumber.Size = new Size(284, 28);
            txtBankCardNumber.TabIndex = 15;
            // 
            // txtBankAccountNumber
            // 
            txtBankAccountNumber.Location = new Point(125, 98);
            txtBankAccountNumber.Margin = new Padding(4, 5, 4, 5);
            txtBankAccountNumber.Name = "txtBankAccountNumber";
            txtBankAccountNumber.Size = new Size(284, 28);
            txtBankAccountNumber.TabIndex = 14;
            // 
            // txtBankName
            // 
            txtBankName.Location = new Point(125, 55);
            txtBankName.Margin = new Padding(4, 5, 4, 5);
            txtBankName.Name = "txtBankName";
            txtBankName.Size = new Size(284, 28);
            txtBankName.TabIndex = 13;
            // 
            // btnCancel
            // 
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(303, 357);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "برگشت";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(26, 358);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(230, 40);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "ثبت کارت جدید";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmAddBankCardInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(436, 412);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(txtExpireDate);
            Controls.Add(txtBankCvv2);
            Controls.Add(txtBankCardNumber);
            Controls.Add(txtBankAccountNumber);
            Controls.Add(txtBankName);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmAddBankCardInfo";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmBnakName";
            Load += frmAddContact_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label1;
        private TextBox txtExpireDate;
        private TextBox txtBankCvv2;
        private TextBox txtBankCardNumber;
        private TextBox txtBankAccountNumber;
        private TextBox txtBankName;
        private Button btnCancel;
        private Button btnAdd;
    }
}