
namespace ADonet
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(592, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 49;
            this.dataGridView1.Size = new System.Drawing.Size(1791, 1142);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(493, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вывести всё";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(493, 61);
            this.button2.TabIndex = 2;
            this.button2.Text = "Вывести все названия";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1049, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(493, 61);
            this.button3.TabIndex = 3;
            this.button3.Text = "Вывести все цвета";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 97);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(493, 61);
            this.button4.TabIndex = 4;
            this.button4.Text = "Максимальная калорийность";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(530, 97);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(493, 61);
            this.button5.TabIndex = 5;
            this.button5.Text = "Минимальная калорийность";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1049, 97);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(493, 61);
            this.button6.TabIndex = 6;
            this.button6.Text = "Средняя калорийность";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1673, 115);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(319, 61);
            this.button7.TabIndex = 7;
            this.button7.Text = "Количество овощей";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(2024, 115);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(346, 61);
            this.button8.TabIndex = 8;
            this.button8.Text = "Количество фруктов";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 182);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(762, 61);
            this.button9.TabIndex = 9;
            this.button9.Text = "Вывести только красные и желтые цвета";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Location = new System.Drawing.Point(1854, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(302, 49);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "Выберете цвет";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(809, 182);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(733, 61);
            this.button10.TabIndex = 11;
            this.button10.Text = "Вывести количество каждого цвета";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(379, 305);
            this.textBox1.MaxLength = 6;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 47);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(107, 724);
            this.textBoxFrom.MaxLength = 6;
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(153, 47);
            this.textBoxFrom.TabIndex = 13;
            this.textBoxFrom.Text = "0";
            this.textBoxFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(24, 379);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(522, 61);
            this.button11.TabIndex = 14;
            this.button11.Text = "Вывести с меньшей калорийностью";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(24, 465);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(522, 61);
            this.button12.TabIndex = 15;
            this.button12.Text = "Вывести с большей калорийностью";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 41);
            this.label1.TabIndex = 16;
            this.label1.Text = "Введите калорийность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 730);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 41);
            this.label2.TabIndex = 17;
            this.label2.Text = "От";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 662);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 41);
            this.label3.TabIndex = 18;
            this.label3.Text = "Введите калорийность:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 730);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 41);
            this.label4.TabIndex = 19;
            this.label4.Text = "До";
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(352, 724);
            this.textBoxTo.MaxLength = 6;
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(153, 47);
            this.textBoxTo.TabIndex = 20;
            this.textBoxTo.Text = "10000";
            this.textBoxTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(24, 808);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(522, 61);
            this.button13.TabIndex = 21;
            this.button13.Text = "Показать";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2408, 1456);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Button button13;
    }
}

