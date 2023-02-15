namespace AdminPage
{
    partial class ConsultUsers
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
            this.button1 = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.addPersone = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(114, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "عرض المستخدمين";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Aldhabi", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.welcome.Location = new System.Drawing.Point(155, 42);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(126, 67);
            this.welcome.TabIndex = 1;
            this.welcome.Text = "مرحبا نذير";
            this.welcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(114, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 63);
            this.button2.TabIndex = 2;
            this.button2.Text = "الامن و المراقبة";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addPersone
            // 
            this.addPersone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(44)))));
            this.addPersone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPersone.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold);
            this.addPersone.ForeColor = System.Drawing.Color.White;
            this.addPersone.Location = new System.Drawing.Point(114, 218);
            this.addPersone.Name = "addPersone";
            this.addPersone.Size = new System.Drawing.Size(231, 63);
            this.addPersone.TabIndex = 3;
            this.addPersone.Text = "اضافة مستخدم";
            this.addPersone.UseVisualStyleBackColor = false;
            this.addPersone.Click += new System.EventHandler(this.addPersone_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(222)))), ((int)(((byte)(216)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(114, 450);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(231, 49);
            this.button4.TabIndex = 4;
            this.button4.Text = "خروج";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // ConsultUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(507, 561);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.addPersone);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "ConsultUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الادمن";
            this.Load += new System.EventHandler(this.ConsultUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addPersone;
        private System.Windows.Forms.Button button4;
    }
}