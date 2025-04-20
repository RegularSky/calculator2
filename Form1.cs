using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //全域變數
        float firstNumber, secondNumber; // firstNumber 儲存第一個數字，secondNumber 儲存第二個數字
        int operators = -1; // 記錄選擇哪一種運算符號？0:加、1:減、2:乘、3:除、-1:重新設定

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = ""; // 如果你的判斷式簡單到只有一行程式，可以把 { } 大刮號省略掉
            txtNumber.Text += "1";
            // 這種寫法和這段「txtNumber.Text = txtNumber.Text + "1";」是一樣的
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = ""; // 如果你的判斷式簡單到只有一行程式，可以把 { } 大刮號省略掉
            txtNumber.Text += "2";
            // 這種寫法和這段「txtNumber.Text = txtNumber.Text + "2";」是一樣的
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = ""; // 如果你的判斷式簡單到只有一行程式，可以把 { } 大刮號省略掉
            txtNumber.Text += "3";
            // 這種寫法和這段「txtNumber.Text = txtNumber.Text + "3";」是一樣的
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = ""; // 如果你的判斷式簡單到只有一行程式，可以把 { } 大刮號省略掉
            txtNumber.Text += "4";
            // 這種寫法和這段「txtNumber.Text = txtNumber.Text + "4";」是一樣的
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = ""; // 如果你的判斷式簡單到只有一行程式，可以把 { } 大刮號省略掉
            txtNumber.Text += "5";
            // 這種寫法和這段「txtNumber.Text = txtNumber.Text + "5";」是一樣的
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = ""; // 如果你的判斷式簡單到只有一行程式，可以把 { } 大刮號省略掉
            txtNumber.Text += "6";
            // 這種寫法和這段「txtNumber.Text = txtNumber.Text + "6";」是一樣的
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = ""; // 如果你的判斷式簡單到只有一行程式，可以把 { } 大刮號省略掉
            txtNumber.Text += "7";
            // 這種寫法和這段「txtNumber.Text = txtNumber.Text + "7";」是一樣的
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = ""; // 如果你的判斷式簡單到只有一行程式，可以把 { } 大刮號省略掉
            txtNumber.Text += "8";
            // 這種寫法和這段「txtNumber.Text = txtNumber.Text + "8";」是一樣的
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = ""; // 如果你的判斷式簡單到只有一行程式，可以把 { } 大刮號省略掉
            txtNumber.Text += "9";
            // 這種寫法和這段「txtNumber.Text = txtNumber.Text + "9";」是一樣的
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text); //將輸入文字框轉換成浮點數，存入第一個數字的全域變數
            txtNumber.Text = ""; //重新將輸入文字框重新設定為0
            operators = 0; //選擇「加」號
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text);
            txtNumber.Text = "";
            operators = 1; //選擇「減」號
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text);
            txtNumber.Text = "";
            operators = 2; //選擇「乘」號
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToSingle(txtNumber.Text);
            txtNumber.Text = "";
            operators = 3; //選擇「除」號
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            float finalResults = 0f; //宣告最後計算結果變數
            secondNumber = Convert.ToSingle(txtNumber.Text); //將輸入文字框轉換成浮點數，存入第二個數字的全域變數

            //依照四則運算符號的選擇，進行加減乘除
            switch (operators)
            {
                case 0:
                    finalResults = firstNumber + secondNumber;
                    break;
                case 1:
                    finalResults = firstNumber - secondNumber;
                    break;
                case 2:
                    finalResults = firstNumber * secondNumber;
                    break;
                case 3:
                    finalResults = firstNumber / secondNumber;
                    break;
            }

            txtNumber.Text = string.Format("{0:0.##########}", finalResults); //在輸入文字框中，顯示最後計算結果，並且轉換成格式化的字串內容

            //重置所有全域變數
            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.IndexOf(".") == -1)
                txtNumber.Text = txtNumber.Text + ".";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "0";
            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length > 0)
            {
                txtNumber.Text = txtNumber.Text.Substring(0, txtNumber.Text.Length - 1);
                if (txtNumber.Text == "") // 如果全部刪光就回到 0
                    txtNumber.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float currentNumber = Convert.ToSingle(txtNumber.Text);
            currentNumber = currentNumber / 100f;
            txtNumber.Text = currentNumber.ToString();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = ""; // 如果你的判斷式簡單到只有一行程式，可以把 { } 大刮號省略掉
            txtNumber.Text += "0";
            // 這種寫法和這段「txtNumber.Text = txtNumber.Text + "1";」是一樣的
        }
    }

}
