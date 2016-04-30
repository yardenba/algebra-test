namespace מבחן_בחשבון
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
            this.button1A = new System.Windows.Forms.Button();
            this.button2B = new System.Windows.Forms.Button();
            this.button3C = new System.Windows.Forms.Button();
            this.button4D = new System.Windows.Forms.Button();
            this.button5E = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1A
            // 
            this.button1A.Location = new System.Drawing.Point(60, 51);
            this.button1A.Name = "button1A";
            this.button1A.Size = new System.Drawing.Size(236, 72);
            this.button1A.TabIndex = 0;
            this.button1A.Text = "מיבחן חיבור";
            this.button1A.UseVisualStyleBackColor = true;
            this.button1A.Click += new System.EventHandler(this.button1A_Click);
            // 
            // button2B
            // 
            this.button2B.Location = new System.Drawing.Point(60, 151);
            this.button2B.Name = "button2B";
            this.button2B.Size = new System.Drawing.Size(236, 72);
            this.button2B.TabIndex = 1;
            this.button2B.Text = "מיבחן חיסור";
            this.button2B.UseVisualStyleBackColor = true;
            this.button2B.Click += new System.EventHandler(this.button2B_Click_1);
            // 
            // button3C
            // 
            this.button3C.Location = new System.Drawing.Point(60, 248);
            this.button3C.Name = "button3C";
            this.button3C.Size = new System.Drawing.Size(236, 72);
            this.button3C.TabIndex = 2;
            this.button3C.Text = "מיבחן כפל";
            this.button3C.UseVisualStyleBackColor = true;
            this.button3C.Click += new System.EventHandler(this.button3C_Click);
            // 
            // button4D
            // 
            this.button4D.Location = new System.Drawing.Point(60, 345);
            this.button4D.Name = "button4D";
            this.button4D.Size = new System.Drawing.Size(236, 72);
            this.button4D.TabIndex = 3;
            this.button4D.Text = "מיבחן חילוק";
            this.button4D.UseVisualStyleBackColor = true;
            this.button4D.Click += new System.EventHandler(this.button4D_Click);
            // 
            // button5E
            // 
            this.button5E.Location = new System.Drawing.Point(60, 444);
            this.button5E.Name = "button5E";
            this.button5E.Size = new System.Drawing.Size(236, 72);
            this.button5E.TabIndex = 4;
            this.button5E.Text = "מיבחן מסכם";
            this.button5E.UseVisualStyleBackColor = true;
            this.button5E.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(339, 544);
            this.Controls.Add(this.button5E);
            this.Controls.Add(this.button4D);
            this.Controls.Add(this.button3C);
            this.Controls.Add(this.button2B);
            this.Controls.Add(this.button1A);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1A;
        public System.Windows.Forms.Button button2B;
        public System.Windows.Forms.Button button3C;
        public System.Windows.Forms.Button button4D;
        public System.Windows.Forms.Button button5E;
    }
}

