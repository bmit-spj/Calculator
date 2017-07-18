namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numOne = new System.Windows.Forms.Button();
            this.numThree = new System.Windows.Forms.Button();
            this.numTwo = new System.Windows.Forms.Button();
            this.numFour = new System.Windows.Forms.Button();
            this.numSeven = new System.Windows.Forms.Button();
            this.numSix = new System.Windows.Forms.Button();
            this.numFive = new System.Windows.Forms.Button();
            this.numZero = new System.Windows.Forms.Button();
            this.numNine = new System.Windows.Forms.Button();
            this.numEight = new System.Windows.Forms.Button();
            this.calcPlus = new System.Windows.Forms.Button();
            this.calcClearEntry = new System.Windows.Forms.Button();
            this.calcClear = new System.Windows.Forms.Button();
            this.calcComma = new System.Windows.Forms.Button();
            this.calcMultiply = new System.Windows.Forms.Button();
            this.calcEnter = new System.Windows.Forms.Button();
            this.calcDivision = new System.Windows.Forms.Button();
            this.calcMinus = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numOne
            // 
            this.numOne.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOne.Location = new System.Drawing.Point(12, 223);
            this.numOne.Name = "numOne";
            this.numOne.Size = new System.Drawing.Size(50, 50);
            this.numOne.TabIndex = 0;
            this.numOne.Text = "1";
            this.numOne.UseVisualStyleBackColor = true;
            this.numOne.Click += new System.EventHandler(this.numOne_Click);
            // 
            // numThree
            // 
            this.numThree.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numThree.Location = new System.Drawing.Point(124, 223);
            this.numThree.Name = "numThree";
            this.numThree.Size = new System.Drawing.Size(50, 50);
            this.numThree.TabIndex = 1;
            this.numThree.Text = "3";
            this.numThree.UseVisualStyleBackColor = true;
            this.numThree.Click += new System.EventHandler(this.numOne_Click);
            // 
            // numTwo
            // 
            this.numTwo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTwo.Location = new System.Drawing.Point(68, 223);
            this.numTwo.Name = "numTwo";
            this.numTwo.Size = new System.Drawing.Size(50, 50);
            this.numTwo.TabIndex = 2;
            this.numTwo.Text = "2";
            this.numTwo.UseVisualStyleBackColor = true;
            this.numTwo.Click += new System.EventHandler(this.numOne_Click);
            // 
            // numFour
            // 
            this.numFour.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFour.Location = new System.Drawing.Point(12, 167);
            this.numFour.Name = "numFour";
            this.numFour.Size = new System.Drawing.Size(50, 50);
            this.numFour.TabIndex = 3;
            this.numFour.Text = "4";
            this.numFour.UseVisualStyleBackColor = true;
            this.numFour.Click += new System.EventHandler(this.numOne_Click);
            // 
            // numSeven
            // 
            this.numSeven.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSeven.Location = new System.Drawing.Point(12, 111);
            this.numSeven.Name = "numSeven";
            this.numSeven.Size = new System.Drawing.Size(50, 50);
            this.numSeven.TabIndex = 4;
            this.numSeven.Text = "7";
            this.numSeven.UseVisualStyleBackColor = true;
            this.numSeven.Click += new System.EventHandler(this.numOne_Click);
            // 
            // numSix
            // 
            this.numSix.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSix.Location = new System.Drawing.Point(124, 167);
            this.numSix.Name = "numSix";
            this.numSix.Size = new System.Drawing.Size(50, 50);
            this.numSix.TabIndex = 5;
            this.numSix.Text = "6";
            this.numSix.UseVisualStyleBackColor = true;
            this.numSix.Click += new System.EventHandler(this.numOne_Click);
            // 
            // numFive
            // 
            this.numFive.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFive.Location = new System.Drawing.Point(68, 167);
            this.numFive.Name = "numFive";
            this.numFive.Size = new System.Drawing.Size(50, 50);
            this.numFive.TabIndex = 6;
            this.numFive.Text = "5";
            this.numFive.UseVisualStyleBackColor = true;
            this.numFive.Click += new System.EventHandler(this.numOne_Click);
            // 
            // numZero
            // 
            this.numZero.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numZero.Location = new System.Drawing.Point(12, 279);
            this.numZero.Name = "numZero";
            this.numZero.Size = new System.Drawing.Size(105, 50);
            this.numZero.TabIndex = 7;
            this.numZero.Text = "0";
            this.numZero.UseVisualStyleBackColor = true;
            this.numZero.Click += new System.EventHandler(this.numOne_Click);
            // 
            // numNine
            // 
            this.numNine.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNine.Location = new System.Drawing.Point(124, 111);
            this.numNine.Name = "numNine";
            this.numNine.Size = new System.Drawing.Size(50, 50);
            this.numNine.TabIndex = 8;
            this.numNine.Text = "9";
            this.numNine.UseVisualStyleBackColor = true;
            this.numNine.Click += new System.EventHandler(this.numOne_Click);
            // 
            // numEight
            // 
            this.numEight.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEight.Location = new System.Drawing.Point(68, 111);
            this.numEight.Name = "numEight";
            this.numEight.Size = new System.Drawing.Size(50, 50);
            this.numEight.TabIndex = 9;
            this.numEight.Text = "8";
            this.numEight.UseVisualStyleBackColor = true;
            this.numEight.Click += new System.EventHandler(this.numOne_Click);
            // 
            // calcPlus
            // 
            this.calcPlus.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcPlus.Location = new System.Drawing.Point(196, 111);
            this.calcPlus.Name = "calcPlus";
            this.calcPlus.Size = new System.Drawing.Size(50, 50);
            this.calcPlus.TabIndex = 10;
            this.calcPlus.Text = "+";
            this.calcPlus.UseVisualStyleBackColor = true;
            this.calcPlus.Click += new System.EventHandler(this.operator_click);
            // 
            // calcClearEntry
            // 
            this.calcClearEntry.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcClearEntry.Location = new System.Drawing.Point(252, 111);
            this.calcClearEntry.Name = "calcClearEntry";
            this.calcClearEntry.Size = new System.Drawing.Size(50, 50);
            this.calcClearEntry.TabIndex = 11;
            this.calcClearEntry.Text = "CE";
            this.calcClearEntry.UseVisualStyleBackColor = true;
            this.calcClearEntry.Click += new System.EventHandler(this.calcClearEntry_Click);
            // 
            // calcClear
            // 
            this.calcClear.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcClear.Location = new System.Drawing.Point(252, 167);
            this.calcClear.Name = "calcClear";
            this.calcClear.Size = new System.Drawing.Size(50, 50);
            this.calcClear.TabIndex = 12;
            this.calcClear.Text = "C";
            this.calcClear.UseVisualStyleBackColor = true;
            this.calcClear.Click += new System.EventHandler(this.calcClear_Click);
            // 
            // calcComma
            // 
            this.calcComma.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcComma.Location = new System.Drawing.Point(124, 279);
            this.calcComma.Name = "calcComma";
            this.calcComma.Size = new System.Drawing.Size(50, 50);
            this.calcComma.TabIndex = 13;
            this.calcComma.Text = ",";
            this.calcComma.UseVisualStyleBackColor = true;
            this.calcComma.Click += new System.EventHandler(this.numOne_Click);
            // 
            // calcMultiply
            // 
            this.calcMultiply.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcMultiply.Location = new System.Drawing.Point(196, 279);
            this.calcMultiply.Name = "calcMultiply";
            this.calcMultiply.Size = new System.Drawing.Size(50, 50);
            this.calcMultiply.TabIndex = 14;
            this.calcMultiply.Text = "*";
            this.calcMultiply.UseVisualStyleBackColor = true;
            this.calcMultiply.Click += new System.EventHandler(this.operator_click);
            // 
            // calcEnter
            // 
            this.calcEnter.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcEnter.Location = new System.Drawing.Point(252, 223);
            this.calcEnter.Name = "calcEnter";
            this.calcEnter.Size = new System.Drawing.Size(50, 105);
            this.calcEnter.TabIndex = 15;
            this.calcEnter.Text = "=";
            this.calcEnter.UseVisualStyleBackColor = true;
            this.calcEnter.Click += new System.EventHandler(this.calcEnter_Click);
            // 
            // calcDivision
            // 
            this.calcDivision.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcDivision.Location = new System.Drawing.Point(196, 223);
            this.calcDivision.Name = "calcDivision";
            this.calcDivision.Size = new System.Drawing.Size(50, 50);
            this.calcDivision.TabIndex = 16;
            this.calcDivision.Text = "/";
            this.calcDivision.UseVisualStyleBackColor = true;
            this.calcDivision.Click += new System.EventHandler(this.operator_click);
            // 
            // calcMinus
            // 
            this.calcMinus.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcMinus.Location = new System.Drawing.Point(196, 167);
            this.calcMinus.Name = "calcMinus";
            this.calcMinus.Size = new System.Drawing.Size(50, 50);
            this.calcMinus.TabIndex = 17;
            this.calcMinus.Text = "-";
            this.calcMinus.UseVisualStyleBackColor = true;
            this.calcMinus.Click += new System.EventHandler(this.operator_click);
            // 
            // textResult
            // 
            this.textResult.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResult.Location = new System.Drawing.Point(12, 65);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(290, 29);
            this.textResult.TabIndex = 18;
            this.textResult.Text = "0";
            this.textResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.BackColor = System.Drawing.SystemColors.Control;
            this.labelInput.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelInput.Location = new System.Drawing.Point(12, 30);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(0, 23);
            this.labelInput.TabIndex = 19;
            this.labelInput.Click += new System.EventHandler(this.labelInput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 343);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.calcMinus);
            this.Controls.Add(this.calcDivision);
            this.Controls.Add(this.calcEnter);
            this.Controls.Add(this.calcMultiply);
            this.Controls.Add(this.calcComma);
            this.Controls.Add(this.calcClear);
            this.Controls.Add(this.calcClearEntry);
            this.Controls.Add(this.calcPlus);
            this.Controls.Add(this.numEight);
            this.Controls.Add(this.numNine);
            this.Controls.Add(this.numZero);
            this.Controls.Add(this.numFive);
            this.Controls.Add(this.numSix);
            this.Controls.Add(this.numSeven);
            this.Controls.Add(this.numFour);
            this.Controls.Add(this.numTwo);
            this.Controls.Add(this.numThree);
            this.Controls.Add(this.numOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button numOne;
        private System.Windows.Forms.Button numThree;
        private System.Windows.Forms.Button numTwo;
        private System.Windows.Forms.Button numFour;
        private System.Windows.Forms.Button numSeven;
        private System.Windows.Forms.Button numSix;
        private System.Windows.Forms.Button numFive;
        private System.Windows.Forms.Button numZero;
        private System.Windows.Forms.Button numNine;
        private System.Windows.Forms.Button numEight;
        private System.Windows.Forms.Button calcPlus;
        private System.Windows.Forms.Button calcClearEntry;
        private System.Windows.Forms.Button calcClear;
        private System.Windows.Forms.Button calcComma;
        private System.Windows.Forms.Button calcMultiply;
        private System.Windows.Forms.Button calcEnter;
        private System.Windows.Forms.Button calcDivision;
        private System.Windows.Forms.Button calcMinus;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Label labelInput;
    }
}

