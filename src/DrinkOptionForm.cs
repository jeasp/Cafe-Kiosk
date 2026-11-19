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
    public partial class DrinkOptionForm : Form
    {
        // 메뉴명과 기본 가격 저장
        private string menuName;
        private int basePrice;

        // MenuForm으로 전달할 선택 정보
        public string SelectedMenu { get; private set; }
        public string SelectedOption { get; private set; }
        public int SelectedQuantity { get; private set; }
        public int SelectedTotalPrice { get; private set; }

        public DrinkOptionForm()
        {
            InitializeComponent();
        }

        // 메뉴명과 기본 가격을 받아 옵션창 초기화
        public DrinkOptionForm(string menuName, int basePrice)
        {
            InitializeComponent();

            this.menuName = menuName;
            this.basePrice = basePrice;

            lblMenuName.Text = menuName;
            lblBasePrice.Text = basePrice.ToString("N0") + "원";

            // 기본 옵션 설정
            radioSmall.Checked = true;
            radioNoShot.Checked = true;

            // 수량 설정
            nudQuantity.Minimum = 1;
            nudQuantity.Maximum = 10;
            nudQuantity.Value = 1;

            // 예상 금액 계산
            UpdateExpectedPrice();
        }

        // 선택한 옵션에 따라 총 금액 계산
        private int CalculateTotalPrice()
        {
            int price = basePrice;

            // 사이즈 추가 금액
            if (radioMedium.Checked)
                price += 500;
            else if (radioLarge.Checked)
                price += 1000;

            // 샷 추가 금액
            if (radioShot1.Checked)
                price += 500;
            else if (radioShot2.Checked)
                price += 1000;

            int quantity = (int)nudQuantity.Value;

            // 최종 금액 반환
            return price * quantity;

        }

        // 예상 금액 표시
        private void UpdateExpectedPrice()
        {
            int totalPrice = CalculateTotalPrice();

            lblExpectedPrice.Text = totalPrice.ToString("N0") + "원";

        }

        // 사이즈 변경 시 예상 금액 갱신
        private void radioSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateExpectedPrice();
        }

        private void radioMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateExpectedPrice();
        }

        private void radioLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateExpectedPrice();
        }

        // 샷 옵션 변경 시 예상 금액 갱신
        private void radioNoShot_CheckedChanged(object sender, EventArgs e)
        {
            UpdateExpectedPrice();
        }

        private void radioShot1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateExpectedPrice();
        }

        private void radioShot2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateExpectedPrice();
        }

        // 수량 변경 시 예상 금액 갱신
        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            UpdateExpectedPrice();
        }

        // 장바구니 담기
        private void btnAddCart_Click(object sender, EventArgs e)
        {
            string temperature;

            // 온도 선택 확인
            if (radioHot.Checked)
                temperature = "HOT";
            else if (radioICE.Checked)
                temperature = "ICE";
            else
            {
                MessageBox.Show("온도를 선택해주세요.");
                return;
            }

            string size;

            // 선택한 사이즈 저장
            if (radioLarge.Checked)
                size = "Large";
            else if (radioMedium.Checked)
                size = "Medium";
            else
                size = "Small";
           

            string shot;

            // 선택한 샷 옵션 저장
            if (radioShot2.Checked)
                shot = "2샷 추가";
            else if (radioShot1.Checked)
                shot = "1샷 추가";
            else
                shot = "샷 추가 없음";

            // 선택한 정보를 MenuForm으로 전달
            SelectedMenu = menuName;
            SelectedOption = $"{temperature} / {size} / {shot}";
            SelectedQuantity = (int)nudQuantity.Value;
            SelectedTotalPrice = CalculateTotalPrice();

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
