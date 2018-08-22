using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home18
{




    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
            Console.WriteLine("這個會在輸出視窗");
        }
        private BraveActionClass BraveActionList = new BraveActionClass();
        string StartMessage = "歡迎光臨18";

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"{StartMessage}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BraveActionList.Back();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BraveActionList.LotteryMember();
        }
    }
    public class BraveActionClass
    {
        public void Back()
        {
            MessageBox.Show("正在前往18....");
        }

        public void LotteryMember()
        {
            string member = "";

            //實體化Random物件
            Random random = new Random();
            int returnInt = random.Next(1, 5);

            switch (returnInt)
            {
                case 1:
                    member = "SuQ";
                    break;
                case 2:
                    member = "GMeow";
                    break;
                case 3:
                    member = "臭到爆";
                    break;
                case 4:
                    member = "舉呱";
                    break;
                case 5:
                    member = "肥Q";
                    break;
            }

            MessageBox.Show(member, "今天掃地的人是");
        }
    }
}
