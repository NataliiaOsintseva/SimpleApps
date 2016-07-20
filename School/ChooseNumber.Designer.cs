namespace School
{
    partial class ChooseNumber
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
            this.label1 = new System.Windows.Forms.Label();
            this.select3RBtnn = new System.Windows.Forms.RadioButton();
            this.select4RBtnn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 159);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many students would you like to add by yourself?";
            // 
            // radioButton1
            // 
            this.select3RBtnn.AutoSize = true;
            this.select3RBtnn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.select3RBtnn.Location = new System.Drawing.Point(59, 90);
            this.select3RBtnn.Name = "radioButton1";
            this.select3RBtnn.Size = new System.Drawing.Size(34, 21);
            this.select3RBtnn.TabIndex = 1;
            this.select3RBtnn.TabStop = true;
            this.select3RBtnn.Text = "3";
            this.select3RBtnn.UseVisualStyleBackColor = true;
            
            // 
            // radioButton2
            // 
            this.select4RBtnn.AutoSize = true;
            this.select4RBtnn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.select4RBtnn.Location = new System.Drawing.Point(59, 117);
            this.select4RBtnn.Name = "radioButton2";
            this.select4RBtnn.Size = new System.Drawing.Size(34, 21);
            this.select4RBtnn.TabIndex = 2;
            this.select4RBtnn.TabStop = true;
            this.select4RBtnn.Text = "4";
            this.select4RBtnn.UseVisualStyleBackColor = true;
            // 
            // ChooseNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(567, 302);
            this.Controls.Add(this.select4RBtnn);
            this.Controls.Add(this.select3RBtnn);
            this.Controls.Add(this.label1);
            this.Name = "ChooseNumber";
            this.Text = "Choosing Number";
            this.Load += new System.EventHandler(this.ChooseNumber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton select3RBtnn;
        private System.Windows.Forms.RadioButton select4RBtnn;
    }
}