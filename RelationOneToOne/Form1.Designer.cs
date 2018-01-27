namespace RelationOneToOne
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
            this.BtnAddNewPeople = new System.Windows.Forms.Button();
            this.BtnLoadAddressIncludePerson = new System.Windows.Forms.Button();
            this.BtnLoadPersonIncludeAddress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAddNewPeople
            // 
            this.BtnAddNewPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnAddNewPeople.Location = new System.Drawing.Point(12, 12);
            this.BtnAddNewPeople.Name = "BtnAddNewPeople";
            this.BtnAddNewPeople.Size = new System.Drawing.Size(360, 49);
            this.BtnAddNewPeople.TabIndex = 0;
            this.BtnAddNewPeople.Text = "Add New People";
            this.BtnAddNewPeople.UseVisualStyleBackColor = true;
            this.BtnAddNewPeople.Click += new System.EventHandler(this.BtnAddNewPeople_Click);
            // 
            // BtnLoadAddressIncludePerson
            // 
            this.BtnLoadAddressIncludePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnLoadAddressIncludePerson.Location = new System.Drawing.Point(12, 67);
            this.BtnLoadAddressIncludePerson.Name = "BtnLoadAddressIncludePerson";
            this.BtnLoadAddressIncludePerson.Size = new System.Drawing.Size(360, 49);
            this.BtnLoadAddressIncludePerson.TabIndex = 1;
            this.BtnLoadAddressIncludePerson.Text = "Load Address Include Person";
            this.BtnLoadAddressIncludePerson.UseVisualStyleBackColor = true;
            this.BtnLoadAddressIncludePerson.Click += new System.EventHandler(this.BtnLoadAddressIncludePerson_Click);
            // 
            // BtnLoadPersonIncludeAddress
            // 
            this.BtnLoadPersonIncludeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnLoadPersonIncludeAddress.Location = new System.Drawing.Point(12, 122);
            this.BtnLoadPersonIncludeAddress.Name = "BtnLoadPersonIncludeAddress";
            this.BtnLoadPersonIncludeAddress.Size = new System.Drawing.Size(360, 49);
            this.BtnLoadPersonIncludeAddress.TabIndex = 2;
            this.BtnLoadPersonIncludeAddress.Text = "Load Person Include Address";
            this.BtnLoadPersonIncludeAddress.UseVisualStyleBackColor = true;
            this.BtnLoadPersonIncludeAddress.Click += new System.EventHandler(this.BtnLoadPersonIncludeAddress_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 177);
            this.Controls.Add(this.BtnLoadPersonIncludeAddress);
            this.Controls.Add(this.BtnLoadAddressIncludePerson);
            this.Controls.Add(this.BtnAddNewPeople);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAddNewPeople;
        private System.Windows.Forms.Button BtnLoadAddressIncludePerson;
        private System.Windows.Forms.Button BtnLoadPersonIncludeAddress;
    }
}

