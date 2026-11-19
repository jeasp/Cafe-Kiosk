namespace Kiosk
{
    partial class ReceiptForm
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
            pnlReceipt = new Panel();
            btnConfirm = new Button();
            lblThanks = new Label();
            lblTotalPrice = new Label();
            lblTotalTitle = new Label();
            lblLine3 = new Label();
            flpOrderItems = new FlowLayoutPanel();
            lblLine2 = new Label();
            lblPaymentTime = new Label();
            lblPaymentMethod = new Label();
            lblOrderType = new Label();
            lblOrderNumber = new Label();
            lblLine1 = new Label();
            lblCafeName = new Label();
            pnlReceipt.SuspendLayout();
            SuspendLayout();
            // 
            // pnlReceipt
            // 
            pnlReceipt.BackColor = Color.White;
            pnlReceipt.BorderStyle = BorderStyle.FixedSingle;
            pnlReceipt.Controls.Add(btnConfirm);
            pnlReceipt.Controls.Add(lblThanks);
            pnlReceipt.Controls.Add(lblTotalPrice);
            pnlReceipt.Controls.Add(lblTotalTitle);
            pnlReceipt.Controls.Add(lblLine3);
            pnlReceipt.Controls.Add(flpOrderItems);
            pnlReceipt.Controls.Add(lblLine2);
            pnlReceipt.Controls.Add(lblPaymentTime);
            pnlReceipt.Controls.Add(lblPaymentMethod);
            pnlReceipt.Controls.Add(lblOrderType);
            pnlReceipt.Controls.Add(lblOrderNumber);
            pnlReceipt.Controls.Add(lblLine1);
            pnlReceipt.Controls.Add(lblCafeName);
            pnlReceipt.Location = new Point(55, 25);
            pnlReceipt.Name = "pnlReceipt";
            pnlReceipt.Size = new Size(390, 630);
            pnlReceipt.TabIndex = 0;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(93, 64, 55);
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(105, 570);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(180, 40);
            btnConfirm.TabIndex = 10;
            btnConfirm.Text = "확인";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // lblThanks
            // 
            lblThanks.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblThanks.Location = new Point(30, 505);
            lblThanks.Name = "lblThanks";
            lblThanks.Size = new Size(330, 50);
            lblThanks.TabIndex = 9;
            lblThanks.Text = "이용해주셔서 감사합니다";
            lblThanks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalPrice.ForeColor = Color.FromArgb(93, 64, 55);
            lblTotalPrice.Location = new Point(180, 440);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(180, 45);
            lblTotalPrice.TabIndex = 8;
            lblTotalPrice.Text = "0원";
            lblTotalPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalTitle.Location = new Point(30, 450);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(120, 30);
            lblTotalTitle.TabIndex = 7;
            lblTotalTitle.Text = "총 결제금액";
            // 
            // lblLine3
            // 
            lblLine3.Location = new Point(20, 415);
            lblLine3.Name = "lblLine3";
            lblLine3.Size = new Size(350, 20);
            lblLine3.TabIndex = 6;
            lblLine3.Text = "─────────────────────────";
            lblLine3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpOrderItems
            // 
            flpOrderItems.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpOrderItems.FlowDirection = FlowDirection.TopDown;
            flpOrderItems.Location = new Point(25, 245);
            flpOrderItems.Name = "flpOrderItems";
            flpOrderItems.Size = new Size(340, 160);
            flpOrderItems.TabIndex = 5;
            flpOrderItems.WrapContents = false;
            // 
            // lblLine2
            // 
            lblLine2.Location = new Point(20, 215);
            lblLine2.Name = "lblLine2";
            lblLine2.Size = new Size(350, 20);
            lblLine2.TabIndex = 4;
            lblLine2.Text = "─────────────────────────";
            lblLine2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPaymentTime
            // 
            lblPaymentTime.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaymentTime.Location = new Point(30, 185);
            lblPaymentTime.Name = "lblPaymentTime";
            lblPaymentTime.Size = new Size(330, 25);
            lblPaymentTime.TabIndex = 3;
            lblPaymentTime.Text = "결제시간 : 2026-08-04 17:30";
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPaymentMethod.Location = new Point(30, 155);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(330, 25);
            lblPaymentMethod.TabIndex = 3;
            lblPaymentMethod.Text = "결제수단 : 카카오페이";
            // 
            // lblOrderType
            // 
            lblOrderType.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrderType.Location = new Point(30, 125);
            lblOrderType.Name = "lblOrderType";
            lblOrderType.Size = new Size(330, 25);
            lblOrderType.TabIndex = 3;
            lblOrderType.Text = "주문방식 : 매장";
            // 
            // lblOrderNumber
            // 
            lblOrderNumber.Font = new Font("맑은 고딕", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrderNumber.Location = new Point(30, 95);
            lblOrderNumber.Name = "lblOrderNumber";
            lblOrderNumber.Size = new Size(330, 25);
            lblOrderNumber.TabIndex = 2;
            lblOrderNumber.Text = "주문번호 : 1001";
            // 
            // lblLine1
            // 
            lblLine1.Location = new Point(20, 65);
            lblLine1.Name = "lblLine1";
            lblLine1.Size = new Size(350, 20);
            lblLine1.TabIndex = 1;
            lblLine1.Text = "─────────────────────────";
            lblLine1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCafeName
            // 
            lblCafeName.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblCafeName.Location = new Point(20, 20);
            lblCafeName.Name = "lblCafeName";
            lblCafeName.Size = new Size(350, 40);
            lblCafeName.TabIndex = 0;
            lblCafeName.Text = "CAFE KIOSK";
            lblCafeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 244, 239);
            ClientSize = new Size(484, 661);
            Controls.Add(pnlReceipt);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form7";
            StartPosition = FormStartPosition.CenterParent;
            Text = "영수증";
            pnlReceipt.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlReceipt;
        private Label lblLine2;
        private Label lblPaymentTime;
        private Label lblPaymentMethod;
        private Label lblOrderType;
        private Label lblOrderNumber;
        private Label lblLine1;
        private Label lblCafeName;
        private Label lblTotalPrice;
        private Label lblTotalTitle;
        private Label lblLine3;
        private FlowLayoutPanel flpOrderItems;
        private Button btnConfirm;
        private Label lblThanks;
    }
}