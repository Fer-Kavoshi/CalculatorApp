// Main Form

namespace WinFormCalv1
{
    public partial class Form1 : Form
    {
        Calculator cal = new();
        private void Operation(string operation)
        {
            cal.Operator(lblInput.Text, operation);
            lblHistory.Text = cal.history;
            lblResult.Text = cal.result;
            lblInput.Text = "0";
        }
        private void Input(string input)
        {
            if (lblInput.Text == "0")
            {
                lblInput.Text = input;
            }
            else
            {
                lblInput.Text += input;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            Input("1");
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            Input("2");
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            Input("3");
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            Input("4");
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            Input("5");
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            Input("6");
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            Input("7");
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            Input("8");
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            Input("9");
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            Input("0");
        }
        private void buttonPoint_Click(object sender, EventArgs e)
        {
            lblInput.Text += ".";
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            cal.Operator(lblInput.Text, "");
            cal.history = cal.result;
            lblHistory.Text = cal.result;
            lblResult.Text = cal.result;
            lblInput.Text = "0";
        }
        private void btnSum_Click(object sender, EventArgs e)
        {
            Operation("+");
        }
        private void btnSubstract_Click(object sender, EventArgs e)
        {
            Operation("-");
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Operation("*");
        }
        private void btnDevide_Click(object sender, EventArgs e)
        {
            Operation("/");
        }
        private void btnCe_Click(object sender, EventArgs e)
        {
            lblHistory.Text = null;
            lblInput.Text = "0";
            lblResult.Text = null;
            cal.CeButton();
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            lblInput.Text = "0";
        }
        private void btnPosNeg_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(lblInput.Text);
            input = (-1) * input;
            lblInput.Text = Convert.ToString(input);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            string input = lblInput.Text;
            int count = input.Length - 1;
            lblInput.Text = input.Remove(count);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                    {
                        Input("1");
                        break;
                    }
                case Keys.D2:
                    {
                        Input("2");
                        break;
                    }
                case Keys.D3:
                    {
                        Input("3");
                        break;
                    }
                case Keys.D4:
                    {
                        Input("4");
                        break;
                    }
                case Keys.D5:
                    {
                        Input("5");
                        break;
                    }
                case Keys.D6:
                    {
                        Input("6");
                        break;
                    }
                case Keys.D7:
                    {
                        Input("7");
                        break;
                    }
                case Keys.D8:
                    {
                        Input("8");
                        break;
                    }
                case Keys.D9:
                    {
                        Input("9");
                        break;
                    }
                case Keys.D0:
                    {
                        Input("0");
                        break;
                    }
                case Keys.OemPeriod:
                    {
                        Input(".");
                        break;
                    }
            }
        }

        private void btn1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
