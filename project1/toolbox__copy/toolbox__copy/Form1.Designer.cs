using System.Windows.Forms;

namespace toolbox__copy
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gradient_box1 = new toolbox__copy.gradient_box();
            this.main_input = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.gradient_box1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 50);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modern Window";
            // 
            // gradient_box1
            // 
            this.gradient_box1.Controls.Add(this.main_input);
            this.gradient_box1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient_box1.Gradient_bottom = System.Drawing.SystemColors.WindowFrame;
            this.gradient_box1.Gradient_top = System.Drawing.Color.BlueViolet;
            this.gradient_box1.Location = new System.Drawing.Point(0, 50);
            this.gradient_box1.Name = "gradient_box1";
            this.gradient_box1.Size = new System.Drawing.Size(553, 263);
            this.gradient_box1.TabIndex = 1;
            // 
            // main_input
            // 
            this.main_input.BackColor = System.Drawing.Color.OldLace;
            this.main_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.main_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.main_input.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_input.Location = new System.Drawing.Point(19, 56);
            this.main_input.Margin = new System.Windows.Forms.Padding(10);
            this.main_input.Multiline = true;
            this.main_input.Name = "main_input";
            this.main_input.Size = new System.Drawing.Size(181, 41);
            this.main_input.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(553, 313);
            this.Controls.Add(this.gradient_box1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gradient_box1.ResumeLayout(false);
            this.gradient_box1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public gradient_box gradient_box1;
        private System.Windows.Forms.TextBox main_input;
    }
}

