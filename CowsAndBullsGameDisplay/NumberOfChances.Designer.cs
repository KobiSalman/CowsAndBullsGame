namespace CowsAndBullsGameDisplay
{
    partial class NumberOfChances
    {
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

        private void InitializeComponent()
        {
            this.ButtonNumberOfChances = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonNumberOfChances
            // 
            this.ButtonNumberOfChances.Location = new System.Drawing.Point(29, 12);
            this.ButtonNumberOfChances.Name = "ButtonNumberOfChances";
            this.ButtonNumberOfChances.Size = new System.Drawing.Size(212, 26);
            this.ButtonNumberOfChances.TabIndex = 0;
            this.ButtonNumberOfChances.Text = "Number of chances: 4";
            this.ButtonNumberOfChances.UseVisualStyleBackColor = true;
            this.ButtonNumberOfChances.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonNumberOfChances_MouseClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonStart);
            // 
            // NumberOfChances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 110);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ButtonNumberOfChances);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NumberOfChances";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bool Pgia";
            this.Load += new System.EventHandler(this.NumberOfChances_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonNumberOfChances;
        private System.Windows.Forms.Button button2;
    }
}