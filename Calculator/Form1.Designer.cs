namespace Calculator
{
    partial class Calculator
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TextDisplay = new System.Windows.Forms.TextBox();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.ButtonPower = new System.Windows.Forms.Button();
            this.ButtonModulo = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonEquals = new System.Windows.Forms.Button();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonNumZero = new System.Windows.Forms.Button();
            this.ButtonPeriod = new System.Windows.Forms.Button();
            this.ButtonNum9 = new System.Windows.Forms.Button();
            this.ButtonNum8 = new System.Windows.Forms.Button();
            this.ButtonNum7 = new System.Windows.Forms.Button();
            this.ButtonNum6 = new System.Windows.Forms.Button();
            this.ButtonNum5 = new System.Windows.Forms.Button();
            this.ButtonNum4 = new System.Windows.Forms.Button();
            this.ButtonNum3 = new System.Windows.Forms.Button();
            this.ButtonNum2 = new System.Windows.Forms.Button();
            this.ButtonNum1 = new System.Windows.Forms.Button();
            this.labelOperationalNum = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.labelOperationalNum);
            this.MainPanel.Controls.Add(this.TextDisplay);
            this.MainPanel.Controls.Add(this.ButtonDivide);
            this.MainPanel.Controls.Add(this.ButtonPower);
            this.MainPanel.Controls.Add(this.ButtonModulo);
            this.MainPanel.Controls.Add(this.ButtonClear);
            this.MainPanel.Controls.Add(this.ButtonMinus);
            this.MainPanel.Controls.Add(this.ButtonPlus);
            this.MainPanel.Controls.Add(this.ButtonEquals);
            this.MainPanel.Controls.Add(this.ButtonMultiply);
            this.MainPanel.Controls.Add(this.ButtonDelete);
            this.MainPanel.Controls.Add(this.ButtonNumZero);
            this.MainPanel.Controls.Add(this.ButtonPeriod);
            this.MainPanel.Controls.Add(this.ButtonNum9);
            this.MainPanel.Controls.Add(this.ButtonNum8);
            this.MainPanel.Controls.Add(this.ButtonNum7);
            this.MainPanel.Controls.Add(this.ButtonNum6);
            this.MainPanel.Controls.Add(this.ButtonNum5);
            this.MainPanel.Controls.Add(this.ButtonNum4);
            this.MainPanel.Controls.Add(this.ButtonNum3);
            this.MainPanel.Controls.Add(this.ButtonNum2);
            this.MainPanel.Controls.Add(this.ButtonNum1);
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(454, 517);
            this.MainPanel.TabIndex = 0;
            // 
            // TextDisplay
            // 
            this.TextDisplay.BackColor = System.Drawing.SystemColors.WindowText;
            this.TextDisplay.Enabled = false;
            this.TextDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDisplay.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TextDisplay.Location = new System.Drawing.Point(11, 68);
            this.TextDisplay.Multiline = true;
            this.TextDisplay.Name = "TextDisplay";
            this.TextDisplay.Size = new System.Drawing.Size(427, 123);
            this.TextDisplay.TabIndex = 20;
            this.TextDisplay.Text = "0";
            this.TextDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.BackColor = System.Drawing.Color.DarkGreen;
            this.ButtonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDivide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonDivide.Location = new System.Drawing.Point(390, 238);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(48, 38);
            this.ButtonDivide.TabIndex = 19;
            this.ButtonDivide.Text = "/";
            this.ButtonDivide.UseVisualStyleBackColor = false;
            this.ButtonDivide.Click += new System.EventHandler(this.ButtonDivide_Click);
            // 
            // ButtonPower
            // 
            this.ButtonPower.BackColor = System.Drawing.Color.DarkGreen;
            this.ButtonPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPower.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonPower.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonPower.Location = new System.Drawing.Point(134, 238);
            this.ButtonPower.Name = "ButtonPower";
            this.ButtonPower.Size = new System.Drawing.Size(117, 35);
            this.ButtonPower.TabIndex = 18;
            this.ButtonPower.Text = "^";
            this.ButtonPower.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonPower.UseVisualStyleBackColor = false;
            this.ButtonPower.Click += new System.EventHandler(this.ButtonPower_Click);
            // 
            // ButtonModulo
            // 
            this.ButtonModulo.BackColor = System.Drawing.Color.DarkGreen;
            this.ButtonModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonModulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonModulo.Location = new System.Drawing.Point(11, 238);
            this.ButtonModulo.Name = "ButtonModulo";
            this.ButtonModulo.Size = new System.Drawing.Size(117, 37);
            this.ButtonModulo.TabIndex = 17;
            this.ButtonModulo.Text = "%";
            this.ButtonModulo.UseVisualStyleBackColor = false;
            this.ButtonModulo.Click += new System.EventHandler(this.ButtonModulo_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.Color.DarkGreen;
            this.ButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonClear.Location = new System.Drawing.Point(257, 430);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(117, 38);
            this.ButtonClear.TabIndex = 16;
            this.ButtonClear.Text = "C";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.BackColor = System.Drawing.Color.DarkGreen;
            this.ButtonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMinus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonMinus.Location = new System.Drawing.Point(390, 333);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(48, 38);
            this.ButtonMinus.TabIndex = 15;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = false;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.BackColor = System.Drawing.Color.DarkGreen;
            this.ButtonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPlus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonPlus.Location = new System.Drawing.Point(390, 381);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(48, 38);
            this.ButtonPlus.TabIndex = 14;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = false;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // ButtonEquals
            // 
            this.ButtonEquals.BackColor = System.Drawing.Color.DarkGreen;
            this.ButtonEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEquals.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonEquals.Location = new System.Drawing.Point(390, 430);
            this.ButtonEquals.Name = "ButtonEquals";
            this.ButtonEquals.Size = new System.Drawing.Size(48, 38);
            this.ButtonEquals.TabIndex = 13;
            this.ButtonEquals.Text = "=";
            this.ButtonEquals.UseVisualStyleBackColor = false;
            this.ButtonEquals.Click += new System.EventHandler(this.ButtonEquals_Click);
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.BackColor = System.Drawing.Color.DarkGreen;
            this.ButtonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMultiply.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonMultiply.Location = new System.Drawing.Point(390, 284);
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Size = new System.Drawing.Size(48, 38);
            this.ButtonMultiply.TabIndex = 12;
            this.ButtonMultiply.Text = "×";
            this.ButtonMultiply.UseVisualStyleBackColor = false;
            this.ButtonMultiply.Click += new System.EventHandler(this.ButtonMultiply_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.DarkGreen;
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonDelete.Location = new System.Drawing.Point(257, 238);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(117, 35);
            this.ButtonDelete.TabIndex = 11;
            this.ButtonDelete.Text = "⌫";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonNumZero
            // 
            this.ButtonNumZero.BackColor = System.Drawing.Color.Purple;
            this.ButtonNumZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNumZero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonNumZero.Location = new System.Drawing.Point(134, 430);
            this.ButtonNumZero.Name = "ButtonNumZero";
            this.ButtonNumZero.Size = new System.Drawing.Size(117, 38);
            this.ButtonNumZero.TabIndex = 10;
            this.ButtonNumZero.Text = "0";
            this.ButtonNumZero.UseVisualStyleBackColor = false;
            this.ButtonNumZero.Click += new System.EventHandler(this.ButtonNumZero_Click);
            // 
            // ButtonPeriod
            // 
            this.ButtonPeriod.BackColor = System.Drawing.Color.DarkGreen;
            this.ButtonPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPeriod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonPeriod.Location = new System.Drawing.Point(11, 430);
            this.ButtonPeriod.Name = "ButtonPeriod";
            this.ButtonPeriod.Size = new System.Drawing.Size(117, 38);
            this.ButtonPeriod.TabIndex = 9;
            this.ButtonPeriod.Text = ".";
            this.ButtonPeriod.UseVisualStyleBackColor = false;
            this.ButtonPeriod.Click += new System.EventHandler(this.ButtonPeriod_Click);
            // 
            // ButtonNum9
            // 
            this.ButtonNum9.BackColor = System.Drawing.Color.Purple;
            this.ButtonNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNum9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonNum9.Location = new System.Drawing.Point(257, 381);
            this.ButtonNum9.Name = "ButtonNum9";
            this.ButtonNum9.Size = new System.Drawing.Size(117, 38);
            this.ButtonNum9.TabIndex = 8;
            this.ButtonNum9.Text = "9";
            this.ButtonNum9.UseVisualStyleBackColor = false;
            this.ButtonNum9.Click += new System.EventHandler(this.ButtonNum9_Click);
            // 
            // ButtonNum8
            // 
            this.ButtonNum8.BackColor = System.Drawing.Color.Purple;
            this.ButtonNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNum8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonNum8.Location = new System.Drawing.Point(134, 381);
            this.ButtonNum8.Name = "ButtonNum8";
            this.ButtonNum8.Size = new System.Drawing.Size(117, 38);
            this.ButtonNum8.TabIndex = 7;
            this.ButtonNum8.Text = "8";
            this.ButtonNum8.UseVisualStyleBackColor = false;
            this.ButtonNum8.Click += new System.EventHandler(this.ButtonNum8_Click);
            // 
            // ButtonNum7
            // 
            this.ButtonNum7.BackColor = System.Drawing.Color.Purple;
            this.ButtonNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNum7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonNum7.Location = new System.Drawing.Point(11, 381);
            this.ButtonNum7.Name = "ButtonNum7";
            this.ButtonNum7.Size = new System.Drawing.Size(117, 38);
            this.ButtonNum7.TabIndex = 6;
            this.ButtonNum7.Text = "7";
            this.ButtonNum7.UseVisualStyleBackColor = false;
            this.ButtonNum7.Click += new System.EventHandler(this.ButtonNum7_Click);
            // 
            // ButtonNum6
            // 
            this.ButtonNum6.BackColor = System.Drawing.Color.Purple;
            this.ButtonNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNum6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonNum6.Location = new System.Drawing.Point(257, 333);
            this.ButtonNum6.Name = "ButtonNum6";
            this.ButtonNum6.Size = new System.Drawing.Size(117, 38);
            this.ButtonNum6.TabIndex = 5;
            this.ButtonNum6.Text = "6";
            this.ButtonNum6.UseVisualStyleBackColor = false;
            this.ButtonNum6.Click += new System.EventHandler(this.ButtonNum6_Click);
            // 
            // ButtonNum5
            // 
            this.ButtonNum5.BackColor = System.Drawing.Color.Purple;
            this.ButtonNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNum5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonNum5.Location = new System.Drawing.Point(134, 333);
            this.ButtonNum5.Name = "ButtonNum5";
            this.ButtonNum5.Size = new System.Drawing.Size(117, 38);
            this.ButtonNum5.TabIndex = 4;
            this.ButtonNum5.Text = "5";
            this.ButtonNum5.UseVisualStyleBackColor = false;
            this.ButtonNum5.Click += new System.EventHandler(this.ButtonNum5_Click);
            // 
            // ButtonNum4
            // 
            this.ButtonNum4.BackColor = System.Drawing.Color.Purple;
            this.ButtonNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNum4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonNum4.Location = new System.Drawing.Point(11, 333);
            this.ButtonNum4.Name = "ButtonNum4";
            this.ButtonNum4.Size = new System.Drawing.Size(117, 38);
            this.ButtonNum4.TabIndex = 3;
            this.ButtonNum4.Text = "4";
            this.ButtonNum4.UseVisualStyleBackColor = false;
            this.ButtonNum4.Click += new System.EventHandler(this.ButtonNum4_Click);
            // 
            // ButtonNum3
            // 
            this.ButtonNum3.BackColor = System.Drawing.Color.Purple;
            this.ButtonNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNum3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonNum3.Location = new System.Drawing.Point(257, 284);
            this.ButtonNum3.Name = "ButtonNum3";
            this.ButtonNum3.Size = new System.Drawing.Size(117, 38);
            this.ButtonNum3.TabIndex = 2;
            this.ButtonNum3.Text = "3";
            this.ButtonNum3.UseVisualStyleBackColor = false;
            this.ButtonNum3.Click += new System.EventHandler(this.ButtonNum3_Click);
            // 
            // ButtonNum2
            // 
            this.ButtonNum2.BackColor = System.Drawing.Color.Purple;
            this.ButtonNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNum2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonNum2.Location = new System.Drawing.Point(134, 284);
            this.ButtonNum2.Name = "ButtonNum2";
            this.ButtonNum2.Size = new System.Drawing.Size(117, 38);
            this.ButtonNum2.TabIndex = 1;
            this.ButtonNum2.Text = "2";
            this.ButtonNum2.UseVisualStyleBackColor = false;
            this.ButtonNum2.Click += new System.EventHandler(this.ButtonNum2_Click);
            // 
            // ButtonNum1
            // 
            this.ButtonNum1.BackColor = System.Drawing.Color.Purple;
            this.ButtonNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNum1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonNum1.Location = new System.Drawing.Point(11, 284);
            this.ButtonNum1.Name = "ButtonNum1";
            this.ButtonNum1.Size = new System.Drawing.Size(117, 38);
            this.ButtonNum1.TabIndex = 0;
            this.ButtonNum1.Text = "1";
            this.ButtonNum1.UseVisualStyleBackColor = false;
            this.ButtonNum1.Click += new System.EventHandler(this.ButtonNum1_Click);
            // 
            // labelOperationalNum
            // 
            this.labelOperationalNum.AutoSize = true;
            this.labelOperationalNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOperationalNum.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelOperationalNum.Location = new System.Drawing.Point(375, 165);
            this.labelOperationalNum.Name = "labelOperationalNum";
            this.labelOperationalNum.Size = new System.Drawing.Size(0, 16);
            this.labelOperationalNum.TabIndex = 21;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(478, 541);
            this.Controls.Add(this.MainPanel);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button ButtonDivide;
        private System.Windows.Forms.Button ButtonPower;
        private System.Windows.Forms.Button ButtonModulo;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button ButtonEquals;
        private System.Windows.Forms.Button ButtonMultiply;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonNumZero;
        private System.Windows.Forms.Button ButtonPeriod;
        private System.Windows.Forms.Button ButtonNum9;
        private System.Windows.Forms.Button ButtonNum8;
        private System.Windows.Forms.Button ButtonNum7;
        private System.Windows.Forms.Button ButtonNum6;
        private System.Windows.Forms.Button ButtonNum5;
        private System.Windows.Forms.Button ButtonNum4;
        private System.Windows.Forms.Button ButtonNum3;
        private System.Windows.Forms.Button ButtonNum2;
        private System.Windows.Forms.Button ButtonNum1;
        private System.Windows.Forms.TextBox TextDisplay;
        private System.Windows.Forms.Label labelOperationalNum;
    }
}

