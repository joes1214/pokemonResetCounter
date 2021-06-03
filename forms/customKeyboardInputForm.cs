using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * Form that handles the keybinds separately from the mainForm.
 * Accepts inputs in each TextBox. TextBoxes are readonly.
 * KeyDown while focused on a TextBox executes the action to:
 *  -saves the KeyDown KeyCode into tempKey
 *  -checks to see if tempKey is a forbidden value, if so, exits the function
 *  -if not, checks to see if tempKey is matching any other keybind, if so, exits the function
 *  -if not, changes the keybind for that respective sheet
 *  
 *  if I ever find a way to use arrays or multiple textboxes efficiently I'll fix this
 */
namespace pokemonCounterThing
{
    public partial class customKeyboardInputForm : Form
    {
        private Keys tempKey;
        private static readonly Keys[] forbiddenKeys = {Keys.Enter, Keys.Escape, Keys.Space, Keys.Return, Keys.Capital, Keys.CapsLock, Keys.NumLock, Keys.Scroll, Keys.PrintScreen};
        //I have no idea what to else to add, so it'll be expanded as time goes on
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

        private void sheet1Key_KeyDown(object sender, KeyEventArgs e)
        {
            tempKey = e.KeyData;
            sameButtonCheck(0);
        }
        private void sheet2Key_KeyDown(object sender, KeyEventArgs e)
        {
            tempKey = e.KeyData;
            sameButtonCheck(1);
        }
        private void sheet3Key_KeyDown(object sender, KeyEventArgs e)
        {
            tempKey = e.KeyData;
            sameButtonCheck(2);
        }
        private void sheet4Key_KeyDown(object sender, KeyEventArgs e)
        {
            tempKey = e.KeyData;
            sameButtonCheck(3);
        }
        private void sheet5Key_KeyDown(object sender, KeyEventArgs e)
        {
            tempKey = e.KeyData;
            sameButtonCheck(4);
        }
        private void sheet6Key_KeyDown(object sender, KeyEventArgs e)
        {
            tempKey = e.KeyData;
            sameButtonCheck(5);
        }

        private void sameButtonCheck(int keyArrayIndex)
        {
            for(int x = 0; x < forbiddenKeys.Length; x++)
            {
                if (tempKey == forbiddenKeys[x])
                {
                    MessageBox.Show("This is a forbidden key!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            for (int x = 0; x < 6; x++)
            {
                if (keyArrayIndex == x)
                {
                    x++;
                }else if (tempKey == mainForm.getKeyValArr(x))
                {
                    MessageBox.Show("Can't have the same button for\na keybind!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
            }

            mainForm.setKeyValArr(tempKey, keyArrayIndex);
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
            //This button basically does nothing
            this.Close();
        }
    }
}
