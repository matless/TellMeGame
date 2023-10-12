namespace TellMe
{
    partial class tellMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tellMe));
            this.submitButton = new System.Windows.Forms.Button();
            this.questionBox = new System.Windows.Forms.TextBox();
            this.answerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.submitButton.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.submitButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.submitButton.Location = new System.Drawing.Point(18, 617);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(327, 57);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Tell me!";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // questionBox
            // 
            this.questionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.questionBox.Location = new System.Drawing.Point(18, 558);
            this.questionBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.questionBox.Multiline = true;
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(325, 47);
            this.questionBox.TabIndex = 1;
            this.questionBox.Text = "Ask your question here...";
            // 
            // answerLabel
            // 
            this.answerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.answerLabel.BackColor = System.Drawing.Color.Transparent;
            this.answerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.answerLabel.Location = new System.Drawing.Point(508, 252);
            this.answerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(184, 65);
            this.answerLabel.TabIndex = 2;
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tellMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.questionBox);
            this.Controls.Add(this.submitButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "tellMe";
            this.Text = "Tell me!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox questionBox;
        private System.Windows.Forms.Label answerLabel;
    }
}

