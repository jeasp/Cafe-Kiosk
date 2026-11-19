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
    public partial class ReceiptForm : Form
    {

        public ReceiptForm()
        {
            InitializeComponent();
        }

        // 주문 정보와 장바구니 내용을 받아 영수증 생성
        public ReceiptForm(int orderNumber, string orderType, string paymentMethod, int totalPrice, ListView cartListView)
        {
            InitializeComponent();

            // 주문 기본 정보 표시
            lblOrderNumber.Text = $"주문번호 : {orderNumber}";
            lblOrderType.Text = $"주문방식 : {orderType}";
            lblPaymentMethod.Text = $"결제수단 : {paymentMethod}";
            lblPaymentTime.Text = $"결제시간 : {DateTime.Now:yyyy-MM-dd HH:mm}";
            lblTotalPrice.Text = $"{totalPrice:N0}원";

            // 장바구니 내용을 영수증에 출력
            CreateReceiptItems(cartListView);

            // 주문 개수에 맞게 영수증 크기 조절
            ResizeReceipt();
        }

        // 장바구니의 주문내역을 영수증에 동적으로 생성
        private void CreateReceiptItems(ListView cartListView)
        {
            // 기존 주문내역 제거
            flpOrderItems.Controls.Clear();

            foreach (ListViewItem cartItem in cartListView.Items)
            {
                // 장바구니에서 주문 정보 가져오기
                string menu = cartItem.SubItems[0].Text;
                string option = cartItem.SubItems[1].Text;
                string quantity = cartItem.SubItems[2].Text;
                string price = cartItem.SubItems[3].Text;

                // 메뉴 한 개를 표시할 Panel 생성
                Panel itemPanel = new Panel();

                itemPanel.Width = 320;
                itemPanel.Height = option == "-" ? 38 : 60;
                itemPanel.BackColor = Color.White;
                itemPanel.Margin = new Padding(0, 0, 0, 5);

                // 메뉴명 표시
                Label lblMenu = new Label();

                lblMenu.Text = menu;
                lblMenu.Location = new Point(5, 5);
                lblMenu.Size = new Size(145, 25);
                lblMenu.Font =
                    new Font("맑은 고딕", 9, FontStyle.Regular);

                // 수량 표시
                Label lblQuantity = new Label();

                lblQuantity.Text = $"x{quantity}";
                lblQuantity.Location = new Point(155, 5);
                lblQuantity.Size = new Size(45, 25);
                lblQuantity.TextAlign =
                    ContentAlignment.MiddleCenter;
                lblQuantity.Font =
                    new Font("맑은 고딕", 9);

                Label lblPrice = new Label();

                // 금액 표시
                int itemPrice = int.Parse(price);

                lblPrice.Text = $"{itemPrice:N0}원";
                lblPrice.Location = new Point(205, 5);
                lblPrice.Size = new Size(105, 25);
                lblPrice.TextAlign =
                    ContentAlignment.MiddleRight;
                lblPrice.Font =
                    new Font(
                        "맑은 고딕",
                        9,
                        FontStyle.Bold
                    );

                itemPanel.Controls.Add(lblMenu);
                itemPanel.Controls.Add(lblQuantity);
                itemPanel.Controls.Add(lblPrice);

                // 음료인 경우 옵션 정보 표시
                if (option != "-")
                {
                    Label lblOption = new Label();

                    lblOption.Text = option;
                    lblOption.Location = new Point(15, 30);
                    lblOption.Size = new Size(290, 22);
                    lblOption.ForeColor = Color.Gray;
                    lblOption.Font =
                        new Font("맑은 고딕", 8);

                    itemPanel.Controls.Add(lblOption);
                }

                // 생성한 주문내역을 FlowLayoutPanel에 추가
                flpOrderItems.Controls.Add(itemPanel);
            }
        }

        // 주문 개수에 따라 영수증 크기 자동 조절
        private void ResizeReceipt()
        {
            // 디자이너에서 설정한 주문내역 영역의 기본 높이
            int defaultOrderAreaHeight = 160;

            // FlowLayoutPanel 내부 컨트롤 배치 계산
            flpOrderItems.PerformLayout();

            // 실제 메뉴들이 필요한 전체 높이
            int requiredHeight = 0;

            foreach (Control control in flpOrderItems.Controls)
            {
                requiredHeight +=
                    control.Height +
                    control.Margin.Top +
                    control.Margin.Bottom;
            }

            // 최소 높이 유지
            if (requiredHeight < defaultOrderAreaHeight)
            {
                requiredHeight = defaultOrderAreaHeight;
            }

            // 최대 높이를 넘으면 스크롤 표시
            int maximumOrderAreaHeight = 420;

            if (requiredHeight > maximumOrderAreaHeight)
            {
                requiredHeight = maximumOrderAreaHeight;
                flpOrderItems.AutoScroll = true;
            }
            else
            {
                flpOrderItems.AutoScroll = false;
            }

            // 추가로 필요한 높이 계산
            int extraHeight =
                requiredHeight - defaultOrderAreaHeight;

            // 주문내역 영역 크기 변경
            flpOrderItems.Height = requiredHeight;

            if (extraHeight <= 0)
            {
                return;
            }

            // 아래 컨트롤들을 함께 이동
            lblLine3.Top += extraHeight;
            lblTotalTitle.Top += extraHeight;
            lblTotalPrice.Top += extraHeight;
            lblThanks.Top += extraHeight;
            btnConfirm.Top += extraHeight;

            // 영수증 Panel과 Form 크기 조절
            pnlReceipt.Height += extraHeight;

            ClientSize = new Size(
                ClientSize.Width,
                ClientSize.Height + extraHeight
            );

            // 화면 중앙으로 이동
            CenterToParent();
        }

        // 영수증 확인 후 시작 화면으로 돌아감
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
