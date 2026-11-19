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
    public partial class DessertOptionForm : Form
    {
        // 메뉴명과 기본 가격 저장
        private string menuName;
        private int basePrice;

        // MenuForm으로 전달할 선택 정보
        public string SelectedMenu { get; private set; }
        public string SelectedOption { get; private set; }
        public int SelectedQuantity { get; private set; }
        public int SelectedTotalPrice { get; private set; }

        public DessertOptionForm()
        {
            InitializeComponent();

        }

        // 메뉴명과 기본 가격을 받아 디저트 옵션창 초기화
        public DessertOptionForm(string menuName, int basePrice)
        {
            InitializeComponent();

            this.menuName = menuName;
            this.basePrice = basePrice;

            lblMenuName.Text = menuName;
            lblBasePrice.Text = basePrice.ToString("N0") + "원";

            // 수량 설정
            nudQuantity.Minimum = 1;
            nudQuantity.Maximum = 10;
            nudQuantity.Value = 1;

            // 예상 금액 계산
            UpdateExpectedPrice();
        }

        // 수량에 따른 예상 금액 계산
        private void UpdateExpectedPrice()
        {
            int quantity = (int)nudQuantity.Value;
            int totalPrice = basePrice * quantity;

            lblExpectedPrice.Text = totalPrice.ToString("N0") + "원";
        }

        // 수량 변경 시 예상 금액 갱신
        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            UpdateExpectedPrice();
        }

        // 장바구니 담기
        private void btnAddCart_Click(object sender, EventArgs e)
        {
            // 선택한 정보를 MenuForm으로 전달
            SelectedMenu = menuName;
            SelectedOption = "-";    // 디저트는 옵션이 없음
            SelectedQuantity = (int)nudQuantity.Value;
            SelectedTotalPrice = basePrice * SelectedQuantity;

            DialogResult = DialogResult.OK;
            Close();
        }

        // 옵션 선택 취소
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
