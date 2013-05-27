namespace JumbleSolver
{
    partial class jumbleSolverApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jumbleSolverApp));
            this.headerLabel = new System.Windows.Forms.Label();
            this.wordLabel = new System.Windows.Forms.Label();
            this.originalWord = new System.Windows.Forms.TextBox();
            this.answerLabel = new System.Windows.Forms.Label();
            this.solvedWord = new System.Windows.Forms.TextBox();
            this.solveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Location = new System.Drawing.Point(190, 23);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(95, 13);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "JUMBLE SOLVER";
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Location = new System.Drawing.Point(12, 58);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(152, 13);
            this.wordLabel.TabIndex = 1;
            this.wordLabel.Text = "ORIGINAL JUMBLED WORD:";
            // 
            // originalWord
            // 
            this.originalWord.Location = new System.Drawing.Point(170, 55);
            this.originalWord.Name = "originalWord";
            this.originalWord.Size = new System.Drawing.Size(190, 20);
            this.originalWord.TabIndex = 2;
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(12, 104);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(65, 13);
            this.answerLabel.TabIndex = 3;
            this.answerLabel.Text = "SOLUTION:";
            // 
            // solvedWord
            // 
            this.solvedWord.Location = new System.Drawing.Point(170, 97);
            this.solvedWord.Name = "solvedWord";
            this.solvedWord.Size = new System.Drawing.Size(190, 20);
            this.solvedWord.TabIndex = 4;
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(86, 142);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(119, 28);
            this.solveButton.TabIndex = 5;
            this.solveButton.Text = "SOLVE";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(290, 142);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(102, 28);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // jumbleSolverApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(514, 212);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.solvedWord);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.originalWord);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.headerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "jumbleSolverApp";
            this.Text = "KARTHIK\'S JUMBLE SOLVER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.TextBox originalWord;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.TextBox solvedWord;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.Button clearButton;
    }
}

