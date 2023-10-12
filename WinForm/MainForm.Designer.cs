namespace Calculator_WinForm
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

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
            basicPanel = new Panel();
            delete = new Button();
            deleteAll = new Button();
            degree = new Button();
            factorial = new Button();
            plus = new Button();
            minus = new Button();
            multiply = new Button();
            divide = new Button();
            nine = new Button();
            eight = new Button();
            seven = new Button();
            six = new Button();
            five = new Button();
            four = new Button();
            egual = new Button();
            symbolDot = new Button();
            three = new Button();
            two = new Button();
            one = new Button();
            zero = new Button();
            solutionPanel = new Panel();
            solution = new Label();
            basicPanel.SuspendLayout();
            solutionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // basicPanel
            // 
            basicPanel.BackColor = Color.FromArgb(36, 34, 34);
            basicPanel.BorderStyle = BorderStyle.FixedSingle;
            basicPanel.Controls.Add(delete);
            basicPanel.Controls.Add(deleteAll);
            basicPanel.Controls.Add(degree);
            basicPanel.Controls.Add(factorial);
            basicPanel.Controls.Add(plus);
            basicPanel.Controls.Add(minus);
            basicPanel.Controls.Add(multiply);
            basicPanel.Controls.Add(divide);
            basicPanel.Controls.Add(nine);
            basicPanel.Controls.Add(eight);
            basicPanel.Controls.Add(seven);
            basicPanel.Controls.Add(six);
            basicPanel.Controls.Add(five);
            basicPanel.Controls.Add(four);
            basicPanel.Controls.Add(egual);
            basicPanel.Controls.Add(symbolDot);
            basicPanel.Controls.Add(three);
            basicPanel.Controls.Add(two);
            basicPanel.Controls.Add(one);
            basicPanel.Controls.Add(zero);
            basicPanel.Controls.Add(solutionPanel);
            basicPanel.Dock = DockStyle.Fill;
            basicPanel.Location = new Point(0, 0);
            basicPanel.Name = "basicPanel";
            basicPanel.Size = new Size(605, 576);
            basicPanel.TabIndex = 0;
            // 
            // delete
            // 
            delete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            delete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            delete.BackColor = Color.FromArgb(95, 122, 104);
            delete.Cursor = Cursors.Hand;
            delete.Location = new Point(460, 239);
            delete.Name = "delete";
            delete.Size = new Size(132, 60);
            delete.TabIndex = 20;
            delete.Text = "<x|";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // deleteAll
            // 
            deleteAll.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            deleteAll.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deleteAll.BackColor = Color.FromArgb(95, 122, 104);
            deleteAll.Cursor = Cursors.Hand;
            deleteAll.Location = new Point(303, 239);
            deleteAll.Name = "deleteAll";
            deleteAll.Size = new Size(132, 60);
            deleteAll.TabIndex = 19;
            deleteAll.Text = "C";
            deleteAll.UseVisualStyleBackColor = false;
            deleteAll.Click += deleteAll_Click;
            // 
            // degree
            // 
            degree.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            degree.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            degree.BackColor = Color.FromArgb(95, 122, 104);
            degree.Cursor = Cursors.Hand;
            degree.Location = new Point(157, 239);
            degree.Name = "degree";
            degree.Size = new Size(132, 60);
            degree.TabIndex = 18;
            degree.Text = "^";
            degree.UseVisualStyleBackColor = false;
            degree.Click += degree_Click;
            // 
            // factorial
            // 
            factorial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            factorial.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            factorial.BackColor = Color.FromArgb(95, 122, 104);
            factorial.Cursor = Cursors.Hand;
            factorial.ImageAlign = ContentAlignment.MiddleLeft;
            factorial.Location = new Point(11, 239);
            factorial.Name = "factorial";
            factorial.Size = new Size(132, 60);
            factorial.TabIndex = 17;
            factorial.Text = "%";
            factorial.UseVisualStyleBackColor = false;
            factorial.Click += factorial_Click;
            // 
            // plus
            // 
            plus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            plus.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            plus.BackColor = Color.FromArgb(95, 122, 104);
            plus.Cursor = Cursors.Hand;
            plus.Location = new Point(460, 511);
            plus.Name = "plus";
            plus.Size = new Size(132, 60);
            plus.TabIndex = 16;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = false;
            plus.Click += plus_Click;
            // 
            // minus
            // 
            minus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            minus.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            minus.BackColor = Color.FromArgb(95, 122, 104);
            minus.Cursor = Cursors.Hand;
            minus.Location = new Point(460, 445);
            minus.Name = "minus";
            minus.Size = new Size(132, 60);
            minus.TabIndex = 15;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = false;
            minus.Click += minus_Click;
            // 
            // multiply
            // 
            multiply.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            multiply.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            multiply.BackColor = Color.FromArgb(95, 122, 104);
            multiply.Cursor = Cursors.Hand;
            multiply.Location = new Point(460, 379);
            multiply.Name = "multiply";
            multiply.Size = new Size(132, 60);
            multiply.TabIndex = 14;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = false;
            multiply.Click += multiply_Click;
            // 
            // divide
            // 
            divide.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            divide.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            divide.BackColor = Color.FromArgb(95, 122, 104);
            divide.Cursor = Cursors.Hand;
            divide.Location = new Point(460, 313);
            divide.Name = "divide";
            divide.Size = new Size(132, 60);
            divide.TabIndex = 13;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = false;
            divide.Click += divide_Click;
            // 
            // nine
            // 
            nine.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nine.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            nine.BackColor = Color.FromArgb(132, 137, 140);
            nine.Cursor = Cursors.Hand;
            nine.Location = new Point(303, 313);
            nine.Name = "nine";
            nine.Size = new Size(132, 60);
            nine.TabIndex = 12;
            nine.Text = "9";
            nine.UseVisualStyleBackColor = false;
            nine.Click += nine_Click;
            // 
            // eight
            // 
            eight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            eight.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            eight.BackColor = Color.FromArgb(132, 137, 140);
            eight.Cursor = Cursors.Hand;
            eight.Location = new Point(157, 313);
            eight.Name = "eight";
            eight.Size = new Size(132, 60);
            eight.TabIndex = 11;
            eight.Text = "8";
            eight.UseVisualStyleBackColor = false;
            eight.Click += eight_Click;
            // 
            // seven
            // 
            seven.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            seven.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            seven.BackColor = Color.FromArgb(132, 137, 140);
            seven.Cursor = Cursors.Hand;
            seven.Location = new Point(11, 313);
            seven.Name = "seven";
            seven.Size = new Size(132, 60);
            seven.TabIndex = 10;
            seven.Text = "7";
            seven.UseVisualStyleBackColor = false;
            seven.Click += seven_Click;
            // 
            // six
            // 
            six.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            six.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            six.BackColor = Color.FromArgb(132, 137, 140);
            six.Cursor = Cursors.Hand;
            six.Location = new Point(303, 379);
            six.Name = "six";
            six.Size = new Size(132, 60);
            six.TabIndex = 9;
            six.Text = "6";
            six.UseVisualStyleBackColor = false;
            six.Click += six_Click;
            // 
            // five
            // 
            five.AccessibleName = "";
            five.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            five.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            five.BackColor = Color.FromArgb(132, 137, 140);
            five.Cursor = Cursors.Hand;
            five.Location = new Point(157, 379);
            five.Name = "five";
            five.Size = new Size(132, 60);
            five.TabIndex = 8;
            five.Text = "5";
            five.UseVisualStyleBackColor = false;
            five.Click += five_Click;
            // 
            // four
            // 
            four.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            four.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            four.BackColor = Color.FromArgb(132, 137, 140);
            four.Cursor = Cursors.Hand;
            four.Location = new Point(11, 379);
            four.Name = "four";
            four.Size = new Size(132, 60);
            four.TabIndex = 7;
            four.Text = "4";
            four.UseVisualStyleBackColor = false;
            four.Click += four_Click;
            // 
            // egual
            // 
            egual.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            egual.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            egual.BackColor = Color.Teal;
            egual.Cursor = Cursors.Hand;
            egual.Location = new Point(303, 511);
            egual.Name = "egual";
            egual.Size = new Size(132, 60);
            egual.TabIndex = 6;
            egual.Text = "=";
            egual.UseVisualStyleBackColor = false;
            egual.Click += egual_Click;
            // 
            // symbolDot
            // 
            symbolDot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            symbolDot.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            symbolDot.BackColor = Color.FromArgb(132, 137, 140);
            symbolDot.Cursor = Cursors.Hand;
            symbolDot.Location = new Point(11, 511);
            symbolDot.Name = "symbolDot";
            symbolDot.Size = new Size(132, 60);
            symbolDot.TabIndex = 5;
            symbolDot.Text = ".";
            symbolDot.UseVisualStyleBackColor = false;
            symbolDot.Click += symbolDot_Click;
            // 
            // three
            // 
            three.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            three.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            three.BackColor = Color.FromArgb(132, 137, 140);
            three.Cursor = Cursors.Hand;
            three.Location = new Point(303, 445);
            three.Name = "three";
            three.Size = new Size(132, 60);
            three.TabIndex = 4;
            three.Text = "3";
            three.UseVisualStyleBackColor = false;
            three.Click += three_Click;
            // 
            // two
            // 
            two.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            two.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            two.BackColor = Color.FromArgb(132, 137, 140);
            two.Cursor = Cursors.Hand;
            two.Location = new Point(157, 445);
            two.Name = "two";
            two.Size = new Size(132, 60);
            two.TabIndex = 3;
            two.Text = "2";
            two.UseVisualStyleBackColor = false;
            two.Click += two_Click;
            // 
            // one
            // 
            one.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            one.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            one.BackColor = Color.FromArgb(132, 137, 140);
            one.Cursor = Cursors.Hand;
            one.Location = new Point(11, 445);
            one.Name = "one";
            one.Size = new Size(132, 60);
            one.TabIndex = 2;
            one.Text = "1";
            one.UseVisualStyleBackColor = false;
            one.Click += one_Click;
            // 
            // zero
            // 
            zero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            zero.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            zero.BackColor = Color.FromArgb(132, 137, 140);
            zero.Cursor = Cursors.Hand;
            zero.Location = new Point(157, 511);
            zero.Name = "zero";
            zero.Size = new Size(132, 60);
            zero.TabIndex = 1;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = false;
            zero.Click += zero_Click;
            // 
            // solutionPanel
            // 
            solutionPanel.AutoScroll = true;
            solutionPanel.BackColor = Color.Lavender;
            solutionPanel.Controls.Add(solution);
            solutionPanel.Location = new Point(-1, 79);
            solutionPanel.Name = "solutionPanel";
            solutionPanel.Size = new Size(613, 128);
            solutionPanel.TabIndex = 0;
            // 
            // solution
            // 
            solution.AutoSize = true;
            solution.Location = new Point(21, 95);
            solution.Name = "solution";
            solution.Size = new Size(0, 20);
            solution.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 576);
            Controls.Add(basicPanel);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            basicPanel.ResumeLayout(false);
            solutionPanel.ResumeLayout(false);
            solutionPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel basicPanel;
        private Button delete;
        private Button deleteAll;
        private Button degree;
        private Button factorial;
        private Button plus;
        private Button minus;
        private Button multiply;
        private Button divide;
        private Button nine;
        private Button eight;
        private Button seven;
        private Button six;
        private Button five;
        private Button four;
        private Button egual;
        private Button symbolDot;
        private Button three;
        private Button two;
        private Button one;
        private Button zero;
        private Panel solutionPanel;
        private Label solution;
    }
}