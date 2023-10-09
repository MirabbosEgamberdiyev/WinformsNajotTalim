using System.Data;

namespace _1_dars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (screen.Text.Length > 0 && !screen.Text.StartsWith("0"))
            {
                screen.Text += "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            screen.Text = screen.Text + button.Text;
        }

        //clear all
        private void button3_Click(object sender, EventArgs e)
        {
            screen.Clear();
        }


        //clear right to left
        private void left_Click(object sender, EventArgs e)
        {
            if (screen.Text.Length > 0)
            {
                screen.Text = screen.Text[0..^1];
            }
        }

        //plus-minus
        private void button24_Click(object sender, EventArgs e)
        {
            if (screen.Text.StartsWith("-"))
            {
                screen.Text = screen.Text.Substring(1);
            }
            else
            {
                screen.Text = "-" + screen.Text;
            }
        }

        //nuqta
        private void button22_Click(object sender, EventArgs e)
        {
            if (screen.Text.Length > 0 &&
                !screen.Text.Contains(".") &&
                char.IsDigit(screen.Text[^1]))
            {
                screen.Text += ".";
            }
        }

        //operation
        private void button17_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (screen.Text.Length > 0 &&
                char.IsDigit(screen.Text[^1]))
            {
                screen.Text += button.Text;
            }
            else if (!screen.Text.EndsWith("."))
            {
                screen.Text = screen.Text[0..^1] + button.Text;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            DataTable dt = new();
            var res = dt.Compute(screen.Text, null);
            screen.Text = res.ToString();
        }
    }
}