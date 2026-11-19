namespace Kiosk
{
    partial class PaymentProgressForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            prgPayment = new ProgressBar();
            label2 = new Label();
            tmrPayment = new System.Windows.Forms.Timer(components);
            lblMessage = new Label();
            panel1 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 12);
            label1.Name = "label1";
            label1.Size = new Size(400, 40);
            label1.TabIndex = 0;
            label1.Text = "결제를 진행하고 있습니다";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // prgPayment
            // 
            prgPayment.Location = new Point(55, 160);
            prgPayment.Name = "prgPayment";
            prgPayment.Size = new Size(290, 24);
            prgPayment.Style = ProgressBarStyle.Continuous;
            prgPayment.TabIndex = 1;
            // 
            // label2
            // 
            label2.ForeColor = Color.FromArgb(80, 80, 80);
            label2.Location = new Point(50, 120);
            label2.Name = "label2";
            label2.Size = new Size(300, 25);
            label2.TabIndex = 2;
            label2.Text = "결제를 처리하고 있습니다";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tmrPayment
            // 
            tmrPayment.Tick += tmrPayment_Tick;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessage.ForeColor = Color.FromArgb(93, 64, 55);
            lblMessage.Location = new Point(50, 85);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(300, 35);
            lblMessage.TabIndex = 3;
            lblMessage.Text = "결제수단";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(93, 64, 55);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 65);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(50, 200);
            label3.Name = "label3";
            label3.Size = new Size(300, 30);
            label3.TabIndex = 5;
            label3.Text = "잠시만 기다려주세요";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 244, 239);
            ClientSize = new Size(384, 241);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(lblMessage);
            Controls.Add(label2);
            Controls.Add(prgPayment);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterParent;
            Text = "결제 진행";
            Shown += Form5_Shown;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ProgressBar prgPayment;
        private Label label2;
        private System.Windows.Forms.Timer tmrPayment;
        private Label lblMessage;
        private Panel panel1;
        private Label label3;
    }
}