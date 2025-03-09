namespace day10_winform
{
    partial class form1
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
            question_text = new TextBox();
            solution_textbox = new TextBox();
            button1 = new Button();
            solution_label = new Label();
            SuspendLayout();
            // 
            // question_text
            // 
            question_text.Font = new Font("Segoe UI", 20F);
            question_text.Location = new Point(75, 43);
            question_text.Multiline = true;
            question_text.Name = "question_text";
            question_text.Size = new Size(462, 65);
            question_text.TabIndex = 0;
            // 
            // solution_textbox
            // 
            solution_textbox.Font = new Font("Segoe UI", 20F);
            solution_textbox.ForeColor = Color.ForestGreen;
            solution_textbox.Location = new Point(75, 142);
            solution_textbox.Multiline = true;
            solution_textbox.Name = "solution_textbox";
            solution_textbox.Size = new Size(270, 65);
            solution_textbox.TabIndex = 1;
            solution_textbox.Text = "0";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F);
            button1.Location = new Point(579, 55);
            button1.Name = "button1";
            button1.Size = new Size(177, 53);
            button1.TabIndex = 2;
            button1.Text = "คำนวณ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // solution_label
            // 
            solution_label.AutoSize = true;
            solution_label.Font = new Font("Segoe UI", 20F);
            solution_label.ForeColor = Color.Red;
            solution_label.Location = new Point(437, 161);
            solution_label.Name = "solution_label";
            solution_label.Size = new Size(38, 46);
            solution_label.TabIndex = 3;
            solution_label.Text = "0";
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(solution_label);
            Controls.Add(button1);
            Controls.Add(solution_textbox);
            Controls.Add(question_text);
            Name = "form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox question_text;
        private TextBox solution_textbox;
        private Button button1;
        private Label solution_label;
    }
}
