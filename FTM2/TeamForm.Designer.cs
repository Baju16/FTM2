namespace FTM2
{
    partial class TeamForm
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

        private void InitializeComponent()
        {
            tabPageTeam = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            addplayerButton = new Button();
            removeButton = new Button();
            editButton = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label2 = new Label();
            firstnameBox = new TextBox();
            label3 = new Label();
            lastnameBox = new TextBox();
            label4 = new Label();
            ageBox = new TextBox();
            label5 = new Label();
            positionBox = new TextBox();
            label6 = new Label();
            nationalityBox = new TextBox();
            label7 = new Label();
            teamBox = new ComboBox();
            filterButton = new Button();
            button1 = new Button();
            tabControl1 = new TabControl();
            tabPageContracts = new TabPage();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPageTeam.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageTeam
            // 
            tabPageTeam.Controls.Add(tableLayoutPanel1);
            tabPageTeam.Location = new Point(4, 24);
            tabPageTeam.Name = "tabPageTeam";
            tabPageTeam.Padding = new Padding(3);
            tabPageTeam.Size = new Size(1289, 533);
            tabPageTeam.TabIndex = 0;
            tabPageTeam.Text = "Players";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89.39984F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.6001558F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1283, 527);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 60);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1141, 464);
            dataGridView1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(addplayerButton);
            flowLayoutPanel1.Controls.Add(removeButton);
            flowLayoutPanel1.Controls.Add(editButton);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(1150, 60);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(130, 464);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // addplayerButton
            // 
            addplayerButton.Dock = DockStyle.Fill;
            addplayerButton.Location = new Point(3, 3);
            addplayerButton.Name = "addplayerButton";
            addplayerButton.Size = new Size(75, 23);
            addplayerButton.TabIndex = 0;
            addplayerButton.Text = "add new";
            addplayerButton.UseVisualStyleBackColor = true;
            addplayerButton.Click += addplayerButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(3, 32);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(75, 23);
            removeButton.TabIndex = 1;
            removeButton.Text = "remove player";
            removeButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            editButton.Location = new Point(3, 61);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 23);
            editButton.TabIndex = 2;
            editButton.Text = "edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click_1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(firstnameBox);
            flowLayoutPanel2.Controls.Add(label3);
            flowLayoutPanel2.Controls.Add(lastnameBox);
            flowLayoutPanel2.Controls.Add(label4);
            flowLayoutPanel2.Controls.Add(ageBox);
            flowLayoutPanel2.Controls.Add(label5);
            flowLayoutPanel2.Controls.Add(positionBox);
            flowLayoutPanel2.Controls.Add(label6);
            flowLayoutPanel2.Controls.Add(nationalityBox);
            flowLayoutPanel2.Controls.Add(label7);
            flowLayoutPanel2.Controls.Add(teamBox);
            flowLayoutPanel2.Controls.Add(filterButton);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1141, 51);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 0;
            label2.Text = "firstname";
            // 
            // firstnameBox
            // 
            firstnameBox.Location = new Point(66, 3);
            firstnameBox.Name = "firstnameBox";
            firstnameBox.Size = new Size(100, 23);
            firstnameBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(172, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "lastname";
            // 
            // lastnameBox
            // 
            lastnameBox.Location = new Point(233, 3);
            lastnameBox.Name = "lastnameBox";
            lastnameBox.Size = new Size(100, 23);
            lastnameBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(339, 0);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 4;
            label4.Text = "age";
            // 
            // ageBox
            // 
            ageBox.Location = new Point(371, 3);
            ageBox.Name = "ageBox";
            ageBox.Size = new Size(100, 23);
            ageBox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(477, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 6;
            label5.Text = "position";
            // 
            // positionBox
            // 
            positionBox.Location = new Point(533, 3);
            positionBox.Name = "positionBox";
            positionBox.Size = new Size(100, 23);
            positionBox.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(639, 0);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 8;
            label6.Text = "nationality";
            // 
            // nationalityBox
            // 
            nationalityBox.Location = new Point(708, 3);
            nationalityBox.Name = "nationalityBox";
            nationalityBox.Size = new Size(100, 23);
            nationalityBox.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(814, 0);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 10;
            label7.Text = "team";
            // 
            // teamBox
            // 
            teamBox.FormattingEnabled = true;
            teamBox.Location = new Point(854, 3);
            teamBox.Name = "teamBox";
            teamBox.Size = new Size(121, 23);
            teamBox.TabIndex = 11;
            // 
            // filterButton
            // 
            filterButton.Location = new Point(981, 3);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(75, 23);
            filterButton.TabIndex = 12;
            filterButton.Text = "filter";
            filterButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(1150, 3);
            button1.Name = "button1";
            button1.Size = new Size(78, 26);
            button1.TabIndex = 3;
            button1.Text = "refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageTeam);
            tabControl1.Controls.Add(tabPageContracts);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1297, 561);
            tabControl1.TabIndex = 0;
            tabControl1.Tag = "";
            // 
            // tabPageContracts
            // 
            tabPageContracts.Location = new Point(4, 24);
            tabPageContracts.Name = "tabPageContracts";
            tabPageContracts.Padding = new Padding(3);
            tabPageContracts.Size = new Size(1289, 533);
            tabPageContracts.TabIndex = 1;
            tabPageContracts.Text = "Contracts";
            tabPageContracts.Click += tabPageContracts_Click;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1289, 533);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Teams";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1289, 533);
            tabPage2.TabIndex = 3;
            tabPage2.Text = "CreateGames";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // TeamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 561);
            Controls.Add(tabControl1);
            Name = "TeamForm";
            Text = "TeamForm";
            Load += TeamForm_Load;
            tabPageTeam.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabPageTeam;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private FindPlayersControl findPlayersControl1;
        private CreateGamesControl createGamesControl1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label2;
        private TextBox firstnameBox;
        private Label label3;
        private TextBox lastnameBox;
        private Label label4;
        private TextBox ageBox;
        private Label label5;
        private TextBox positionBox;
        private Label label6;
        private TextBox nationalityBox;
        private Label label7;
        private ComboBox teamBox;
        private Button filterButton;
        private Button addplayerButton;
        private Button removeButton;
        private Button editButton;
        private Button button1;
        private TabPage tabPageContracts;
        private ContractControl contractControl1;
        private FindPlayersControl findPlayersControl2;
        private CreateGamesControl createGamesControl2;
    }
}
