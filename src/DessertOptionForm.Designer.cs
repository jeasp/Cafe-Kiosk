namespace Kiosk
{
    partial class DessertOptionForm
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
            lblMenuName = new Label();
            label2 = new Label();
            lblBasePrice = new Label();
            label4 = new Label();
            nudQuantity = new NumericUpDown();
            label5 = new Label();
            lblExpectedPrice = new Label();
            btnCancel = new Button();
            btnAddCart = new Button();
            pnlHeader = new Panel();
            grpQuantity = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            pnlHeader.SuspendLayout();
            grpQuantity.SuspendLayout();
            SuspendLayout();
            // 
            // lblMenuName
            // 
            lblMenuName.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblMenuName.ForeColor = Color.White;
            lblMenuName.Location = new Point(0, 12);
            lblMenuName.Name = "lblMenuName";
            lblMenuName.Size = new Size(390, 42);
            lblMenuName.TabIndex = 0;
            lblMenuName.Text = "메뉴명";
            lblMenuName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(40, 90);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 1;
            label2.Text = "기본가격 :";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBasePrice
            // 
            lblBasePrice.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblBasePrice.ForeColor = Color.FromArgb(93, 64, 55);
            lblBasePrice.Location = new Point(125, 90);
            lblBasePrice.Name = "lblBasePrice";
            lblBasePrice.Size = new Size(120, 25);
            lblBasePrice.TabIndex = 2;
            lblBasePrice.Text = "0원";
            lblBasePrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(45, 38);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 3;
            label4.Text = "수량 :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(174, 43);
            nudQuantity.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(90, 25);
            nudQuantity.TabIndex = 4;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.ValueChanged += nudQuantity_ValueChanged;
            // 
            // label5
            // 
            label5.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(45, 260);
            label5.Name = "label5";
            label5.Size = new Size(100, 30);
            label5.TabIndex = 5;
            label5.Text = "예상금액 : ";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblExpectedPrice
            // 
            lblExpectedPrice.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblExpectedPrice.ForeColor = Color.FromArgb(93, 64, 55);
            lblExpectedPrice.Location = new Point(155, 250);
            lblExpectedPrice.Name = "lblExpectedPrice";
            lblExpectedPrice.Size = new Size(180, 45);
            lblExpectedPrice.TabIndex = 6;
            lblExpectedPrice.Text = "0원";
            lblExpectedPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatAppearance.BorderColor = Color.LightGray;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(80, 80, 80);
            btnCancel.Location = new Point(45, 335);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "취소";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAddCart
            // 
            btnAddCart.BackColor = Color.FromArgb(93, 64, 55);
            btnAddCart.FlatAppearance.BorderSize = 0;
            btnAddCart.FlatStyle = FlatStyle.Flat;
            btnAddCart.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddCart.ForeColor = Color.White;
            btnAddCart.Location = new Point(205, 335);
            btnAddCart.Name = "btnAddCart";
            btnAddCart.Size = new Size(145, 40);
            btnAddCart.TabIndex = 7;
            btnAddCart.Text = "장바구니 담기";
            btnAddCart.UseVisualStyleBackColor = false;
            btnAddCart.Click += btnAddCart_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(93, 64, 55);
            pnlHeader.Controls.Add(lblMenuName);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(390, 70);
            pnlHeader.TabIndex = 8;
            // 
            // grpQuantity
            // 
            grpQuantity.BackColor = Color.White;
            grpQuantity.Controls.Add(label4);
            grpQuantity.Controls.Add(nudQuantity);
            grpQuantity.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            grpQuantity.Location = new Point(35, 135);
            grpQuantity.Name = "grpQuantity";
            grpQuantity.Size = new Size(320, 95);
            grpQuantity.TabIndex = 9;
            grpQuantity.TabStop = false;
            grpQuantity.Text = "수량 선택";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 244, 239);
            ClientSize = new Size(374, 391);
            Controls.Add(grpQuantity);
            Controls.Add(pnlHeader);
            Controls.Add(btnAddCart);
            Controls.Add(btnCancel);
            Controls.Add(lblExpectedPrice);
            Controls.Add(label5);
            Controls.Add(lblBasePrice);
            Controls.Add(label2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterParent;
            Text = "디저트 옵션";
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            pnlHeader.ResumeLayout(false);
            grpQuantity.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblMenuName;
        private Label label2;
        private Label lblBasePrice;
        private Label label4;
        private NumericUpDown nudQuantity;
        private Label label5;
        private Label lblExpectedPrice;
        private Button btnCancel;
        private Button btnAddCart;
        private Panel pnlHeader;
        private GroupBox grpQuantity;
    }
}