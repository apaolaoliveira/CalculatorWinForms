namespace CalculatorWinForms
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
            this.txtOperation = new System.Windows.Forms.TextBox();
            this.listHistory = new System.Windows.Forms.ListBox();
            this.lblHistory = new System.Windows.Forms.Label();
            this.panCalculation = new System.Windows.Forms.Panel();
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnCH = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.panButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnPoint = new System.Windows.Forms.Button();
            this.panHistory = new System.Windows.Forms.Panel();
            this.panCalculation.SuspendLayout();
            this.panButtons.SuspendLayout();
            this.panHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOperation
            // 
            this.txtOperation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOperation.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txtOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperation.ForeColor = System.Drawing.Color.White;
            this.txtOperation.Location = new System.Drawing.Point(4, 4);
            this.txtOperation.Margin = new System.Windows.Forms.Padding(4);
            this.txtOperation.Name = "txtOperation";
            this.txtOperation.Size = new System.Drawing.Size(436, 36);
            this.txtOperation.TabIndex = 19;
            this.txtOperation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listHistory
            // 
            this.listHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listHistory.BackColor = System.Drawing.Color.Snow;
            this.listHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listHistory.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.listHistory.FormattingEnabled = true;
            this.listHistory.ItemHeight = 29;
            this.listHistory.Location = new System.Drawing.Point(3, 57);
            this.listHistory.Margin = new System.Windows.Forms.Padding(4);
            this.listHistory.Name = "listHistory";
            this.listHistory.Size = new System.Drawing.Size(287, 406);
            this.listHistory.TabIndex = 21;
            // 
            // lblHistory
            // 
            this.lblHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHistory.AutoSize = true;
            this.lblHistory.BackColor = System.Drawing.Color.Transparent;
            this.lblHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblHistory.Location = new System.Drawing.Point(75, 9);
            this.lblHistory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(129, 29);
            this.lblHistory.TabIndex = 22;
            this.lblHistory.Text = "HISTORY";
            // 
            // panCalculation
            // 
            this.panCalculation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panCalculation.Controls.Add(this.txtNumbers);
            this.panCalculation.Controls.Add(this.txtOperation);
            this.panCalculation.Location = new System.Drawing.Point(16, 26);
            this.panCalculation.Margin = new System.Windows.Forms.Padding(4);
            this.panCalculation.Name = "panCalculation";
            this.panCalculation.Size = new System.Drawing.Size(445, 143);
            this.panCalculation.TabIndex = 24;
            // 
            // txtNumbers
            // 
            this.txtNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumbers.BackColor = System.Drawing.Color.Snow;
            this.txtNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumbers.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtNumbers.Location = new System.Drawing.Point(4, 55);
            this.txtNumbers.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.Size = new System.Drawing.Size(436, 83);
            this.txtNumbers.TabIndex = 20;
            this.txtNumbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.BackColor = System.Drawing.Color.Snow;
            this.btnSubtraction.FlatAppearance.BorderSize = 0;
            this.btnSubtraction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnSubtraction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnSubtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtraction.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSubtraction.Location = new System.Drawing.Point(271, 82);
            this.btnSubtraction.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(81, 70);
            this.btnSubtraction.TabIndex = 12;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Snow;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn3.Location = new System.Drawing.Point(182, 160);
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(81, 70);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.BackColor = System.Drawing.Color.Snow;
            this.btnMultiplication.FlatAppearance.BorderSize = 0;
            this.btnMultiplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnMultiplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplication.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnMultiplication.Location = new System.Drawing.Point(271, 160);
            this.btnMultiplication.Margin = new System.Windows.Forms.Padding(4);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(81, 70);
            this.btnMultiplication.TabIndex = 13;
            this.btnMultiplication.Text = "x";
            this.btnMultiplication.UseVisualStyleBackColor = false;
            // 
            // btnCH
            // 
            this.btnCH.BackColor = System.Drawing.Color.Snow;
            this.btnCH.FlatAppearance.BorderSize = 0;
            this.btnCH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnCH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCH.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCH.Location = new System.Drawing.Point(360, 82);
            this.btnCH.Margin = new System.Windows.Forms.Padding(4);
            this.btnCH.Name = "btnCH";
            this.btnCH.Size = new System.Drawing.Size(81, 70);
            this.btnCH.TabIndex = 16;
            this.btnCH.Text = "CH";
            this.btnCH.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Snow;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn2.Location = new System.Drawing.Point(93, 160);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(81, 70);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.Snow;
            this.btnDivision.FlatAppearance.BorderSize = 0;
            this.btnDivision.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnDivision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDivision.Location = new System.Drawing.Point(271, 238);
            this.btnDivision.Margin = new System.Windows.Forms.Padding(4);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(81, 72);
            this.btnDivision.TabIndex = 14;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Snow;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn6.Location = new System.Drawing.Point(182, 82);
            this.btn6.Margin = new System.Windows.Forms.Padding(4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(81, 70);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Snow;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn1.Location = new System.Drawing.Point(4, 160);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(81, 70);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Snow;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn5.Location = new System.Drawing.Point(93, 82);
            this.btn5.Margin = new System.Windows.Forms.Padding(4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(81, 70);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Snow;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn4.Location = new System.Drawing.Point(4, 82);
            this.btn4.Margin = new System.Windows.Forms.Padding(4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(81, 70);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.Snow;
            this.btnCE.FlatAppearance.BorderSize = 0;
            this.btnCE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnCE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCE.Location = new System.Drawing.Point(360, 4);
            this.btnCE.Margin = new System.Windows.Forms.Padding(4);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(81, 70);
            this.btnCE.TabIndex = 15;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.Snow;
            this.btnEquals.FlatAppearance.BorderSize = 0;
            this.btnEquals.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnEquals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEquals.Location = new System.Drawing.Point(360, 238);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(4);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(81, 72);
            this.btnEquals.TabIndex = 17;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Snow;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn0.Location = new System.Drawing.Point(93, 238);
            this.btn0.Margin = new System.Windows.Forms.Padding(4);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(81, 72);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            // 
            // btnAddition
            // 
            this.btnAddition.BackColor = System.Drawing.Color.Snow;
            this.btnAddition.FlatAppearance.BorderSize = 0;
            this.btnAddition.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnAddition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnAddition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddition.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAddition.Location = new System.Drawing.Point(271, 4);
            this.btnAddition.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(81, 70);
            this.btnAddition.TabIndex = 11;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Snow;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn9.Location = new System.Drawing.Point(182, 4);
            this.btn9.Margin = new System.Windows.Forms.Padding(4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(81, 70);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Snow;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn8.Location = new System.Drawing.Point(93, 4);
            this.btn8.Margin = new System.Windows.Forms.Padding(4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(81, 70);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Snow;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn7.Location = new System.Drawing.Point(4, 4);
            this.btn7.Margin = new System.Windows.Forms.Padding(4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(81, 70);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // panButtons
            // 
            this.panButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panButtons.ColumnCount = 5;
            this.panButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panButtons.Controls.Add(this.btnPoint, 4, 2);
            this.panButtons.Controls.Add(this.btn7, 0, 0);
            this.panButtons.Controls.Add(this.btn8, 1, 0);
            this.panButtons.Controls.Add(this.btn9, 2, 0);
            this.panButtons.Controls.Add(this.btnAddition, 3, 0);
            this.panButtons.Controls.Add(this.btn0, 1, 3);
            this.panButtons.Controls.Add(this.btnEquals, 4, 3);
            this.panButtons.Controls.Add(this.btnCE, 4, 0);
            this.panButtons.Controls.Add(this.btn4, 0, 1);
            this.panButtons.Controls.Add(this.btn5, 1, 1);
            this.panButtons.Controls.Add(this.btn1, 0, 2);
            this.panButtons.Controls.Add(this.btn6, 2, 1);
            this.panButtons.Controls.Add(this.btnDivision, 3, 3);
            this.panButtons.Controls.Add(this.btn2, 1, 2);
            this.panButtons.Controls.Add(this.btnCH, 4, 1);
            this.panButtons.Controls.Add(this.btnMultiplication, 3, 2);
            this.panButtons.Controls.Add(this.btn3, 2, 2);
            this.panButtons.Controls.Add(this.btnSubtraction, 3, 1);
            this.panButtons.Location = new System.Drawing.Point(16, 176);
            this.panButtons.Margin = new System.Windows.Forms.Padding(4);
            this.panButtons.Name = "panButtons";
            this.panButtons.RowCount = 4;
            this.panButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panButtons.Size = new System.Drawing.Size(445, 314);
            this.panButtons.TabIndex = 23;
            // 
            // btnPoint
            // 
            this.btnPoint.BackColor = System.Drawing.Color.Snow;
            this.btnPoint.FlatAppearance.BorderSize = 0;
            this.btnPoint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnPoint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.btnPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoint.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPoint.Location = new System.Drawing.Point(360, 160);
            this.btnPoint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(81, 70);
            this.btnPoint.TabIndex = 26;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = false;
            // 
            // panHistory
            // 
            this.panHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panHistory.Controls.Add(this.lblHistory);
            this.panHistory.Controls.Add(this.listHistory);
            this.panHistory.Location = new System.Drawing.Point(475, 26);
            this.panHistory.Margin = new System.Windows.Forms.Padding(4);
            this.panHistory.Name = "panHistory";
            this.panHistory.Size = new System.Drawing.Size(293, 464);
            this.panHistory.TabIndex = 25;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(781, 521);
            this.Controls.Add(this.panCalculation);
            this.Controls.Add(this.panButtons);
            this.Controls.Add(this.panHistory);
            this.ForeColor = System.Drawing.Color.RosyBrown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(797, 558);
            this.Name = "Calculator";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.panCalculation.ResumeLayout(false);
            this.panCalculation.PerformLayout();
            this.panButtons.ResumeLayout(false);
            this.panHistory.ResumeLayout(false);
            this.panHistory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtOperation;
        private System.Windows.Forms.ListBox listHistory;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.TableLayoutPanel panButtons;
        private System.Windows.Forms.Panel panHistory;
        private System.Windows.Forms.Panel panCalculation;
        private System.Windows.Forms.TextBox txtNumbers;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnCH;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnPoint;
    }
}

