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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.typeOfCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayTextBox = new System.Windows.Forms.TextBox();
            this.TypeCalLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CELabel = new System.Windows.Forms.Label();
            this.CLabel = new System.Windows.Forms.Label();
            this.DelLabel = new System.Windows.Forms.Label();
            this.DivLabel = new System.Windows.Forms.Label();
            this.SevenLabel = new System.Windows.Forms.Label();
            this.EightLabel = new System.Windows.Forms.Label();
            this.NineLabel = new System.Windows.Forms.Label();
            this.MultipleLabel = new System.Windows.Forms.Label();
            this.FourLabel = new System.Windows.Forms.Label();
            this.FiveLabel = new System.Windows.Forms.Label();
            this.SixLabel = new System.Windows.Forms.Label();
            this.SubtractLabel = new System.Windows.Forms.Label();
            this.OneLabel = new System.Windows.Forms.Label();
            this.TwoLabel = new System.Windows.Forms.Label();
            this.ThreeLabel = new System.Windows.Forms.Label();
            this.AddLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ZeroLabel = new System.Windows.Forms.Label();
            this.DotLabel = new System.Windows.Forms.Label();
            this.EqualLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeOfCalculatorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(321, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // typeOfCalculatorToolStripMenuItem
            // 
            this.typeOfCalculatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicToolStripMenuItem,
            this.scientificToolStripMenuItem,
            this.programmerToolStripMenuItem});
            this.typeOfCalculatorToolStripMenuItem.Name = "typeOfCalculatorToolStripMenuItem";
            this.typeOfCalculatorToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.typeOfCalculatorToolStripMenuItem.Text = "Type of Calculator";
            // 
            // basicToolStripMenuItem
            // 
            this.basicToolStripMenuItem.Name = "basicToolStripMenuItem";
            this.basicToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.basicToolStripMenuItem.Text = "Standard";
            this.basicToolStripMenuItem.Click += new System.EventHandler(this.basicToolStripMenuItem_Click);
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.scientificToolStripMenuItem.Text = "Scientific";
            this.scientificToolStripMenuItem.Click += new System.EventHandler(this.scientificToolStripMenuItem_Click);
            // 
            // programmerToolStripMenuItem
            // 
            this.programmerToolStripMenuItem.Name = "programmerToolStripMenuItem";
            this.programmerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.programmerToolStripMenuItem.Text = "Programmer";
            this.programmerToolStripMenuItem.Click += new System.EventHandler(this.programmerToolStripMenuItem_Click);
            // 
            // DisplayTextBox
            // 
            this.DisplayTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DisplayTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.DisplayTextBox.Enabled = false;
            this.DisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTextBox.Location = new System.Drawing.Point(24, 61);
            this.DisplayTextBox.Multiline = true;
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.ReadOnly = true;
            this.DisplayTextBox.Size = new System.Drawing.Size(267, 114);
            this.DisplayTextBox.TabIndex = 1;
            this.DisplayTextBox.Text = "0";
            this.DisplayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TypeCalLabel
            // 
            this.TypeCalLabel.AutoSize = true;
            this.TypeCalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeCalLabel.Location = new System.Drawing.Point(24, 42);
            this.TypeCalLabel.Name = "TypeCalLabel";
            this.TypeCalLabel.Size = new System.Drawing.Size(63, 16);
            this.TypeCalLabel.TabIndex = 2;
            this.TypeCalLabel.Text = "Standard";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.EqualLabel, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.DotLabel, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.ZeroLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.AddLabel, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.ThreeLabel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.TwoLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.OneLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.SubtractLabel, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.SixLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.FiveLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.FourLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.MultipleLabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.NineLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.EightLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SevenLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DivLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.DelLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.CLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CELabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 192);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(267, 226);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // CELabel
            // 
            this.CELabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CELabel.BackColor = System.Drawing.Color.Gainsboro;
            this.CELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CELabel.Location = new System.Drawing.Point(3, 3);
            this.CELabel.Margin = new System.Windows.Forms.Padding(3);
            this.CELabel.Name = "CELabel";
            this.CELabel.Size = new System.Drawing.Size(60, 39);
            this.CELabel.TabIndex = 0;
            this.CELabel.Text = "CE";
            this.CELabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CLabel
            // 
            this.CLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.CLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLabel.Location = new System.Drawing.Point(69, 3);
            this.CLabel.Margin = new System.Windows.Forms.Padding(3);
            this.CLabel.Name = "CLabel";
            this.CLabel.Size = new System.Drawing.Size(60, 39);
            this.CLabel.TabIndex = 1;
            this.CLabel.Text = "C";
            this.CLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DelLabel
            // 
            this.DelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DelLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.DelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelLabel.Location = new System.Drawing.Point(135, 3);
            this.DelLabel.Margin = new System.Windows.Forms.Padding(3);
            this.DelLabel.Name = "DelLabel";
            this.DelLabel.Size = new System.Drawing.Size(60, 39);
            this.DelLabel.TabIndex = 2;
            this.DelLabel.Text = "◄";
            this.DelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DivLabel
            // 
            this.DivLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DivLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.DivLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivLabel.Location = new System.Drawing.Point(201, 3);
            this.DivLabel.Margin = new System.Windows.Forms.Padding(3);
            this.DivLabel.Name = "DivLabel";
            this.DivLabel.Size = new System.Drawing.Size(63, 39);
            this.DivLabel.TabIndex = 3;
            this.DivLabel.Text = "/";
            this.DivLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SevenLabel
            // 
            this.SevenLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SevenLabel.BackColor = System.Drawing.Color.White;
            this.SevenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenLabel.Location = new System.Drawing.Point(3, 48);
            this.SevenLabel.Margin = new System.Windows.Forms.Padding(3);
            this.SevenLabel.Name = "SevenLabel";
            this.SevenLabel.Size = new System.Drawing.Size(60, 39);
            this.SevenLabel.TabIndex = 4;
            this.SevenLabel.Text = "7";
            this.SevenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EightLabel
            // 
            this.EightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EightLabel.BackColor = System.Drawing.Color.White;
            this.EightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightLabel.Location = new System.Drawing.Point(69, 48);
            this.EightLabel.Margin = new System.Windows.Forms.Padding(3);
            this.EightLabel.Name = "EightLabel";
            this.EightLabel.Size = new System.Drawing.Size(60, 39);
            this.EightLabel.TabIndex = 5;
            this.EightLabel.Text = "8";
            this.EightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NineLabel
            // 
            this.NineLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NineLabel.BackColor = System.Drawing.Color.White;
            this.NineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineLabel.Location = new System.Drawing.Point(135, 48);
            this.NineLabel.Margin = new System.Windows.Forms.Padding(3);
            this.NineLabel.Name = "NineLabel";
            this.NineLabel.Size = new System.Drawing.Size(60, 39);
            this.NineLabel.TabIndex = 6;
            this.NineLabel.Text = "9";
            this.NineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MultipleLabel
            // 
            this.MultipleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MultipleLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.MultipleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultipleLabel.Location = new System.Drawing.Point(201, 48);
            this.MultipleLabel.Margin = new System.Windows.Forms.Padding(3);
            this.MultipleLabel.Name = "MultipleLabel";
            this.MultipleLabel.Size = new System.Drawing.Size(63, 39);
            this.MultipleLabel.TabIndex = 7;
            this.MultipleLabel.Text = "X";
            this.MultipleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FourLabel
            // 
            this.FourLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FourLabel.BackColor = System.Drawing.Color.White;
            this.FourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourLabel.Location = new System.Drawing.Point(3, 93);
            this.FourLabel.Margin = new System.Windows.Forms.Padding(3);
            this.FourLabel.Name = "FourLabel";
            this.FourLabel.Size = new System.Drawing.Size(60, 39);
            this.FourLabel.TabIndex = 8;
            this.FourLabel.Text = "4";
            this.FourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FiveLabel
            // 
            this.FiveLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FiveLabel.BackColor = System.Drawing.Color.White;
            this.FiveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveLabel.Location = new System.Drawing.Point(69, 93);
            this.FiveLabel.Margin = new System.Windows.Forms.Padding(3);
            this.FiveLabel.Name = "FiveLabel";
            this.FiveLabel.Size = new System.Drawing.Size(60, 39);
            this.FiveLabel.TabIndex = 9;
            this.FiveLabel.Text = "5";
            this.FiveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SixLabel
            // 
            this.SixLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SixLabel.BackColor = System.Drawing.Color.White;
            this.SixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixLabel.Location = new System.Drawing.Point(135, 93);
            this.SixLabel.Margin = new System.Windows.Forms.Padding(3);
            this.SixLabel.Name = "SixLabel";
            this.SixLabel.Size = new System.Drawing.Size(60, 39);
            this.SixLabel.TabIndex = 10;
            this.SixLabel.Text = "6";
            this.SixLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubtractLabel
            // 
            this.SubtractLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubtractLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.SubtractLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractLabel.Location = new System.Drawing.Point(201, 93);
            this.SubtractLabel.Margin = new System.Windows.Forms.Padding(3);
            this.SubtractLabel.Name = "SubtractLabel";
            this.SubtractLabel.Size = new System.Drawing.Size(63, 39);
            this.SubtractLabel.TabIndex = 11;
            this.SubtractLabel.Text = "-";
            this.SubtractLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OneLabel
            // 
            this.OneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OneLabel.BackColor = System.Drawing.Color.White;
            this.OneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneLabel.Location = new System.Drawing.Point(3, 138);
            this.OneLabel.Margin = new System.Windows.Forms.Padding(3);
            this.OneLabel.Name = "OneLabel";
            this.OneLabel.Size = new System.Drawing.Size(60, 39);
            this.OneLabel.TabIndex = 12;
            this.OneLabel.Text = "1";
            this.OneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TwoLabel
            // 
            this.TwoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TwoLabel.BackColor = System.Drawing.Color.White;
            this.TwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoLabel.Location = new System.Drawing.Point(69, 138);
            this.TwoLabel.Margin = new System.Windows.Forms.Padding(3);
            this.TwoLabel.Name = "TwoLabel";
            this.TwoLabel.Size = new System.Drawing.Size(60, 39);
            this.TwoLabel.TabIndex = 13;
            this.TwoLabel.Text = "2";
            this.TwoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThreeLabel
            // 
            this.ThreeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ThreeLabel.BackColor = System.Drawing.Color.White;
            this.ThreeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeLabel.Location = new System.Drawing.Point(135, 138);
            this.ThreeLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ThreeLabel.Name = "ThreeLabel";
            this.ThreeLabel.Size = new System.Drawing.Size(60, 39);
            this.ThreeLabel.TabIndex = 14;
            this.ThreeLabel.Text = "3";
            this.ThreeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddLabel
            // 
            this.AddLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.AddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLabel.Location = new System.Drawing.Point(201, 138);
            this.AddLabel.Margin = new System.Windows.Forms.Padding(3);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(63, 39);
            this.AddLabel.TabIndex = 15;
            this.AddLabel.Text = "+";
            this.AddLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(5, 185);
            this.label17.Margin = new System.Windows.Forms.Padding(1);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 35);
            this.label17.TabIndex = 16;
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ZeroLabel
            // 
            this.ZeroLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ZeroLabel.BackColor = System.Drawing.Color.White;
            this.ZeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroLabel.Location = new System.Drawing.Point(69, 183);
            this.ZeroLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ZeroLabel.Name = "ZeroLabel";
            this.ZeroLabel.Size = new System.Drawing.Size(60, 40);
            this.ZeroLabel.TabIndex = 17;
            this.ZeroLabel.Text = "0";
            this.ZeroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ZeroLabel.Click += new System.EventHandler(this.ZeroLabel_Click);
            // 
            // DotLabel
            // 
            this.DotLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DotLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.DotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DotLabel.Location = new System.Drawing.Point(135, 183);
            this.DotLabel.Margin = new System.Windows.Forms.Padding(3);
            this.DotLabel.Name = "DotLabel";
            this.DotLabel.Size = new System.Drawing.Size(60, 40);
            this.DotLabel.TabIndex = 18;
            this.DotLabel.Text = ".";
            this.DotLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EqualLabel
            // 
            this.EqualLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EqualLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.EqualLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualLabel.Location = new System.Drawing.Point(201, 183);
            this.EqualLabel.Margin = new System.Windows.Forms.Padding(3);
            this.EqualLabel.Name = "EqualLabel";
            this.EqualLabel.Size = new System.Drawing.Size(63, 40);
            this.EqualLabel.TabIndex = 19;
            this.EqualLabel.Text = "=";
            this.EqualLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(321, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TypeCalLabel);
            this.Controls.Add(this.DisplayTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem typeOfCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmerToolStripMenuItem;
        private System.Windows.Forms.TextBox DisplayTextBox;
        private System.Windows.Forms.Label TypeCalLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label EqualLabel;
        private System.Windows.Forms.Label DotLabel;
        private System.Windows.Forms.Label ZeroLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label AddLabel;
        private System.Windows.Forms.Label ThreeLabel;
        private System.Windows.Forms.Label TwoLabel;
        private System.Windows.Forms.Label OneLabel;
        private System.Windows.Forms.Label SubtractLabel;
        private System.Windows.Forms.Label SixLabel;
        private System.Windows.Forms.Label FiveLabel;
        private System.Windows.Forms.Label FourLabel;
        private System.Windows.Forms.Label MultipleLabel;
        private System.Windows.Forms.Label NineLabel;
        private System.Windows.Forms.Label EightLabel;
        private System.Windows.Forms.Label SevenLabel;
        private System.Windows.Forms.Label DivLabel;
        private System.Windows.Forms.Label DelLabel;
        private System.Windows.Forms.Label CLabel;
        private System.Windows.Forms.Label CELabel;
    }
}

