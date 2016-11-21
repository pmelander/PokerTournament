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

            bb1.Leave += ValidateBlind;
            bb2.Leave += ValidateBlind;
            bb2.Leave += ValidateBlind;
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

        private void ValidateBlind(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox == null) return; // guard
            textBox.ForeColor = textBox.Text.IsBlind() ? Color.Black : Color.Red;
            if (!textBox.Text.IsBlind()) textBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProgramSettings.BlindLevels = new List<BlindLevel>();

            if (bb1.Text.IsBlind() && t1.Text.IsNumeric())
                ProgramSettings.BlindLevels.Add(
                    new BlindLevel(bb1.Text.GetBB(), bb1.Text.GetSB(), int.Parse(t1.Text)));

            if (bb2.Text.IsBlind() && t2.Text.IsNumeric())
                ProgramSettings.BlindLevels.Add(
                    new BlindLevel(bb2.Text.GetBB(), bb2.Text.GetSB(), int.Parse(t2.Text)));

            if (bb3.Text.IsBlind() && t3.Text.IsNumeric())
                ProgramSettings.BlindLevels.Add(
                    new BlindLevel(bb2.Text.GetBB(), bb2.Text.GetSB(), int.Parse(t3.Text)));

            // vi injektar timern i konstruktorn för Form2 för att slippa
            // dubbla uppräkningar om man öppnar flera formulär
            var form2 = new Form2();
            form2.Show();
        }
    }
}
