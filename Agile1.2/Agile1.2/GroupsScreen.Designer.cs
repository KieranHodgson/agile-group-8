namespace Agile1._2
{
    partial class GroupsScreen
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
            this.GroupBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TieleLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GroupBtn
            // 
            this.GroupBtn.BackColor = System.Drawing.Color.Navy;
            this.GroupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBtn.ForeColor = System.Drawing.Color.White;
            this.GroupBtn.Location = new System.Drawing.Point(366, 521);
            this.GroupBtn.Name = "GroupBtn";
            this.GroupBtn.Size = new System.Drawing.Size(103, 47);
            this.GroupBtn.TabIndex = 7;
            this.GroupBtn.Text = "Enter";
            this.GroupBtn.UseVisualStyleBackColor = false;
            this.GroupBtn.Click += new System.EventHandler(this.GroupBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.Red;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Location = new System.Drawing.Point(12, 14);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(93, 36);
            this.HomeBtn.TabIndex = 6;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 107);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(457, 388);
            this.listBox1.TabIndex = 5;
            // 
            // TieleLbl
            // 
            this.TieleLbl.AutoSize = true;
            this.TieleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TieleLbl.ForeColor = System.Drawing.Color.Black;
            this.TieleLbl.Location = new System.Drawing.Point(167, 40);
            this.TieleLbl.Name = "TieleLbl";
            this.TieleLbl.Size = new System.Drawing.Size(145, 44);
            this.TieleLbl.TabIndex = 4;
            this.TieleLbl.Text = "Groups";
            this.TieleLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // GroupsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(482, 953);
            this.Controls.Add(this.GroupBtn);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TieleLbl);
            this.Name = "GroupsScreen";
            this.Text = "Groups Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GroupBtn;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label TieleLbl;
    }
}