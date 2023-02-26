namespace Calculator
{
    partial class Calculator
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
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            display = new TextBox();
            button2 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button3 = new Button();
            button16 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveBorder;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 67);
            button1.Name = "button1";
            button1.Size = new Size(174, 40);
            button1.TabIndex = 0;
            button1.Text = "C";
            button1.UseVisualStyleBackColor = false;
            button1.Click += ClearButton;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.InactiveBorder;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(282, 67);
            button4.Name = "button4";
            button4.Size = new Size(85, 40);
            button4.TabIndex = 3;
            button4.Text = "+";
            button4.UseVisualStyleBackColor = false;
            button4.Click += buttonClick;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.InactiveBorder;
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(192, 67);
            button5.Name = "button5";
            button5.Size = new Size(85, 40);
            button5.TabIndex = 5;
            button5.Text = "CE";
            button5.UseVisualStyleBackColor = false;
            button5.Click += ClearEntry;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.InactiveBorder;
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(102, 120);
            button6.Name = "button6";
            button6.Size = new Size(85, 40);
            button6.TabIndex = 9;
            button6.Text = "8";
            button6.UseVisualStyleBackColor = false;
            button6.Click += buttonClick;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.InactiveBorder;
            button7.Cursor = Cursors.Hand;
            button7.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(282, 120);
            button7.Name = "button7";
            button7.Size = new Size(85, 40);
            button7.TabIndex = 8;
            button7.Text = "-";
            button7.UseVisualStyleBackColor = false;
            button7.Click += buttonClick;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.InactiveBorder;
            button8.Cursor = Cursors.Hand;
            button8.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(192, 120);
            button8.Name = "button8";
            button8.Size = new Size(85, 40);
            button8.TabIndex = 7;
            button8.Text = "9";
            button8.UseVisualStyleBackColor = false;
            button8.Click += buttonClick;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.InactiveBorder;
            button9.Cursor = Cursors.Hand;
            button9.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(12, 120);
            button9.Name = "button9";
            button9.Size = new Size(85, 40);
            button9.TabIndex = 6;
            button9.Text = "7";
            button9.UseVisualStyleBackColor = false;
            button9.Click += buttonClick;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.InactiveBorder;
            button10.Cursor = Cursors.Hand;
            button10.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(102, 173);
            button10.Name = "button10";
            button10.Size = new Size(85, 40);
            button10.TabIndex = 13;
            button10.Text = "5";
            button10.UseVisualStyleBackColor = false;
            button10.Click += buttonClick;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.InactiveBorder;
            button11.Cursor = Cursors.Hand;
            button11.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button11.Location = new Point(282, 173);
            button11.Name = "button11";
            button11.Size = new Size(85, 40);
            button11.TabIndex = 12;
            button11.Text = "*";
            button11.UseVisualStyleBackColor = false;
            button11.Click += buttonClick;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.InactiveBorder;
            button12.Cursor = Cursors.Hand;
            button12.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button12.Location = new Point(192, 173);
            button12.Name = "button12";
            button12.Size = new Size(85, 40);
            button12.TabIndex = 11;
            button12.Text = "6";
            button12.UseVisualStyleBackColor = false;
            button12.Click += buttonClick;
            // 
            // button13
            // 
            button13.BackColor = SystemColors.InactiveBorder;
            button13.Cursor = Cursors.Hand;
            button13.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button13.Location = new Point(12, 173);
            button13.Name = "button13";
            button13.Size = new Size(85, 40);
            button13.TabIndex = 10;
            button13.Text = "4";
            button13.UseVisualStyleBackColor = false;
            button13.Click += buttonClick;
            // 
            // button14
            // 
            button14.BackColor = SystemColors.InactiveBorder;
            button14.Cursor = Cursors.Hand;
            button14.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button14.Location = new Point(102, 226);
            button14.Name = "button14";
            button14.Size = new Size(85, 40);
            button14.TabIndex = 17;
            button14.Text = "2";
            button14.UseVisualStyleBackColor = false;
            button14.Click += buttonClick;
            // 
            // button15
            // 
            button15.BackColor = SystemColors.InactiveBorder;
            button15.Cursor = Cursors.Hand;
            button15.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button15.Location = new Point(282, 226);
            button15.Name = "button15";
            button15.Size = new Size(85, 40);
            button15.TabIndex = 16;
            button15.Text = "/";
            button15.UseVisualStyleBackColor = false;
            button15.Click += buttonClick;
            // 
            // display
            // 
            display.Location = new Point(12, 12);
            display.Name = "display";
            display.Size = new Size(354, 27);
            display.TabIndex = 18;
            display.TextChanged += display_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.InactiveBorder;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(102, 272);
            button2.Name = "button2";
            button2.Size = new Size(85, 40);
            button2.TabIndex = 22;
            button2.Text = "0";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonClick;
            // 
            // button18
            // 
            button18.BackColor = SystemColors.InactiveBorder;
            button18.Cursor = Cursors.Hand;
            button18.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button18.Location = new Point(282, 272);
            button18.Name = "button18";
            button18.Size = new Size(85, 40);
            button18.TabIndex = 21;
            button18.Text = "%";
            button18.UseVisualStyleBackColor = false;
            button18.Click += buttonClick;
            // 
            // button19
            // 
            button19.BackColor = SystemColors.InactiveBorder;
            button19.Cursor = Cursors.Hand;
            button19.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button19.Location = new Point(192, 272);
            button19.Name = "button19";
            button19.Size = new Size(85, 40);
            button19.TabIndex = 20;
            button19.Text = "Enter";
            button19.UseVisualStyleBackColor = false;
            button19.Click += EqualButton;
            // 
            // button20
            // 
            button20.BackColor = SystemColors.InactiveBorder;
            button20.Cursor = Cursors.Hand;
            button20.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button20.Location = new Point(12, 272);
            button20.Name = "button20";
            button20.Size = new Size(85, 40);
            button20.TabIndex = 19;
            button20.Text = ".";
            button20.UseVisualStyleBackColor = false;
            button20.Click += buttonClick;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.InactiveBorder;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(12, 226);
            button3.Name = "button3";
            button3.Size = new Size(85, 40);
            button3.TabIndex = 25;
            button3.Text = "1";
            button3.UseVisualStyleBackColor = false;
            button3.Click += buttonClick;
            // 
            // button16
            // 
            button16.BackColor = SystemColors.InactiveBorder;
            button16.Cursor = Cursors.Hand;
            button16.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button16.Location = new Point(192, 226);
            button16.Name = "button16";
            button16.Size = new Size(85, 40);
            button16.TabIndex = 26;
            button16.Text = "3";
            button16.UseVisualStyleBackColor = false;
            button16.Click += buttonClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(383, 326);
            Controls.Add(button16);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button18);
            Controls.Add(button19);
            Controls.Add(button20);
            Controls.Add(display);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button1);
            ForeColor = SystemColors.HotTrack;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private TextBox display;
        private Button button2;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button3;
        private Button button16;
    }
}