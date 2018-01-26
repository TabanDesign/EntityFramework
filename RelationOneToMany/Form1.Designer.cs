namespace RelationOneToMany
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
            this.BtnAddCountry = new System.Windows.Forms.Button();
            this.BtnDoSomthing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAddCountry
            // 
            this.BtnAddCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnAddCountry.Location = new System.Drawing.Point(12, 12);
            this.BtnAddCountry.Name = "BtnAddCountry";
            this.BtnAddCountry.Size = new System.Drawing.Size(254, 47);
            this.BtnAddCountry.TabIndex = 0;
            this.BtnAddCountry.Text = "Add Country";
            this.BtnAddCountry.UseVisualStyleBackColor = true;
            this.BtnAddCountry.Click += new System.EventHandler(this.BtnAddCountry_Click);
            // 
            // BtnDoSomthing
            // 
            this.BtnDoSomthing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnDoSomthing.Location = new System.Drawing.Point(12, 78);
            this.BtnDoSomthing.Name = "BtnDoSomthing";
            this.BtnDoSomthing.Size = new System.Drawing.Size(254, 47);
            this.BtnDoSomthing.TabIndex = 1;
            this.BtnDoSomthing.Text = "Do Somthing";
            this.BtnDoSomthing.UseVisualStyleBackColor = true;
            this.BtnDoSomthing.Click += new System.EventHandler(this.BtnDoSomthing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 138);
            this.Controls.Add(this.BtnDoSomthing);
            this.Controls.Add(this.BtnAddCountry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAddCountry;
        private System.Windows.Forms.Button BtnDoSomthing;
    }
}

