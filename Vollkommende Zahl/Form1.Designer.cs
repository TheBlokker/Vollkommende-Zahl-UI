namespace Vollkommende_Zahl
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
            label1 = new Label();
            calc_btn = new Button();
            input_txtbox = new TextBox();
            label2 = new Label();
            output_label = new Label();
            solve_label = new Label();
            reset_btn = new Button();
            about_btn = new Button();
            close_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Help;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(231, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 25);
            label1.TabIndex = 0;
            label1.Text = "Vollkommende Zahl";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // calc_btn
            // 
            calc_btn.AccessibleDescription = "Überprüft";
            calc_btn.Cursor = Cursors.Hand;
            calc_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            calc_btn.Location = new Point(439, 172);
            calc_btn.Name = "calc_btn";
            calc_btn.Size = new Size(104, 29);
            calc_btn.TabIndex = 1;
            calc_btn.Text = "Überprüfen";
            calc_btn.UseVisualStyleBackColor = true;
            calc_btn.Click += calc_btn_Click;
            // 
            // input_txtbox
            // 
            input_txtbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            input_txtbox.Location = new Point(194, 172);
            input_txtbox.Name = "input_txtbox";
            input_txtbox.Size = new Size(227, 29);
            input_txtbox.TabIndex = 2;
            input_txtbox.KeyPress += input_txtbox_enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.No;
            label2.Location = new Point(194, 238);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 3;
            label2.Text = "Ausgabe:";
            // 
            // output_label
            // 
            output_label.AutoSize = true;
            output_label.Location = new Point(301, 284);
            output_label.Name = "output_label";
            output_label.Size = new Size(0, 15);
            output_label.TabIndex = 4;
            // 
            // solve_label
            // 
            solve_label.AutoSize = true;
            solve_label.Cursor = Cursors.AppStarting;
            solve_label.Location = new Point(301, 238);
            solve_label.Name = "solve_label";
            solve_label.Size = new Size(210, 15);
            solve_label.TabIndex = 5;
            solve_label.Text = "Es wurde noch keine Eingabe gemacht";
            // 
            // reset_btn
            // 
            reset_btn.Cursor = Cursors.Hand;
            reset_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            reset_btn.Location = new Point(78, 423);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(114, 33);
            reset_btn.TabIndex = 6;
            reset_btn.Text = "Zurücksetzen";
            reset_btn.UseVisualStyleBackColor = true;
            reset_btn.Click += reset_btn_Click;
            // 
            // about_btn
            // 
            about_btn.Cursor = Cursors.Hand;
            about_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            about_btn.Location = new Point(12, 423);
            about_btn.Name = "about_btn";
            about_btn.Size = new Size(60, 33);
            about_btn.TabIndex = 7;
            about_btn.Text = "About";
            about_btn.UseVisualStyleBackColor = true;
            about_btn.Click += about_btn_Click;
            // 
            // close_btn
            // 
            close_btn.BackColor = SystemColors.ButtonFace;
            close_btn.Cursor = Cursors.Hand;
            close_btn.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
            close_btn.FlatAppearance.BorderSize = 4;
            close_btn.Location = new Point(613, 423);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(52, 33);
            close_btn.TabIndex = 8;
            close_btn.Text = "Close!";
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 461);
            Controls.Add(label1);
            Controls.Add(input_txtbox);
            Controls.Add(calc_btn);
            Controls.Add(close_btn);
            Controls.Add(about_btn);
            Controls.Add(reset_btn);
            Controls.Add(solve_label);
            Controls.Add(output_label);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Vollkommende Zahl";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button calc_btn;
        private TextBox input_txtbox;
        private Label label2;
        private Label output_label;
        private Label solve_label;
        private Button reset_btn;
        private Button about_btn;
        private Button close_btn;
    }
}