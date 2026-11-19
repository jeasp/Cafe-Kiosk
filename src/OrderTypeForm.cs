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
    public partial class OrderTypeForm : Form
    {
        public OrderTypeForm()
        {
            InitializeComponent();

        }

        // 매장 주문 선택
        private void button1_Click(object sender, EventArgs e)
        {
            // 현재 화면 숨기기
            this.Hide();

            // 메뉴 화면(MenuForm) 실행
            MenuForm form1 = new MenuForm("매장");
            form1.ShowDialog();

            // MenuForm 종료 후 다시 시작 화면 표시
            this.Show();
        }

        // 포장 주문 선택
        private void button2_Click(object sender, EventArgs e)
        {
            // 현재 화면 숨기기
            this.Hide();

            // 메뉴 화면(MenuForm) 실행
            MenuForm form1 = new MenuForm("포장");
            form1.ShowDialog();

            // MenuForm 종료 후 다시 시작 화면 표시
            this.Show();
        }

        // 현재 시간을 1초마다 갱신
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("yyyy년 MM월 dd일\ntt h:mm:ss");
        }

        // 프로그램 시작 시 현재 시간 표시 및 Timer 시작
        private void Form6_Load(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("yyyy년 MM월 dd일\ntt h:mm:ss");
            timer1.Start();

        }
    }
}
