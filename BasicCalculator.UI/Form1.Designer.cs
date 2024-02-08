namespace BasicCalculator.UI
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
            txt_Total = new TextBox();
            lbl_Standard = new Label();
            btn_1 = new Button();
            btn_2 = new Button();
            btn_3 = new Button();
            btn_clear = new Button();
            btn_add = new Button();
            btn_6 = new Button();
            btn_5 = new Button();
            btn_4 = new Button();
            btn_sub = new Button();
            btn_9 = new Button();
            btn_8 = new Button();
            btn_7 = new Button();
            btn_mul = new Button();
            btn_div = new Button();
            btn_dec = new Button();
            btn_0 = new Button();
            btn_eq = new Button();
            SuspendLayout();
            // 
            // txt_Total
            // 
            txt_Total.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            txt_Total.Location = new Point(4, 44);
            txt_Total.Multiline = true;
            txt_Total.Name = "txt_Total";
            txt_Total.Size = new Size(302, 32);
            txt_Total.TabIndex = 0;
            txt_Total.Text = "0";
            txt_Total.TextAlign = HorizontalAlignment.Right;
            txt_Total.MouseLeave += txt_Total_MouseLeave;
            // 
            // lbl_Standard
            // 
            lbl_Standard.AutoSize = true;
            lbl_Standard.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Standard.Location = new Point(6, 10);
            lbl_Standard.Name = "lbl_Standard";
            lbl_Standard.Size = new Size(169, 20);
            lbl_Standard.TabIndex = 1;
            lbl_Standard.Text = "Standard Calculator";
            // 
            // btn_1
            // 
            btn_1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_1.Location = new Point(6, 116);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(66, 28);
            btn_1.TabIndex = 2;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += number_click;
            // 
            // btn_2
            // 
            btn_2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_2.Location = new Point(82, 116);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(66, 28);
            btn_2.TabIndex = 3;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += number_click;
            // 
            // btn_3
            // 
            btn_3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_3.Location = new Point(159, 116);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(66, 28);
            btn_3.TabIndex = 4;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += number_click;
            // 
            // btn_clear
            // 
            btn_clear.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_clear.Location = new Point(236, 116);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(66, 28);
            btn_clear.TabIndex = 5;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clr_Click;
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_add.Location = new Point(236, 165);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(66, 28);
            btn_add.TabIndex = 9;
            btn_add.Text = "+";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += Operator_Click;
            // 
            // btn_6
            // 
            btn_6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_6.Location = new Point(159, 165);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(66, 28);
            btn_6.TabIndex = 8;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += number_click;
            // 
            // btn_5
            // 
            btn_5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_5.Location = new Point(82, 165);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(66, 28);
            btn_5.TabIndex = 7;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += number_click;
            // 
            // btn_4
            // 
            btn_4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_4.Location = new Point(6, 165);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(66, 28);
            btn_4.TabIndex = 6;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += number_click;
            // 
            // btn_sub
            // 
            btn_sub.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sub.Location = new Point(236, 210);
            btn_sub.Name = "btn_sub";
            btn_sub.Size = new Size(66, 28);
            btn_sub.TabIndex = 13;
            btn_sub.Text = "-";
            btn_sub.UseVisualStyleBackColor = true;
            btn_sub.Click += Operator_Click;
            // 
            // btn_9
            // 
            btn_9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_9.Location = new Point(159, 210);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(66, 28);
            btn_9.TabIndex = 12;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += number_click;
            // 
            // btn_8
            // 
            btn_8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_8.Location = new Point(82, 210);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(66, 28);
            btn_8.TabIndex = 11;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += number_click;
            // 
            // btn_7
            // 
            btn_7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_7.Location = new Point(6, 210);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(66, 28);
            btn_7.TabIndex = 10;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += number_click;
            // 
            // btn_mul
            // 
            btn_mul.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_mul.Location = new Point(236, 254);
            btn_mul.Name = "btn_mul";
            btn_mul.Size = new Size(66, 28);
            btn_mul.TabIndex = 17;
            btn_mul.Text = "*";
            btn_mul.UseVisualStyleBackColor = true;
            btn_mul.Click += Operator_Click;
            // 
            // btn_div
            // 
            btn_div.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_div.Location = new Point(159, 254);
            btn_div.Name = "btn_div";
            btn_div.Size = new Size(66, 28);
            btn_div.TabIndex = 16;
            btn_div.Text = "/";
            btn_div.UseVisualStyleBackColor = true;
            btn_div.Click += Operator_Click;
            // 
            // btn_dec
            // 
            btn_dec.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Pixel);
            btn_dec.Location = new Point(82, 254);
            btn_dec.Name = "btn_dec";
            btn_dec.Size = new Size(66, 28);
            btn_dec.TabIndex = 15;
            btn_dec.Text = ".";
            btn_dec.UseVisualStyleBackColor = true;
            btn_dec.Click += btn_dec_Click;
            // 
            // btn_0
            // 
            btn_0.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_0.Location = new Point(6, 254);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(66, 28);
            btn_0.TabIndex = 14;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += number_click;
            // 
            // btn_eq
            // 
            btn_eq.BackColor = SystemColors.Highlight;
            btn_eq.FlatStyle = FlatStyle.Popup;
            btn_eq.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_eq.ForeColor = SystemColors.ControlLightLight;
            btn_eq.Location = new Point(6, 301);
            btn_eq.Name = "btn_eq";
            btn_eq.Size = new Size(296, 28);
            btn_eq.TabIndex = 18;
            btn_eq.Text = "=";
            btn_eq.UseVisualStyleBackColor = false;
            btn_eq.Click += btn_eq_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 341);
            Controls.Add(btn_eq);
            Controls.Add(btn_mul);
            Controls.Add(btn_div);
            Controls.Add(btn_dec);
            Controls.Add(btn_0);
            Controls.Add(btn_sub);
            Controls.Add(btn_9);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(btn_add);
            Controls.Add(btn_6);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_clear);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Controls.Add(lbl_Standard);
            Controls.Add(txt_Total);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Total;
        private Label lbl_Standard;
        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_clear;
        private Button btn_add;
        private Button btn_6;
        private Button btn_5;
        private Button btn_4;
        private Button btn_sub;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
        private Button btn_mul;
        private Button btn_div;
        private Button btn_dec;
        private Button btn_0;
        private Button btn_eq;
    }
}