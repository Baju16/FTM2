namespace FTM2.Forms
{
    partial class addplayerForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            label1 = new Label();
            firstnameBox = new TextBox();
            lastname = new Label();
            lastnameBox = new TextBox();
            age = new Label();
            ageBox = new TextBox();
            label4 = new Label();
            positionBox = new TextBox();
            label6 = new Label();
            nationalityBox = new TextBox();
            label5 = new Label();
            jerseyBox = new TextBox();
            label2 = new Label();
            teamComboBox = new ComboBox();
            button1 = new Button();
            checkBox = new CheckBox();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(firstnameBox);
            flowLayoutPanel1.Controls.Add(lastname);
            flowLayoutPanel1.Controls.Add(lastnameBox);
            flowLayoutPanel1.Controls.Add(age);
            flowLayoutPanel1.Controls.Add(ageBox);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(positionBox);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(nationalityBox);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(jerseyBox);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(teamComboBox);
            flowLayoutPanel1.Controls.Add(checkBox);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(299, 455);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(64, 0);
            label3.Margin = new Padding(3, 0, 3, 20);
            label3.Name = "label3";
            label3.Size = new Size(173, 28);
            label3.TabIndex = 13;
            label3.Text = "ADD NEW PLAYER";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 48);
            label1.Name = "label1";
            label1.Size = new Size(296, 15);
            label1.TabIndex = 0;
            label1.Text = "first name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // firstnameBox
            // 
            firstnameBox.Dock = DockStyle.Fill;
            firstnameBox.Location = new Point(3, 66);
            firstnameBox.Name = "firstnameBox";
            firstnameBox.Size = new Size(296, 23);
            firstnameBox.TabIndex = 1;
            // 
            // lastname
            // 
            lastname.Anchor = AnchorStyles.None;
            lastname.AutoSize = true;
            lastname.Location = new Point(122, 92);
            lastname.Name = "lastname";
            lastname.Size = new Size(58, 15);
            lastname.TabIndex = 2;
            lastname.Text = "last name";
            // 
            // lastnameBox
            // 
            lastnameBox.Location = new Point(3, 110);
            lastnameBox.Name = "lastnameBox";
            lastnameBox.Size = new Size(296, 23);
            lastnameBox.TabIndex = 3;
            // 
            // age
            // 
            age.Anchor = AnchorStyles.None;
            age.AutoSize = true;
            age.Location = new Point(138, 136);
            age.Name = "age";
            age.Size = new Size(26, 15);
            age.TabIndex = 4;
            age.Text = "age";
            // 
            // ageBox
            // 
            ageBox.Location = new Point(3, 154);
            ageBox.Name = "ageBox";
            ageBox.Size = new Size(296, 23);
            ageBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(126, 180);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 6;
            label4.Text = "position";
            // 
            // positionBox
            // 
            positionBox.Location = new Point(3, 198);
            positionBox.Name = "positionBox";
            positionBox.Size = new Size(296, 23);
            positionBox.TabIndex = 7;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(119, 224);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 14;
            label6.Text = "nationality";
            // 
            // nationalityBox
            // 
            nationalityBox.Location = new Point(3, 242);
            nationalityBox.Name = "nationalityBox";
            nationalityBox.Size = new Size(296, 23);
            nationalityBox.TabIndex = 15;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(110, 268);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 8;
            label5.Text = "jersey number";
            // 
            // jerseyBox
            // 
            jerseyBox.Location = new Point(3, 286);
            jerseyBox.Name = "jerseyBox";
            jerseyBox.Size = new Size(296, 23);
            jerseyBox.TabIndex = 9;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(134, 312);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 10;
            label2.Text = "team";
            // 
            // teamComboBox
            // 
            teamComboBox.FormattingEnabled = true;
            teamComboBox.Location = new Point(3, 330);
            teamComboBox.Margin = new Padding(3, 3, 3, 13);
            teamComboBox.Name = "teamComboBox";
            teamComboBox.Size = new Size(296, 23);
            teamComboBox.TabIndex = 11;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(113, 394);
            button1.Name = "button1";
            button1.Size = new Size(75, 38);
            button1.TabIndex = 12;
            button1.Text = "add player";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Location = new Point(3, 369);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(82, 19);
            checkBox.TabIndex = 17;
            checkBox.Text = "checkBox1";
            checkBox.UseVisualStyleBackColor = true;
            // 
            // addplayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 455);
            Controls.Add(flowLayoutPanel1);
            Name = "addplayerForm";
            Text = "addplayerForm";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox firstnameBox;
        private Label lastname;
        private TextBox lastnameBox;
        private Label age;
        private TextBox ageBox;
        private Label label4;
        private TextBox positionBox;
        private Label label5;
        private TextBox jerseyBox;
        private Label label3;
        private Label label2;
        private ComboBox teamComboBox;
        private Button button1;
        private Label label6;
        private TextBox nationalityBox;
        private CheckBox checkBox;
    }
}