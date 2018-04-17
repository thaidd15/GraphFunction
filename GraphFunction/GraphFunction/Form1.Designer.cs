namespace GraphFunction
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Inputtxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ZoomOutbtn = new System.Windows.Forms.Button();
            this.ZoomInbtn = new System.Windows.Forms.Button();
            this.Drawbtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Integral = new System.Windows.Forms.TextBox();
            this.Integralbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Iterationtxt = new System.Windows.Forms.TextBox();
            this.Uppertxt = new System.Windows.Forms.TextBox();
            this.Lowertxt = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.Graph = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(-3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Function y=f(x)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(219, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "GraphFunction";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.Inputtxt);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(1, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 137);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // Inputtxt
            // 
            this.Inputtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Inputtxt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inputtxt.Location = new System.Drawing.Point(0, 20);
            this.Inputtxt.Multiline = true;
            this.Inputtxt.Name = "Inputtxt";
            this.Inputtxt.Size = new System.Drawing.Size(211, 111);
            this.Inputtxt.TabIndex = 0;
            this.Inputtxt.Tag = "";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.ZoomOutbtn);
            this.groupBox3.Controls.Add(this.ZoomInbtn);
            this.groupBox3.Controls.Add(this.Drawbtn);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(1, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 144);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graph";
            // 
            // ZoomOutbtn
            // 
            this.ZoomOutbtn.Location = new System.Drawing.Point(59, 101);
            this.ZoomOutbtn.Name = "ZoomOutbtn";
            this.ZoomOutbtn.Size = new System.Drawing.Size(97, 32);
            this.ZoomOutbtn.TabIndex = 2;
            this.ZoomOutbtn.Text = "Zoom Out";
            this.ZoomOutbtn.UseVisualStyleBackColor = true;
            this.ZoomOutbtn.Click += new System.EventHandler(this.ZoomOutbtn_Click);
            // 
            // ZoomInbtn
            // 
            this.ZoomInbtn.Location = new System.Drawing.Point(59, 63);
            this.ZoomInbtn.Name = "ZoomInbtn";
            this.ZoomInbtn.Size = new System.Drawing.Size(97, 32);
            this.ZoomInbtn.TabIndex = 1;
            this.ZoomInbtn.Text = "Zoom In";
            this.ZoomInbtn.UseVisualStyleBackColor = true;
            this.ZoomInbtn.Click += new System.EventHandler(this.ZoomInbtn_Click);
            // 
            // Drawbtn
            // 
            this.Drawbtn.Location = new System.Drawing.Point(59, 25);
            this.Drawbtn.Name = "Drawbtn";
            this.Drawbtn.Size = new System.Drawing.Size(97, 32);
            this.Drawbtn.TabIndex = 0;
            this.Drawbtn.Text = "Draw";
            this.Drawbtn.UseVisualStyleBackColor = true;
            this.Drawbtn.Click += new System.EventHandler(this.Drawbtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox4.Controls.Add(this.Integral);
            this.groupBox4.Controls.Add(this.Integralbtn);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.Iterationtxt);
            this.groupBox4.Controls.Add(this.Uppertxt);
            this.groupBox4.Controls.Add(this.Lowertxt);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(1, 324);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(211, 288);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Integral";
            // 
            // Integral
            // 
            this.Integral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Integral.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Integral.Location = new System.Drawing.Point(0, 159);
            this.Integral.Multiline = true;
            this.Integral.Name = "Integral";
            this.Integral.ReadOnly = true;
            this.Integral.Size = new System.Drawing.Size(211, 123);
            this.Integral.TabIndex = 7;
            // 
            // Integralbtn
            // 
            this.Integralbtn.Location = new System.Drawing.Point(59, 121);
            this.Integralbtn.Name = "Integralbtn";
            this.Integralbtn.Size = new System.Drawing.Size(97, 32);
            this.Integralbtn.TabIndex = 6;
            this.Integralbtn.Text = "Integral";
            this.Integralbtn.UseVisualStyleBackColor = true;
            this.Integralbtn.Click += new System.EventHandler(this.Integralbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Iteration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Upper Bound";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lower Bound";
            // 
            // Iterationtxt
            // 
            this.Iterationtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Iterationtxt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iterationtxt.Location = new System.Drawing.Point(106, 85);
            this.Iterationtxt.Name = "Iterationtxt";
            this.Iterationtxt.Size = new System.Drawing.Size(99, 26);
            this.Iterationtxt.TabIndex = 2;
            // 
            // Uppertxt
            // 
            this.Uppertxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Uppertxt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uppertxt.Location = new System.Drawing.Point(106, 53);
            this.Uppertxt.Name = "Uppertxt";
            this.Uppertxt.Size = new System.Drawing.Size(99, 26);
            this.Uppertxt.TabIndex = 1;
            // 
            // Lowertxt
            // 
            this.Lowertxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lowertxt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lowertxt.Location = new System.Drawing.Point(106, 21);
            this.Lowertxt.Name = "Lowertxt";
            this.Lowertxt.Size = new System.Drawing.Size(99, 26);
            this.Lowertxt.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox5.Controls.Add(this.Resetbtn);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Blue;
            this.groupBox5.Location = new System.Drawing.Point(1, 618);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(211, 95);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Option";
            // 
            // Resetbtn
            // 
            this.Resetbtn.Location = new System.Drawing.Point(59, 37);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(97, 32);
            this.Resetbtn.TabIndex = 0;
            this.Resetbtn.Text = "Reset";
            this.Resetbtn.UseVisualStyleBackColor = true;
            this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
            // 
            // Graph
            // 
            this.Graph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Graph.Location = new System.Drawing.Point(218, 31);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(1140, 682);
            this.Graph.TabIndex = 7;
            this.Graph.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 721);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "GraphFunction";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox Graph;
        private System.Windows.Forms.TextBox Inputtxt;
        private System.Windows.Forms.Button ZoomOutbtn;
        private System.Windows.Forms.Button ZoomInbtn;
        private System.Windows.Forms.Button Drawbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Iterationtxt;
        private System.Windows.Forms.TextBox Uppertxt;
        private System.Windows.Forms.TextBox Lowertxt;
        private System.Windows.Forms.Button Resetbtn;
        private System.Windows.Forms.Button Integralbtn;
        private System.Windows.Forms.TextBox Integral;
    }
}

