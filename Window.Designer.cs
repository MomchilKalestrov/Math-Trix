using System.Windows.Forms;
using System.Drawing;

namespace MathTrix
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainContainer = new SplitContainer();
            p2ScoreLabel = new Label();
            p1ScoreLabel = new Label();
            generateBoardButton = new Button();
            ((System.ComponentModel.ISupportInitialize)mainContainer).BeginInit();
            mainContainer.Panel1.SuspendLayout();
            mainContainer.SuspendLayout();
            SuspendLayout();
            // 
            // mainContainer
            // 
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.FixedPanel = FixedPanel.Panel1;
            mainContainer.IsSplitterFixed = true;
            mainContainer.Location = new Point(0, 0);
            mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            mainContainer.Panel1.BackColor = Color.White;
            mainContainer.Panel1.Controls.Add(p2ScoreLabel);
            mainContainer.Panel1.Controls.Add(p1ScoreLabel);
            mainContainer.Panel1.Controls.Add(generateBoardButton);
            // 
            // mainContainer.Panel2
            // 
            mainContainer.Panel2.BackColor = Color.White;
            mainContainer.Size = new Size(316, 231);
            mainContainer.SplitterDistance = 100;
            mainContainer.SplitterWidth = 2;
            mainContainer.TabIndex = 0;
            // 
            // p2ScoreLabel
            // 
            p2ScoreLabel.AutoSize = true;
            p2ScoreLabel.Dock = DockStyle.Top;
            p2ScoreLabel.Location = new Point(0, 15);
            p2ScoreLabel.Name = "p2ScoreLabel";
            p2ScoreLabel.Size = new Size(23, 15);
            p2ScoreLabel.TabIndex = 8;
            p2ScoreLabel.Text = "P2:";
            // 
            // p1ScoreLabel
            // 
            p1ScoreLabel.AutoSize = true;
            p1ScoreLabel.Dock = DockStyle.Top;
            p1ScoreLabel.Location = new Point(0, 0);
            p1ScoreLabel.Name = "p1ScoreLabel";
            p1ScoreLabel.Size = new Size(23, 15);
            p1ScoreLabel.TabIndex = 7;
            p1ScoreLabel.Text = "P1:";
            // 
            // generateBoardButton
            // 
            generateBoardButton.Dock = DockStyle.Bottom;
            generateBoardButton.Location = new Point(0, 151);
            generateBoardButton.Name = "generateBoardButton";
            generateBoardButton.Size = new Size(100, 80);
            generateBoardButton.TabIndex = 3;
            generateBoardButton.Text = "Generate Board";
            generateBoardButton.UseVisualStyleBackColor = true;
            generateBoardButton.Click += GenerateBoard;
            // 
            // Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 231);
            Controls.Add(mainContainer);
            HelpButton = true;
            MinimumSize = new Size(332, 270);
            Name = "Window";
            ShowIcon = false;
            Text = "Math Trix";
            ResizeEnd += ResizeWindow;
            SizeChanged += ResizeWindow;
            mainContainer.Panel1.ResumeLayout(false);
            mainContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainContainer).EndInit();
            mainContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer mainContainer;
        private Button generateBoardButton;
        private Label p2ScoreLabel;
        private Label p1ScoreLabel;
    }
}