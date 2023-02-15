namespace person
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.ps = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.GroupBox();
            this.br = new System.Windows.Forms.Button();
            this.bh = new System.Windows.Forms.Button();
            this.bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pt = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.Label();
            this.ph = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ps.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Menu.SuspendLayout();
            this.pt.SuspendLayout();
            this.ph.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ps
            // 
            this.ps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(33)))));
            this.ps.Controls.Add(this.label6);
            this.ps.Controls.Add(this.panel2);
            this.ps.Controls.Add(this.button1);
            this.ps.Controls.Add(this.label5);
            this.ps.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ps.Location = new System.Drawing.Point(0, 0);
            this.ps.Margin = new System.Windows.Forms.Padding(4);
            this.ps.Name = "ps";
            this.ps.Size = new System.Drawing.Size(1121, 524);
            this.ps.TabIndex = 3;
            this.ps.Paint += new System.Windows.Forms.PaintEventHandler(this.ps_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arabic Typesetting", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(538, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 34);
            this.label6.TabIndex = 1;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(326, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 73);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(13, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 33);
            this.textBox1.TabIndex = 0;
            this.textBox1.Tag = "Enter Password";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(222)))), ((int)(((byte)(216)))));
            this.button1.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(416, 328);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "ارسال الطلب";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Andalus", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(394, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 44);
            this.label5.TabIndex = 0;
            this.label5.Text = "كلمة المرور لفتح الباب";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.Menu.Controls.Add(this.button3);
            this.Menu.Controls.Add(this.label1);
            this.Menu.Controls.Add(this.bt);
            this.Menu.Controls.Add(this.bh);
            this.Menu.Controls.Add(this.br);
            this.Menu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Menu.Location = new System.Drawing.Point(1120, -6);
            this.Menu.Margin = new System.Windows.Forms.Padding(4);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(4);
            this.Menu.Size = new System.Drawing.Size(267, 530);
            this.Menu.TabIndex = 0;
            this.Menu.TabStop = false;
            this.Menu.Enter += new System.EventHandler(this.Menu_Enter);
            // 
            // br
            // 
            this.br.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.br.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.br.Font = new System.Drawing.Font("Andalus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.br.ForeColor = System.Drawing.Color.White;
            this.br.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.br.Location = new System.Drawing.Point(27, 240);
            this.br.Margin = new System.Windows.Forms.Padding(4);
            this.br.Name = "br";
            this.br.Padding = new System.Windows.Forms.Padding(4);
            this.br.Size = new System.Drawing.Size(240, 68);
            this.br.TabIndex = 3;
            this.br.Text = "فتح الباب";
            this.br.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.br.UseVisualStyleBackColor = false;
            this.br.Click += new System.EventHandler(this.br_Click);
            // 
            // bh
            // 
            this.bh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.bh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bh.Font = new System.Drawing.Font("Andalus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bh.ForeColor = System.Drawing.Color.White;
            this.bh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bh.Location = new System.Drawing.Point(27, 164);
            this.bh.Margin = new System.Windows.Forms.Padding(4);
            this.bh.Name = "bh";
            this.bh.Padding = new System.Windows.Forms.Padding(4);
            this.bh.Size = new System.Drawing.Size(240, 68);
            this.bh.TabIndex = 4;
            this.bh.Text = "الرطوبة";
            this.bh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bh.UseVisualStyleBackColor = false;
            this.bh.Click += new System.EventHandler(this.bh_Click);
            // 
            // bt
            // 
            this.bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(28)))));
            this.bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt.Font = new System.Drawing.Font("Andalus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt.ForeColor = System.Drawing.Color.White;
            this.bt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt.Location = new System.Drawing.Point(27, 84);
            this.bt.Margin = new System.Windows.Forms.Padding(4);
            this.bt.Name = "bt";
            this.bt.Padding = new System.Windows.Forms.Padding(4);
            this.bt.Size = new System.Drawing.Size(240, 68);
            this.bt.TabIndex = 5;
            this.bt.Text = "درجة الحرارة";
            this.bt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt.UseVisualStyleBackColor = false;
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(59, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "مرحبا من جديد";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(222)))), ((int)(((byte)(216)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(65, 468);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "تسجيل الخروج";
            this.button3.UseCompatibleTextRendering = true;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pt
            // 
            this.pt.Controls.Add(this.temp);
            this.pt.Controls.Add(this.label2);
            this.pt.Enabled = false;
            this.pt.Location = new System.Drawing.Point(501, 87);
            this.pt.Margin = new System.Windows.Forms.Padding(4);
            this.pt.Name = "pt";
            this.pt.Size = new System.Drawing.Size(267, 123);
            this.pt.TabIndex = 1;
            this.pt.Paint += new System.Windows.Forms.PaintEventHandler(this.pt_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "temperature is";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.temp.Location = new System.Drawing.Point(81, 66);
            this.temp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(94, 39);
            this.temp.TabIndex = 1;
            this.temp.Text = "25°C";
            this.temp.Click += new System.EventHandler(this.label3_Click);
            // 
            // ph
            // 
            this.ph.Controls.Add(this.label3);
            this.ph.Controls.Add(this.label4);
            this.ph.Enabled = false;
            this.ph.Location = new System.Drawing.Point(497, 87);
            this.ph.Margin = new System.Windows.Forms.Padding(4);
            this.ph.Name = "ph";
            this.ph.Size = new System.Drawing.Size(267, 123);
            this.ph.TabIndex = 2;
            this.ph.Visible = false;
            this.ph.Paint += new System.Windows.Forms.PaintEventHandler(this.ph_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(48, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Humidity is";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(81, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 39);
            this.label3.TabIndex = 1;
            this.label3.Text = "70%";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.ps);
            this.panel1.Controls.Add(this.ph);
            this.panel1.Controls.Add(this.pt);
            this.panel1.Controls.Add(this.Menu);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1391, 524);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 526);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ps.ResumeLayout(false);
            this.ps.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.pt.ResumeLayout(false);
            this.pt.PerformLayout();
            this.ph.ResumeLayout(false);
            this.ph.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ps;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox Menu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pt;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel ph;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt;
        private System.Windows.Forms.Button bh;
        private System.Windows.Forms.Button br;


    }
}

