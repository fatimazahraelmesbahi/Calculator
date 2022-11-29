using System;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		public Form1() => InitializeComponent();

		private string Action { get; set; } = "";

		private double FirstNumber { get; set; } = 0;

		private double SecondNumber { get; set; } = 0;

		private double Result { get; set; } = 0;

		private void button1_Click(object sender, EventArgs e) => AddTextToLabel(btn1);
		private void button2_Click(object sender, EventArgs e) => AddTextToLabel(btn2);
		private void button3_Click(object sender, EventArgs e) => AddTextToLabel(btn3);
		private void button4_Click(object sender, EventArgs e) => AddTextToLabel(btn4);
		private void button5_Click(object sender, EventArgs e) => AddTextToLabel(btn5);
		private void button6_Click(object sender, EventArgs e) => AddTextToLabel(btn6);
		private void button7_Click(object sender, EventArgs e) => AddTextToLabel(btn7);
		private void button8_Click(object sender, EventArgs e) => AddTextToLabel(btn8);
		private void button9_Click(object sender, EventArgs e) => AddTextToLabel(btn9);
		private void button10_Click(object sender, EventArgs e) => AddTextToLabel(btn0);
		private void button15_Click(object sender, EventArgs e) => AddTextToLabel(btn_point);

		private void AddTextToLabel(Button button) => label1.Text += button.Text;

		private void button11_Click(object sender, EventArgs e)
		{
			FirstNumber = Convert.ToDouble(label1.Text);
			label1.Text = "";
			Action = "+";
		}

		private void button12_Click(object sender, EventArgs e)
		{
			FirstNumber = Convert.ToDouble(label1.Text);
			label1.Text = "";
			Action = "-";
		}
        private void btn_fois_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(label1.Text);
            label1.Text = "";
            Action = "*";
        }
        private void btn_division_Click(object sender, EventArgs e)
        {

            FirstNumber = Convert.ToDouble(label1.Text);
            label1.Text = "";
            Action = "/";
        }
        private void button13_Click(object sender, EventArgs e)
		{
			SecondNumber = Convert.ToDouble(label1.Text);
			if (Action == "+")
			{
				Result = FirstNumber + SecondNumber;
				label1.Text = Result.ToString();
			}
			if (Action == "-")
			{
				Result = FirstNumber - SecondNumber;
				label1.Text = Result.ToString();
			}
            if (Action == "*")
            {
                Result = FirstNumber * SecondNumber;
                label1.Text = Result.ToString();
            }
            if (Action == "/")
            {
                Result = FirstNumber / SecondNumber;
                label1.Text = Result.ToString();
            }
        }

		private void button14_Click(object sender, EventArgs e)
		{
			label1.Text = "";
			FirstNumber = 0;
			SecondNumber = 0;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
