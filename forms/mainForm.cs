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
    -Give user option to make text bold/change font i guess too
    -Custom Keyboard input options (user defined)
    -6th Slot - Done 
    -save the previous counts
     
     */

namespace pokemonCounterThing {
    public partial class mainForm : Form {
        //private string test = "";
        public mainForm() {
            
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            ClientSize = new Size(216, 257);

            //this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainForm_KeyDown);
        }



        private short userContPanCount = 0;

        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.isCounting = new System.Windows.Forms.CheckBox();
            this.addCounterSheet = new System.Windows.Forms.Button();
            this.removeCounterSheet = new System.Windows.Forms.Button();
            this.helpButt = new System.Windows.Forms.Button();
            this.counterSheet5 = new pokemonCounterThing.counterSheet();
            this.counterSheet4 = new pokemonCounterThing.counterSheet();
            this.counterSheet3 = new pokemonCounterThing.counterSheet();
            this.counterSheet1 = new pokemonCounterThing.counterSheet();
            this.counterSheet2 = new pokemonCounterThing.counterSheet();
            this.greenScreenBox = new System.Windows.Forms.CheckBox();
            this.counterSheet6 = new pokemonCounterThing.counterSheet();
            this.SuspendLayout();
            // 
            // isCounting
            // 
            this.isCounting.AutoSize = true;
            this.isCounting.Location = new System.Drawing.Point(12, 216);
            this.isCounting.Name = "isCounting";
            this.isCounting.Size = new System.Drawing.Size(127, 17);
            this.isCounting.TabIndex = 1;
            this.isCounting.Text = "Start Keyboard Count";
            this.isCounting.UseVisualStyleBackColor = true;
            this.isCounting.CheckedChanged += new System.EventHandler(this.isCounting_CheckedChanged);
            // 
            // addCounterSheet
            // 
            this.addCounterSheet.Location = new System.Drawing.Point(135, 185);
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
            this.removeCounterSheet.Location = new System.Drawing.Point(216, 185);
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
            this.helpButt.Location = new System.Drawing.Point(135, 212);
            this.helpButt.Name = "helpButt";
            this.helpButt.Size = new System.Drawing.Size(73, 23);
            this.helpButt.TabIndex = 8;
            this.helpButt.Text = "Help?";
            this.helpButt.UseVisualStyleBackColor = true;
            this.helpButt.Click += new System.EventHandler(this.helpButt_Click);
            // 
            // counterSheet5
            // 
            this.counterSheet5.Enabled = false;
            this.counterSheet5.Location = new System.Drawing.Point(848, 12);
            this.counterSheet5.Name = "counterSheet5";
            this.counterSheet5.Size = new System.Drawing.Size(196, 189);
            this.counterSheet5.TabIndex = 6;
            this.counterSheet5.Visible = false;
            // 
            // counterSheet4
            // 
            this.counterSheet4.Enabled = false;
            this.counterSheet4.Location = new System.Drawing.Point(639, 12);
            this.counterSheet4.Name = "counterSheet4";
            this.counterSheet4.Size = new System.Drawing.Size(196, 189);
            this.counterSheet4.TabIndex = 5;
            this.counterSheet4.Visible = false;
            // 
            // counterSheet3
            // 
            this.counterSheet3.Enabled = false;
            this.counterSheet3.Location = new System.Drawing.Point(430, 12);
            this.counterSheet3.Name = "counterSheet3";
            this.counterSheet3.Size = new System.Drawing.Size(196, 189);
            this.counterSheet3.TabIndex = 4;
            this.counterSheet3.Visible = false;
            // 
            // counterSheet1
            // 
            this.counterSheet1.Location = new System.Drawing.Point(12, 12);
            this.counterSheet1.Name = "counterSheet1";
            this.counterSheet1.Size = new System.Drawing.Size(196, 189);
            this.counterSheet1.TabIndex = 0;
            this.counterSheet1.Load += new System.EventHandler(this.counterSheet1_Load);
            // 
            // counterSheet2
            // 
            this.counterSheet2.Enabled = false;
            this.counterSheet2.Location = new System.Drawing.Point(221, 12);
            this.counterSheet2.Name = "counterSheet2";
            this.counterSheet2.Size = new System.Drawing.Size(196, 189);
            this.counterSheet2.TabIndex = 3;
            this.counterSheet2.Visible = false;
            // 
            // greenScreenBox
            // 
            this.greenScreenBox.AutoSize = true;
            this.greenScreenBox.Location = new System.Drawing.Point(12, 189);
            this.greenScreenBox.Name = "greenScreenBox";
            this.greenScreenBox.Size = new System.Drawing.Size(122, 17);
            this.greenScreenBox.TabIndex = 9;
            this.greenScreenBox.Text = "Green Screen Mode";
            this.greenScreenBox.UseVisualStyleBackColor = true;
            this.greenScreenBox.CheckedChanged += new System.EventHandler(this.greenScreenBox_CheckedChanged);
            // 
            // counterSheet6
            // 
            this.counterSheet6.Enabled = false;
            this.counterSheet6.Location = new System.Drawing.Point(1057, 12);
            this.counterSheet6.Name = "counterSheet6";
            this.counterSheet6.Padding = new System.Windows.Forms.Padding(10);
            this.counterSheet6.Size = new System.Drawing.Size(196, 189);
            this.counterSheet6.TabIndex = 10;
            this.counterSheet6.Visible = false;
            this.counterSheet6.Load += new System.EventHandler(this.counterSheet6_Load);
            // 
            // mainForm
            // 
            this.ClientSize = new System.Drawing.Size(1265, 248);
            this.Controls.Add(this.counterSheet6);
            this.Controls.Add(this.greenScreenBox);
            this.Controls.Add(this.helpButt);
            this.Controls.Add(this.addCounterSheet);
            this.Controls.Add(this.removeCounterSheet);
            this.Controls.Add(this.counterSheet5);
            this.Controls.Add(this.counterSheet4);
            this.Controls.Add(this.counterSheet3);
            this.Controls.Add(this.isCounting);
            this.Controls.Add(this.counterSheet1);
            this.Controls.Add(this.counterSheet2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "\"TVEPRC\" Counter - Streamer Edition";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load_1);
            this.Click += new System.EventHandler(this.mainForm_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
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

        private void addCounterSheet_Click(object sender, EventArgs e) {
            if (userContPanCount < 6) {
                switch (userContPanCount) {
                    case 0:
                        counterSheet2.Visible = true;
                        counterSheet2.Enabled = true;
                        counterSheet2.changeCounterSheetState(true);
                        userContPanCount++;
                        removeCounterSheet.Enabled = true;
                        removeCounterSheet.Visible = true;
                        ClientSize = new Size(432, 257);
                        break;

                    case 1:
                        counterSheet3.Visible = true;
                        counterSheet3.Enabled = true;
                        counterSheet3.changeCounterSheetState(true);
                        userContPanCount++;
                        ClientSize = new Size(648, 257);
                        break;

                    case 2:
                        counterSheet4.Visible = true;
                        counterSheet4.Enabled = true;
                        counterSheet4.changeCounterSheetState(true);
                        userContPanCount++;
                        ClientSize = new Size(864, 257);
                        break;

                    case 3:
                        counterSheet5.Visible = true;
                        counterSheet5.Enabled = true;
                        counterSheet5.changeCounterSheetState(true);
                        userContPanCount++;
                        ClientSize = new Size(1080, 257);
                        break;
                    case 4:
                        counterSheet6.Visible = true;
                        counterSheet6.Enabled = true;
                        counterSheet6.changeCounterSheetState(true);
                        userContPanCount++;
                        addCounterSheet.Enabled = false;
                        ClientSize = new Size(1281, 257);
                        break;
                }
            }
        }

        private void removeCounterSheet_Click(object sender, EventArgs e) {
            if (userContPanCount < 0) {
            }
            else {
                switch (userContPanCount) {
                    case 5:
                        counterSheet6.Enabled = false;
                        counterSheet6.Visible = false;
                        counterSheet2.changeCounterSheetState(false);
                        userContPanCount--;
                        addCounterSheet.Enabled = true;
                        addCounterSheet.Visible = true;
                        ClientSize = new Size(1080, 257);
                        break;

                    case 4:
                        counterSheet5.Enabled = false;
                        counterSheet5.Visible = false;
                        counterSheet2.changeCounterSheetState(false);
                        userContPanCount--;
                        addCounterSheet.Enabled = true;
                        addCounterSheet.Visible = true;
                        ClientSize = new Size(864, 257);
                        
                        break;

                    case 3:
                        counterSheet4.Enabled = false;
                        counterSheet4.Visible = false;
                        counterSheet4.changeCounterSheetState(false);
                        userContPanCount--;
                        ClientSize = new Size(648, 257);
                        break;

                    case 2:
                        counterSheet3.Enabled = false;
                        counterSheet3.Visible = false;
                        counterSheet3.changeCounterSheetState(false);
                        userContPanCount--;
                        ClientSize = new Size(432, 257);
                        break;

                    case 1:
                        counterSheet2.Enabled = false;
                        counterSheet2.Visible = false;
                        counterSheet2.changeCounterSheetState(false);
                        userContPanCount--;
                        removeCounterSheet.Enabled = false;
                        removeCounterSheet.Visible = false;
                        ClientSize = new Size(216, 257);
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
        }

        private void counterSheet6_Load(object sender, EventArgs e)
        {

        }
    }

}
