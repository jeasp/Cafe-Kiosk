namespace Kiosk
{
    partial class DrinkOptionForm
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
            groupBox1 = new GroupBox();
            radioICE = new RadioButton();
            radioHot = new RadioButton();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            radioLarge = new RadioButton();
            radioMedium = new RadioButton();
            radioSmall = new RadioButton();
            groupBox3 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            radioShot2 = new RadioButton();
            radioShot1 = new RadioButton();
            radioNoShot = new RadioButton();
            nudQuantity = new NumericUpDown();
            label1 = new Label();
            lblMenuName = new Label();
            label3 = new Label();
            lblBasePrice = new Label();
            btnAddCart = new Button();
            btnCancel = new Button();
            label9 = new Label();
            lblExpectedPrice = new Label();
            pnlHeader = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(radioICE);
            groupBox1.Controls.Add(radioHot);
            groupBox1.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(50, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 80);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "온도";
            // 
            // radioICE
            // 
            radioICE.AutoSize = true;
            radioICE.Location = new Point(180, 30);
            radioICE.Name = "radioICE";
            radioICE.Size = new Size(45, 21);
            radioICE.TabIndex = 1;
            radioICE.TabStop = true;
            radioICE.Text = "ICE";
            radioICE.UseVisualStyleBackColor = true;
            // 
            // radioHot
            // 
            radioHot.AutoSize = true;
            radioHot.Location = new Point(45, 30);
            radioHot.Name = "radioHot";
            radioHot.Size = new Size(52, 21);
            radioHot.TabIndex = 0;
            radioHot.TabStop = true;
            radioHot.Text = "HOT";
            radioHot.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(radioLarge);
            groupBox2.Controls.Add(radioMedium);
            groupBox2.Controls.Add(radioSmall);
            groupBox2.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(50, 210);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(360, 115);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "사이즈";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 80);
            label5.Name = "label5";
            label5.Size = new Size(63, 17);
            label5.TabIndex = 3;
            label5.Text = "+ 1000원";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(190, 53);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 3;
            label4.Text = "+ 500원";
            // 
            // radioLarge
            // 
            radioLarge.AutoSize = true;
            radioLarge.Location = new Point(45, 82);
            radioLarge.Name = "radioLarge";
            radioLarge.Size = new Size(59, 21);
            radioLarge.TabIndex = 2;
            radioLarge.TabStop = true;
            radioLarge.Text = "Large";
            radioLarge.UseVisualStyleBackColor = true;
            radioLarge.CheckedChanged += radioLarge_CheckedChanged;
            // 
            // radioMedium
            // 
            radioMedium.AutoSize = true;
            radioMedium.Location = new Point(45, 55);
            radioMedium.Name = "radioMedium";
            radioMedium.Size = new Size(75, 21);
            radioMedium.TabIndex = 1;
            radioMedium.TabStop = true;
            radioMedium.Text = "Medium";
            radioMedium.UseVisualStyleBackColor = true;
            radioMedium.CheckedChanged += radioMedium_CheckedChanged;
            // 
            // radioSmall
            // 
            radioSmall.AutoSize = true;
            radioSmall.Location = new Point(45, 28);
            radioSmall.Name = "radioSmall";
            radioSmall.Size = new Size(57, 21);
            radioSmall.TabIndex = 0;
            radioSmall.TabStop = true;
            radioSmall.Text = "Small";
            radioSmall.UseVisualStyleBackColor = true;
            radioSmall.CheckedChanged += radioSmall_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(radioShot2);
            groupBox3.Controls.Add(radioShot1);
            groupBox3.Controls.Add(radioNoShot);
            groupBox3.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(50, 340);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(360, 125);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "샷 추가";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(205, 86);
            label7.Name = "label7";
            label7.Size = new Size(63, 17);
            label7.TabIndex = 1;
            label7.Text = "+ 1000원";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(205, 56);
            label6.Name = "label6";
            label6.Size = new Size(56, 17);
            label6.TabIndex = 1;
            label6.Text = "+ 500원";
            // 
            // radioShot2
            // 
            radioShot2.AutoSize = true;
            radioShot2.Location = new Point(45, 88);
            radioShot2.Name = "radioShot2";
            radioShot2.Size = new Size(147, 21);
            radioShot2.TabIndex = 0;
            radioShot2.TabStop = true;
            radioShot2.Text = "에스프레소 2샷 추가";
            radioShot2.UseVisualStyleBackColor = true;
            radioShot2.CheckedChanged += radioShot2_CheckedChanged;
            // 
            // radioShot1
            // 
            radioShot1.AutoSize = true;
            radioShot1.Location = new Point(45, 58);
            radioShot1.Name = "radioShot1";
            radioShot1.Size = new Size(140, 21);
            radioShot1.TabIndex = 0;
            radioShot1.TabStop = true;
            radioShot1.Text = "에스프레소 샷 추가";
            radioShot1.UseVisualStyleBackColor = true;
            radioShot1.CheckedChanged += radioShot1_CheckedChanged;
            // 
            // radioNoShot
            // 
            radioNoShot.AutoSize = true;
            radioNoShot.Location = new Point(45, 28);
            radioNoShot.Name = "radioNoShot";
            radioNoShot.Size = new Size(78, 21);
            radioNoShot.TabIndex = 0;
            radioNoShot.TabStop = true;
            radioNoShot.Text = "추가없음";
            radioNoShot.UseVisualStyleBackColor = true;
            radioNoShot.CheckedChanged += radioNoShot_CheckedChanged;
            // 
            // nudQuantity
            // 
            nudQuantity.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nudQuantity.Location = new Point(270, 485);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(90, 25);
            nudQuantity.TabIndex = 2;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.ValueChanged += nudQuantity_ValueChanged;
            // 
            // label1
            // 
            label1.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(75, 485);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 3;
            label1.Text = "수량 :";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMenuName
            // 
            lblMenuName.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblMenuName.ForeColor = Color.White;
            lblMenuName.Location = new Point(0, 12);
            lblMenuName.Name = "lblMenuName";
            lblMenuName.Size = new Size(460, 40);
            lblMenuName.TabIndex = 4;
            lblMenuName.Text = "메뉴명";
            lblMenuName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(35, 85);
            label3.Name = "label3";
            label3.Size = new Size(73, 17);
            label3.TabIndex = 5;
            label3.Text = "기본가격 : ";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBasePrice
            // 
            lblBasePrice.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblBasePrice.ForeColor = Color.FromArgb(93, 64, 55);
            lblBasePrice.Location = new Point(120, 82);
            lblBasePrice.Name = "lblBasePrice";
            lblBasePrice.Size = new Size(120, 25);
            lblBasePrice.TabIndex = 6;
            lblBasePrice.Text = "0원";
            lblBasePrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAddCart
            // 
            btnAddCart.BackColor = Color.FromArgb(93, 64, 55);
            btnAddCart.FlatAppearance.BorderSize = 0;
            btnAddCart.FlatStyle = FlatStyle.Flat;
            btnAddCart.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddCart.ForeColor = Color.White;
            btnAddCart.Location = new Point(245, 585);
            btnAddCart.Name = "btnAddCart";
            btnAddCart.Size = new Size(150, 38);
            btnAddCart.TabIndex = 7;
            btnAddCart.Text = "장바구니 담기";
            btnAddCart.UseVisualStyleBackColor = false;
            btnAddCart.Click += btnAddCart_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(80, 80, 80);
            btnCancel.Location = new Point(65, 585);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 38);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "취소";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label9
            // 
            label9.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(75, 525);
            label9.Name = "label9";
            label9.Size = new Size(100, 30);
            label9.TabIndex = 9;
            label9.Text = "예상금액 : ";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblExpectedPrice
            // 
            lblExpectedPrice.Font = new Font("맑은 고딕", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblExpectedPrice.ForeColor = Color.FromArgb(93, 64, 55);
            lblExpectedPrice.Location = new Point(190, 518);
            lblExpectedPrice.Name = "lblExpectedPrice";
            lblExpectedPrice.Size = new Size(180, 42);
            lblExpectedPrice.TabIndex = 10;
            lblExpectedPrice.Text = "0원";
            lblExpectedPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(93, 64, 55);
            pnlHeader.Controls.Add(lblMenuName);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(460, 70);
            pnlHeader.TabIndex = 11;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 244, 239);
            ClientSize = new Size(444, 651);
            Controls.Add(pnlHeader);
            Controls.Add(label3);
            Controls.Add(lblBasePrice);
            Controls.Add(lblExpectedPrice);
            Controls.Add(label9);
            Controls.Add(btnCancel);
            Controls.Add(btnAddCart);
            Controls.Add(label1);
            Controls.Add(nudQuantity);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "옵션 선택";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioICE;
        private RadioButton radioHot;
        private GroupBox groupBox2;
        private RadioButton radioLarge;
        private RadioButton radioMedium;
        private RadioButton radioSmall;
        private GroupBox groupBox3;
        private RadioButton radioShot2;
        private RadioButton radioShot1;
        private RadioButton radioNoShot;
        private NumericUpDown nudQuantity;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label lblMenuName;
        private Label label3;
        private Label lblBasePrice;
        private Button btnAddCart;
        private Button btnCancel;
        private Label label9;
        private Label lblExpectedPrice;
        private Panel pnlHeader;
    }
}