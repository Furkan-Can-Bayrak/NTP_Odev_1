namespace CarRacing
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.p4 = new System.Windows.Forms.PictureBox();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.p5 = new System.Windows.Forms.PictureBox();
            this.p6 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.car1 = new System.Windows.Forms.PictureBox();
            this.car3 = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            this.SuspendLayout();
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p2.Location = new System.Drawing.Point(176, 120);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(10, 88);
            this.p2.TabIndex = 0;
            this.p2.TabStop = false;
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p1.Location = new System.Drawing.Point(176, 0);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(10, 88);
            this.p1.TabIndex = 0;
            this.p1.TabStop = false;
            // 
            // p4
            // 
            this.p4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p4.Location = new System.Drawing.Point(176, 360);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(10, 88);
            this.p4.TabIndex = 0;
            this.p4.TabStop = false;
            // 
            // p3
            // 
            this.p3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p3.Location = new System.Drawing.Point(176, 240);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(10, 88);
            this.p3.TabIndex = 0;
            this.p3.TabStop = false;
            // 
            // p5
            // 
            this.p5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p5.Location = new System.Drawing.Point(362, 1);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(10, 460);
            this.p5.TabIndex = 0;
            this.p5.TabStop = false;
            // 
            // p6
            // 
            this.p6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p6.Location = new System.Drawing.Point(12, 1);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(10, 460);
            this.p6.TabIndex = 0;
            this.p6.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // car1
            // 
            this.car1.Image = ((System.Drawing.Image)(resources.GetObject("car1.Image")));
            this.car1.Location = new System.Drawing.Point(54, 319);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(72, 91);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.car1.TabIndex = 1;
            this.car1.TabStop = false;
            // 
            // car3
            // 
            this.car3.Image = ((System.Drawing.Image)(resources.GetObject("car3.Image")));
            this.car3.Location = new System.Drawing.Point(226, 120);
            this.car3.Name = "car3";
            this.car3.Size = new System.Drawing.Size(50, 100);
            this.car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.car3.TabIndex = 1;
            this.car3.TabStop = false;
            // 
            // car2
            // 
            this.car2.Image = ((System.Drawing.Image)(resources.GetObject("car2.Image")));
            this.car2.Location = new System.Drawing.Point(54, 89);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(50, 100);
            this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.car2.TabIndex = 1;
            this.car2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.car2);
            this.Controls.Add(this.car3);
            this.Controls.Add(this.car1);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p6);
            this.Controls.Add(this.p5);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.p2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p4;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.PictureBox p5;
        private System.Windows.Forms.PictureBox p6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.PictureBox car3;
        private System.Windows.Forms.PictureBox car2;
    }
}

