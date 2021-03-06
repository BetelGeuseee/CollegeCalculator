using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeCalculator
{
    public partial class Form1 : Form
    {
        
        private Button button;
        private Double finalValue;
        private String buttonName;
       
        public Form1()
        {
            InitializeComponent();
        }
        private void button_click(object sender,EventArgs e)
        {
            button = (Button)sender;
            if (button.Text == "Clear")
            {
                textBoxOne.Clear();
                roughLabel.Text=null;
                finalValue = 0;
            }
           else if (button.Text == ".")
            {
                textBoxOne.Text = textBoxOne.Text+".";
            }
            else
            {
                textBoxOne.Text = textBoxOne.Text + button.Text;
               
            }
        }
        private void arithmetic_sign(object sender,EventArgs e)
        {
            try
            {
                button = (Button)sender;
                buttonName = button.Text;

                finalValue =  Double.Parse(textBoxOne.Text);
                 roughLabel.Text = roughLabel.Text + +finalValue+buttonName;
              
                textBoxOne.Clear();
            }
            catch (Exception)
            {

                roughLabel.Text = " ";
                roughLabel.Text = "Syntax Error";
            }
            
        }
        private void trignometric_operation(object sender,EventArgs e)
        {
            try
            {
                button = (Button)sender;
                buttonName = button.Text;
                roughLabel.Text =  "" + buttonName + roughLabel.Text;
                textBoxOne.Clear();
            }
            catch (Exception)
            {
                roughLabel.Text = " ";
                roughLabel.Text = "Syntax Error";
            }
        }

        private void buttonEqualto_Click(object sender, EventArgs e) 
        {
            roughLabel.Text = " ";
            try
            {
                switch (buttonName)
                {
                    case "+":
                       // Console.WriteLine("asdhhakds");
                        textBoxOne.Text = (finalValue + Double.Parse(textBoxOne.Text)).ToString();
                       
                        break;
                    case "-":
                        textBoxOne.Text = (finalValue - Double.Parse(textBoxOne.Text)).ToString();

                        break;
                    case "/":
                       // Console.WriteLine("hello");
                        Double b = Convert.ToDouble(textBoxOne.Text);
                        textBoxOne.Text = ( finalValue / b).ToString();
                       
                        break;
                    case "X":
                        textBoxOne.Text=(finalValue * Double.Parse(textBoxOne.Text)).ToString();

                        break;
                    case "Sin":
                        double value = Convert.ToDouble(textBoxOne.Text);
                        textBoxOne.Text = Math.Sin((value * (Math.PI)) / 180).ToString();
                    
                        break;
                    case "Cos":
                        double value1 = Convert.ToDouble(textBoxOne.Text);
                        textBoxOne.Text = Math.Cos((value1 * (Math.PI)) / 180).ToString();
                        break;
                    case "Tan":
                        double value2 = Convert.ToDouble(textBoxOne.Text);
                        textBoxOne.Text = Math.Tan((value2 * (Math.PI)) / 180).ToString();
                        break;
                    default:
                        break;
                }
            }catch(Exception )
            {
                roughLabel.Text = " ";
                roughLabel.Text = "Syntax Error";
            }
        }

       
    }
}
