namespace Kiosk
{
    partial class OrderTypeForm
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
            button1 = new Button();
            button2 = new Button();
            lblClock = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(93, 64, 55);
            button1.Location = new Point(245, 310);
            button1.Name = "button1";
            button1.Size = new Size(230, 260);
            button1.TabIndex = 0;
            button1.TabStop = false;
            button1.Text = "매장";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(93, 64, 55);
            button2.Location = new Point(550, 310);
            button2.Name = "button2";
            button2.Size = new Size(230, 260);
            button2.TabIndex = 0;
            button2.TabStop = false;
            button2.Text = "포장";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblClock
            // 
            lblClock.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblClock.ForeColor = Color.FromArgb(93, 64, 55);
            lblClock.Location = new Point(312, 145);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(400, 70);
            lblClock.TabIndex = 1;
            lblClock.Text = "현재시간";
            lblClock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(93, 64, 55);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 100);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(0, 58);
            label3.Name = "label3";
            label3.Size = new Size(1024, 25);
            label3.TabIndex = 1;
            label3.Text = "주문 방식을 선택해주세요";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("맑은 고딕", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 18);
            label2.Name = "label2";
            label2.Size = new Size(1024, 40);
            label2.TabIndex = 0;
            label2.Text = "CAFE KIOSK";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 244, 239);
            ClientSize = new Size(1008, 729);
            Controls.Add(panel1);
            Controls.Add(lblClock);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CAFE KIOSK";
            Load += Form6_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label lblClock;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Label label3;
        private Label label2;
    }
}