namespace FTM2.Forms
{
    partial class addcontractForm
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
            player = new Label();
            playerComboBox = new ComboBox();
            label2 = new Label();
            startDatePicker = new DateTimePicker();
            label3 = new Label();
            endDatePicker = new DateTimePicker();
            label4 = new Label();
            salaryBox = new TextBox();
            saveButton = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(player);
            flowLayoutPanel1.Controls.Add(playerComboBox);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(startDatePicker);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(endDatePicker);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(salaryBox);
            flowLayoutPanel1.Controls.Add(saveButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(299, 304);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(48, 0);
            label1.Margin = new Padding(3, 0, 3, 20);
            label1.Name = "label1";
            label1.Size = new Size(205, 28);
            label1.TabIndex = 0;
            label1.Text = "ADD NEW CONTRACT";
            // 
            // player
            // 
            player.Anchor = AnchorStyles.None;
            player.AutoSize = true;
            player.Location = new Point(131, 48);
            player.Name = "player";
            player.Size = new Size(39, 15);
            player.TabIndex = 1;
            player.Text = "player";
            // 
            // playerComboBox
            // 
            playerComboBox.FormattingEnabled = true;
            playerComboBox.Location = new Point(3, 66);
            playerComboBox.Name = "playerComboBox";
            playerComboBox.Size = new Size(296, 23);
            playerComboBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(123, 92);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 3;
            label2.Text = "start date";
            // 
            // startDatePicker
            // 
            startDatePicker.Location = new Point(3, 110);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(296, 23);
            startDatePicker.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(124, 136);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "end date";
            // 
            // endDatePicker
            // 
            endDatePicker.Location = new Point(3, 154);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(296, 23);
            endDatePicker.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(132, 180);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 7;
            label4.Text = "salary";
            // 
            // salaryBox
            // 
            salaryBox.Location = new Point(3, 198);
            salaryBox.Margin = new Padding(3, 3, 3, 13);
            salaryBox.Name = "salaryBox";
            salaryBox.Size = new Size(296, 23);
            salaryBox.TabIndex = 8;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.None;
            saveButton.Location = new Point(101, 237);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(100, 37);
            saveButton.TabIndex = 9;
            saveButton.Text = "add contract";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // addcontractForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 304);
            Controls.Add(flowLayoutPanel1);
            Name = "addcontractForm";
            Text = "addcontractForm";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label player;
        private ComboBox playerComboBox;
        private Label label2;
        private DateTimePicker startDatePicker;
        private Label label3;
        private DateTimePicker endDatePicker;
        private Label label4;
        private TextBox salaryBox;
        private Button saveButton;
    }
}