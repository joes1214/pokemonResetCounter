using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * Add a feature that detects if the same button is being used twice
 * if so, ask the user if he wants to replace that key
 *      if so, make the user reopen the dialogue and re-enter the key
 *      if not, replace the other key with an empty space
 * Maybe a default button
 */
namespace pokemonCounterThing
{
    public partial class customKeyboardInputForm : Form
    {
        public static Keys tempKey;
        public customKeyboardInputForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

        }

        private void customKeyboardInputForm_Load(object sender, EventArgs e)
        {
            sheet1.Focus();
            updateText();
        }

        private void sheet1Key_MouseDown(object sender, MouseEventArgs e)
        {
            openDialogueBox(0);
        }
        private void sheet2Key_MouseDown(object sender, MouseEventArgs e)
        {
            openDialogueBox(1);
        }

        private void sheet3Key_MouseDown(object sender, MouseEventArgs e)
        {
            openDialogueBox(2);
        }

        private void sheet4Key_MouseDown(object sender, MouseEventArgs e)
        {
            openDialogueBox(3);
        }

        private void sheet5Key_MouseDown(object sender, MouseEventArgs e)
        {
            openDialogueBox(4);
        }

        private void sheet6Key_MouseDown(object sender, MouseEventArgs e)
        {
            openDialogueBox(5);
        }
        private void openDialogueBox(int index)
        {
            tempKey = mainForm.getKeyValArr(index);
            customKeyboardInputDialogue inputForm = new customKeyboardInputDialogue(tempKey);

            inputForm.ShowDialog();
            tempKey = inputForm.returningKey;

            mainForm.setKeyValArr(tempKey, index);
            updateText();
        }

        private void updateText()
        {
            sheet1Key.Text = mainForm.getKeyValArrString(0);
            sheet2Key.Text = mainForm.getKeyValArrString(1);
            sheet3Key.Text = mainForm.getKeyValArrString(2);
            sheet4Key.Text = mainForm.getKeyValArrString(3);
            sheet5Key.Text = mainForm.getKeyValArrString(4);
            sheet6Key.Text = mainForm.getKeyValArrString(5);
        }

        private void defaultReset_Click(object sender, EventArgs e)
        {
            mainForm.setKeyValArr(Keys.A, 0);
            mainForm.setKeyValArr(Keys.S, 1);
            mainForm.setKeyValArr(Keys.D, 2);
            mainForm.setKeyValArr(Keys.F, 3);
            mainForm.setKeyValArr(Keys.G, 4);
            mainForm.setKeyValArr(Keys.H, 5);
            updateText();
        }

        private void confirmKeys_Click(object sender, EventArgs e)
        {
            //This button literally does nothing
            this.Close();
        }
    }
}
