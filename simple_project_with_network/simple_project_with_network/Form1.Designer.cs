namespace simple_project_with_network
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
            this.main_gradient = new toolbox__copy.gradient_box();
            this.show_txt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.main_gradient.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_gradient
            // 
            this.main_gradient.Controls.Add(this.button1);
            this.main_gradient.Controls.Add(this.show_txt);
            this.main_gradient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_gradient.Gradient_bottom = System.Drawing.Color.DarkSeaGreen;
            this.main_gradient.Gradient_top = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.main_gradient.Location = new System.Drawing.Point(0, 0);
            this.main_gradient.Name = "main_gradient";
            this.main_gradient.Size = new System.Drawing.Size(804, 450);
            this.main_gradient.TabIndex = 2;
            // 
            // show_txt
            // 
            this.show_txt.AutoSize = true;
            this.show_txt.BackColor = System.Drawing.Color.Transparent;
            this.show_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_txt.ForeColor = System.Drawing.Color.White;
            this.show_txt.Location = new System.Drawing.Point(55, 101);
            this.show_txt.Name = "show_txt";
            this.show_txt.Size = new System.Drawing.Size(0, 135);
            this.show_txt.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Roboto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(804, 66);
            this.button1.TabIndex = 3;
            this.button1.Text = "click here";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.main_gradient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.main_gradient.ResumeLayout(false);
            this.main_gradient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private toolbox__copy.gradient_box main_gradient;
        private System.Windows.Forms.Label show_txt;
        private System.Windows.Forms.Button button1;
    }
}

