using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pokemonCounterThing
{
    public partial class customKeyboardInputDialogue : Form
    {
        public Keys returningKey;

        public customKeyboardInputDialogue(Keys tempKeyVal) {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            returningKey = tempKeyVal;
            inputValue.Text = tempKeyVal.ToString();
        }
        private void inputValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() != "Escape") 
            {
                inputValue.Text = e.KeyData.ToString();
                this.returningKey = e.KeyData;
                
            } else
            {
                this.Close();
            }
                
        }
    }
}
