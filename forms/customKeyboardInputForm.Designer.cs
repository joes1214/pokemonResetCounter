namespace pokemonCounterThing
{
    partial class customKeyboardInputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customKeyboardInputForm));
            this.testLabel = new System.Windows.Forms.Label();
            this.inputValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(119, 33);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(119, 13);
            this.testLabel.TabIndex = 0;
            this.testLabel.Text = "Hit ESC to confirm input";
            // 
            // inputValue
            // 
            this.inputValue.BackColor = System.Drawing.SystemColors.Window;
            this.inputValue.Location = new System.Drawing.Point(128, 49);
            this.inputValue.Name = "inputValue";
            this.inputValue.ReadOnly = true;
            this.inputValue.Size = new System.Drawing.Size(100, 20);
            this.inputValue.TabIndex = 1;
            this.inputValue.Text = "Keyboard Input";
            this.inputValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputValue_KeyDown);
            // 
            // customKeyboardInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 107);
            this.Controls.Add(this.inputValue);
            this.Controls.Add(this.testLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "customKeyboardInputForm";
            this.Text = "Input the key you\'d like to use";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.customKeyboardInput_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.TextBox inputValue;
    }
}