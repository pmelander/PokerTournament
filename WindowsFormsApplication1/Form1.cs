using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            bb1.Leave += ValidateNumeric;
            bb2.Leave += ValidateNumeric;
            bb2.Leave += ValidateNumeric;
            sb1.Leave += ValidateNumeric;
            sb2.Leave += ValidateNumeric;
            sb3.Leave += ValidateNumeric;
            t1.Leave += ValidateNumeric;
            t1.Leave += ValidateNumeric;
            t1.Leave += ValidateNumeric;
        }

        private void ValidateNumeric(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null) return; // guard
            textBox.ForeColor = textBox.Text.IsNumericOrEmpty() ? Color.Black : Color.Red;
            if (!textBox.Text.IsNumericOrEmpty()) textBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProgramSettings.BlindLevels = new List<BlindLevel>();

            if (bb1.Text.IsNumeric() && sb1.Text.IsNumeric() && t1.Text.IsNumeric())
                ProgramSettings.BlindLevels.Add(
                    new BlindLevel(int.Parse(bb1.Text), int.Parse(bb1.Text), int.Parse(t1.Text)));

            if (bb2.Text.IsNumeric() && sb2.Text.IsNumeric() && t2.Text.IsNumeric())
                ProgramSettings.BlindLevels.Add(
                    new BlindLevel(int.Parse(bb2.Text), int.Parse(bb2.Text), int.Parse(t2.Text)));

            if (bb3.Text.IsNumeric() && sb3.Text.IsNumeric() && t3.Text.IsNumeric())
                ProgramSettings.BlindLevels.Add(
                    new BlindLevel(int.Parse(bb3.Text), int.Parse(bb3.Text), int.Parse(t3.Text)));

            // vi injektar timern i konstruktorn för Form2 för att slippa
            // dubbla uppräkningar om man öppnar flera formulär
            var form2 = new Form2();
            form2.Show();
        }
    }
}
