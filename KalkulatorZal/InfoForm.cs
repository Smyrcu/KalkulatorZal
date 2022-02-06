using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorZal
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void InfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            textLabel.Text = "Program stworzony przez Błażeja Szadkowskiego (25723) jako projekt zaliczeniowy.";
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            textLabel.Text = "";
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            mathButton.Visible = true;
            logButton.Visible = true;
            sqrtButton.Visible = true;
        }

        private void mathButton_Click(object sender, EventArgs e)
        {
            textLabel.Text = "Funkcje sin, cos, tg oraz ctg przyjmują jako argument x ( np.: sin(x) ) wartość wpisaną przez użytkownika " +
                "znajdującą się w dolnym polu."; 
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            textLabel.Text = "Funkcje log, ln oraz silnia przyjmują jako argument x ( np.: x!, log(x) ) wartość wpisaną przez użytkownika " +
                "znajdującą się w dolnym polu.";
        }

        private void sqrtButton_Click(object sender, EventArgs e)
        {
            textLabel.Text = "Funkcja pierwiasta przyjmuje jako stopień pierwiastka wartość wpisaną przez użytkownika " +
                "znajdującą się w dolnym polu, a jako liczbę podpierwiastkową kolejną wpisaną liczbę.";
        }

        private void converterInfoButton_Click(object sender, EventArgs e)
        {
            textLabel.Text = "Kalkulator posiada konwerter liczb w systemach: dziesiętnym, szesnastkowym, binarnym i ósemkowym. Jest on dostępny w menu " +
                "Widok po włączeniu trybu Programisty";
        }
    }
}
