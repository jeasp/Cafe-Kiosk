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
    public partial class PaymentForm : Form
    {
        // 선택한 결제수단 저장
        private string paymentMethod = "";

        // MenuForm에서 선택한 결제수단을 가져오기 위한 속성
        public string SelectedPaymentMethod
        {
            get
            {
                return paymentMethod;
            }
        }

        public PaymentForm()
        {
            InitializeComponent();
        }

        // 총 결제금액 표시
        public PaymentForm(int totalPrice)
        {
            InitializeComponent();
            lblTotalPrice.Text = totalPrice.ToString("N0") + "원";
        }

        // 결제 진행
        private void btnPay_Click(object sender, EventArgs e)
        {
            // 결제수단을 선택하지 않은 경우
            if (paymentMethod == "")
            {
                MessageBox.Show("결제방법을 선택해주세요.");
                return;
            }

            // 결제 여부 확인
            DialogResult result = MessageBox.Show(
                $"{paymentMethod}로 결제하시겠습니까?",
                "결제 확인",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
                return;

            // 결제 진행 화면(PaymentProgressForm) 실행
            using (PaymentProgressForm progressForm =
                   new PaymentProgressForm(paymentMethod))
            {
                if (progressForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(
                        $"{paymentMethod} 결제가 완료되었습니다.",
                        "결제 완료",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        // 신용카드 선택
        private void pnlCard_Click(object sender, EventArgs e)
        {
            SelectPayment(pnlCard, "신용카드");
        }

        // 네이버페이 선택
        private void pnlNaverPay_Click(object sender, EventArgs e)
        {
            SelectPayment(pnlNaverPay, "네이버페이");
        }

        // 카카오페이 선택
        private void pnlKakaoPay_Click(object sender, EventArgs e)
        {
            SelectPayment(pnlKakaoPay, "카카오페이");
        }

        // 삼성페이 선택
        private void pnlSamsungPay_Click(object sender, EventArgs e)
        {
            SelectPayment(pnlSamsungPay, "삼성페이");
        }

        // 선택한 결제수단 표시 및 패널 색상 변경
        private void SelectPayment(Panel selectedPanel, string method)
        {
            paymentMethod = method;

            // 모든 패널 색상 초기화
            pnlCard.BackColor = Color.White;
            pnlNaverPay.BackColor = Color.White;
            pnlKakaoPay.BackColor = Color.White;
            pnlSamsungPay.BackColor = Color.White;

            // 선택한 패널만 강조 표시
            selectedPanel.BackColor = Color.FromArgb(235, 221, 212);
        }

        // 결제 취소
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // 이미지나 라벨을 클릭해도 동일하게 결제수단 선택
        private void picCard_Click(object sender, EventArgs e)
        {
            SelectPayment(pnlCard, "신용카드");
        }

        private void lblCard_Click(object sender, EventArgs e)
        {
            SelectPayment(pnlCard, "신용카드");
        }

        private void picNaverPay_Click(object sender, EventArgs e)
        {
            SelectPayment(pnlNaverPay, "네이버페이");
        }

        private void lblNaverPay_Click(object sender, EventArgs e)
        {
            SelectPayment(pnlNaverPay, "네이버페이");
        }

        private void picKakaoPay_Click(object sender, EventArgs e)
        {
            SelectPayment(pnlKakaoPay, "카카오페이");
        }

        private void lblKakaoPay_Click(object sender, EventArgs e)
        {
            SelectPayment(pnlKakaoPay, "카카오페이");
        }

        private void picSamsungPay_Click(object sender, EventArgs e)
        {
            SelectPayment(pnlSamsungPay, "삼성페이");
        }

        private void lblSamsungPay_Click(object sender, EventArgs e)
        {
            SelectPayment(pnlSamsungPay, "삼성페이");
        }
    }
}
