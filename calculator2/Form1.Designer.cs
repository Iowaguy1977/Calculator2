﻿namespace calculator2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.CalculationWindow = new System.Windows.Forms.Label();
            this.SumWindow = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button19);
            this.panel1.Controls.Add(this.button18);
            this.panel1.Controls.Add(this.button17);
            this.panel1.Controls.Add(this.button16);
            this.panel1.Controls.Add(this.button15);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.CalculationWindow);
            this.panel1.Controls.Add(this.SumWindow);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(194, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 427);
            this.panel1.TabIndex = 0;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(111, 92);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(80, 30);
            this.button18.TabIndex = 19;
            this.button18.Text = "Backspace";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.BackSpaceClick);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(305, 319);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(80, 30);
            this.button17.TabIndex = 18;
            this.button17.Text = "=";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.EqualsClick);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(209, 92);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(80, 30);
            this.button16.TabIndex = 17;
            this.button16.Text = "Clear";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.ClearButtomClick);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(209, 319);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(80, 30);
            this.button15.TabIndex = 16;
            this.button15.Text = ".";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.DecimalClick);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(305, 263);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(80, 30);
            this.button14.TabIndex = 15;
            this.button14.Text = "/";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.OperationClick);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(305, 210);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(80, 30);
            this.button13.TabIndex = 14;
            this.button13.Text = "*";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.OperationClick);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(305, 145);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(80, 30);
            this.button12.TabIndex = 13;
            this.button12.Text = "-";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.OperationClick);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(305, 92);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(80, 30);
            this.button11.TabIndex = 12;
            this.button11.Text = "+";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.OperationClick);
            // 
            // CalculationWindow
            // 
            this.CalculationWindow.AutoSize = true;
            this.CalculationWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculationWindow.Location = new System.Drawing.Point(27, 18);
            this.CalculationWindow.MinimumSize = new System.Drawing.Size(345, 20);
            this.CalculationWindow.Name = "CalculationWindow";
            this.CalculationWindow.Size = new System.Drawing.Size(345, 20);
            this.CalculationWindow.TabIndex = 11;
            this.CalculationWindow.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SumWindow
            // 
            this.SumWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumWindow.Location = new System.Drawing.Point(30, 50);
            this.SumWindow.Name = "SumWindow";
            this.SumWindow.Size = new System.Drawing.Size(345, 24);
            this.SumWindow.TabIndex = 10;
            this.SumWindow.Text = "0";
            this.SumWindow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(111, 319);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(80, 30);
            this.button10.TabIndex = 9;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.NumberClick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(209, 263);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 30);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.NumberClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(111, 263);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 30);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.NumberClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(14, 263);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 30);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.NumberClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(209, 210);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 30);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.NumberClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(111, 210);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 30);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NumberClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(14, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 30);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NumberClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(209, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NumberClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NumberClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumberClick);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(19, 96);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 23);
            this.button19.TabIndex = 1;
            this.button19.Text = "History";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.HistoryClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SumWindow;
        private System.Windows.Forms.Label CalculationWindow;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
    }
}

