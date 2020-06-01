namespace Agile1._2
{
    partial class ClubsScreen
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
            this.ClubLst = new System.Windows.Forms.ListBox();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.ClubBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(168, 38);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(117, 44);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "Clubs";
            this.TitleLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // ClubLst
            // 
            this.ClubLst.FormattingEnabled = true;
            this.ClubLst.ItemHeight = 16;
            this.ClubLst.Location = new System.Drawing.Point(13, 105);
            this.ClubLst.Name = "ClubLst";
            this.ClubLst.Size = new System.Drawing.Size(457, 388);
            this.ClubLst.TabIndex = 1;
            this.ClubLst.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.Red;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Location = new System.Drawing.Point(13, 12);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(93, 36);
            this.HomeBtn.TabIndex = 2;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // ClubBtn
            // 
            this.ClubBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClubBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClubBtn.ForeColor = System.Drawing.Color.White;
            this.ClubBtn.Location = new System.Drawing.Point(367, 519);
            this.ClubBtn.Name = "ClubBtn";
            this.ClubBtn.Size = new System.Drawing.Size(103, 47);
            this.ClubBtn.TabIndex = 3;
            this.ClubBtn.Text = "Enter";
            this.ClubBtn.UseVisualStyleBackColor = false;
            this.ClubBtn.Click += new System.EventHandler(this.ClubBtn_Click);
            // 
            // ClubsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(482, 953);
            this.Controls.Add(this.ClubBtn);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.ClubLst);
            this.Controls.Add(this.TitleLbl);
            this.Name = "ClubsScreen";
            this.Text = "Clubs Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.ListBox ClubLst;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button ClubBtn;
    }
}