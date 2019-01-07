namespace CowsAndBullsGameDisplay
{
    partial class PickAColor
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
            this.PurpleButton = new System.Windows.Forms.Button();
            this.RedButton = new System.Windows.Forms.Button();
            this.GreenButton = new System.Windows.Forms.Button();
            this.AzureButton = new System.Windows.Forms.Button();
            this.BlueButton = new System.Windows.Forms.Button();
            this.YellowButton = new System.Windows.Forms.Button();
            this.BrownButton = new System.Windows.Forms.Button();
            this.WhiteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PurpleButton
            // 
            this.PurpleButton.BackColor = System.Drawing.Color.Purple;
            this.PurpleButton.Location = new System.Drawing.Point(12, 12);
            this.PurpleButton.Name = "PurpleButton";
            this.PurpleButton.Size = new System.Drawing.Size(52, 46);
            this.PurpleButton.TabIndex = 0;
            this.PurpleButton.UseVisualStyleBackColor = false;
            this.PurpleButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PurpleButton_MouseClick);
            // 
            // RedButton
            // 
            this.RedButton.BackColor = System.Drawing.Color.Red;
            this.RedButton.Location = new System.Drawing.Point(69, 12);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(50, 46);
            this.RedButton.TabIndex = 0;
            this.RedButton.UseVisualStyleBackColor = false;
            this.RedButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RedButton_MouseClick);
            // 
            // GreenButton
            // 
            this.GreenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.GreenButton.Location = new System.Drawing.Point(125, 12);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(52, 46);
            this.GreenButton.TabIndex = 0;
            this.GreenButton.UseVisualStyleBackColor = false;
            this.GreenButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GreenButton_MouseClick);
            // 
            // AzureButton
            // 
            this.AzureButton.BackColor = System.Drawing.Color.Cyan;
            this.AzureButton.Location = new System.Drawing.Point(181, 12);
            this.AzureButton.Name = "AzureButton";
            this.AzureButton.Size = new System.Drawing.Size(50, 46);
            this.AzureButton.TabIndex = 0;
            this.AzureButton.UseVisualStyleBackColor = false;
            this.AzureButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AzureButton_MouseClick);
            // 
            // BlueButton
            // 
            this.BlueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BlueButton.Location = new System.Drawing.Point(14, 64);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Size = new System.Drawing.Size(50, 44);
            this.BlueButton.TabIndex = 0;
            this.BlueButton.UseVisualStyleBackColor = false;
            this.BlueButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BlueButton_MouseClick);
            // 
            // YellowButton
            // 
            this.YellowButton.BackColor = System.Drawing.Color.Yellow;
            this.YellowButton.Location = new System.Drawing.Point(70, 64);
            this.YellowButton.Name = "YellowButton";
            this.YellowButton.Size = new System.Drawing.Size(50, 44);
            this.YellowButton.TabIndex = 0;
            this.YellowButton.UseVisualStyleBackColor = false;
            this.YellowButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.YellowButton_MouseClick);
            // 
            // BrownButton
            // 
            this.BrownButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BrownButton.Location = new System.Drawing.Point(124, 64);
            this.BrownButton.Name = "BrownButton";
            this.BrownButton.Size = new System.Drawing.Size(53, 44);
            this.BrownButton.TabIndex = 0;
            this.BrownButton.UseVisualStyleBackColor = false;
            this.BrownButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BrownButton_MouseClick);
            // 
            // WhiteButton
            // 
            this.WhiteButton.BackColor = System.Drawing.Color.White;
            this.WhiteButton.Location = new System.Drawing.Point(181, 64);
            this.WhiteButton.Name = "WhiteButton";
            this.WhiteButton.Size = new System.Drawing.Size(50, 44);
            this.WhiteButton.TabIndex = 0;
            this.WhiteButton.UseVisualStyleBackColor = false;
            this.WhiteButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WhiteButton_MouseClick);
            // 
            // PickAColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 121);
            this.Controls.Add(this.WhiteButton);
            this.Controls.Add(this.BrownButton);
            this.Controls.Add(this.AzureButton);
            this.Controls.Add(this.YellowButton);
            this.Controls.Add(this.GreenButton);
            this.Controls.Add(this.BlueButton);
            this.Controls.Add(this.RedButton);
            this.Controls.Add(this.PurpleButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PickAColor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pick A Color:";
            this.Load += new System.EventHandler(this.PickAColor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PurpleButton;
        private System.Windows.Forms.Button RedButton;
        private System.Windows.Forms.Button GreenButton;
        private System.Windows.Forms.Button AzureButton;
        private System.Windows.Forms.Button BlueButton;
        private System.Windows.Forms.Button YellowButton;
        private System.Windows.Forms.Button BrownButton;
        private System.Windows.Forms.Button WhiteButton;
    }
}