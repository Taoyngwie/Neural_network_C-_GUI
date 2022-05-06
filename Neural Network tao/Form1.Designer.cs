
namespace Neural_Network_tao
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_pathfile = new System.Windows.Forms.TextBox();
            this.button_browse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_weight3 = new System.Windows.Forms.Label();
            this.label_weight2 = new System.Windows.Forms.Label();
            this.label_weight1 = new System.Windows.Forms.Label();
            this.textBox_Output = new System.Windows.Forms.TextBox();
            this.textBox_input3 = new System.Windows.Forms.TextBox();
            this.textBox_input2 = new System.Windows.Forms.TextBox();
            this.textBox_input1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_NumberOfIteration = new System.Windows.Forms.TextBox();
            this.button_predict = new System.Windows.Forms.Button();
            this.button_train = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.textBox_pathfile);
            this.groupBox1.Controls.Add(this.button_browse);
            this.groupBox1.Location = new System.Drawing.Point(35, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INPUT";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox_pathfile
            // 
            this.textBox_pathfile.Location = new System.Drawing.Point(16, 30);
            this.textBox_pathfile.Name = "textBox_pathfile";
            this.textBox_pathfile.Size = new System.Drawing.Size(603, 22);
            this.textBox_pathfile.TabIndex = 3;
            this.textBox_pathfile.TextChanged += new System.EventHandler(this.textBox_pathfile_TextChanged);
            // 
            // button_browse
            // 
            this.button_browse.AccessibleName = "";
            this.button_browse.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_browse.Location = new System.Drawing.Point(636, 21);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(87, 41);
            this.button_browse.TabIndex = 0;
            this.button_browse.Text = "Browse";
            this.button_browse.UseVisualStyleBackColor = false;
            this.button_browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_NumberOfIteration);
            this.groupBox2.Controls.Add(this.button_predict);
            this.groupBox2.Controls.Add(this.button_train);
            this.groupBox2.Location = new System.Drawing.Point(33, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(730, 364);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BOT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(342, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Output";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Neural_Network_tao.Properties.Resources.My_project;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.label_weight3);
            this.panel1.Controls.Add(this.label_weight2);
            this.panel1.Controls.Add(this.label_weight1);
            this.panel1.Controls.Add(this.textBox_Output);
            this.panel1.Controls.Add(this.textBox_input3);
            this.panel1.Controls.Add(this.textBox_input2);
            this.panel1.Controls.Add(this.textBox_input1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(86, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 276);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_weight3
            // 
            this.label_weight3.AutoSize = true;
            this.label_weight3.Location = new System.Drawing.Point(399, 175);
            this.label_weight3.Name = "label_weight3";
            this.label_weight3.Size = new System.Drawing.Size(44, 17);
            this.label_weight3.TabIndex = 16;
            this.label_weight3.Text = "0.000";
            this.label_weight3.Click += new System.EventHandler(this.label_weight3_Click);
            // 
            // label_weight2
            // 
            this.label_weight2.AutoSize = true;
            this.label_weight2.Location = new System.Drawing.Point(261, 150);
            this.label_weight2.Name = "label_weight2";
            this.label_weight2.Size = new System.Drawing.Size(44, 17);
            this.label_weight2.TabIndex = 15;
            this.label_weight2.Text = "0.000";
            this.label_weight2.Click += new System.EventHandler(this.label_weight2_Click);
            // 
            // label_weight1
            // 
            this.label_weight1.AutoSize = true;
            this.label_weight1.Location = new System.Drawing.Point(106, 175);
            this.label_weight1.Name = "label_weight1";
            this.label_weight1.Size = new System.Drawing.Size(44, 17);
            this.label_weight1.TabIndex = 14;
            this.label_weight1.Text = "0.000";
            this.label_weight1.Click += new System.EventHandler(this.label_weight1_Click);
            // 
            // textBox_Output
            // 
            this.textBox_Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Output.Location = new System.Drawing.Point(228, 186);
            this.textBox_Output.Name = "textBox_Output";
            this.textBox_Output.Size = new System.Drawing.Size(109, 68);
            this.textBox_Output.TabIndex = 13;
            this.textBox_Output.TextChanged += new System.EventHandler(this.textBox_Output_TextChanged);
            // 
            // textBox_input3
            // 
            this.textBox_input3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_input3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_input3.Location = new System.Drawing.Point(374, 38);
            this.textBox_input3.Name = "textBox_input3";
            this.textBox_input3.Size = new System.Drawing.Size(109, 91);
            this.textBox_input3.TabIndex = 12;
            this.textBox_input3.TextChanged += new System.EventHandler(this.textBox_input3_TextChanged);
            // 
            // textBox_input2
            // 
            this.textBox_input2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_input2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_input2.Location = new System.Drawing.Point(228, 38);
            this.textBox_input2.Name = "textBox_input2";
            this.textBox_input2.Size = new System.Drawing.Size(109, 91);
            this.textBox_input2.TabIndex = 11;
            this.textBox_input2.TextChanged += new System.EventHandler(this.textBox_input2_TextChanged);
            // 
            // textBox_input1
            // 
            this.textBox_input1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_input1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_input1.Location = new System.Drawing.Point(76, 38);
            this.textBox_input1.Name = "textBox_input1";
            this.textBox_input1.Size = new System.Drawing.Size(109, 91);
            this.textBox_input1.TabIndex = 10;
            this.textBox_input1.TextChanged += new System.EventHandler(this.textBox_input1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(409, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Input3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(256, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Input2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(105, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Input1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of Iteration";
            // 
            // textBox_NumberOfIteration
            // 
            this.textBox_NumberOfIteration.Location = new System.Drawing.Point(142, 30);
            this.textBox_NumberOfIteration.Name = "textBox_NumberOfIteration";
            this.textBox_NumberOfIteration.Size = new System.Drawing.Size(479, 22);
            this.textBox_NumberOfIteration.TabIndex = 4;
            this.textBox_NumberOfIteration.TextChanged += new System.EventHandler(this.textBox_NumberOfIteration_TextChanged);
            // 
            // button_predict
            // 
            this.button_predict.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_predict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_predict.Location = new System.Drawing.Point(637, 77);
            this.button_predict.Name = "button_predict";
            this.button_predict.Size = new System.Drawing.Size(87, 41);
            this.button_predict.TabIndex = 2;
            this.button_predict.Text = "Predict";
            this.button_predict.UseVisualStyleBackColor = false;
            this.button_predict.Click += new System.EventHandler(this.button_predict_Click);
            // 
            // button_train
            // 
            this.button_train.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_train.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_train.Location = new System.Drawing.Point(637, 21);
            this.button_train.Name = "button_train";
            this.button_train.Size = new System.Drawing.Size(87, 41);
            this.button_train.TabIndex = 1;
            this.button_train.Text = "Train";
            this.button_train.UseVisualStyleBackColor = false;
            this.button_train.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(797, 610);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_pathfile;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_NumberOfIteration;
        private System.Windows.Forms.Button button_predict;
        private System.Windows.Forms.Button button_train;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Output;
        private System.Windows.Forms.TextBox textBox_input3;
        private System.Windows.Forms.TextBox textBox_input2;
        private System.Windows.Forms.TextBox textBox_input1;
        private System.Windows.Forms.Label label_weight3;
        private System.Windows.Forms.Label label_weight2;
        private System.Windows.Forms.Label label_weight1;
    }
}

