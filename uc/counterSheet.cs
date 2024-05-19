using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using pokemonCounterThing.models;

namespace pokemonCounterThing {
    public partial class counterSheet : UserControl {
        public Counter counterInfo = new Counter();

        public int resetCounter = 0;
        public int incrementBy = 1;
        public int decrementBy = 1;
        private bool turnedOn = false;

        public int sheetNumber = 0;

        public counterSheet() {
            InitializeComponent();
            //temp fix for focus to textbox focus or permanent idk
            focusLabel.Focus();
        }

        public void incrementCounter() {
            counterInfo.startingValue += counterInfo.increment;
            if (counterInfo.startingValue >= 1000000)
            {
                MessageBox.Show("CHIEF HOW DO YOU HAVE A MILLION COUNTS??\nOk so, we're not counting any higher.\nWrite it down and start from 0.", "ME MILLIONTH DOLLAR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                counterInfo.startingValue = 1000000;
            }
            resetCounterBox.Text = counterInfo.startingValue.ToString();
        }

        private void counterSheet_Load(object sender, EventArgs e) {
            
            resetCounterBox.Text = counterInfo.startingValue.ToString();
        }

        public string getLabelString()
        {
            return counterInfo.title;
        }

        private void pkmnGameName_TextChanged(object sender, EventArgs e) {
            this.ActiveControl = null;
            counterInfo.title = pkmnGameName.Text;
            //make it so when Keyboard Counting starts disable the ability to edit this and Starting Value
        }

        private void decrementButt_Click(object sender, EventArgs e) {
            counterInfo.startingValue--;
            if (counterInfo.startingValue < 0) {
                counterInfo.startingValue = 0;
            }
            resetCounterBox.Text = counterInfo.startingValue.ToString();
        }

        /*Function tries to parse the setStrartingVal textbox and
          tries to put it in the resetCounterBox. Added tempVal so
          it could reset the number incase the parse fails.*/
        private void setStartValButt_Click(object sender, EventArgs e) {
            int tempVal = counterInfo.startingValue;
            if(Int32.TryParse(setStartingVal.Text, out counterInfo.startingValue)) {
                counterInfo.startingValue = Int32.Parse(setStartingVal.Text);
                resetCounterBox.Text = counterInfo.startingValue.ToString();
                setStartingVal.Text = "Set Starting Value";
            }else {
                MessageBox.Show("Enter an Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                counterInfo.startingValue = tempVal;
            }
        }

        private void resetButt_Click(object sender, EventArgs e) {
            counterInfo.startingValue = 0;
            resetCounterBox.Text = counterInfo.startingValue.ToString();
        }
        
        public void resetToZero()
        {
            counterInfo.startingValue = 0;
            resetCounterBox.Text = counterInfo.startingValue.ToString();
        }
        private void focusLabel_Click(object sender, EventArgs e) {

        }

        private void counterSheet_Click(object sender, EventArgs e) {
            //temp fix for focus to textbox focus
            focusLabel.Focus();
        }

        public void changeCounterSheetState(bool x) {
            turnedOn = x;
        }


        public bool isOn() {
            return turnedOn;
        }

        public void defocusText() {
            focusLabel.Focus();
        }

        public void set_greenScreenMode(bool checkBox)
        {
            if (checkBox)
                resetCounterBox.BackColor = Color.FromArgb(0, 255, 0);
            else
                resetCounterBox.BackColor = SystemColors.Control;
        }

        private void incrementValue_ValueChanged(object sender, EventArgs e)
        {
            //increment the value from this box to the incrementBy value
            counterInfo.increment = (int)incrementValue.Value;
            //decrementBy = (int)incrementValue.Value;
            decreaseBy.Text = "-" + (int)incrementValue.Value;
        }

        private void decreaseBy_Click(object sender, EventArgs e)
        {
            counterInfo.startingValue -= counterInfo.increment;
            if (counterInfo.startingValue < 0)
            {
                counterInfo.startingValue = 0;
            }
            resetCounterBox.Text = counterInfo.startingValue.ToString();
        }
    }
}

