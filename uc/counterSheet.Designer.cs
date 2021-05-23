namespace pokemonCounterThing {
    partial class counterSheet {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pkmnGameName = new System.Windows.Forms.TextBox();
            this.resetCounterBox = new System.Windows.Forms.TextBox();
            this.setStartingVal = new System.Windows.Forms.TextBox();
            this.setStartValButt = new System.Windows.Forms.Button();
            this.resetButt = new System.Windows.Forms.Button();
            this.decrementButt = new System.Windows.Forms.Button();
            this.focusLabel = new System.Windows.Forms.Label();
            this.incrementValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.incrementValue)).BeginInit();
            this.SuspendLayout();
            // 
            // pkmnGameName
            // 
            this.pkmnGameName.Location = new System.Drawing.Point(16, 20);
            this.pkmnGameName.Name = "pkmnGameName";
            this.pkmnGameName.Size = new System.Drawing.Size(164, 20);
            this.pkmnGameName.TabIndex = 0;
            this.pkmnGameName.Text = "Pokemon Game Name";
            this.pkmnGameName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pkmnGameName.TextChanged += new System.EventHandler(this.pkmnGameName_TextChanged);
            // 
            // resetCounterBox
            // 
            this.resetCounterBox.BackColor = System.Drawing.SystemColors.Control;
            this.resetCounterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetCounterBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.resetCounterBox.Location = new System.Drawing.Point(52, 46);
            this.resetCounterBox.Name = "resetCounterBox";
            this.resetCounterBox.ReadOnly = true;
            this.resetCounterBox.Size = new System.Drawing.Size(128, 45);
            this.resetCounterBox.TabIndex = 1;
            this.resetCounterBox.Text = "0";
            this.resetCounterBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resetCounterBox.TextChanged += new System.EventHandler(this.resetCounterBox_TextChanged);
            // 
            // setStartingVal
            // 
            this.setStartingVal.Location = new System.Drawing.Point(16, 97);
            this.setStartingVal.MaxLength = 2;
            this.setStartingVal.Name = "setStartingVal";
            this.setStartingVal.Size = new System.Drawing.Size(100, 20);
            this.setStartingVal.TabIndex = 3;
            this.setStartingVal.Text = "Set Starting Value";
            this.setStartingVal.TextChanged += new System.EventHandler(this.setStartingVal_TextChanged);
            // 
            // setStartValButt
            // 
            this.setStartValButt.Location = new System.Drawing.Point(122, 97);
            this.setStartValButt.Name = "setStartValButt";
            this.setStartValButt.Size = new System.Drawing.Size(58, 23);
            this.setStartValButt.TabIndex = 4;
            this.setStartValButt.Text = "Set";
            this.setStartValButt.UseVisualStyleBackColor = true;
            this.setStartValButt.Click += new System.EventHandler(this.setStartValButt_Click);
            // 
            // resetButt
            // 
            this.resetButt.Location = new System.Drawing.Point(122, 133);
            this.resetButt.Name = "resetButt";
            this.resetButt.Size = new System.Drawing.Size(58, 35);
            this.resetButt.TabIndex = 5;
            this.resetButt.Text = "Reset";
            this.resetButt.UseVisualStyleBackColor = true;
            this.resetButt.Click += new System.EventHandler(this.resetButt_Click);
            // 
            // decrementButt
            // 
            this.decrementButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.decrementButt.Location = new System.Drawing.Point(16, 53);
            this.decrementButt.Name = "decrementButt";
            this.decrementButt.Size = new System.Drawing.Size(30, 30);
            this.decrementButt.TabIndex = 2;
            this.decrementButt.Text = "-1";
            this.decrementButt.UseVisualStyleBackColor = true;
            this.decrementButt.Click += new System.EventHandler(this.decrementButt_Click);
            // 
            // focusLabel
            // 
            this.focusLabel.AutoSize = true;
            this.focusLabel.Location = new System.Drawing.Point(20, 144);
            this.focusLabel.Name = "focusLabel";
            this.focusLabel.Size = new System.Drawing.Size(25, 13);
            this.focusLabel.TabIndex = 6;
            this.focusLabel.Text = "      ";
            this.focusLabel.Click += new System.EventHandler(this.focusLabel_Click);
            // 
            // incrementValue
            // 
            this.incrementValue.Enabled = false;
            this.incrementValue.Location = new System.Drawing.Point(16, 148);
            this.incrementValue.Name = "incrementValue";
            this.incrementValue.Size = new System.Drawing.Size(100, 20);
            this.incrementValue.TabIndex = 8;
            this.incrementValue.ValueChanged += new System.EventHandler(this.incrementValue_ValueChanged);
            // 
            // counterSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.incrementValue);
            this.Controls.Add(this.focusLabel);
            this.Controls.Add(this.decrementButt);
            this.Controls.Add(this.resetButt);
            this.Controls.Add(this.setStartValButt);
            this.Controls.Add(this.setStartingVal);
            this.Controls.Add(this.resetCounterBox);
            this.Controls.Add(this.pkmnGameName);
            this.Name = "counterSheet";
            this.Size = new System.Drawing.Size(196, 189);
            this.Load += new System.EventHandler(this.counterSheet_Load);
            this.Click += new System.EventHandler(this.counterSheet_Click);
            this.DoubleClick += new System.EventHandler(this.counterSheet_Click);
            ((System.ComponentModel.ISupportInitialize)(this.incrementValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pkmnGameName;
        private System.Windows.Forms.TextBox resetCounterBox;
        private System.Windows.Forms.TextBox setStartingVal;
        private System.Windows.Forms.Button setStartValButt;
        private System.Windows.Forms.Button resetButt;
        private System.Windows.Forms.Button decrementButt;
        private System.Windows.Forms.Label focusLabel;
        private System.Windows.Forms.NumericUpDown incrementValue;
    }
}
