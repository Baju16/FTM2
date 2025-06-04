namespace FTM2
{
    partial class FindPlayersControl
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
            components = new System.ComponentModel.Container();
            teamBindingSource = new BindingSource(components);
            appDbContextBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            nameBox = new TextBox();
            coach = new Label();
            coachBox = new TextBox();
            label3 = new Label();
            leagueBox = new TextBox();
            filterButton = new Button();
            refreshButton = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            addButton = new Button();
            removeButton = new Button();
            editButton = new Button();
            ((System.ComponentModel.ISupportInitialize)teamBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // teamBindingSource
            // 
            teamBindingSource.DataSource = typeof(Models.Team);
            // 
            // appDbContextBindingSource
            // 
            appDbContextBindingSource.DataSource = typeof(Data.AppDbContext);
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(803, 337);
            dataGridView1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 91F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(refreshButton, 1, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85.75F));
            tableLayoutPanel1.Size = new Size(900, 400);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(nameBox);
            flowLayoutPanel1.Controls.Add(coach);
            flowLayoutPanel1.Controls.Add(coachBox);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(leagueBox);
            flowLayoutPanel1.Controls.Add(filterButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(803, 51);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "name";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(46, 3);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(100, 23);
            nameBox.TabIndex = 1;
            // 
            // coach
            // 
            coach.AutoSize = true;
            coach.Location = new Point(152, 0);
            coach.Name = "coach";
            coach.Size = new Size(39, 15);
            coach.TabIndex = 2;
            coach.Text = "coach";
            // 
            // coachBox
            // 
            coachBox.Location = new Point(197, 3);
            coachBox.Name = "coachBox";
            coachBox.Size = new Size(100, 23);
            coachBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(303, 0);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "league";
            // 
            // leagueBox
            // 
            leagueBox.Location = new Point(351, 3);
            leagueBox.Name = "leagueBox";
            leagueBox.Size = new Size(100, 23);
            leagueBox.TabIndex = 5;
            // 
            // filterButton
            // 
            filterButton.Location = new Point(457, 3);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(75, 23);
            filterButton.TabIndex = 6;
            filterButton.Text = "filter";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(812, 3);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(75, 23);
            refreshButton.TabIndex = 3;
            refreshButton.Text = "refresh";
            refreshButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(addButton);
            flowLayoutPanel2.Controls.Add(removeButton);
            flowLayoutPanel2.Controls.Add(editButton);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(812, 60);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(85, 337);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // addButton
            // 
            addButton.Location = new Point(3, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 0;
            addButton.Text = "add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(3, 32);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(75, 23);
            removeButton.TabIndex = 1;
            removeButton.Text = "remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click_1;
            // 
            // editButton
            // 
            editButton.Location = new Point(3, 61);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 23);
            editButton.TabIndex = 2;
            editButton.Text = "edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // FindPlayersControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "FindPlayersControl";
            Size = new Size(900, 400);
            ((System.ComponentModel.ISupportInitialize)teamBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private BindingSource teamBindingSource;
        private BindingSource appDbContextBindingSource;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox nameBox;
        private Label coach;
        private TextBox coachBox;
        private Label label3;
        private TextBox leagueBox;
        private Button filterButton;
        private Button refreshButton;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button addButton;
        private Button removeButton;
        private Button editButton;
    }
}
