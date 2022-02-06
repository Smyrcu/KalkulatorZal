
namespace KalkulatorZal
{
    partial class Converter
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.decLabel = new System.Windows.Forms.Label();
            this.hexLabel = new System.Windows.Forms.Label();
            this.binLabel = new System.Windows.Forms.Label();
            this.octLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "HEX:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "BIN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "OCT:";
            // 
            // decLabel
            // 
            this.decLabel.BackColor = System.Drawing.Color.White;
            this.decLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.decLabel.Location = new System.Drawing.Point(96, 20);
            this.decLabel.Name = "decLabel";
            this.decLabel.Size = new System.Drawing.Size(100, 25);
            this.decLabel.TabIndex = 4;
            // 
            // hexLabel
            // 
            this.hexLabel.BackColor = System.Drawing.Color.White;
            this.hexLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hexLabel.Location = new System.Drawing.Point(96, 70);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(100, 25);
            this.hexLabel.TabIndex = 5;
            // 
            // binLabel
            // 
            this.binLabel.BackColor = System.Drawing.Color.White;
            this.binLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.binLabel.Location = new System.Drawing.Point(96, 120);
            this.binLabel.Name = "binLabel";
            this.binLabel.Size = new System.Drawing.Size(100, 25);
            this.binLabel.TabIndex = 6;
            // 
            // octLabel
            // 
            this.octLabel.BackColor = System.Drawing.Color.White;
            this.octLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.octLabel.Location = new System.Drawing.Point(96, 170);
            this.octLabel.Name = "octLabel";
            this.octLabel.Size = new System.Drawing.Size(100, 25);
            this.octLabel.TabIndex = 7;
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 215);
            this.Controls.Add(this.octLabel);
            this.Controls.Add(this.binLabel);
            this.Controls.Add(this.hexLabel);
            this.Controls.Add(this.decLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Converter";
            this.Text = "Converter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Converter_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label decLabel;
        private System.Windows.Forms.Label hexLabel;
        private System.Windows.Forms.Label binLabel;
        private System.Windows.Forms.Label octLabel;
    }
}