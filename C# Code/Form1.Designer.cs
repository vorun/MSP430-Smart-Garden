
namespace MSP430_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bsabtn = new System.Windows.Forms.Button();
            this.bsobtn = new System.Windows.Forms.Button();
            this.bscbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sdabtn = new System.Windows.Forms.Button();
            this.sdobtn = new System.Windows.Forms.Button();
            this.sdcbtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.iyabtn = new System.Windows.Forms.Button();
            this.iyobtn = new System.Windows.Forms.Button();
            this.iycbtn = new System.Windows.Forms.Button();
            this.iabtn = new System.Windows.Forms.Button();
            this.ikbtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.fcabtn = new System.Windows.Forms.Button();
            this.fcobtn = new System.Windows.Forms.Button();
            this.fccbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(85, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open Port";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(33, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Humidity Ratio :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(260, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(447, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 71);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close Port";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(170, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 28);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(70, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Light Ratio :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(170, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 28);
            this.label4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(20, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Water Tank Level :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(170, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 28);
            this.label6.TabIndex = 8;
            // 
            // bsabtn
            // 
            this.bsabtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bsabtn.ForeColor = System.Drawing.Color.Black;
            this.bsabtn.Location = new System.Drawing.Point(68, 33);
            this.bsabtn.Name = "bsabtn";
            this.bsabtn.Size = new System.Drawing.Size(107, 29);
            this.bsabtn.TabIndex = 9;
            this.bsabtn.Text = "3 Seconds";
            this.bsabtn.UseVisualStyleBackColor = false;
            this.bsabtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // bsobtn
            // 
            this.bsobtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bsobtn.ForeColor = System.Drawing.Color.Black;
            this.bsobtn.Location = new System.Drawing.Point(68, 92);
            this.bsobtn.Name = "bsobtn";
            this.bsobtn.Size = new System.Drawing.Size(107, 29);
            this.bsobtn.TabIndex = 10;
            this.bsobtn.Text = "7 Seconds";
            this.bsobtn.UseVisualStyleBackColor = false;
            this.bsobtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // bscbtn
            // 
            this.bscbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bscbtn.ForeColor = System.Drawing.Color.Black;
            this.bscbtn.Location = new System.Drawing.Point(68, 151);
            this.bscbtn.Name = "bscbtn";
            this.bscbtn.Size = new System.Drawing.Size(107, 29);
            this.bscbtn.TabIndex = 11;
            this.bscbtn.Text = "10 Seconds";
            this.bscbtn.UseVisualStyleBackColor = false;
            this.bscbtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "There is no connection!";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.bsabtn);
            this.groupBox1.Controls.Add(this.bsobtn);
            this.groupBox1.Controls.Add(this.bscbtn);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(946, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 238);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Irrigation";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.sdabtn);
            this.groupBox2.Controls.Add(this.sdobtn);
            this.groupBox2.Controls.Add(this.sdcbtn);
            this.groupBox2.Location = new System.Drawing.Point(669, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 238);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transfer To Water Tank";
            // 
            // sdabtn
            // 
            this.sdabtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sdabtn.Location = new System.Drawing.Point(68, 33);
            this.sdabtn.Name = "sdabtn";
            this.sdabtn.Size = new System.Drawing.Size(107, 29);
            this.sdabtn.TabIndex = 9;
            this.sdabtn.Text = "3 Seconds";
            this.sdabtn.UseVisualStyleBackColor = false;
            this.sdabtn.Click += new System.EventHandler(this.sdabtn_Click);
            // 
            // sdobtn
            // 
            this.sdobtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sdobtn.Location = new System.Drawing.Point(68, 92);
            this.sdobtn.Name = "sdobtn";
            this.sdobtn.Size = new System.Drawing.Size(107, 29);
            this.sdobtn.TabIndex = 10;
            this.sdobtn.Text = "7 Seconds";
            this.sdobtn.UseVisualStyleBackColor = false;
            this.sdobtn.Click += new System.EventHandler(this.sdobtn_Click);
            // 
            // sdcbtn
            // 
            this.sdcbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sdcbtn.Location = new System.Drawing.Point(68, 151);
            this.sdcbtn.Name = "sdcbtn";
            this.sdcbtn.Size = new System.Drawing.Size(107, 29);
            this.sdcbtn.TabIndex = 11;
            this.sdcbtn.Text = "10 Seconds";
            this.sdcbtn.UseVisualStyleBackColor = false;
            this.sdcbtn.Click += new System.EventHandler(this.sdcbtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.iyabtn);
            this.groupBox3.Controls.Add(this.iyobtn);
            this.groupBox3.Controls.Add(this.iycbtn);
            this.groupBox3.Location = new System.Drawing.Point(946, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 238);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FAN";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(68, 181);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 47);
            this.button6.TabIndex = 15;
            this.button6.Text = "Close";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // iyabtn
            // 
            this.iyabtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iyabtn.Location = new System.Drawing.Point(68, 40);
            this.iyabtn.Name = "iyabtn";
            this.iyabtn.Size = new System.Drawing.Size(107, 29);
            this.iyabtn.TabIndex = 9;
            this.iyabtn.Text = "Low";
            this.iyabtn.UseVisualStyleBackColor = false;
            this.iyabtn.Click += new System.EventHandler(this.iyabtn_Click);
            // 
            // iyobtn
            // 
            this.iyobtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iyobtn.Location = new System.Drawing.Point(68, 87);
            this.iyobtn.Name = "iyobtn";
            this.iyobtn.Size = new System.Drawing.Size(107, 29);
            this.iyobtn.TabIndex = 10;
            this.iyobtn.Text = "Medium";
            this.iyobtn.UseVisualStyleBackColor = false;
            this.iyobtn.Click += new System.EventHandler(this.iyobtn_Click);
            // 
            // iycbtn
            // 
            this.iycbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iycbtn.Location = new System.Drawing.Point(68, 134);
            this.iycbtn.Name = "iycbtn";
            this.iycbtn.Size = new System.Drawing.Size(107, 29);
            this.iycbtn.TabIndex = 11;
            this.iycbtn.Text = "High";
            this.iycbtn.UseVisualStyleBackColor = false;
            this.iycbtn.Click += new System.EventHandler(this.iycbtn_Click);
            // 
            // iabtn
            // 
            this.iabtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iabtn.Location = new System.Drawing.Point(31, 42);
            this.iabtn.Name = "iabtn";
            this.iabtn.Size = new System.Drawing.Size(94, 29);
            this.iabtn.TabIndex = 16;
            this.iabtn.Text = "Open";
            this.iabtn.UseVisualStyleBackColor = false;
            this.iabtn.Click += new System.EventHandler(this.iabtn_Click);
            // 
            // ikbtn
            // 
            this.ikbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ikbtn.Location = new System.Drawing.Point(31, 89);
            this.ikbtn.Name = "ikbtn";
            this.ikbtn.Size = new System.Drawing.Size(94, 29);
            this.ikbtn.TabIndex = 17;
            this.ikbtn.Text = "Close";
            this.ikbtn.UseVisualStyleBackColor = false;
            this.ikbtn.Click += new System.EventHandler(this.ikbtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.iabtn);
            this.groupBox4.Controls.Add(this.ikbtn);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(459, 390);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 146);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "HEATER";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Silver;
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.fcabtn);
            this.groupBox5.Controls.Add(this.fcobtn);
            this.groupBox5.Controls.Add(this.fccbtn);
            this.groupBox5.Location = new System.Drawing.Point(669, 298);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(250, 238);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "LIGHT";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(68, 181);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 47);
            this.button5.TabIndex = 14;
            this.button5.Text = "Close";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // fcabtn
            // 
            this.fcabtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.fcabtn.Location = new System.Drawing.Point(68, 40);
            this.fcabtn.Name = "fcabtn";
            this.fcabtn.Size = new System.Drawing.Size(107, 29);
            this.fcabtn.TabIndex = 9;
            this.fcabtn.Text = "Low";
            this.fcabtn.UseVisualStyleBackColor = false;
            this.fcabtn.Click += new System.EventHandler(this.fcabtn_Click);
            // 
            // fcobtn
            // 
            this.fcobtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.fcobtn.Location = new System.Drawing.Point(68, 87);
            this.fcobtn.Name = "fcobtn";
            this.fcobtn.Size = new System.Drawing.Size(107, 29);
            this.fcobtn.TabIndex = 10;
            this.fcobtn.Text = "Medium";
            this.fcobtn.UseVisualStyleBackColor = false;
            this.fcobtn.Click += new System.EventHandler(this.fcobtn_Click);
            // 
            // fccbtn
            // 
            this.fccbtn.BackColor = System.Drawing.Color.Yellow;
            this.fccbtn.Location = new System.Drawing.Point(68, 134);
            this.fccbtn.Name = "fccbtn";
            this.fccbtn.Size = new System.Drawing.Size(107, 29);
            this.fccbtn.TabIndex = 11;
            this.fccbtn.Text = "High";
            this.fccbtn.UseVisualStyleBackColor = false;
            this.fccbtn.Click += new System.EventHandler(this.fccbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 548);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bsabtn;
        private System.Windows.Forms.Button bsobtn;
        private System.Windows.Forms.Button bscbtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button sdabtn;
        private System.Windows.Forms.Button sdobtn;
        private System.Windows.Forms.Button sdcbtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button iyabtn;
        private System.Windows.Forms.Button iyobtn;
        private System.Windows.Forms.Button iycbtn;
        private System.Windows.Forms.Button iabtn;
        private System.Windows.Forms.Button ikbtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button fcabtn;
        private System.Windows.Forms.Button fcobtn;
        private System.Windows.Forms.Button fccbtn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}

