namespace CirclePointFinder
{
    partial class PointsView
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
            btnCalculate = new Button();
            lblPoint1 = new Label();
            txtPoint1X = new TextBox();
            txtPoint1Y = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPoint2Y = new TextBox();
            txtPoint2X = new TextBox();
            lblPoint2 = new Label();
            txtRadius = new TextBox();
            lblRadius = new Label();
            lblResultHeader = new Label();
            txtPointsCount = new TextBox();
            lblPointsCount = new Label();
            label4 = new Label();
            rbtCounterClockwise = new RadioButton();
            rbtClockwise = new RadioButton();
            lblResult = new Label();
            listView1 = new ListView();
            Points = new ColumnHeader();
            Coordinates = new ColumnHeader();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalculate.Location = new Point(300, 230);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(200, 40);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate Points";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblPoint1
            // 
            lblPoint1.AutoSize = true;
            lblPoint1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPoint1.Location = new Point(12, 46);
            lblPoint1.Name = "lblPoint1";
            lblPoint1.Size = new Size(89, 37);
            lblPoint1.TabIndex = 1;
            lblPoint1.Text = "Point 1";
            lblPoint1.UseCompatibleTextRendering = true;
            // 
            // txtPoint1X
            // 
            txtPoint1X.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPoint1X.Location = new Point(115, 43);
            txtPoint1X.Name = "txtPoint1X";
            txtPoint1X.Size = new Size(84, 39);
            txtPoint1X.TabIndex = 2;
            txtPoint1X.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPoint1Y
            // 
            txtPoint1Y.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPoint1Y.Location = new Point(205, 43);
            txtPoint1Y.Name = "txtPoint1Y";
            txtPoint1Y.Size = new Size(84, 39);
            txtPoint1Y.TabIndex = 3;
            txtPoint1Y.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(145, 3);
            label1.Name = "label1";
            label1.Size = new Size(30, 37);
            label1.TabIndex = 4;
            label1.Text = "X";
            label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(234, 3);
            label2.Name = "label2";
            label2.Size = new Size(30, 37);
            label2.TabIndex = 5;
            label2.Text = "Y";
            label2.UseCompatibleTextRendering = true;
            // 
            // txtPoint2Y
            // 
            txtPoint2Y.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPoint2Y.Location = new Point(205, 88);
            txtPoint2Y.Name = "txtPoint2Y";
            txtPoint2Y.Size = new Size(84, 39);
            txtPoint2Y.TabIndex = 8;
            txtPoint2Y.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPoint2X
            // 
            txtPoint2X.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPoint2X.Location = new Point(115, 88);
            txtPoint2X.Name = "txtPoint2X";
            txtPoint2X.Size = new Size(84, 39);
            txtPoint2X.TabIndex = 7;
            txtPoint2X.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPoint2
            // 
            lblPoint2.AutoSize = true;
            lblPoint2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPoint2.Location = new Point(12, 91);
            lblPoint2.Name = "lblPoint2";
            lblPoint2.Size = new Size(89, 37);
            lblPoint2.TabIndex = 6;
            lblPoint2.Text = "Point 2";
            lblPoint2.UseCompatibleTextRendering = true;
            // 
            // txtRadius
            // 
            txtRadius.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRadius.Location = new Point(115, 133);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(174, 39);
            txtRadius.TabIndex = 10;
            txtRadius.TextAlign = HorizontalAlignment.Center;
            // 
            // lblRadius
            // 
            lblRadius.AutoSize = true;
            lblRadius.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblRadius.Location = new Point(15, 136);
            lblRadius.Name = "lblRadius";
            lblRadius.Size = new Size(87, 37);
            lblRadius.TabIndex = 9;
            lblRadius.Text = "Radius";
            lblRadius.UseCompatibleTextRendering = true;
            // 
            // lblResultHeader
            // 
            lblResultHeader.AutoSize = true;
            lblResultHeader.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultHeader.Location = new Point(34, 203);
            lblResultHeader.Name = "lblResultHeader";
            lblResultHeader.Size = new Size(88, 37);
            lblResultHeader.TabIndex = 11;
            lblResultHeader.Text = "Result:";
            lblResultHeader.UseCompatibleTextRendering = true;
            // 
            // txtPointsCount
            // 
            txtPointsCount.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPointsCount.Location = new Point(572, 46);
            txtPointsCount.Name = "txtPointsCount";
            txtPointsCount.Size = new Size(189, 39);
            txtPointsCount.TabIndex = 13;
            txtPointsCount.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPointsCount
            // 
            lblPointsCount.AutoSize = true;
            lblPointsCount.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPointsCount.Location = new Point(415, 46);
            lblPointsCount.Name = "lblPointsCount";
            lblPointsCount.Size = new Size(148, 37);
            lblPointsCount.TabIndex = 12;
            lblPointsCount.Text = "Points count";
            lblPointsCount.TextAlign = ContentAlignment.MiddleCenter;
            lblPointsCount.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(449, 94);
            label4.Name = "label4";
            label4.Size = new Size(115, 37);
            label4.TabIndex = 14;
            label4.Text = "Direction";
            label4.UseCompatibleTextRendering = true;
            // 
            // rbtCounterClockwise
            // 
            rbtCounterClockwise.AutoSize = true;
            rbtCounterClockwise.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbtCounterClockwise.Location = new Point(577, 127);
            rbtCounterClockwise.Name = "rbtCounterClockwise";
            rbtCounterClockwise.Size = new Size(184, 27);
            rbtCounterClockwise.TabIndex = 16;
            rbtCounterClockwise.TabStop = true;
            rbtCounterClockwise.Text = "Counter clockwise";
            rbtCounterClockwise.UseVisualStyleBackColor = true;
            rbtCounterClockwise.CheckedChanged += rbtCounterClockwise_CheckedChanged;
            // 
            // rbtClockwise
            // 
            rbtClockwise.AutoSize = true;
            rbtClockwise.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbtClockwise.Location = new Point(577, 98);
            rbtClockwise.Name = "rbtClockwise";
            rbtClockwise.Size = new Size(116, 27);
            rbtClockwise.TabIndex = 17;
            rbtClockwise.TabStop = true;
            rbtClockwise.Text = "Clockwise";
            rbtClockwise.UseVisualStyleBackColor = true;
            rbtClockwise.CheckedChanged += rbtClockwise_CheckedChanged;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(34, 240);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 34);
            lblResult.TabIndex = 18;
            lblResult.UseCompatibleTextRendering = true;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Bottom;
            listView1.BackColor = SystemColors.Info;
            listView1.Columns.AddRange(new ColumnHeader[] { Points, Coordinates });
            listView1.Location = new Point(300, 276);
            listView1.Name = "listView1";
            listView1.Size = new Size(200, 285);
            listView1.TabIndex = 19;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Points
            // 
            Points.Text = "Points";
            Points.Width = 80;
            // 
            // Coordinates
            // 
            Coordinates.Text = "Coordinates";
            Coordinates.TextAlign = HorizontalAlignment.Center;
            Coordinates.Width = 115;
            // 
            // PointsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(listView1);
            Controls.Add(lblResult);
            Controls.Add(rbtClockwise);
            Controls.Add(rbtCounterClockwise);
            Controls.Add(label4);
            Controls.Add(txtPointsCount);
            Controls.Add(lblPointsCount);
            Controls.Add(lblResultHeader);
            Controls.Add(txtRadius);
            Controls.Add(lblRadius);
            Controls.Add(txtPoint2Y);
            Controls.Add(txtPoint2X);
            Controls.Add(lblPoint2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPoint1Y);
            Controls.Add(txtPoint1X);
            Controls.Add(lblPoint1);
            Controls.Add(btnCalculate);
            Name = "PointsView";
            Text = "PointsView";
            Load += PointsView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Label lblPoint1;
        private TextBox txtPoint1X;
        private TextBox txtPoint1Y;
        private Label label1;
        private Label label2;
        private TextBox txtPoint2Y;
        private TextBox txtPoint2X;
        private Label lblPoint2;
        private TextBox txtRadius;
        private Label lblRadius;
        private Label lblResultHeader;
        private TextBox txtPointsCount;
        private Label lblPointsCount;
        private Label label4;
        private RadioButton rbtCounterClockwise;
        private RadioButton rbtClockwise;
        private Label lblResult;
        private ListView listView1;
        private ColumnHeader Points;
        private ColumnHeader Coordinates;
    }
}