namespace ماشین_حساب
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
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_mines = new System.Windows.Forms.Button();
            this.btn_multiplay = new System.Windows.Forms.Button();
            this.btn_devide = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_number1 = new System.Windows.Forms.Label();
            this.lbl_number2 = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_sum
            // 
            this.btn_sum.Location = new System.Drawing.Point(278, 265);
            this.btn_sum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(50, 41);
            this.btn_sum.TabIndex = 2;
            this.btn_sum.Text = "+";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // btn_mines
            // 
            this.btn_mines.Location = new System.Drawing.Point(504, 263);
            this.btn_mines.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_mines.Name = "btn_mines";
            this.btn_mines.Size = new System.Drawing.Size(50, 41);
            this.btn_mines.TabIndex = 2;
            this.btn_mines.Text = "-";
            this.btn_mines.UseVisualStyleBackColor = true;
            this.btn_mines.Click += new System.EventHandler(this.btn_mines_Click);
            // 
            // btn_multiplay
            // 
            this.btn_multiplay.Location = new System.Drawing.Point(278, 385);
            this.btn_multiplay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_multiplay.Name = "btn_multiplay";
            this.btn_multiplay.Size = new System.Drawing.Size(50, 41);
            this.btn_multiplay.TabIndex = 2;
            this.btn_multiplay.Text = "*";
            this.btn_multiplay.UseVisualStyleBackColor = true;
            this.btn_multiplay.Click += new System.EventHandler(this.btn_multiplay_Click);
            // 
            // btn_devide
            // 
            this.btn_devide.Location = new System.Drawing.Point(504, 385);
            this.btn_devide.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_devide.Name = "btn_devide";
            this.btn_devide.Size = new System.Drawing.Size(50, 41);
            this.btn_devide.TabIndex = 2;
            this.btn_devide.Text = "/";
            this.btn_devide.UseVisualStyleBackColor = true;
            this.btn_devide.Click += new System.EventHandler(this.btn_devide_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(223, 489);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(150, 41);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "&Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_number1
            // 
            this.lbl_number1.AutoSize = true;
            this.lbl_number1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_number1.Location = new System.Drawing.Point(27, 42);
            this.lbl_number1.Name = "lbl_number1";
            this.lbl_number1.Size = new System.Drawing.Size(213, 27);
            this.lbl_number1.TabIndex = 6;
            this.lbl_number1.Text = "Enter first number : ";
            // 
            // lbl_number2
            // 
            this.lbl_number2.AutoSize = true;
            this.lbl_number2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_number2.Location = new System.Drawing.Point(27, 129);
            this.lbl_number2.Name = "lbl_number2";
            this.lbl_number2.Size = new System.Drawing.Size(244, 27);
            this.lbl_number2.TabIndex = 7;
            this.lbl_number2.Text = "Enter second number : ";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(403, 200);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 27);
            this.lbl_result.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(323, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(411, 43);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(323, 113);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(411, 43);
            this.textBox2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 563);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_number2);
            this.Controls.Add(this.lbl_number1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_devide);
            this.Controls.Add(this.btn_multiplay);
            this.Controls.Add(this.btn_mines);
            this.Controls.Add(this.btn_sum);
            this.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Button btn_mines;
        private System.Windows.Forms.Button btn_multiplay;
        private System.Windows.Forms.Button btn_devide;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_number1;
        private System.Windows.Forms.Label lbl_number2;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

