namespace Agile1._2
{
    partial class ExampleGroupScreen
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
            this.GroupsBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GroupsBtn
            // 
            this.GroupsBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.GroupsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupsBtn.ForeColor = System.Drawing.Color.Black;
            this.GroupsBtn.Location = new System.Drawing.Point(16, 81);
            this.GroupsBtn.Name = "GroupsBtn";
            this.GroupsBtn.Size = new System.Drawing.Size(95, 42);
            this.GroupsBtn.TabIndex = 5;
            this.GroupsBtn.Text = "Groups";
            this.GroupsBtn.UseVisualStyleBackColor = false;
            this.GroupsBtn.Click += new System.EventHandler(this.GroupsBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.Red;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Location = new System.Drawing.Point(16, 24);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(95, 42);
            this.HomeBtn.TabIndex = 4;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.White;
            this.TitleLbl.Location = new System.Drawing.Point(190, 24);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(285, 44);
            this.TitleLbl.TabIndex = 3;
            this.TitleLbl.Text = "Example Group";
            // 
            // ExampleGroupScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(482, 953);
            this.Controls.Add(this.GroupsBtn);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.TitleLbl);
            this.Name = "ExampleGroupScreen";
            this.Text = "ExampleGroupScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GroupsBtn;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Label TitleLbl;
    }
}