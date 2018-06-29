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
            this.btn_ShowRel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAddCountry
            // 
            this.BtnAddCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnAddCountry.Location = new System.Drawing.Point(11, 10);
            this.BtnAddCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddCountry.Name = "BtnAddCountry";
            this.BtnAddCountry.Size = new System.Drawing.Size(226, 38);
            this.BtnAddCountry.TabIndex = 0;
            this.BtnAddCountry.Text = "Add Country";
            this.BtnAddCountry.UseVisualStyleBackColor = true;
            this.BtnAddCountry.Click += new System.EventHandler(this.BtnAddCountry_Click);
            // 
            // BtnDoSomthing
            // 
            this.BtnDoSomthing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnDoSomthing.Location = new System.Drawing.Point(11, 62);
            this.BtnDoSomthing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDoSomthing.Name = "BtnDoSomthing";
            this.BtnDoSomthing.Size = new System.Drawing.Size(226, 38);
            this.BtnDoSomthing.TabIndex = 1;
            this.BtnDoSomthing.Text = "Do Somthing";
            this.BtnDoSomthing.UseVisualStyleBackColor = true;
            this.BtnDoSomthing.Click += new System.EventHandler(this.BtnDoSomthing_Click);
            // 
            // btn_ShowRel
            // 
            this.btn_ShowRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_ShowRel.Location = new System.Drawing.Point(10, 116);
            this.btn_ShowRel.Name = "btn_ShowRel";
            this.btn_ShowRel.Size = new System.Drawing.Size(225, 49);
            this.btn_ShowRel.TabIndex = 2;
            this.btn_ShowRel.Text = "Show relation";
            this.btn_ShowRel.UseVisualStyleBackColor = true;
            this.btn_ShowRel.Click += new System.EventHandler(this.btn_ShowRel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 178);
            this.Controls.Add(this.btn_ShowRel);
            this.Controls.Add(this.BtnDoSomthing);
            this.Controls.Add(this.BtnAddCountry);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAddCountry;
        private System.Windows.Forms.Button BtnDoSomthing;
        private System.Windows.Forms.Button btn_ShowRel;
    }
}

