namespace Agile1._2
{
    partial class HomeScreen
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
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.ClubsBtn = new System.Windows.Forms.Button();
            this.GroupsBtn = new System.Windows.Forms.Button();
            this.SignOutBtn = new System.Windows.Forms.Button();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.EventsLbl = new System.Windows.Forms.Label();
            this.GroupEventsLst = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupMeetingLst = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackColor = System.Drawing.Color.Purple;
            this.SettingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBtn.ForeColor = System.Drawing.Color.White;
            this.SettingsBtn.Location = new System.Drawing.Point(12, 743);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(195, 130);
            this.SettingsBtn.TabIndex = 20;
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.UseVisualStyleBackColor = false;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // ClubsBtn
            // 
            this.ClubsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClubsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClubsBtn.Location = new System.Drawing.Point(275, 612);
            this.ClubsBtn.Name = "ClubsBtn";
            this.ClubsBtn.Size = new System.Drawing.Size(195, 130);
            this.ClubsBtn.TabIndex = 19;
            this.ClubsBtn.Text = "Clubs";
            this.ClubsBtn.UseVisualStyleBackColor = false;
            this.ClubsBtn.Click += new System.EventHandler(this.ClubsBtn_Click);
            // 
            // GroupsBtn
            // 
            this.GroupsBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.GroupsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupsBtn.Location = new System.Drawing.Point(275, 743);
            this.GroupsBtn.Name = "GroupsBtn";
            this.GroupsBtn.Size = new System.Drawing.Size(195, 130);
            this.GroupsBtn.TabIndex = 18;
            this.GroupsBtn.Text = "Groups";
            this.GroupsBtn.UseVisualStyleBackColor = false;
            this.GroupsBtn.Click += new System.EventHandler(this.GroupsBtn_Click);
            // 
            // SignOutBtn
            // 
            this.SignOutBtn.BackColor = System.Drawing.Color.Indigo;
            this.SignOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOutBtn.ForeColor = System.Drawing.Color.White;
            this.SignOutBtn.Location = new System.Drawing.Point(12, 612);
            this.SignOutBtn.Name = "SignOutBtn";
            this.SignOutBtn.Size = new System.Drawing.Size(195, 130);
            this.SignOutBtn.TabIndex = 17;
            this.SignOutBtn.Text = "Sign Out";
            this.SignOutBtn.UseVisualStyleBackColor = false;
            this.SignOutBtn.Click += new System.EventHandler(this.SignOutBtn_Click);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(175, 85);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(122, 44);
            this.TitleLbl.TabIndex = 16;
            this.TitleLbl.Text = "Home";
            // 
            // EventsLbl
            // 
            this.EventsLbl.AutoSize = true;
            this.EventsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventsLbl.Location = new System.Drawing.Point(250, 160);
            this.EventsLbl.Name = "EventsLbl";
            this.EventsLbl.Size = new System.Drawing.Size(176, 32);
            this.EventsLbl.TabIndex = 15;
            this.EventsLbl.Text = "Club Events:";
            // 
            // GroupEventsLst
            // 
            this.GroupEventsLst.FormattingEnabled = true;
            this.GroupEventsLst.ItemHeight = 16;
            this.GroupEventsLst.Location = new System.Drawing.Point(256, 195);
            this.GroupEventsLst.Name = "GroupEventsLst";
            this.GroupEventsLst.Size = new System.Drawing.Size(214, 388);
            this.GroupEventsLst.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Group Meetings:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GroupMeetingLst
            // 
            this.GroupMeetingLst.FormattingEnabled = true;
            this.GroupMeetingLst.ItemHeight = 16;
            this.GroupMeetingLst.Location = new System.Drawing.Point(12, 195);
            this.GroupMeetingLst.Name = "GroupMeetingLst";
            this.GroupMeetingLst.Size = new System.Drawing.Size(214, 388);
            this.GroupMeetingLst.TabIndex = 21;
            this.GroupMeetingLst.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(482, 953);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupMeetingLst);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.ClubsBtn);
            this.Controls.Add(this.GroupsBtn);
            this.Controls.Add(this.SignOutBtn);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.EventsLbl);
            this.Controls.Add(this.GroupEventsLst);
            this.Name = "HomeScreen";
            this.Text = "Home Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.Button ClubsBtn;
        private System.Windows.Forms.Button GroupsBtn;
        private System.Windows.Forms.Button SignOutBtn;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Label EventsLbl;
        private System.Windows.Forms.ListBox GroupEventsLst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox GroupMeetingLst;
    }
}