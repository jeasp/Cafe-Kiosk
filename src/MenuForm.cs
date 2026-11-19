namespace Kiosk
{
    public partial class MenuForm : Form
    {

        private string orderType;
        private static int orderNumber = 1000;

        public MenuForm()
        {
            InitializeComponent();
        }

        public MenuForm(string orderType)
        {
            InitializeComponent();
            this.orderType = orderType;

        }



        private void btnAmericano_Click(object sender, EventArgs e)
        {
            DrinkOptionForm optionform = new DrinkOptionForm("아메리카노", 3000);
            if (optionform.ShowDialog() == DialogResult.OK)
            {
                AddOrUpdateCartItem(optionform.SelectedMenu, optionform.SelectedOption, optionform.SelectedQuantity,
                    optionform.SelectedTotalPrice);
            }


        }

        private void btnCafeLatte_Click(object sender, EventArgs e)
        {
            DrinkOptionForm optionform = new DrinkOptionForm("카페라떼", 3500);
            if (optionform.ShowDialog() == DialogResult.OK)
            {
                AddOrUpdateCartItem(optionform.SelectedMenu, optionform.SelectedOption, optionform.SelectedQuantity,
                    optionform.SelectedTotalPrice);
            }
        }

        private void btnCaramelMacchiato_Click(object sender, EventArgs e)
        {
            DrinkOptionForm optionform = new DrinkOptionForm("카라멜 마끼야또", 4500);
            if (optionform.ShowDialog() == DialogResult.OK)
            {
                AddOrUpdateCartItem(optionform.SelectedMenu, optionform.SelectedOption, optionform.SelectedQuantity,
                    optionform.SelectedTotalPrice);
            }
        }

        private void btnCafeMocha_Click(object sender, EventArgs e)
        {
            DrinkOptionForm optionform = new DrinkOptionForm("카페모카", 4500);
            if (optionform.ShowDialog() == DialogResult.OK)
            {
                AddOrUpdateCartItem(optionform.SelectedMenu, optionform.SelectedOption, optionform.SelectedQuantity,
                    optionform.SelectedTotalPrice);
            }
        }

        private void btnLemonAde_Click(object sender, EventArgs e)
        {
            DrinkOptionForm optionform = new DrinkOptionForm("레몬에이드", 4500);
            if (optionform.ShowDialog() == DialogResult.OK)
            {
                AddOrUpdateCartItem(optionform.SelectedMenu, optionform.SelectedOption, optionform.SelectedQuantity,
                    optionform.SelectedTotalPrice);
            }
        }

        private void btnGrapefruitAde_Click(object sender, EventArgs e)
        {
            DrinkOptionForm optionform = new DrinkOptionForm("자몽에이드", 4500);
            if (optionform.ShowDialog() == DialogResult.OK)
            {
                AddOrUpdateCartItem(optionform.SelectedMenu, optionform.SelectedOption, optionform.SelectedQuantity,
                    optionform.SelectedTotalPrice);
            }
        }

        private void btnGreenGrapeAde_Click(object sender, EventArgs e)
        {
            DrinkOptionForm optionform = new DrinkOptionForm("청포도에이드", 4500);
            if (optionform.ShowDialog() == DialogResult.OK)
            {
                AddOrUpdateCartItem(optionform.SelectedMenu, optionform.SelectedOption, optionform.SelectedQuantity,
                    optionform.SelectedTotalPrice);
            }
        }

        private void btnCheeseCake_Click(object sender, EventArgs e)
        {
            DessertOptionForm optionform = new DessertOptionForm("치즈케이크", 5500);

            if (optionform.ShowDialog() == DialogResult.OK)
            {
                AddOrUpdateCartItem(optionform.SelectedMenu, optionform.SelectedOption, optionform.SelectedQuantity,
                    optionform.SelectedTotalPrice);
            }

        }

        private void btnCroissant_Click(object sender, EventArgs e)
        {
            DessertOptionForm optionform = new DessertOptionForm("크로와상", 3500);

            if (optionform.ShowDialog() == DialogResult.OK)
            {
                AddOrUpdateCartItem(optionform.SelectedMenu, optionform.SelectedOption, optionform.SelectedQuantity,
                     optionform.SelectedTotalPrice);
            }
        }

        private void btnChocoCookie_Click(object sender, EventArgs e)
        {
            DessertOptionForm optionform = new DessertOptionForm("초코쿠키", 2500);

            if (optionform.ShowDialog() == DialogResult.OK)
            {
                AddOrUpdateCartItem(optionform.SelectedMenu, optionform.SelectedOption, optionform.SelectedQuantity,
                     optionform.SelectedTotalPrice);
            }
        }


        // 장바구니에 있는 모든 메뉴의 금액을 합산하여 총 결제금액 표시
        private void CalculateCartTotal()
        {
            int total = 0;

            foreach (ListViewItem item in IvCart.Items)
            {
                total += int.Parse(item.SubItems[3].Text);
            }

            lblTotalPrice.Text = total.ToString("N0") + "원";
        }


        // 선택한 메뉴를 장바구니에서 삭제
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 선택된 메뉴가 없는 경우
            if (IvCart.SelectedItems.Count == 0)
            {
                MessageBox.Show("삭제할 메뉴를 선택해주세요.");
                return;
            }

            IvCart.Items.RemoveAt(IvCart.FocusedItem.Index);
            // 삭제 후 총 금액 다시 계산
            CalculateCartTotal();
        }

        // 장바구니 전체 비우기
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (IvCart.Items.Count == 0)
            {
                MessageBox.Show("장바구니가 비어있습니다.");
                return;
            }

            DialogResult result = MessageBox.Show("장바구니를 모두 비우시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                IvCart.Items.Clear();
                // 총 금액 초기화
                CalculateCartTotal();
            }


        }

        // 결제 진행
        private void btnPayment_Click(object sender, EventArgs e)
        {
            // 장바구니가 비어있으면 결제 불가
            if (IvCart.Items.Count == 0)
            {
                MessageBox.Show("장바구니가 비어 있습니다.");
                return;
            }

            // 총 결제금액 계산
            int totalPrice = GetCartTotal();

            PaymentForm paymentForm = new PaymentForm(totalPrice);

            // 결제가 완료되면 영수증 출력
            if (paymentForm.ShowDialog() == DialogResult.OK)
            {
                orderNumber++;

                string paymentMethod = paymentForm.SelectedPaymentMethod;

                ReceiptForm receiptForm = new ReceiptForm(orderNumber, orderType, paymentMethod, totalPrice, IvCart);
                {
                    receiptForm.ShowDialog();
                }

                // 결제 완료 후 장바구니 초기화
                IvCart.Items.Clear();
                CalculateCartTotal();

                this.Close();
            }
        }

        // 장바구니 총 금액 반환
        private int GetCartTotal()
        {
            int total = 0;
            foreach (ListViewItem item in IvCart.Items)
            {
                total += int.Parse(item.SubItems[3].Text);
            }
            return total;
        }

        // 시작 화면(OrderType)으로 돌아가기
        private void btnBack_Click(object sender, EventArgs e)
        {
            // 장바구니에 메뉴가 있는 경우 확인 메시지 출력
            if (IvCart.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show("이전 화면으로 돌아가면 장바구니 내용이 사라집니다. \n돌아가시겠습니까?", "이전 화면", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;
            }
            Close();
        }

        // 같은 메뉴와 옵션이면 수량을 증가시키고,
        // 없으면 새로운 항목을 장바구니에 추가
        private void AddOrUpdateCartItem(string menu, string option, int quantity, int totalPrice)
        {
            foreach(ListViewItem item in IvCart.Items)
            {
                string existingMenu = item.SubItems[0].Text;
                string existingOption = item.SubItems[1].Text;

                // 메뉴명과 옵션이 모두 같은 경우
                if (existingMenu == menu &&  existingOption == option)
                {
                    int existingQuantity = int.Parse(item.SubItems[2].Text);
                    int existingPrice = int.Parse(item.SubItems[3].Text);

                    // 수량 증가
                    item.SubItems[2].Text = (existingQuantity + quantity).ToString();

                    // 금액 증가
                    item.SubItems[3].Text = (existingPrice + totalPrice).ToString();

                    CalculateCartTotal();
                    return;
                }
            }

            // 같은 메뉴가 없으면 새 항목 추가
            ListViewItem newItem = new ListViewItem(menu);
            newItem.SubItems.Add(option);
            newItem.SubItems.Add(quantity.ToString());
            newItem.SubItems.Add(totalPrice.ToString());

            IvCart.Items.Add(newItem);

            CalculateCartTotal() ;
        }
    }
}
