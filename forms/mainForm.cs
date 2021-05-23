using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 TODO:
    -Give user option to make text bold/change font i guess too - ????
    -Custom Keyboard input options (user defined) - In Progress***
    -6th Slot - Done 
    -Set an "Incremnet By", instead of adding by 1, add by 2 or 6 - In progress ***
    -save the previous counts - Not in progress, but the option is there **
    -load the previous counts - ^^^^^
    
    -Menu strip - I mean it's there, but disabled on release build. Doesn't function much
    -Optimize and clean up the code - not really in progress xd
     
     */

namespace pokemonCounterThing {
    public partial class mainForm : Form {
        //private string[] cusKeyInput;
        //private string test = "";
        public mainForm() {
            
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            ClientSize = new Size(216, 290);

            //this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainForm_KeyDown);
        }



        private short userContPanCount = 0;

        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.isCounting = new System.Windows.Forms.CheckBox();
            this.addCounterSheet = new System.Windows.Forms.Button();
            this.removeCounterSheet = new System.Windows.Forms.Button();
            this.helpButt = new System.Windows.Forms.Button();
            this.greenScreenBox = new System.Windows.Forms.CheckBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keybindsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.counterSheet6 = new pokemonCounterThing.counterSheet();
            this.counterSheet5 = new pokemonCounterThing.counterSheet();
            this.counterSheet4 = new pokemonCounterThing.counterSheet();
            this.counterSheet3 = new pokemonCounterThing.counterSheet();
            this.counterSheet1 = new pokemonCounterThing.counterSheet();
            this.counterSheet2 = new pokemonCounterThing.counterSheet();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // isCounting
            // 
            this.isCounting.AutoSize = true;
            this.isCounting.Location = new System.Drawing.Point(12, 256);
            this.isCounting.Name = "isCounting";
            this.isCounting.Size = new System.Drawing.Size(127, 17);
            this.isCounting.TabIndex = 1;
            this.isCounting.Text = "Start Keyboard Count";
            this.isCounting.UseVisualStyleBackColor = true;
            this.isCounting.CheckedChanged += new System.EventHandler(this.isCounting_CheckedChanged);
            // 
            // addCounterSheet
            // 
            this.addCounterSheet.Location = new System.Drawing.Point(135, 225);
            this.addCounterSheet.Name = "addCounterSheet";
            this.addCounterSheet.Size = new System.Drawing.Size(73, 23);
            this.addCounterSheet.TabIndex = 2;
            this.addCounterSheet.Text = "More games";
            this.addCounterSheet.UseVisualStyleBackColor = true;
            this.addCounterSheet.Click += new System.EventHandler(this.addCounterSheet_Click);
            // 
            // removeCounterSheet
            // 
            this.removeCounterSheet.Enabled = false;
            this.removeCounterSheet.Location = new System.Drawing.Point(216, 225);
            this.removeCounterSheet.Name = "removeCounterSheet";
            this.removeCounterSheet.Size = new System.Drawing.Size(75, 50);
            this.removeCounterSheet.TabIndex = 7;
            this.removeCounterSheet.Text = "Less games to count";
            this.removeCounterSheet.UseVisualStyleBackColor = true;
            this.removeCounterSheet.Visible = false;
            this.removeCounterSheet.Click += new System.EventHandler(this.removeCounterSheet_Click);
            // 
            // helpButt
            // 
            this.helpButt.Location = new System.Drawing.Point(135, 252);
            this.helpButt.Name = "helpButt";
            this.helpButt.Size = new System.Drawing.Size(73, 23);
            this.helpButt.TabIndex = 8;
            this.helpButt.Text = "Help?";
            this.helpButt.UseVisualStyleBackColor = true;
            this.helpButt.Click += new System.EventHandler(this.helpButt_Click);
            // 
            // greenScreenBox
            // 
            this.greenScreenBox.AutoSize = true;
            this.greenScreenBox.Location = new System.Drawing.Point(12, 229);
            this.greenScreenBox.Name = "greenScreenBox";
            this.greenScreenBox.Size = new System.Drawing.Size(122, 17);
            this.greenScreenBox.TabIndex = 9;
            this.greenScreenBox.Text = "Green Screen Mode";
            this.greenScreenBox.UseVisualStyleBackColor = true;
            this.greenScreenBox.CheckedChanged += new System.EventHandler(this.greenScreenBox_CheckedChanged);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.mainMenuStrip.Enabled = false;
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1265, 24);
            this.mainMenuStrip.TabIndex = 11;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveNumbersToolStripMenuItem,
            this.importNumbersToolStripMenuItem,
            this.resetAllToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.mainToolStripMenuItem.Text = "Menu";
            // 
            // saveNumbersToolStripMenuItem
            // 
            this.saveNumbersToolStripMenuItem.Name = "saveNumbersToolStripMenuItem";
            this.saveNumbersToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.saveNumbersToolStripMenuItem.Text = "Save Numbers";
            // 
            // importNumbersToolStripMenuItem
            // 
            this.importNumbersToolStripMenuItem.Name = "importNumbersToolStripMenuItem";
            this.importNumbersToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.importNumbersToolStripMenuItem.Text = "Import Numbers";
            // 
            // resetAllToolStripMenuItem
            // 
            this.resetAllToolStripMenuItem.Name = "resetAllToolStripMenuItem";
            this.resetAllToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.resetAllToolStripMenuItem.Text = "Reset All";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keybindsToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // keybindsToolStripMenuItem
            // 
            this.keybindsToolStripMenuItem.Name = "keybindsToolStripMenuItem";
            this.keybindsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.keybindsToolStripMenuItem.Text = "Keybinds";
            this.keybindsToolStripMenuItem.Click += new System.EventHandler(this.keybindsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // counterSheet6
            // 
            this.counterSheet6.Enabled = false;
            this.counterSheet6.Location = new System.Drawing.Point(1057, 27);
            this.counterSheet6.Name = "counterSheet6";
            this.counterSheet6.Padding = new System.Windows.Forms.Padding(10);
            this.counterSheet6.Size = new System.Drawing.Size(196, 189);
            this.counterSheet6.TabIndex = 10;
            this.counterSheet6.Visible = false;
            this.counterSheet6.Load += new System.EventHandler(this.counterSheet6_Load);
            // 
            // counterSheet5
            // 
            this.counterSheet5.Enabled = false;
            this.counterSheet5.Location = new System.Drawing.Point(848, 27);
            this.counterSheet5.Name = "counterSheet5";
            this.counterSheet5.Size = new System.Drawing.Size(196, 189);
            this.counterSheet5.TabIndex = 6;
            this.counterSheet5.Visible = false;
            // 
            // counterSheet4
            // 
            this.counterSheet4.Enabled = false;
            this.counterSheet4.Location = new System.Drawing.Point(639, 27);
            this.counterSheet4.Name = "counterSheet4";
            this.counterSheet4.Size = new System.Drawing.Size(196, 189);
            this.counterSheet4.TabIndex = 5;
            this.counterSheet4.Visible = false;
            // 
            // counterSheet3
            // 
            this.counterSheet3.Enabled = false;
            this.counterSheet3.Location = new System.Drawing.Point(430, 27);
            this.counterSheet3.Name = "counterSheet3";
            this.counterSheet3.Size = new System.Drawing.Size(196, 189);
            this.counterSheet3.TabIndex = 4;
            this.counterSheet3.Visible = false;
            // 
            // counterSheet1
            // 
            this.counterSheet1.Location = new System.Drawing.Point(12, 27);
            this.counterSheet1.Name = "counterSheet1";
            this.counterSheet1.Size = new System.Drawing.Size(196, 189);
            this.counterSheet1.TabIndex = 0;
            this.counterSheet1.Load += new System.EventHandler(this.counterSheet1_Load);
            // 
            // counterSheet2
            // 
            this.counterSheet2.Enabled = false;
            this.counterSheet2.Location = new System.Drawing.Point(221, 27);
            this.counterSheet2.Name = "counterSheet2";
            this.counterSheet2.Size = new System.Drawing.Size(196, 189);
            this.counterSheet2.TabIndex = 3;
            this.counterSheet2.Visible = false;
            // 
            // mainForm
            // 
            this.ClientSize = new System.Drawing.Size(1265, 287);
            this.Controls.Add(this.counterSheet1);
            this.Controls.Add(this.counterSheet2);
            this.Controls.Add(this.counterSheet3);
            this.Controls.Add(this.counterSheet4);
            this.Controls.Add(this.counterSheet5);
            this.Controls.Add(this.counterSheet6);
            this.Controls.Add(this.greenScreenBox);
            this.Controls.Add(this.helpButt);
            this.Controls.Add(this.addCounterSheet);
            this.Controls.Add(this.removeCounterSheet);
            this.Controls.Add(this.isCounting);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "\"TVEPRC\" Counter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load_1);
            this.Click += new System.EventHandler(this.mainForm_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void mainForm_Load(object sender, EventArgs e) {

        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e) {
            //Simple warning because I haven't done anyone justice by
            //not learning how to save values and reinsert them
            if (MessageBox.Show("Remember to write down your numbers! This program doesn't save your counters...yet.\nDo you want to close?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) {
            
                e.Cancel = true;
            }
        }

        private void mainForm_KeyDown(object sender, KeyEventArgs e) {

            switch (e.KeyCode.ToString()) {
                case "A":
                    counterSheet1.incrementCounter();
                    break;

                case "S":
                    if (counterSheet2.isOn())
                        counterSheet2.incrementCounter();
                    break;

                case "D":
                    if (counterSheet3.isOn())
                        counterSheet3.incrementCounter();
                    break;

                case "F":
                    if (counterSheet4.isOn())
                        counterSheet4.incrementCounter();
                    break;

                case "G":

                    if (counterSheet5.isOn())
                        counterSheet5.incrementCounter();
                    break;

                case "H":
                    if (counterSheet6.isOn())
                        counterSheet6.incrementCounter();
                    break;
            }
        }

        private void isCounting_CheckedChanged(object sender, EventArgs e) {
            if (isCounting.Checked) {
                this.KeyPreview = true;
            } else {
                this.KeyPreview = false;
            }
        }

        /* Enables the sheet*/
        private void TurnOnSheet(counterSheet sheet)
        {
            sheet.Visible = true;
            sheet.Enabled = true;
        }

        /* Pretty Simple, the opposite of the function above
         * removes the and disables the functionality of the 
         * sheet*/
        private void TurnOffSheet(counterSheet sheet)
        {
            sheet.Enabled = false;
            sheet.Visible = false;
        }

        /* On click on the button, it will add a sheet
         * there cannot be more than 6 (as I didnt load up more xd)*/
        private void addCounterSheet_Click(object sender, EventArgs e) {
            if (userContPanCount < 6) {
                switch (userContPanCount) {
                    case 0:
                        TurnOnSheet(counterSheet2);
                        counterSheet2.changeCounterSheetState(true);
                        userContPanCount++;
                        removeCounterSheet.Enabled = true;
                        removeCounterSheet.Visible = true;
                        ClientSize = new Size(432, 290);
                        break;

                    case 1:
                        TurnOnSheet(counterSheet3);
                        counterSheet3.changeCounterSheetState(true);
                        userContPanCount++;
                        ClientSize = new Size(648, 290);
                        break;

                    case 2:
                        TurnOnSheet(counterSheet4);
                        counterSheet4.changeCounterSheetState(true);
                        userContPanCount++;
                        ClientSize = new Size(864, 290);
                        break;

                    case 3:
                        TurnOnSheet(counterSheet5);
                        counterSheet5.changeCounterSheetState(true);
                        userContPanCount++;
                        ClientSize = new Size(1080, 290);
                        break;
                    case 4:
                        TurnOnSheet(counterSheet6);
                        counterSheet6.changeCounterSheetState(true);
                        userContPanCount++;
                        addCounterSheet.Enabled = false;
                        ClientSize = new Size(1281, 290);
                        break;
                }
            }
        }

        /* Opposite of the above function
         * removes a sheet, cannot be less than 0*/
        private void removeCounterSheet_Click(object sender, EventArgs e) {
            if (userContPanCount < 0) {
            }
            else {
                switch (userContPanCount) {
                    case 5:
                        TurnOffSheet(counterSheet6);
                        counterSheet2.changeCounterSheetState(false);
                        userContPanCount--;
                        addCounterSheet.Enabled = true;
                        addCounterSheet.Visible = true;
                        ClientSize = new Size(1080, 290);
                        break;

                    case 4:
                        TurnOffSheet(counterSheet5);
                        counterSheet2.changeCounterSheetState(false);
                        userContPanCount--;
                        addCounterSheet.Enabled = true;
                        addCounterSheet.Visible = true;
                        ClientSize = new Size(864, 290);
                        
                        break;

                    case 3:
                        TurnOffSheet(counterSheet4);
                        counterSheet4.changeCounterSheetState(false);
                        userContPanCount--;
                        ClientSize = new Size(648, 290);
                        break;

                    case 2:
                        TurnOffSheet(counterSheet3);
                        counterSheet3.changeCounterSheetState(false);
                        userContPanCount--;
                        ClientSize = new Size(432, 290);
                        break;

                    case 1:
                        TurnOffSheet(counterSheet2);
                        counterSheet2.changeCounterSheetState(false);
                        userContPanCount--;
                        removeCounterSheet.Enabled = false;
                        removeCounterSheet.Visible = false;
                        ClientSize = new Size(216, 290);
                        break;
                }
            }
        }

        private void mainForm_Click(object sender, EventArgs e) {
            counterSheet1.defocusText();
        }

        private void counterSheet1_Load(object sender, EventArgs e) {

        }

        private void mainForm_Load_1(object sender, EventArgs e) {
            
        }

        private void helpButt_Click(object sender, EventArgs e) {
            helpKeyboardForm helpBox = new helpKeyboardForm();
            helpBox.ShowDialog();

        }

        private void greenScreenBox_CheckedChanged(object sender, EventArgs e)
        {
            counterSheet1.set_greenScreenMode(greenScreenBox.Checked);
            counterSheet2.set_greenScreenMode(greenScreenBox.Checked);
            counterSheet3.set_greenScreenMode(greenScreenBox.Checked);
            counterSheet4.set_greenScreenMode(greenScreenBox.Checked);
            counterSheet5.set_greenScreenMode(greenScreenBox.Checked);
            counterSheet6.set_greenScreenMode(greenScreenBox.Checked);
        }

        private void counterSheet6_Load(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            helpKeyboardForm helpBox = new helpKeyboardForm();
            helpBox.ShowDialog();
        }

        private void keybindsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customKeyboardInputForm inputForm = new customKeyboardInputForm();
            inputForm.ShowDialog();
        }
    }

}
