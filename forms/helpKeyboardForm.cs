﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pokemonCounterThing 
{
    public partial class helpKeyboardForm : Form {
        public helpKeyboardForm() {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void helpKeyboardForm_Load(object sender, EventArgs e) {

        }

        private void helpExplainBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void setKeys_Click(object sender, EventArgs e)
        {
            customKeyboardInputForm inputForm = new customKeyboardInputForm();
            inputForm.ShowDialog();
        }
    }
}
