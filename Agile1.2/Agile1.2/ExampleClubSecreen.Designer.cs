namespace Agile1._2
{
    partial class ExampleClubSecreen
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
            this.TitleLbl = new System.Windows.Forms.Label();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.ClubsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(186, 12);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(257, 44);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "Example Club";
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.Red;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Location = new System.Drawing.Point(12, 12);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(95, 42);
            this.HomeBtn.TabIndex = 1;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // ClubsBtn
            // 
            this.ClubsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClubsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClubsBtn.ForeColor = System.Drawing.Color.White;
            this.ClubsBtn.Location = new System.Drawing.Point(12, 69);
            this.ClubsBtn.Name = "ClubsBtn";
            this.ClubsBtn.Size = new System.Drawing.Size(95, 42);
            this.ClubsBtn.TabIndex = 2;
            this.ClubsBtn.Text = "Clubs";
            this.ClubsBtn.UseVisualStyleBackColor = false;
            this.ClubsBtn.Click += new System.EventHandler(this.ClubsBtn_Click);
            // 
            // ExampleClubSecreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(482, 953);
            this.Controls.Add(this.ClubsBtn);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.TitleLbl);
            this.Name = "ExampleClubSecreen";
            this.Text = "ExampleClubSecreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button ClubsBtn;
    }
}