﻿namespace Exchange
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_Insert = new System.Windows.Forms.TextBox();
            this.text_Result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_From = new System.Windows.Forms.ComboBox();
            this.combo_To = new System.Windows.Forms.ComboBox();
            this.button_Result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_Insert
            // 
            this.text_Insert.Location = new System.Drawing.Point(13, 34);
            this.text_Insert.Name = "text_Insert";
            this.text_Insert.Size = new System.Drawing.Size(121, 20);
            this.text_Insert.TabIndex = 0;
            // 
            // text_Result
            // 
            this.text_Result.Location = new System.Drawing.Point(185, 34);
            this.text_Result.Name = "text_Result";
            this.text_Result.Size = new System.Drawing.Size(121, 20);
            this.text_Result.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insert";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result";
            // 
            // combo_From
            // 
            this.combo_From.FormattingEnabled = true;
            this.combo_From.Items.AddRange(new object[] {
            "UAH",
            "USD",
            "EUR",
            "RUB",
            "HUF"});
            this.combo_From.Location = new System.Drawing.Point(13, 89);
            this.combo_From.Name = "combo_From";
            this.combo_From.Size = new System.Drawing.Size(121, 21);
            this.combo_From.TabIndex = 4;
            // 
            // combo_To
            // 
            this.combo_To.FormattingEnabled = true;
            this.combo_To.Items.AddRange(new object[] {
            "UAH",
            "USD",
            "EUR",
            "RUB",
            "HUF"});
            this.combo_To.Location = new System.Drawing.Point(185, 88);
            this.combo_To.Name = "combo_To";
            this.combo_To.Size = new System.Drawing.Size(121, 21);
            this.combo_To.TabIndex = 5;
            // 
            // button_Result
            // 
            this.button_Result.Location = new System.Drawing.Point(59, 144);
            this.button_Result.Name = "button_Result";
            this.button_Result.Size = new System.Drawing.Size(75, 23);
            this.button_Result.TabIndex = 6;
            this.button_Result.Text = "Result";
            this.button_Result.UseVisualStyleBackColor = true;
            this.button_Result.Click += new System.EventHandler(this.button_Result_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 261);
            this.Controls.Add(this.button_Result);
            this.Controls.Add(this.combo_To);
            this.Controls.Add(this.combo_From);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_Result);
            this.Controls.Add(this.text_Insert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_Insert;
        private System.Windows.Forms.TextBox text_Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_From;
        private System.Windows.Forms.ComboBox combo_To;
        private System.Windows.Forms.Button button_Result;
    }
}
