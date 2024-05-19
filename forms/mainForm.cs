using Newtonsoft.Json.Linq;
using pokemonCounterThing.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

/*
 TODO:
    -Give user option to make text bold/change font i guess too - ????
    -Custom Keyboard input options (user defined) - Done, fully, I think

    -save the previous counts - Not in progress, but the option is there **
    -load the previous counts - ^^^^^
    
    -Menu strip - More functional, still cant save and load
    -Optimize and clean up the code - not really in progress xd
     */

namespace pokemonCounterThing
{
    public partial class mainForm : Form
    {

        private short userContPanCount = 0;
        private static Keys[] KeyValArr = new Keys[6];

        public mainForm()
        {

            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            ClientSize = new Size(216, 290);
            InitUC();
            getKeybinds();

        }

        public static Keys getKeyValArr(int indexVal)
        {
            return KeyValArr[indexVal];
        }

        public static string getKeyValArrString(int indexVal)
        {
            return KeyValArr[indexVal].ToString();
        }

        public static void setKeyValArr(Keys keyVal, int indexVal)
        {
            KeyValArr[indexVal] = keyVal;
        }

        private void InitUC()
        {
            counterSheet[] counterSheets = new counterSheet[6];

            for (int i = 1; i < 6; i++)
            {
                String xyz = "counterSheets" + i.ToString();
                counterSheets[i] = new counterSheet
                {
                    Enabled = true,
                    Location = new System.Drawing.Point((12 + (i * 209)), 37),
                    Name = xyz,
                    Size = new System.Drawing.Size(196, 189),
                    Visible = true
                };

            }


        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.isCounting = new System.Windows.Forms.CheckBox();
            this.addCounterSheet = new System.Windows.Forms.Button();
            this.removeCounterSheet = new System.Windows.Forms.Button();
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
            this.counterSheet1 = new pokemonCounterThing.counterSheet();
            this.counterSheet2 = new pokemonCounterThing.counterSheet();
            this.counterSheet3 = new pokemonCounterThing.counterSheet();
            this.counterSheet4 = new pokemonCounterThing.counterSheet();
            this.counterSheet5 = new pokemonCounterThing.counterSheet();
            this.counterSheet6 = new pokemonCounterThing.counterSheet();
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
            this.addCounterSheet.Size = new System.Drawing.Size(73, 50);
            this.addCounterSheet.TabIndex = 2;
            this.addCounterSheet.Text = "More games\nto count";
            this.addCounterSheet.UseVisualStyleBackColor = true;
            this.addCounterSheet.Click += new System.EventHandler(this.addCounterSheet_Click);
            // 
            // removeCounterSheet
            // 
            this.removeCounterSheet.Enabled = false;
            this.removeCounterSheet.Location = new System.Drawing.Point(216, 225);
            this.removeCounterSheet.Name = "removeCounterSheet";
            this.removeCounterSheet.Size = new System.Drawing.Size(73, 50);
            this.removeCounterSheet.TabIndex = 7;
            this.removeCounterSheet.Text = "Less games to count";
            this.removeCounterSheet.UseVisualStyleBackColor = true;
            this.removeCounterSheet.Visible = false;
            this.removeCounterSheet.Click += new System.EventHandler(this.removeCounterSheet_Click);
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
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1266, 24);
            this.mainMenuStrip.TabIndex = 0;
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
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // saveNumbersToolStripMenuItem
            // 
            this.saveNumbersToolStripMenuItem.Name = "saveNumbersToolStripMenuItem";
            this.saveNumbersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveNumbersToolStripMenuItem.Text = "Save Numbers";
            this.saveNumbersToolStripMenuItem.Click += new System.EventHandler(this.saveNumbersToolStripMenuItem_Click);
            // 
            // importNumbersToolStripMenuItem
            // 
            this.importNumbersToolStripMenuItem.Enabled = false;
            this.importNumbersToolStripMenuItem.Name = "importNumbersToolStripMenuItem";
            this.importNumbersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importNumbersToolStripMenuItem.Text = "Import Numbers";
            // 
            // resetAllToolStripMenuItem
            // 
            this.resetAllToolStripMenuItem.Name = "resetAllToolStripMenuItem";
            this.resetAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetAllToolStripMenuItem.Text = "Reset All";
            this.resetAllToolStripMenuItem.Click += new System.EventHandler(this.resetAllToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keybindsToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.helpToolStripMenuItem.Text = "Preferences";
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
            // counterSheet1
            // 
            this.counterSheet1.Location = new System.Drawing.Point(12, 27);
            this.counterSheet1.Name = "counterSheet1";
            this.counterSheet1.Size = new System.Drawing.Size(196, 189);
            this.counterSheet1.TabIndex = 0;
            this.counterSheet1.Visible = false;
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
            // counterSheet3
            // 
            this.counterSheet3.Enabled = false;
            this.counterSheet3.Location = new System.Drawing.Point(430, 27);
            this.counterSheet3.Name = "counterSheet3";
            this.counterSheet3.Size = new System.Drawing.Size(196, 189);
            this.counterSheet3.TabIndex = 4;
            this.counterSheet3.Visible = false;
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
            // counterSheet5
            // 
            this.counterSheet5.Enabled = false;
            this.counterSheet5.Location = new System.Drawing.Point(848, 27);
            this.counterSheet5.Name = "counterSheet5";
            this.counterSheet5.Size = new System.Drawing.Size(196, 189);
            this.counterSheet5.TabIndex = 6;
            this.counterSheet5.Visible = false;
            // 
            // counterSheet6
            // 
            this.counterSheet6.Enabled = false;
            this.counterSheet6.Location = new System.Drawing.Point(1057, 27);
            this.counterSheet6.Name = "counterSheet6";
            this.counterSheet6.Size = new System.Drawing.Size(196, 189);
            this.counterSheet6.TabIndex = 7;
            this.counterSheet6.Visible = false;
            this.counterSheet6.Load += new System.EventHandler(this.counterSheet6_Load);
            // 
            // mainForm
            // 
            this.ClientSize = new System.Drawing.Size(1266, 287);
            this.Controls.Add(this.counterSheet1);
            this.Controls.Add(this.counterSheet2);
            this.Controls.Add(this.counterSheet3);
            this.Controls.Add(this.counterSheet4);
            this.Controls.Add(this.counterSheet5);
            this.Controls.Add(this.counterSheet6);
            this.Controls.Add(this.greenScreenBox);
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
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Click += new System.EventHandler(this.mainForm_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Simple warning because I haven't done anyone justice by
            //not learning how to save values and reinsert them
            if (MessageBox.Show("Remember to write down your numbers! This program doesn't save your counters...yet.\nDo you want to close?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {

                e.Cancel = true;
            }
        }
        private bool isSame(Keys Key1, Keys Key2)
        {
            if (Key1 == Key2)
                return true;

            return false;
        }

        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (KeyValArr[0] == e.KeyData && counterSheet1.isOn())
                counterSheet1.incrementCounter();

            if (KeyValArr[1] == e.KeyData && counterSheet2.isOn())
                counterSheet2.incrementCounter();

            if (KeyValArr[2] == e.KeyData && counterSheet3.isOn())
                counterSheet3.incrementCounter();

            if (KeyValArr[3] == e.KeyData && counterSheet4.isOn())
                counterSheet4.incrementCounter();

            if (KeyValArr[4] == e.KeyData && counterSheet5.isOn())
                counterSheet5.incrementCounter();

            if (KeyValArr[5] == e.KeyData && counterSheet6.isOn())
                counterSheet6.incrementCounter();
        }

        private void isCounting_CheckedChanged(object sender, EventArgs e)
        {
            if (isCounting.Checked)
            {
                this.KeyPreview = true;
            }
            else
            {
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
        private void addCounterSheet_Click(object sender, EventArgs e)
        {
            if (userContPanCount < 6)
            {
                switch (userContPanCount)
                {
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
        private void removeCounterSheet_Click(object sender, EventArgs e)
        {
            if (userContPanCount < 0)
            {
            }
            else
            {
                switch (userContPanCount)
                {
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

        private void mainForm_Click(object sender, EventArgs e)
        {
            counterSheet1.defocusText();
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

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            helpKeyboardForm helpBox = new helpKeyboardForm();
            helpBox.ShowDialog();
        }

        private void keybindsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customKeyboardInputForm inputForm = new customKeyboardInputForm();
            inputForm.ShowDialog();
            setKeybinds();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Reminder we don't save numbers yet. Are you sure?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) { }
            else
            {
                counterSheet1.resetToZero();
                counterSheet2.resetToZero();
                counterSheet3.resetToZero();
                counterSheet4.resetToZero();
                counterSheet5.resetToZero();
                counterSheet6.resetToZero();
            }
        }

        private void counterSheet1_Load(object sender, EventArgs e)
        {

        }

        private void setKeybinds()
        {
            Properties.Settings.Default.csKeybind0 = KeyValArr[0];
            Properties.Settings.Default.csKeybind1 = KeyValArr[1];
            Properties.Settings.Default.csKeybind2 = KeyValArr[2];
            Properties.Settings.Default.csKeybind3 = KeyValArr[3];
            Properties.Settings.Default.csKeybind4 = KeyValArr[4];
            Properties.Settings.Default.csKeybind5 = KeyValArr[5];
            Properties.Settings.Default.Save();
        }

        private void getKeybinds()
        {
            KeyValArr[0] = Properties.Settings.Default.csKeybind0;
            KeyValArr[1] = Properties.Settings.Default.csKeybind1;
            KeyValArr[2] = Properties.Settings.Default.csKeybind2;
            KeyValArr[3] = Properties.Settings.Default.csKeybind3;
            KeyValArr[4] = Properties.Settings.Default.csKeybind4;
            KeyValArr[5] = Properties.Settings.Default.csKeybind5;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            counterSheet1.Visible = true;
            counterSheet1.Enabled = true;
            counterSheet1.changeCounterSheetState(true);

        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Counter cs1 = counterSheet1.counterInfo;
            Counter cs2 = counterSheet2.counterInfo;
            Counter cs3 = counterSheet3.counterInfo;
            Counter cs4 = counterSheet4.counterInfo;
            Counter cs5 = counterSheet5.counterInfo;
            Counter cs6 = counterSheet6.counterInfo;

            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                List<Counter> counterList = new List<Counter>
                {
                    new Counter {id = 0, increment = cs1.increment, title = cs1.title, startingValue = cs1.startingValue},
                    new Counter {id = 1, increment = cs2.increment, title = cs2.title, startingValue = cs2.startingValue},
                    new Counter {id = 2, increment = cs3.increment, title = cs3.title, startingValue = cs3.startingValue},
                    new Counter {id = 3, increment = cs4.increment, title = cs4.title, startingValue = cs4.startingValue},
                    new Counter {id = 4, increment = cs5.increment, title = cs5.title, startingValue = cs5.startingValue},
                    new Counter {id = 5, increment = cs6.increment, title = cs6.title, startingValue = cs6.startingValue}
                };

                JArray counters = JArray.FromObject(counterList);

                string filePath = Path.Combine(folderDialog.SelectedPath, "data.json");

                string jsonString = counters.ToString();

                File.WriteAllText(filePath, jsonString);

                MessageBox.Show("File Saved.");

            }
        }

        private void counterSheet6_Load(object sender, EventArgs e)
        {

        }
    }

}
