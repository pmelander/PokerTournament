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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProgramSettings.BlindLevels = new List<BlindLevel>();

            ProgramSettings.BlindLevels.Add(
                new BlindLevel(int.Parse(bb1.Text), int.Parse(bb1.Text), int.Parse(t1.Text)));

            ProgramSettings.BlindLevels.Add(
                new BlindLevel(int.Parse(bb2.Text), int.Parse(bb2.Text), int.Parse(t2.Text)));

            ProgramSettings.BlindLevels.Add(
                new BlindLevel(int.Parse(bb3.Text), int.Parse(bb3.Text), int.Parse(t3.Text)));

            var form2 = new Form2();
            form2.Show();
        }
    }
}
