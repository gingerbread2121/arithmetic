using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Francis
{
    
    public partial class Form1 : Form
    {

        Random rnd = new Random();
        string[] Maths = {"Addition", "Subtraction", "Multiply" , "Division"};
        int total;
        int score;

        public Form1()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void CheckAnswer(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAnswer.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers!");
                txtAnswer.Text = txtAnswer.Text.Remove(txtAnswer.Text.Length - 1);
            }
        }

        private void CheckButtonClickEvent(object sender, EventArgs e)
        {

            int userEntered = Convert.ToInt32(txtAnswer.Text);

            if (userEntered == total)
            {
                lblAnswer.Text = "Correct";
                lblAnswer.ForeColor = Color.Green;
                score += 1;
                lblScore.Text = "Score: " + score;
                SetUpGame();

            }
            else
            {
                lblAnswer.Text = "Incorrect";
                lblAnswer.ForeColor = Color.Red;
            }

        }

        private void SetUpGame()
        {
            int numA = rnd.Next(10, 20);
            int numB = rnd.Next(0, 9);

            txtAnswer.Text = null;

            switch (Maths[rnd.Next(0, Maths.Length)])
            {
                case "Addition":
                    total = numA + numB;
                    lblSymbol.Text = "+";
                    lblSymbol.ForeColor = Color.Red;
                    break;

                case "Subtraction":
                    total = numA - numB;
                    lblSymbol.Text = "-";
                    lblSymbol.ForeColor = Color.Brown;
                    break;

                case "Multiply":
                    total = numA * numB;
                    lblSymbol.Text = "x";
                    lblSymbol.ForeColor = Color.Green;
                    break;
                case "Division":
                    total = numA / numB;
                    lblSymbol.Text = "/";
                    lblSymbol.ForeColor = Color.Blue;
                    break;
            }

            lblNumA.Text = numA.ToString();
            lblNumB.Text = numB.ToString();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblNumB_Click(object sender, EventArgs e)
        {

        }
    }
}
