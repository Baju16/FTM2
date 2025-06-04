namespace FTM2.Forms
{
    partial class addteamForm
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
            label1 = new Label();
            label2 = new Label();
            nameBox = new TextBox();
            label3 = new Label();
            coachBox = new TextBox();
            label4 = new Label();
            budgetBox = new TextBox();
            label5 = new Label();
            leagueBox = new TextBox();
            button1 = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(nameBox);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(coachBox);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(budgetBox);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(leagueBox);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(299, 325);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(72, 0);
            label1.Margin = new Padding(3, 0, 3, 15);
            label1.Name = "label1";
            label1.Size = new Size(158, 28);
            label1.TabIndex = 0;
            label1.Text = "ADD NEW TEAM";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(132, 43);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "name";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(3, 61);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(296, 23);
            nameBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(131, 87);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "coach";
            // 
            // coachBox
            // 
            coachBox.Location = new Point(3, 105);
            coachBox.Name = "coachBox";
            coachBox.Size = new Size(296, 23);
            coachBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(128, 131);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 5;
            label4.Text = "budget";
            // 
            // budgetBox
            // 
            budgetBox.Location = new Point(3, 149);
            budgetBox.Name = "budgetBox";
            budgetBox.Size = new Size(296, 23);
            budgetBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(130, 175);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 7;
            label5.Text = "league";
            // 
            // leagueBox
            // 
            leagueBox.Location = new Point(3, 193);
            leagueBox.Margin = new Padding(3, 3, 3, 13);
            leagueBox.Name = "leagueBox";
            leagueBox.Size = new Size(296, 23);
            leagueBox.TabIndex = 8;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(113, 232);
            button1.Name = "button1";
            button1.Size = new Size(75, 33);
            button1.TabIndex = 9;
            button1.Text = "add team";
            button1.UseVisualStyleBackColor = true;
            // 
            // addteamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 325);
            Controls.Add(flowLayoutPanel1);
            Name = "addteamForm";
            Text = "addteamForm";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private TextBox nameBox;
        private Label label3;
        private TextBox coachBox;
        private Label label4;
        private TextBox budgetBox;
        private Label label5;
        private TextBox leagueBox;
        private Button button1;
    }
}