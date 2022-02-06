
namespace KalkulatorZal
{
    partial class InfoForm
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
            this.textLabel = new System.Windows.Forms.Label();
            this.logButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.sqrtButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.mathButton = new System.Windows.Forms.Button();
            this.converterInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.textLabel.Location = new System.Drawing.Point(12, 150);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(527, 140);
            this.textLabel.TabIndex = 0;
            // 
            // logButton
            // 
            this.logButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logButton.Location = new System.Drawing.Point(454, 53);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(85, 35);
            this.logButton.TabIndex = 29;
            this.logButton.Text = "log/ln/!";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Visible = false;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helpButton.Location = new System.Drawing.Point(354, 12);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(185, 35);
            this.helpButton.TabIndex = 30;
            this.helpButton.Text = "Pomoc";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // sqrtButton
            // 
            this.sqrtButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sqrtButton.Location = new System.Drawing.Point(354, 94);
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.Size = new System.Drawing.Size(185, 35);
            this.sqrtButton.TabIndex = 31;
            this.sqrtButton.Text = "Pierwiastek";
            this.sqrtButton.UseVisualStyleBackColor = true;
            this.sqrtButton.Visible = false;
            this.sqrtButton.Click += new System.EventHandler(this.sqrtButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aboutButton.Location = new System.Drawing.Point(12, 12);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(185, 35);
            this.aboutButton.TabIndex = 32;
            this.aboutButton.Text = "O Programie";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // mathButton
            // 
            this.mathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mathButton.Location = new System.Drawing.Point(354, 53);
            this.mathButton.Name = "mathButton";
            this.mathButton.Size = new System.Drawing.Size(85, 35);
            this.mathButton.TabIndex = 34;
            this.mathButton.Text = "sin/cos/...";
            this.mathButton.UseVisualStyleBackColor = true;
            this.mathButton.Visible = false;
            this.mathButton.Click += new System.EventHandler(this.mathButton_Click);
            // 
            // converterInfoButton
            // 
            this.converterInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.converterInfoButton.Location = new System.Drawing.Point(12, 94);
            this.converterInfoButton.Name = "converterInfoButton";
            this.converterInfoButton.Size = new System.Drawing.Size(185, 35);
            this.converterInfoButton.TabIndex = 35;
            this.converterInfoButton.Text = "Konwerter";
            this.converterInfoButton.UseVisualStyleBackColor = true;
            this.converterInfoButton.Click += new System.EventHandler(this.converterInfoButton_Click);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 304);
            this.Controls.Add(this.converterInfoButton);
            this.Controls.Add(this.mathButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.sqrtButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.textLabel);
            this.Name = "InfoForm";
            this.Text = "Info";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InfoForm_FormClosed);
            this.Load += new System.EventHandler(this.InfoForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button sqrtButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button mathButton;
        private System.Windows.Forms.Button converterInfoButton;
    }
}