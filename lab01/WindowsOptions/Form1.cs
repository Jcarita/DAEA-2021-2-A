using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsOptions
{
    public partial class Form1 : Form
    {
        public static string ope = "";
        public static int num1 = 0;
        public static int num2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cbOptions.SelectedIndex.ToString()) 
            {
                case "0":
                    lblOperacion.Text = "SUMA";
                    ope = "suma";
                    txtNumber2.Visible = true;
                    break;
                case "1":
                    lblOperacion.Text = "RESTA";
                    ope = "resta";
                    txtNumber2.Visible = true;
                    break;
                case "2":
                    lblOperacion.Text = "MULTIPLICACION";
                    ope = "multi";
                    txtNumber2.Visible = true;
                    break;
                case "3":
                    lblOperacion.Text = "DIVISION";
                    ope = "divi";
                    txtNumber2.Visible = true;
                    break;
                case "4":
                    lblOperacion.Text = "FAHRENHEIT A CELSIUS";
                    txtNumber2.Visible = false;
                    ope = "fToC";
                    break;
                case "5":
                    lblOperacion.Text = "CELSIUS A FAHRENHEIT";
                    txtNumber2.Visible = false;
                    ope = "cToF";
                    break;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);
            switch (ope)
            {
                case "suma":
                    int resSuma = Suma(num1, num2);
                    lblResultado.Text = resSuma.ToString();
                    break;
                case "resta":
                    int resResta = Resta(num1, num2);
                    lblResultado.Text = resResta.ToString();
                    break;
                case "multi":
                    double resMulti = Multiplicacion(num1, num2);
                    lblResultado.Text = resMulti.ToString();
                    break;
                case "divi":
                    double resDivi = Division(num1, num2);
                    lblResultado.Text = resDivi.ToString();
                    break;
                case "fToC":
                    float resFtoC = convertFahrenheitToCelsius(num1);
                    lblResultado.Text = resFtoC.ToString();
                    break;
                case "cToF":
                    double resCtoF = convertCelsiusToFahrenheit(num1);
                    lblResultado.Text = resCtoF.ToString();
                    break;
            }
        }
        static int Suma(int a, int b)
        {
            return a + b;
        }

        static int Resta(int a, int b)
        {
            return a - b;
        }
        static double Multiplicacion(int a, int b)
        {
            return a * b;
        }
        static double Division(int a, int b)
        {
            return a / b;
        }
        static float convertFahrenheitToCelsius(int num)
        {
            return (5 * (num - 32)) / 9;
        }
        static double convertCelsiusToFahrenheit(int num)
        {
            return ((9 * num) / 5) + 32;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumber1.Text = "";
            txtNumber2.Text = "";
            lblResultado.Text = "";
            lblOperacion.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
