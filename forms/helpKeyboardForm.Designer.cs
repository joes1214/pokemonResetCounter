﻿namespace pokemonCounterThing {
    partial class helpKeyboardForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(helpKeyboardForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.helpExplainBox = new System.Windows.Forms.RichTextBox();
            this.copyrightButNotReally = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pokemonCounterThing.Properties.Resources.thinkingProgram;
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // helpExplainBox
            // 
            this.helpExplainBox.BackColor = System.Drawing.SystemColors.Menu;
            this.helpExplainBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.helpExplainBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.helpExplainBox.Location = new System.Drawing.Point(198, 14);
            this.helpExplainBox.Name = "helpExplainBox";
            this.helpExplainBox.ReadOnly = true;
            this.helpExplainBox.Size = new System.Drawing.Size(294, 144);
            this.helpExplainBox.TabIndex = 1;
            this.helpExplainBox.Text = resources.GetString("helpExplainBox.Text");
            this.helpExplainBox.TextChanged += new System.EventHandler(this.helpExplainBox_TextChanged);
            // 
            // copyrightButNotReally
            // 
            this.copyrightButNotReally.AutoSize = true;
            this.copyrightButNotReally.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(128)));
            this.copyrightButNotReally.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.copyrightButNotReally.Location = new System.Drawing.Point(283, 164);
            this.copyrightButNotReally.Name = "copyrightButNotReally";
            this.copyrightButNotReally.Size = new System.Drawing.Size(209, 13);
            this.copyrightButNotReally.TabIndex = 2;
            this.copyrightButNotReally.Text = "Program created by Joseph Salcedo";
            // 
            // helpKeyboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 186);
            this.Controls.Add(this.copyrightButNotReally);
            this.Controls.Add(this.helpExplainBox);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "helpKeyboardForm";
            this.Text = "helpKeyboardForm";
            this.Load += new System.EventHandler(this.helpKeyboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox helpExplainBox;
        private System.Windows.Forms.Label copyrightButNotReally;
    }
}