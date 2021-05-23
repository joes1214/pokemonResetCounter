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
    public partial class customKeyboardInputForm : Form
    {
        public customKeyboardInputForm() {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        //private void customKeyboardInput_Load(object sender, EventArgs e)
        //{
        //}

        private void customKeyboardInput_KeyDown(object sender, KeyEventArgs e)
        {

            //testLabel.Text = e.KeyCode.ToString();
        }

        private void inputValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() != "Escape") 
            {
                inputValue.Text = e.KeyCode.ToString();
            } else
            {

            }
                
        }
    }
}
