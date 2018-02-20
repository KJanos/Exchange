namespace Exchange
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
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_Insert
            // 
            this.text_Insert.Location = new System.Drawing.Point(17, 42);
            this.text_Insert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_Insert.Name = "text_Insert";
            this.text_Insert.Size = new System.Drawing.Size(160, 22);
            this.text_Insert.TabIndex = 0;
            // 
            // text_Result
            // 
            this.text_Result.Location = new System.Drawing.Point(247, 42);
            this.text_Result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_Result.Name = "text_Result";
            this.text_Result.Size = new System.Drawing.Size(160, 22);
            this.text_Result.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insert";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result";
            // 
            // combo_From
            // 
            this.combo_From.FormattingEnabled = true;
            this.combo_From.Location = new System.Drawing.Point(17, 110);
            this.combo_From.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_From.Name = "combo_From";
            this.combo_From.Size = new System.Drawing.Size(160, 24);
            this.combo_From.TabIndex = 4;
            // 
            // combo_To
            // 
            this.combo_To.FormattingEnabled = true;
            this.combo_To.Location = new System.Drawing.Point(247, 108);
            this.combo_To.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_To.Name = "combo_To";
            this.combo_To.Size = new System.Drawing.Size(160, 24);
            this.combo_To.TabIndex = 5;
            // 
            // button_Result
            // 
            this.button_Result.Location = new System.Drawing.Point(79, 177);
            this.button_Result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Result.Name = "button_Result";
            this.button_Result.Size = new System.Drawing.Size(100, 28);
            this.button_Result.TabIndex = 6;
            this.button_Result.Text = "Result";
            this.button_Result.UseVisualStyleBackColor = true;
            this.button_Result.Click += new System.EventHandler(this.button_Result_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(247, 176);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(100, 28);
            this.button_Clear.TabIndex = 7;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(77, 231);
            this.button_Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(100, 28);
            this.button_Add.TabIndex = 8;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(251, 230);
            this.button_Remove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(100, 28);
            this.button_Remove.TabIndex = 9;
            this.button_Remove.Text = "Remove Last Item";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 321);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Result);
            this.Controls.Add(this.combo_To);
            this.Controls.Add(this.combo_From);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_Result);
            this.Controls.Add(this.text_Insert);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button button_Result;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Add;
        public System.Windows.Forms.ComboBox combo_From;
        public System.Windows.Forms.ComboBox combo_To;
        private System.Windows.Forms.Button button_Remove;
    }
}

