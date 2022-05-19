using System.Globalization;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xa, xb, xc, ya, yb, yc;

            xa = double.Parse(xA.Text);
            xb = double.Parse(xB.Text);
            xc = double.Parse(xC.Text);
            ya = double.Parse(textBox6.Text);
            yb = double.Parse(textBox5.Text);
            yc = double.Parse(textBox4.Text);

            double p = (xa + xb + xc) / 2.0;
            double areaX = Math.Sqrt(p * (p - xa) * (p - xb) * (p - xc));

            p = (ya + yb + yc) / 2.0;
            double areaY = Math.Sqrt(p * (p - ya) * (p - yb) * (p - yc));
            textBox7.Text = ("area de X = " + areaX.ToString("f4", CultureInfo.InvariantCulture));
            textBox8.Text = ("area de Y = " + areaY.ToString("f4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                textBox9.Text = ("Maior area x");
            }
            else
            {
                textBox9.Text = ("Maior area:Y");
            }
        }
    }
}