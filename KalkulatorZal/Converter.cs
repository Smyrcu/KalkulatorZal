using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KalkulatorZal.Kalkulator;

namespace KalkulatorZal
{
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
        }

        

        public void UpdateLabel(string str, string system)
        {
            switch (system)
            {
                case "DEC":
                    decLabel.Text = str;
                    hexLabel.Text = Convert.ToString(Convert.ToInt32(str, 10), 16);
                    binLabel.Text = Convert.ToString(Convert.ToInt32(str, 10), 2);
                    octLabel.Text = Convert.ToString(Convert.ToInt32(str, 10), 8);
                    break;
                case "HEX":
                    hexLabel.Text = str;
                    decLabel.Text = Convert.ToString(Convert.ToInt32(str, 16), 10);
                    binLabel.Text = Convert.ToString(Convert.ToInt32(str, 16), 2);
                    octLabel.Text = Convert.ToString(Convert.ToInt32(str, 16), 8);
                    break;
                case "BIN":
                    binLabel.Text = str;
                    decLabel.Text = Convert.ToString(Convert.ToInt32(str, 2), 10);
                    hexLabel.Text = Convert.ToString(Convert.ToInt32(str, 2), 16);
                    octLabel.Text = Convert.ToString(Convert.ToInt32(str, 2), 8);
                    break;
                case "OCT":
                    octLabel.Text = str;
                    decLabel.Text = Convert.ToString(Convert.ToInt32(str, 8), 10);
                    hexLabel.Text = Convert.ToString(Convert.ToInt32(str, 8), 16);
                    binLabel.Text = Convert.ToString(Convert.ToInt32(str, 8), 2);
                    break;

            }
           
        }

        private void Converter_FormClosing(object sender, FormClosingEventArgs e)
        {
            kalkulator.converterMenuItem.Checked = false;
        }

        public void CloseThis()
        {
            this.Close();
        }
    }
}
