using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pokemonCounterThing {
    public partial class counterSheet : UserControl {
        private int resetCounter = 0;
        private int incrementBy = 1;
        private int decrementBy = 1;
        private bool turnedOn = false;

        public int sheetNumber = 0;

        public counterSheet() {
            InitializeComponent();
            //temp fix for focus to textbox focus or permanent idk
            focusLabel.Focus();
        }

        public void incrementCounter() {
            resetCounter += incrementBy;
            if (resetCounter >= 1000000)
            {
                MessageBox.Show("CHIEF HOW DO YOU HAVE A MILLION COUNTS??\nOk so, we're not counting any higher.\nWrite it down and start from 0.", "ME MILLIONTH DOLLAR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                resetCounter = 1000000;
            }
            resetCounterBox.Text = resetCounter.ToString();
        }

        private void counterSheet_Load(object sender, EventArgs e) {
            
            resetCounterBox.Text = resetCounter.ToString();
        }

        public string getLabelString()
        {
            return pkmnGameName.Text;
        }

        private void pkmnGameName_TextChanged(object sender, EventArgs e) {
            this.ActiveControl = null;

            //make it so when Keyboard Counting starts disable the ability to edit this and Starting Value
        }

        private void decrementButt_Click(object sender, EventArgs e) {
            resetCounter--;
            if (resetCounter < 0) {
                resetCounter = 0;
            }
            resetCounterBox.Text = resetCounter.ToString();
        }

        /*Function tries to parse the setStrartingVal textbox and
          tries to put it in the resetCounterBox. Added tempVal so
          it could reset the number incase the parse fails.*/
        private void setStartValButt_Click(object sender, EventArgs e) {
            int tempVal = resetCounter;
            if(Int32.TryParse(setStartingVal.Text, out resetCounter)) {
                resetCounterBox.Text = resetCounter.ToString();
                setStartingVal.Text = "Set Starting Value";
            }else {
                MessageBox.Show("Enter an Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resetCounter = tempVal;
            }
        }

        private void resetButt_Click(object sender, EventArgs e) {
            resetCounter = 0;
            resetCounterBox.Text = resetCounter.ToString();
        }
        
        public void resetToZero()
        {
            resetCounter = 0;
            resetCounterBox.Text = resetCounter.ToString();
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
            incrementBy = (int)incrementValue.Value;
            decrementBy = (int)incrementValue.Value;
            decreaseBy.Text = "-" + (int)incrementValue.Value;
        }

        private void decreaseBy_Click(object sender, EventArgs e)
        {
            resetCounter -= decrementBy;
            if (resetCounter < 0)
            {
                resetCounter = 0;
            }
            resetCounterBox.Text = resetCounter.ToString();
        }
    }
}

