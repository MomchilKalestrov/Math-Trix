namespace MathTrix
{
    partial class Customize
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
            submitButton = new System.Windows.Forms.Button();
            colorDialog = new System.Windows.Forms.ColorDialog();
            p1ColourLabel = new System.Windows.Forms.Label();
            p1PickColourButton = new System.Windows.Forms.Button();
            colourPanel = new System.Windows.Forms.Panel();
            p2ColourPreview = new System.Windows.Forms.PictureBox();
            p1ColourPreview = new System.Windows.Forms.PictureBox();
            p2PickColourButton = new System.Windows.Forms.Button();
            p2ColourLabel = new System.Windows.Forms.Label();
            sizeSplitContainer = new System.Windows.Forms.SplitContainer();
            xNumericUpDown = new System.Windows.Forms.NumericUpDown();
            xLabel = new System.Windows.Forms.Label();
            yNumericUpDown = new System.Windows.Forms.NumericUpDown();
            yLabel = new System.Windows.Forms.Label();
            botOpponentCheckBox = new System.Windows.Forms.CheckBox();
            colourPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)p2ColourPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)p1ColourPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sizeSplitContainer).BeginInit();
            sizeSplitContainer.Panel1.SuspendLayout();
            sizeSplitContainer.Panel2.SuspendLayout();
            sizeSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)xNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // submitButton
            // 
            submitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            submitButton.Location = new System.Drawing.Point(0, 122);
            submitButton.Name = "submitButton";
            submitButton.Size = new System.Drawing.Size(267, 39);
            submitButton.TabIndex = 0;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += returnData;
            // 
            // p1ColourLabel
            // 
            p1ColourLabel.AutoSize = true;
            p1ColourLabel.Location = new System.Drawing.Point(3, 3);
            p1ColourLabel.Name = "p1ColourLabel";
            p1ColourLabel.Size = new System.Drawing.Size(88, 15);
            p1ColourLabel.TabIndex = 5;
            p1ColourLabel.Text = "Player 1 colour:";
            // 
            // p1PickColourButton
            // 
            p1PickColourButton.Location = new System.Drawing.Point(3, 21);
            p1PickColourButton.Name = "p1PickColourButton";
            p1PickColourButton.Size = new System.Drawing.Size(57, 23);
            p1PickColourButton.TabIndex = 7;
            p1PickColourButton.Text = "Pick";
            p1PickColourButton.UseVisualStyleBackColor = true;
            p1PickColourButton.Click += p1PickColourButton_Click;
            // 
            // colourPanel
            // 
            colourPanel.Controls.Add(p2ColourPreview);
            colourPanel.Controls.Add(p1ColourPreview);
            colourPanel.Controls.Add(p2PickColourButton);
            colourPanel.Controls.Add(p1PickColourButton);
            colourPanel.Controls.Add(p2ColourLabel);
            colourPanel.Controls.Add(p1ColourLabel);
            colourPanel.Dock = System.Windows.Forms.DockStyle.Top;
            colourPanel.Location = new System.Drawing.Point(0, 47);
            colourPanel.Name = "colourPanel";
            colourPanel.Size = new System.Drawing.Size(267, 47);
            colourPanel.TabIndex = 9;
            // 
            // p2ColourPreview
            // 
            p2ColourPreview.BackColor = System.Drawing.Color.White;
            p2ColourPreview.Location = new System.Drawing.Point(197, 26);
            p2ColourPreview.Name = "p2ColourPreview";
            p2ColourPreview.Size = new System.Drawing.Size(13, 13);
            p2ColourPreview.TabIndex = 9;
            p2ColourPreview.TabStop = false;
            // 
            // p1ColourPreview
            // 
            p1ColourPreview.BackColor = System.Drawing.Color.White;
            p1ColourPreview.Location = new System.Drawing.Point(63, 26);
            p1ColourPreview.Name = "p1ColourPreview";
            p1ColourPreview.Size = new System.Drawing.Size(13, 13);
            p1ColourPreview.TabIndex = 8;
            p1ColourPreview.TabStop = false;
            // 
            // p2PickColourButton
            // 
            p2PickColourButton.Location = new System.Drawing.Point(137, 21);
            p2PickColourButton.Name = "p2PickColourButton";
            p2PickColourButton.Size = new System.Drawing.Size(57, 23);
            p2PickColourButton.TabIndex = 7;
            p2PickColourButton.Text = "Pick";
            p2PickColourButton.UseVisualStyleBackColor = true;
            p2PickColourButton.Click += p2PickColourButton_Click;
            // 
            // p2ColourLabel
            // 
            p2ColourLabel.AutoSize = true;
            p2ColourLabel.Location = new System.Drawing.Point(137, 3);
            p2ColourLabel.Name = "p2ColourLabel";
            p2ColourLabel.Size = new System.Drawing.Size(88, 15);
            p2ColourLabel.TabIndex = 5;
            p2ColourLabel.Text = "Player 2 colour:";
            // 
            // sizeSplitContainer
            // 
            sizeSplitContainer.Dock = System.Windows.Forms.DockStyle.Top;
            sizeSplitContainer.Location = new System.Drawing.Point(0, 0);
            sizeSplitContainer.Name = "sizeSplitContainer";
            // 
            // sizeSplitContainer.Panel1
            // 
            sizeSplitContainer.Panel1.Controls.Add(xNumericUpDown);
            sizeSplitContainer.Panel1.Controls.Add(xLabel);
            // 
            // sizeSplitContainer.Panel2
            // 
            sizeSplitContainer.Panel2.Controls.Add(yNumericUpDown);
            sizeSplitContainer.Panel2.Controls.Add(yLabel);
            sizeSplitContainer.Size = new System.Drawing.Size(267, 47);
            sizeSplitContainer.SplitterDistance = 133;
            sizeSplitContainer.SplitterWidth = 1;
            sizeSplitContainer.TabIndex = 11;
            // 
            // xNumericUpDown
            // 
            xNumericUpDown.Location = new System.Drawing.Point(3, 21);
            xNumericUpDown.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            xNumericUpDown.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            xNumericUpDown.Name = "xNumericUpDown";
            xNumericUpDown.Size = new System.Drawing.Size(127, 23);
            xNumericUpDown.TabIndex = 11;
            xNumericUpDown.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // xLabel
            // 
            xLabel.AutoSize = true;
            xLabel.Location = new System.Drawing.Point(3, 3);
            xLabel.Name = "xLabel";
            xLabel.Size = new System.Drawing.Size(128, 15);
            xLabel.TabIndex = 3;
            xLabel.Text = "Ammount of columns:";
            // 
            // yNumericUpDown
            // 
            yNumericUpDown.Location = new System.Drawing.Point(3, 21);
            yNumericUpDown.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            yNumericUpDown.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            yNumericUpDown.Name = "yNumericUpDown";
            yNumericUpDown.Size = new System.Drawing.Size(127, 23);
            yNumericUpDown.TabIndex = 12;
            yNumericUpDown.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // yLabel
            // 
            yLabel.AutoSize = true;
            yLabel.Location = new System.Drawing.Point(3, 3);
            yLabel.Name = "yLabel";
            yLabel.Size = new System.Drawing.Size(107, 15);
            yLabel.TabIndex = 5;
            yLabel.Text = "Ammount of rows:";
            // 
            // botOpponentCheckBox
            // 
            botOpponentCheckBox.AutoSize = true;
            botOpponentCheckBox.Location = new System.Drawing.Point(3, 97);
            botOpponentCheckBox.Name = "botOpponentCheckBox";
            botOpponentCheckBox.Size = new System.Drawing.Size(177, 19);
            botOpponentCheckBox.TabIndex = 12;
            botOpponentCheckBox.Text = "Play against an AI opponent.";
            botOpponentCheckBox.UseVisualStyleBackColor = true;
            // 
            // Customize
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(267, 161);
            Controls.Add(botOpponentCheckBox);
            Controls.Add(colourPanel);
            Controls.Add(submitButton);
            Controls.Add(sizeSplitContainer);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(283, 174);
            Name = "Customize";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Customize";
            TopMost = true;
            colourPanel.ResumeLayout(false);
            colourPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)p2ColourPreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)p1ColourPreview).EndInit();
            sizeSplitContainer.Panel1.ResumeLayout(false);
            sizeSplitContainer.Panel1.PerformLayout();
            sizeSplitContainer.Panel2.ResumeLayout(false);
            sizeSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sizeSplitContainer).EndInit();
            sizeSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)xNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)yNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label p1ColourLabel;
        private System.Windows.Forms.Button p1PickColourButton;
        private System.Windows.Forms.Panel colourPanel;
        private System.Windows.Forms.Button p2PickColourButton;
        private System.Windows.Forms.Label p2ColourLabel;
        private System.Windows.Forms.SplitContainer sizeSplitContainer;
        private System.Windows.Forms.NumericUpDown xNumericUpDown;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.NumericUpDown yNumericUpDown;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.CheckBox botOpponentCheckBox;
        private System.Windows.Forms.PictureBox p1ColourPreview;
        private System.Windows.Forms.PictureBox p2ColourPreview;
    }
}