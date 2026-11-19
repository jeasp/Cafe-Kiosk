using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{

    public partial class PaymentProgressForm : Form
    {
        // 선택한 결제수단 저장
        private string paymentMethod;

        public PaymentProgressForm()
        {
            InitializeComponent();
        }

        // 결제수단을 받아 결제 진행 화면 초기화
        public PaymentProgressForm(string paymentMethod)
        {
            InitializeComponent();

            this.paymentMethod = paymentMethod;

            // 선택한 결제수단 표시
            lblMessage.Text = paymentMethod;

            // ProgressBar 초기 설정
            prgPayment.Minimum = 0;
            prgPayment.Maximum = 100;
            prgPayment.Value = 0;

            // Timer 실행 간격(0.1초)
            tmrPayment.Interval = 100;


        }

        // Timer가 실행될 때마다 ProgressBar 증가
        private void tmrPayment_Tick(object sender, EventArgs e)
        {
            if (prgPayment.Value < 100)
            {
                // 진행률 5%씩 증가
                prgPayment.Value += 5;
            }
            else
            {
                // 진행 완료 시 Timer 종료
                tmrPayment.Stop();

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        // Form이 화면에 나타나면 Timer 시작
        private void Form5_Shown(object sender, EventArgs e)
        {
            tmrPayment.Start();
        }
    }
}
