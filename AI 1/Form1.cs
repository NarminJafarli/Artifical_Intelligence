using System.Linq.Expressions;

namespace AI_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        int san = 0;
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            var text = textBox3.Text;
             
            switch (text)
            {
                case "Adiniz?":
                    label2.Text = "Shofia";
                 break;

                case "Vezifeniz?":
                    label2.Text = "IT Developer";
                    break;

                case "cal":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    comboBox1.Visible = true;

                    decimal num1=Convert.ToDecimal(textBox1.Text);
                    decimal num2=Convert.ToDecimal(textBox2.Text);
                    decimal c = 0;
                    
                    if (comboBox1.Text == "+") 
                    {
                        c = num1 + num2;
                        label2.Text=c.ToString();   
                    }
                    else if (comboBox1.Text == "-")
                    {
                        c= num1 - num2;
                        label2.Text=c.ToString();
                    }
                    else if (comboBox1.Text == "/")
                    {
                        c= num1/num2;
                        label2.Text=c.ToString();
                    }
                    else if (comboBox1.Text == "*")
                    {
                      c= num1*num2;
                      label2.Text=c.ToString();
                    }
                    else
                    {
                        label2.Text = "simvol sec";
                    }
                    break;

                case "":
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    comboBox1.Visible = true;
                    label2.Text = "------";
                    break;

                default:
                     label2.Text = "--------"; 
                    break;
                    
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            san++;
            label1.Text = san.ToString();

            if (san > 1)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                
            }
            if (san > 5)
            {
                panel1.Visible = true;
                panel2.Visible = true;
            }
            if (san > 10)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                pictureBox3.Visible = true;
            }
        }
    }
}
