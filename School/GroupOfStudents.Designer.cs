namespace School
{
    partial class GroupStudents
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.welcomeLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.welcomeLabel.Location = new System.Drawing.Point(99, 40);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Padding = new System.Windows.Forms.Padding(1);
            this.welcomeLabel.Size = new System.Drawing.Size(487, 26);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to the Group of Students Formation Application! ";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.FlatAppearance.BorderSize = 2;
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnYes.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnYes.Location = new System.Drawing.Point(49, 252);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(160, 35);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "FORM THE GROUP";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // GroupStudents
            // 
            this.AcceptButton = this.btnYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(669, 325);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.welcomeLabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "GroupStudents";
            this.Text = "Group Of Students";
            this.Load += new System.EventHandler(this.GroupStudents_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button btnYes;
    }
}