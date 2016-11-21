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
    public partial class Form2 : Form
    {
        private Timer _timer;
        private int _listIndex;

        public Form2()
        {
            InitializeComponent();
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += _timer_Tick;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            _timer.Start();
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            if (_listIndex >= ProgramSettings.BlindLevels.Count)
            {
                _timer.Stop(); // guard
                return;
            }
            ProgramSettings.BlindLevels[_listIndex].TimeInSeconds -= 1; // ticka ner en sekund
            
            // uppdatera UI
            var t = TimeSpan.FromSeconds(ProgramSettings.BlindLevels[_listIndex].TimeInSeconds);
            currentBlind.Text = $"Current BB: {ProgramSettings.BlindLevels[_listIndex].BB}";

            nextBlind.Text = _listIndex + 1 < ProgramSettings.BlindLevels.Count
                ? $"Next BB: {ProgramSettings.BlindLevels[_listIndex + 1].BB}"
                : $"Last blind";

            currentTime.Text = t.ToString(@"hh\:mm\:ss");
            
             
            if (ProgramSettings.BlindLevels[_listIndex].TimeInSeconds <= 0)
            {  
                _listIndex += 1; // tiden är slut, byt index
            }
        }
    }
}
