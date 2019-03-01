namespace GraphicsTest
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
            this.Vipu = new System.Windows.Forms.Label();
            this.canvas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vipu1 = new System.Windows.Forms.TextBox();
            this.vipu2 = new System.Windows.Forms.TextBox();
            this.vipu3 = new System.Windows.Forms.TextBox();
            this.vipu4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.vipu4);
            this.panel1.Controls.Add(this.vipu3);
            this.panel1.Controls.Add(this.vipu2);
            this.panel1.Controls.Add(this.vipu1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Vipu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // Vipu
            // 
            this.Vipu.AutoSize = true;
            this.Vipu.Location = new System.Drawing.Point(38, 42);
            this.Vipu.Name = "Vipu";
            this.Vipu.Size = new System.Drawing.Size(41, 20);
            this.Vipu.TabIndex = 0;
            this.Vipu.Text = "Vipu";
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 100);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(800, 350);
            this.canvas.TabIndex = 1;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vipu 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vipu 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vipu 4";
            // 
            // vipu1
            // 
            this.vipu1.Location = new System.Drawing.Point(105, 36);
            this.vipu1.Name = "vipu1";
            this.vipu1.Size = new System.Drawing.Size(38, 26);
            this.vipu1.TabIndex = 4;
            this.vipu1.Text = "1";
            // 
            // vipu2
            // 
            this.vipu2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vipu2.Location = new System.Drawing.Point(249, 36);
            this.vipu2.Name = "vipu2";
            this.vipu2.Size = new System.Drawing.Size(38, 26);
            this.vipu2.TabIndex = 5;
            this.vipu2.Text = "-40";
            // 
            // vipu3
            // 
            this.vipu3.Location = new System.Drawing.Point(393, 36);
            this.vipu3.Name = "vipu3";
            this.vipu3.Size = new System.Drawing.Size(38, 26);
            this.vipu3.TabIndex = 6;
            this.vipu3.Text = "50";
            // 
            // vipu4
            // 
            this.vipu4.Location = new System.Drawing.Point(537, 36);
            this.vipu4.Name = "vipu4";
            this.vipu4.Size = new System.Drawing.Size(38, 26);
            this.vipu4.TabIndex = 7;
            this.vipu4.Text = "50";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 56);
            this.button1.TabIndex = 8;
            this.button1.Text = "Let\'s Go!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Label Vipu;
        private System.Windows.Forms.TextBox vipu4;
        private System.Windows.Forms.TextBox vipu3;
        private System.Windows.Forms.TextBox vipu2;
        private System.Windows.Forms.TextBox vipu1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}