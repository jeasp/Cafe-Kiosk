namespace Kiosk
{
    partial class PaymentForm
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
            label1 = new Label();
            lblTotalPrice = new Label();
            picCard = new PictureBox();
            pnlCard = new Panel();
            lblCard = new Label();
            label3 = new Label();
            pnlNaverPay = new Panel();
            lblNaverPay = new Label();
            picNaverPay = new PictureBox();
            pnlKakaoPay = new Panel();
            lblKakaoPay = new Label();
            picKakaoPay = new PictureBox();
            pnlSamsungPay = new Panel();
            lblSamsungPay = new Label();
            picSamsungPay = new PictureBox();
            btnCancel = new Button();
            btnPay = new Button();
            pnlHeader = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)picCard).BeginInit();
            pnlCard.SuspendLayout();
            pnlNaverPay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picNaverPay).BeginInit();
            pnlKakaoPay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picKakaoPay).BeginInit();
            pnlSamsungPay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSamsungPay).BeginInit();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(45, 405);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 0;
            label1.Text = "총 결제금액 :";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalPrice.ForeColor = Color.FromArgb(93, 64, 55);
            lblTotalPrice.Location = new Point(190, 395);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(220, 45);
            lblTotalPrice.TabIndex = 1;
            lblTotalPrice.Text = "0원";
            lblTotalPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // picCard
            // 
            picCard.Image = Properties.Resources.카드;
            picCard.Location = new Point(37, 15);
            picCard.Name = "picCard";
            picCard.Size = new Size(100, 70);
            picCard.SizeMode = PictureBoxSizeMode.Zoom;
            picCard.TabIndex = 2;
            picCard.TabStop = false;
            picCard.Click += picCard_Click;
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(lblCard);
            pnlCard.Controls.Add(picCard);
            pnlCard.Cursor = Cursors.Hand;
            pnlCard.Location = new Point(40, 95);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(175, 130);
            pnlCard.TabIndex = 3;
            pnlCard.Click += pnlCard_Click;
            // 
            // lblCard
            // 
            lblCard.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCard.ForeColor = Color.FromArgb(51, 51, 51);
            lblCard.Location = new Point(10, 92);
            lblCard.Name = "lblCard";
            lblCard.Size = new Size(155, 28);
            lblCard.TabIndex = 3;
            lblCard.Text = "신용카드";
            lblCard.TextAlign = ContentAlignment.MiddleCenter;
            lblCard.Click += lblCard_Click;
            // 
            // label3
            // 
            label3.Font = new Font("맑은 고딕", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 12);
            label3.Name = "label3";
            label3.Size = new Size(460, 42);
            label3.TabIndex = 4;
            label3.Text = "결제 방법을 선택해주세요";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlNaverPay
            // 
            pnlNaverPay.BackColor = Color.White;
            pnlNaverPay.BorderStyle = BorderStyle.FixedSingle;
            pnlNaverPay.Controls.Add(lblNaverPay);
            pnlNaverPay.Controls.Add(picNaverPay);
            pnlNaverPay.Cursor = Cursors.Hand;
            pnlNaverPay.Location = new Point(245, 95);
            pnlNaverPay.Name = "pnlNaverPay";
            pnlNaverPay.Size = new Size(175, 130);
            pnlNaverPay.TabIndex = 4;
            pnlNaverPay.Click += pnlNaverPay_Click;
            // 
            // lblNaverPay
            // 
            lblNaverPay.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNaverPay.ForeColor = Color.FromArgb(51, 51, 51);
            lblNaverPay.Location = new Point(10, 92);
            lblNaverPay.Name = "lblNaverPay";
            lblNaverPay.Size = new Size(155, 28);
            lblNaverPay.TabIndex = 3;
            lblNaverPay.Text = "네이버페이";
            lblNaverPay.TextAlign = ContentAlignment.MiddleCenter;
            lblNaverPay.Click += lblNaverPay_Click;
            // 
            // picNaverPay
            // 
            picNaverPay.Image = Properties.Resources.네이버페이;
            picNaverPay.Location = new Point(37, 15);
            picNaverPay.Name = "picNaverPay";
            picNaverPay.Size = new Size(100, 70);
            picNaverPay.SizeMode = PictureBoxSizeMode.Zoom;
            picNaverPay.TabIndex = 2;
            picNaverPay.TabStop = false;
            picNaverPay.Click += picNaverPay_Click;
            // 
            // pnlKakaoPay
            // 
            pnlKakaoPay.BackColor = Color.White;
            pnlKakaoPay.BorderStyle = BorderStyle.FixedSingle;
            pnlKakaoPay.Controls.Add(lblKakaoPay);
            pnlKakaoPay.Controls.Add(picKakaoPay);
            pnlKakaoPay.Cursor = Cursors.Hand;
            pnlKakaoPay.Location = new Point(40, 245);
            pnlKakaoPay.Name = "pnlKakaoPay";
            pnlKakaoPay.Size = new Size(175, 130);
            pnlKakaoPay.TabIndex = 4;
            pnlKakaoPay.Click += pnlKakaoPay_Click;
            // 
            // lblKakaoPay
            // 
            lblKakaoPay.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblKakaoPay.ForeColor = Color.FromArgb(51, 51, 51);
            lblKakaoPay.Location = new Point(10, 92);
            lblKakaoPay.Name = "lblKakaoPay";
            lblKakaoPay.Size = new Size(155, 28);
            lblKakaoPay.TabIndex = 3;
            lblKakaoPay.Text = "카카오페이";
            lblKakaoPay.TextAlign = ContentAlignment.MiddleCenter;
            lblKakaoPay.Click += lblKakaoPay_Click;
            // 
            // picKakaoPay
            // 
            picKakaoPay.Image = Properties.Resources.카카오페이;
            picKakaoPay.Location = new Point(37, 15);
            picKakaoPay.Name = "picKakaoPay";
            picKakaoPay.Size = new Size(100, 70);
            picKakaoPay.SizeMode = PictureBoxSizeMode.Zoom;
            picKakaoPay.TabIndex = 2;
            picKakaoPay.TabStop = false;
            picKakaoPay.Click += picKakaoPay_Click;
            // 
            // pnlSamsungPay
            // 
            pnlSamsungPay.BackColor = Color.White;
            pnlSamsungPay.BorderStyle = BorderStyle.FixedSingle;
            pnlSamsungPay.Controls.Add(lblSamsungPay);
            pnlSamsungPay.Controls.Add(picSamsungPay);
            pnlSamsungPay.Cursor = Cursors.Hand;
            pnlSamsungPay.Location = new Point(245, 245);
            pnlSamsungPay.Name = "pnlSamsungPay";
            pnlSamsungPay.Size = new Size(175, 130);
            pnlSamsungPay.TabIndex = 4;
            pnlSamsungPay.Click += pnlSamsungPay_Click;
            // 
            // lblSamsungPay
            // 
            lblSamsungPay.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSamsungPay.ForeColor = Color.FromArgb(51, 51, 51);
            lblSamsungPay.Location = new Point(10, 92);
            lblSamsungPay.Name = "lblSamsungPay";
            lblSamsungPay.Size = new Size(155, 28);
            lblSamsungPay.TabIndex = 3;
            lblSamsungPay.Text = "삼성페이";
            lblSamsungPay.TextAlign = ContentAlignment.MiddleCenter;
            lblSamsungPay.Click += lblSamsungPay_Click;
            // 
            // picSamsungPay
            // 
            picSamsungPay.Image = Properties.Resources.삼성페이;
            picSamsungPay.Location = new Point(37, 15);
            picSamsungPay.Name = "picSamsungPay";
            picSamsungPay.Size = new Size(100, 70);
            picSamsungPay.SizeMode = PictureBoxSizeMode.Zoom;
            picSamsungPay.TabIndex = 2;
            picSamsungPay.TabStop = false;
            picSamsungPay.Click += picSamsungPay_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.FlatAppearance.BorderColor = Color.LightGray;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(80, 80, 80);
            btnCancel.Location = new Point(55, 530);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 42);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "취소";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(217, 140, 74);
            btnPay.Cursor = Cursors.Hand;
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(235, 530);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(170, 42);
            btnPay.TabIndex = 6;
            btnPay.Text = "결제하기";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(93, 64, 55);
            pnlHeader.Controls.Add(label3);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(460, 70);
            pnlHeader.TabIndex = 7;
            // 
            // label2
            // 
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(45, 450);
            label2.Name = "label2";
            label2.Size = new Size(365, 25);
            label2.TabIndex = 8;
            label2.Text = "결제수단을 선택한 후 결제하기를 눌러주세요.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 244, 239);
            ClientSize = new Size(444, 611);
            Controls.Add(label2);
            Controls.Add(pnlHeader);
            Controls.Add(btnPay);
            Controls.Add(btnCancel);
            Controls.Add(pnlSamsungPay);
            Controls.Add(pnlKakaoPay);
            Controls.Add(pnlNaverPay);
            Controls.Add(pnlCard);
            Controls.Add(lblTotalPrice);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterParent;
            Text = "결제하기";
            ((System.ComponentModel.ISupportInitialize)picCard).EndInit();
            pnlCard.ResumeLayout(false);
            pnlNaverPay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picNaverPay).EndInit();
            pnlKakaoPay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picKakaoPay).EndInit();
            pnlSamsungPay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picSamsungPay).EndInit();
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lblTotalPrice;
        private PictureBox picCard;
        private Panel pnlCard;
        private Label lblCard;
        private Label label3;
        private Panel pnlNaverPay;
        private Label lblNaverPay;
        private PictureBox picNaverPay;
        private Panel pnlKakaoPay;
        private Label lblKakaoPay;
        private PictureBox picKakaoPay;
        private Panel pnlSamsungPay;
        private Label lblSamsungPay;
        private PictureBox picSamsungPay;
        private Button btnCancel;
        private Button btnPay;
        private Panel pnlHeader;
        private Label label2;
    }
}