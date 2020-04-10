namespace KablosuzProje
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btn_execute = new System.Windows.Forms.Button();
            this.txt_r1x = new System.Windows.Forms.TextBox();
            this.txt_r1y = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_r2x = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_r2y = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_r3x = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_r3y = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_location = new System.Windows.Forms.Label();
            this.btn_about = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox.Location = new System.Drawing.Point(13, 13);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(500, 500);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // btn_execute
            // 
            this.btn_execute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_execute.Location = new System.Drawing.Point(525, 486);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(100, 27);
            this.btn_execute.TabIndex = 1;
            this.btn_execute.Text = "EXECUTE";
            this.btn_execute.UseVisualStyleBackColor = true;
            this.btn_execute.Click += new System.EventHandler(this.btn_draw_Click);
            // 
            // txt_r1x
            // 
            this.txt_r1x.Location = new System.Drawing.Point(6, 28);
            this.txt_r1x.MaxLength = 3;
            this.txt_r1x.Name = "txt_r1x";
            this.txt_r1x.Size = new System.Drawing.Size(100, 26);
            this.txt_r1x.TabIndex = 2;
            this.txt_r1x.Text = "2";
            this.txt_r1x.TextChanged += new System.EventHandler(this.txt_r1x_TextChanged);
            // 
            // txt_r1y
            // 
            this.txt_r1y.Location = new System.Drawing.Point(6, 60);
            this.txt_r1y.MaxLength = 3;
            this.txt_r1y.Name = "txt_r1y";
            this.txt_r1y.Size = new System.Drawing.Size(100, 26);
            this.txt_r1y.TabIndex = 3;
            this.txt_r1y.Text = "1";
            this.txt_r1y.TextChanged += new System.EventHandler(this.txt_r1x_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "y";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_r1x);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_r1y);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(519, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "B1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_r2x);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_r2y);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(519, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "B2";
            // 
            // txt_r2x
            // 
            this.txt_r2x.Location = new System.Drawing.Point(6, 28);
            this.txt_r2x.MaxLength = 3;
            this.txt_r2x.Name = "txt_r2x";
            this.txt_r2x.Size = new System.Drawing.Size(100, 26);
            this.txt_r2x.TabIndex = 2;
            this.txt_r2x.Text = "5";
            this.txt_r2x.TextChanged += new System.EventHandler(this.txt_r1x_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "y";
            // 
            // txt_r2y
            // 
            this.txt_r2y.Location = new System.Drawing.Point(6, 60);
            this.txt_r2y.MaxLength = 3;
            this.txt_r2y.Name = "txt_r2y";
            this.txt_r2y.Size = new System.Drawing.Size(100, 26);
            this.txt_r2y.TabIndex = 3;
            this.txt_r2y.Text = "4";
            this.txt_r2y.TextChanged += new System.EventHandler(this.txt_r1x_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "x";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_r3x);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_r3y);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(519, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 100);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "B3";
            // 
            // txt_r3x
            // 
            this.txt_r3x.Location = new System.Drawing.Point(6, 28);
            this.txt_r3x.MaxLength = 3;
            this.txt_r3x.Name = "txt_r3x";
            this.txt_r3x.Size = new System.Drawing.Size(100, 26);
            this.txt_r3x.TabIndex = 2;
            this.txt_r3x.Text = "8";
            this.txt_r3x.TextChanged += new System.EventHandler(this.txt_r1x_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "y";
            // 
            // txt_r3y
            // 
            this.txt_r3y.Location = new System.Drawing.Point(6, 60);
            this.txt_r3y.MaxLength = 3;
            this.txt_r3y.Name = "txt_r3y";
            this.txt_r3y.Size = new System.Drawing.Size(100, 26);
            this.txt_r3y.TabIndex = 3;
            this.txt_r3y.Text = "2";
            this.txt_r3y.TextChanged += new System.EventHandler(this.txt_r1x_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "x";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(521, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Location:";
            // 
            // lbl_location
            // 
            this.lbl_location.AutoSize = true;
            this.lbl_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_location.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_location.Location = new System.Drawing.Point(613, 372);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(54, 25);
            this.lbl_location.TabIndex = 10;
            this.lbl_location.Text = "(x,y)";
            // 
            // btn_about
            // 
            this.btn_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_about.Location = new System.Drawing.Point(721, 485);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(27, 27);
            this.btn_about.TabIndex = 11;
            this.btn_about.Text = "?";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 524);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.lbl_location);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_execute);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSSI Triangulation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btn_execute;
        private System.Windows.Forms.TextBox txt_r1x;
        private System.Windows.Forms.TextBox txt_r1y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_r2x;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_r2y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_r3x;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_r3y;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.Button btn_about;
    }
}

