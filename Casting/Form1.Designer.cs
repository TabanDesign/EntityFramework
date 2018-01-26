namespace Casting
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
            this.lstCountry = new System.Windows.Forms.ListBox();
            this.lstState = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstCountry
            // 
            this.lstCountry.FormattingEnabled = true;
            this.lstCountry.ItemHeight = 20;
            this.lstCountry.Location = new System.Drawing.Point(12, 12);
            this.lstCountry.Name = "lstCountry";
            this.lstCountry.Size = new System.Drawing.Size(372, 204);
            this.lstCountry.TabIndex = 0;
            this.lstCountry.SelectedIndexChanged += new System.EventHandler(this.lstCountry_SelectedIndexChanged);
            // 
            // lstState
            // 
            this.lstState.FormattingEnabled = true;
            this.lstState.ItemHeight = 20;
            this.lstState.Location = new System.Drawing.Point(12, 222);
            this.lstState.Name = "lstState";
            this.lstState.Size = new System.Drawing.Size(372, 204);
            this.lstState.TabIndex = 1;
            this.lstState.SelectedIndexChanged += new System.EventHandler(this.lstState_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 434);
            this.Controls.Add(this.lstState);
            this.Controls.Add(this.lstCountry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCountry;
        private System.Windows.Forms.ListBox lstState;
    }
}

