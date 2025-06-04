namespace FTM2
{
    partial class CreateGamesControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            matchdate = new Label();
            dateTimePicker1 = new DateTimePicker();
            hometeam = new Label();
            comboBox1 = new ComboBox();
            awayteam = new Label();
            comboBox2 = new ComboBox();
            stadium = new Label();
            textBox2 = new TextBox();
            result = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.Size = new Size(900, 400);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(matchdate);
            flowLayoutPanel1.Controls.Add(dateTimePicker1);
            flowLayoutPanel1.Controls.Add(hometeam);
            flowLayoutPanel1.Controls.Add(comboBox1);
            flowLayoutPanel1.Controls.Add(awayteam);
            flowLayoutPanel1.Controls.Add(comboBox2);
            flowLayoutPanel1.Controls.Add(stadium);
            flowLayoutPanel1.Controls.Add(textBox2);
            flowLayoutPanel1.Controls.Add(result);
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(894, 394);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // matchdate
            // 
            matchdate.Anchor = AnchorStyles.None;
            matchdate.AutoSize = true;
            matchdate.Location = new Point(71, 0);
            matchdate.Name = "matchdate";
            matchdate.Size = new Size(64, 15);
            matchdate.TabIndex = 0;
            matchdate.Text = "matchdate";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(3, 18);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // hometeam
            // 
            hometeam.Anchor = AnchorStyles.None;
            hometeam.AutoSize = true;
            hometeam.Location = new Point(70, 44);
            hometeam.Name = "hometeam";
            hometeam.Size = new Size(65, 15);
            hometeam.TabIndex = 2;
            hometeam.Text = "hometeam";
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 3;
            // 
            // awayteam
            // 
            awayteam.Anchor = AnchorStyles.None;
            awayteam.AutoSize = true;
            awayteam.Location = new Point(72, 88);
            awayteam.Name = "awayteam";
            awayteam.Size = new Size(61, 15);
            awayteam.TabIndex = 4;
            awayteam.Text = "awayteam";
            // 
            // comboBox2
            // 
            comboBox2.Dock = DockStyle.Fill;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(3, 106);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 23);
            comboBox2.TabIndex = 9;
            // 
            // stadium
            // 
            stadium.Anchor = AnchorStyles.None;
            stadium.AutoSize = true;
            stadium.Location = new Point(78, 132);
            stadium.Name = "stadium";
            stadium.Size = new Size(50, 15);
            stadium.TabIndex = 6;
            stadium.Text = "stadium";
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(3, 150);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 7;
            // 
            // result
            // 
            result.Anchor = AnchorStyles.None;
            result.AutoSize = true;
            result.Location = new Point(85, 176);
            result.Name = "result";
            result.Size = new Size(36, 15);
            result.TabIndex = 10;
            result.Text = "result";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 194);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 11;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(65, 223);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "add";
            button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.31386864F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98.6861343F));
            tableLayoutPanel2.Controls.Add(dataGridView1, 1, 0);
            tableLayoutPanel2.Location = new Point(209, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(685, 394);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(12, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(670, 388);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CreateGamesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CreateGamesControl";
            Size = new Size(900, 400);
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label matchdate;
        private DateTimePicker dateTimePicker1;
        private Label hometeam;
        private ComboBox comboBox1;
        private Label awayteam;
        private Label stadium;
        private TextBox textBox2;
        private Button button1;
        private ComboBox comboBox2;
        private Label result;
        private TextBox textBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dataGridView1;
    }
}
