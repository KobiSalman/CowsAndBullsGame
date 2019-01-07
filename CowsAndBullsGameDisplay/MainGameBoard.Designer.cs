namespace CowsAndBullsGameDisplay
{
    public partial class MainGameBoard
    {
        public const int m_UserButtonSize = 54;
        public const int m_DisplayButtonSize = 18;
        public static int m_HeightDifferenceBetweenGuessLines = m_UserButtonSize + 10;
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponents()
        {
            //this.SizeChanged = false;
            this.ComputerSequenceButton1 = new System.Windows.Forms.Button();
            this.ComputerSequenceButton2 = new System.Windows.Forms.Button();
            this.ComputerSequenceButton3 = new System.Windows.Forms.Button();
            this.ComputerSequenceButton4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComputerSequenceButton1
            // 
            this.ComputerSequenceButton1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ComputerSequenceButton1.Enabled = false;
            this.ComputerSequenceButton1.Location = new System.Drawing.Point(13, 13);
            this.ComputerSequenceButton1.Name = "ComputerSequenceButton1";
            this.ComputerSequenceButton1.Size = new System.Drawing.Size(m_UserButtonSize, m_UserButtonSize);
            this.ComputerSequenceButton1.TabIndex = 0;
            this.ComputerSequenceButton1.UseVisualStyleBackColor = false;
            // 
            // ComputerSequenceButton2
            // 
            this.ComputerSequenceButton2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ComputerSequenceButton2.Enabled = false;
            this.ComputerSequenceButton2.Location = new System.Drawing.Point(73, 13);
            this.ComputerSequenceButton2.Name = "ComputerSequenceButton2";
            this.ComputerSequenceButton2.Size = new System.Drawing.Size(m_UserButtonSize, m_UserButtonSize);
            this.ComputerSequenceButton2.TabIndex = 0;
            this.ComputerSequenceButton2.UseVisualStyleBackColor = false;
            // 
            // ComputerSequenceButton3
            // 
            this.ComputerSequenceButton3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ComputerSequenceButton3.Enabled = false;
            this.ComputerSequenceButton3.Location = new System.Drawing.Point(134, 13);
            this.ComputerSequenceButton3.Name = "ComputerSequenceButton3";
            this.ComputerSequenceButton3.Size = new System.Drawing.Size(m_UserButtonSize, m_UserButtonSize);
            this.ComputerSequenceButton3.TabIndex = 0;
            this.ComputerSequenceButton3.UseVisualStyleBackColor = false;
            // 
            // ComputerSequenceButton4
            // 
            this.ComputerSequenceButton4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ComputerSequenceButton4.Enabled = false;
            this.ComputerSequenceButton4.Location = new System.Drawing.Point(195, 13);
            this.ComputerSequenceButton4.Name = "ComputerSequenceButton4";
            this.ComputerSequenceButton4.Size = new System.Drawing.Size(m_UserButtonSize, m_UserButtonSize);
            this.ComputerSequenceButton4.TabIndex = 0;
            this.ComputerSequenceButton4.UseVisualStyleBackColor = false;

            m_ComputerSequenceButtonsList.Add(this.ComputerSequenceButton1);
            m_ComputerSequenceButtonsList.Add(this.ComputerSequenceButton2);
            m_ComputerSequenceButtonsList.Add(this.ComputerSequenceButton3);
            m_ComputerSequenceButtonsList.Add(this.ComputerSequenceButton4);

            int m_NewHeightDifferenceBetweenGuessLines = m_HeightDifferenceBetweenGuessLines;
            for (int i = 0; i < CowsAndBullsGameDisplay.NumberOfChances.m_NumberOfGuesses; i++)
            {
                GuessLine guessLineList = new GuessLine();
                this.UserSequenceButton1 = new System.Windows.Forms.Button();
                this.UserSequenceButton2 = new System.Windows.Forms.Button();
                this.UserSequenceButton3 = new System.Windows.Forms.Button();
                this.UserSequenceButton4 = new System.Windows.Forms.Button();
                this.ChoiceButton = new System.Windows.Forms.Button();
                this.DiaplayResultButton1 = new System.Windows.Forms.Button();
                this.DiaplayResultButton2 = new System.Windows.Forms.Button();
                this.DiaplayResultButton3 = new System.Windows.Forms.Button();
                this.DiaplayResultButton4 = new System.Windows.Forms.Button();
                // 
                // UserSequenceButton1
                // 
                this.UserSequenceButton1.BackColor = System.Drawing.SystemColors.Control;
                this.UserSequenceButton1.Location = new System.Drawing.Point(17, 20 + m_NewHeightDifferenceBetweenGuessLines);
                this.UserSequenceButton1.Name = "UserSequenceButton1";
                this.UserSequenceButton1.Size = new System.Drawing.Size(m_UserButtonSize, m_UserButtonSize);
                this.UserSequenceButton1.TabIndex = 1;
                this.UserSequenceButton1.UseVisualStyleBackColor = false;
                this.UserSequenceButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserSequenceButton1_MouseClick);
                // 
                // UserSequenceButton2
                // 
                this.UserSequenceButton2.BackColor = System.Drawing.SystemColors.Control;
                this.UserSequenceButton2.Location = new System.Drawing.Point(77, 20 + m_NewHeightDifferenceBetweenGuessLines);
                this.UserSequenceButton2.Name = "UserSequenceButton2";
                this.UserSequenceButton2.Size = new System.Drawing.Size(m_UserButtonSize, m_UserButtonSize);
                this.UserSequenceButton2.TabIndex = 1;
                this.UserSequenceButton2.UseVisualStyleBackColor = false;
                this.UserSequenceButton2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserSequenceButton2_MouseClick);
                // 
                // UserSequenceButton3
                // 
                this.UserSequenceButton3.BackColor = System.Drawing.SystemColors.Control;
                this.UserSequenceButton3.Location = new System.Drawing.Point(136, 20 + m_NewHeightDifferenceBetweenGuessLines);
                this.UserSequenceButton3.Name = "UserSequenceButton3";
                this.UserSequenceButton3.Size = new System.Drawing.Size(m_UserButtonSize, m_UserButtonSize);
                this.UserSequenceButton3.TabIndex = 1;
                this.UserSequenceButton3.UseVisualStyleBackColor = false;
                this.UserSequenceButton3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserSequenceButton3_MouseClick);
                // 
                // UserSequenceButton4
                // 
                this.UserSequenceButton4.BackColor = System.Drawing.SystemColors.Control;
                this.UserSequenceButton4.Location = new System.Drawing.Point(195, 20 + m_NewHeightDifferenceBetweenGuessLines);
                this.UserSequenceButton4.Name = "UserSequenceButton4";
                this.UserSequenceButton4.Size = new System.Drawing.Size(m_UserButtonSize, m_UserButtonSize);
                this.UserSequenceButton4.TabIndex = 1;
                this.UserSequenceButton4.UseVisualStyleBackColor = false;
                this.UserSequenceButton4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserSequenceButton4_MouseClick);
                // 
                // ChoiceButton
                // 
                this.ChoiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
                this.ChoiceButton.Location = new System.Drawing.Point(257, 35 + m_NewHeightDifferenceBetweenGuessLines);
                this.ChoiceButton.Name = "ChoiceButton";
                this.ChoiceButton.Size = new System.Drawing.Size(38, 22);
                this.ChoiceButton.TabIndex = 2;
                this.ChoiceButton.Text = "-->>";
                this.ChoiceButton.UseVisualStyleBackColor = true;
                this.ChoiceButton.Enabled = false;
                this.ChoiceButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChoiceButton_MouseClick);
                // 
                // DiaplayResultButton1
                // 
                this.DiaplayResultButton1.Enabled = false;
                this.DiaplayResultButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
                this.DiaplayResultButton1.Location = new System.Drawing.Point(312, 20 + m_NewHeightDifferenceBetweenGuessLines);
                this.DiaplayResultButton1.Name = "DiaplayResultButton1";
                this.DiaplayResultButton1.Size = new System.Drawing.Size(m_DisplayButtonSize, m_DisplayButtonSize);
                this.DiaplayResultButton1.TabIndex = 3;
                this.DiaplayResultButton1.UseVisualStyleBackColor = true;
                // 
                // DiaplayResultButton2
                // 
                this.DiaplayResultButton2.Enabled = false;
                this.DiaplayResultButton2.Location = new System.Drawing.Point(312, 55 + m_NewHeightDifferenceBetweenGuessLines);
                this.DiaplayResultButton2.Name = "DiaplayResultButton2";
                this.DiaplayResultButton2.Size = new System.Drawing.Size(m_DisplayButtonSize, m_DisplayButtonSize);
                this.DiaplayResultButton2.TabIndex = 4;
                this.DiaplayResultButton2.UseVisualStyleBackColor = true;
                // 
                // DiaplayResultButton3
                // 
                this.DiaplayResultButton3.Enabled = false;
                this.DiaplayResultButton3.Location = new System.Drawing.Point(336, 20 + m_NewHeightDifferenceBetweenGuessLines);
                this.DiaplayResultButton3.Name = "DiaplayResultButton3";
                this.DiaplayResultButton3.Size = new System.Drawing.Size(m_DisplayButtonSize, m_DisplayButtonSize);
                this.DiaplayResultButton3.TabIndex = 5;
                this.DiaplayResultButton3.UseVisualStyleBackColor = true;
                // 
                // DiaplayResultButton4
                // 
                this.DiaplayResultButton4.Enabled = false;
                this.DiaplayResultButton4.Location = new System.Drawing.Point(336, 55 + m_NewHeightDifferenceBetweenGuessLines);
                this.DiaplayResultButton4.Name = "DiaplayResultButton4";
                this.DiaplayResultButton4.Size = new System.Drawing.Size(m_DisplayButtonSize, m_DisplayButtonSize);
                this.DiaplayResultButton4.TabIndex = 6;
                this.DiaplayResultButton4.UseVisualStyleBackColor = true;

                guessLineList.m_ChoiceButton = this.ChoiceButton;
                guessLineList.m_UserGuessesResultButtonsList.Add(this.DiaplayResultButton1);
                guessLineList.m_UserGuessesResultButtonsList.Add(this.DiaplayResultButton2);
                guessLineList.m_UserGuessesResultButtonsList.Add(this.DiaplayResultButton3);
                guessLineList.m_UserGuessesResultButtonsList.Add(this.DiaplayResultButton4);
                guessLineList.m_UserSequenceButtonsList.Add(this.UserSequenceButton1);
                guessLineList.m_UserSequenceButtonsList.Add(this.UserSequenceButton2);
                guessLineList.m_UserSequenceButtonsList.Add(this.UserSequenceButton3);
                guessLineList.m_UserSequenceButtonsList.Add(this.UserSequenceButton4);

                m_GuessLinesList.Add(guessLineList);

                this.Controls.Add(this.DiaplayResultButton4);
                this.Controls.Add(this.DiaplayResultButton3);
                this.Controls.Add(this.DiaplayResultButton2);
                this.Controls.Add(this.DiaplayResultButton1);
                this.Controls.Add(this.ChoiceButton);
                this.Controls.Add(this.UserSequenceButton4);
                this.Controls.Add(this.UserSequenceButton3);
                this.Controls.Add(this.UserSequenceButton2);
                this.Controls.Add(this.UserSequenceButton1);

                m_NewHeightDifferenceBetweenGuessLines += m_HeightDifferenceBetweenGuessLines;
            }

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, m_UserButtonSize * (CowsAndBullsGameDisplay.NumberOfChances.m_NumberOfGuesses + 3));
            this.Controls.Add(this.ComputerSequenceButton4);
            this.Controls.Add(this.ComputerSequenceButton3);
            this.Controls.Add(this.ComputerSequenceButton2);
            this.Controls.Add(this.ComputerSequenceButton1);
            this.Name = "MainGameBoard";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bool Pgia";
            this.Load += new System.EventHandler(this.MainGameBoard_Load);
            this.ResumeLayout(false);
            DisabledUserSequenceButtonsList();
        }

        #endregion

        private System.Windows.Forms.Button ComputerSequenceButton1;
        private System.Windows.Forms.Button ComputerSequenceButton2;
        private System.Windows.Forms.Button ComputerSequenceButton3;
        private System.Windows.Forms.Button ComputerSequenceButton4;
        private System.Windows.Forms.Button UserSequenceButton1;
        private System.Windows.Forms.Button UserSequenceButton2;
        private System.Windows.Forms.Button UserSequenceButton3;
        private System.Windows.Forms.Button UserSequenceButton4;
        private System.Windows.Forms.Button ChoiceButton;
        private System.Windows.Forms.Button DiaplayResultButton1;
        private System.Windows.Forms.Button DiaplayResultButton2;
        private System.Windows.Forms.Button DiaplayResultButton3;
        private System.Windows.Forms.Button DiaplayResultButton4;
    }
}