namespace RelationManyToMany
{
    partial class Form1
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
            this.BtnAddRecords = new System.Windows.Forms.Button();
            this.BtnUsersToGroup = new System.Windows.Forms.Button();
            this.BtnGroupsToUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAddRecords
            // 
            this.BtnAddRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnAddRecords.Location = new System.Drawing.Point(12, 14);
            this.BtnAddRecords.Name = "BtnAddRecords";
            this.BtnAddRecords.Size = new System.Drawing.Size(342, 44);
            this.BtnAddRecords.TabIndex = 0;
            this.BtnAddRecords.Text = "Add Records";
            this.BtnAddRecords.UseVisualStyleBackColor = true;
            this.BtnAddRecords.Click += new System.EventHandler(this.BtnAddRecords_Click);
            // 
            // BtnUsersToGroup
            // 
            this.BtnUsersToGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnUsersToGroup.Location = new System.Drawing.Point(12, 78);
            this.BtnUsersToGroup.Name = "BtnUsersToGroup";
            this.BtnUsersToGroup.Size = new System.Drawing.Size(342, 44);
            this.BtnUsersToGroup.TabIndex = 1;
            this.BtnUsersToGroup.Text = "Add Users To Group";
            this.BtnUsersToGroup.UseVisualStyleBackColor = true;
            this.BtnUsersToGroup.Click += new System.EventHandler(this.BtnUsersToGroup_Click);
            // 
            // BtnGroupsToUser
            // 
            this.BtnGroupsToUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnGroupsToUser.Location = new System.Drawing.Point(12, 143);
            this.BtnGroupsToUser.Name = "BtnGroupsToUser";
            this.BtnGroupsToUser.Size = new System.Drawing.Size(342, 44);
            this.BtnGroupsToUser.TabIndex = 2;
            this.BtnGroupsToUser.Text = "Add Groups To User";
            this.BtnGroupsToUser.UseVisualStyleBackColor = true;
            this.BtnGroupsToUser.Click += new System.EventHandler(this.BtnGroupsToUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 209);
            this.Controls.Add(this.BtnGroupsToUser);
            this.Controls.Add(this.BtnUsersToGroup);
            this.Controls.Add(this.BtnAddRecords);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAddRecords;
        private System.Windows.Forms.Button BtnUsersToGroup;
        private System.Windows.Forms.Button BtnGroupsToUser;
    }
}

