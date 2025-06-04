using System;
using System.Linq;
using System.Windows.Forms;
using FTM2.Data;
using FTM2.Models;
using System.Collections.Generic;
using System.ComponentModel;
using FTM2.Forms;

namespace FTM2
{
    public partial class TeamForm : Form
    {
        private readonly AppDbContext _context;
        private ContractControl _contractControl;
        private FindPlayersControl _findPlayersControl;
        private CreateGamesControl _createGamesControl;

        private AppDbContext _dbContext;

        public TeamForm()
        {
            InitializeComponent();
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            dataGridView1.RowValidating += dataGridView1_RowValidating;

            var factory = new AppDbContextFactory();
            _context = factory.CreateDbContext(Array.Empty<string>());

            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.DataError += dataGridView1_DataError;
            removeButton.Click += removeButton_Click;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToDeleteRows = true;
        }

        private void TeamForm_Load(object sender, EventArgs e)
        {

            LoadTeamsToTeamBox();
            LoadTeamsToComboBox();
            LoadPlayers();

            filterButton.Click += FilterButton_Click;
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            string firstname = firstnameBox.Text.Trim().ToLower();
            string lastname = lastnameBox.Text.Trim().ToLower();
            string ageText = ageBox.Text.Trim();
            string position = positionBox.Text.Trim().ToLower();
            string nationality = nationalityBox.Text.Trim().ToLower();

            int.TryParse(ageText, out int ageFilter);
            bool filterAge = !string.IsNullOrEmpty(ageText);

            int? selectedTeamId = null;
            if (teamBox.SelectedValue != null)
            {
                selectedTeamId = Convert.ToInt32(teamBox.SelectedValue);
            }



            var filteredPlayers = _context.Players
                .Where(p =>
                    (string.IsNullOrEmpty(firstname) || p.firstname.ToLower().Contains(firstname)) &&
                    (string.IsNullOrEmpty(lastname) || p.lastname.ToLower().Contains(lastname)) &&
                    (!filterAge || p.age == ageFilter) &&
                    (string.IsNullOrEmpty(position) || p.position.ToLower().Contains(position)) &&
                    (string.IsNullOrEmpty(nationality) || p.nationality.ToLower().Contains(nationality)) &&
                    (!selectedTeamId.HasValue || p.teamid == selectedTeamId.Value)
                )
                .Select(p => new
                {
                    p.id,
                    p.firstname,
                    p.lastname,
                    p.jerseynumber,
                    p.nationality,
                    teamid = p.team != null ? p.team.name : string.Empty,
                    ContractEndDate = p.PlayerContract != null && p.PlayerContract.enddate.HasValue
                                        ? p.PlayerContract.enddate.Value
                                        : (DateTime?)null
                })
                .ToList();

            dataGridView1.DataSource = filteredPlayers;
        }

        private void LoadTeamsToTeamBox()
        {
            var teams = _context.Teams.OrderBy(t => t.name).ToList();

            teamBox.DataSource = teams;
            teamBox.DisplayMember = "name";
            teamBox.ValueMember = "id";
            teamBox.SelectedIndex = -1;
        }


        private BindingList<Player> _playersBindingList;

        private void LoadPlayers()
        {
            var players = _context.Players
                .Select(p => new
                {
                    p.id,
                    p.firstname,
                    p.lastname,
                    p.jerseynumber,
                    p.nationality,
                    teamid = p.team != null ? p.team.name : string.Empty,
                    ContractEndDate = p.PlayerContract != null && p.PlayerContract.enddate.HasValue
                                        ? p.PlayerContract.enddate.Value
                                        : (DateTime?)null
                })
                .ToList();

            dataGridView1.DataSource = players;
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = dataGridView1.Rows[e.RowIndex];
            if (row.Cells["id"].Value == null)
                return;

            if (!int.TryParse(row.Cells["id"].Value.ToString(), out int playerId))
                return;

            var player = _context.Players.Find(playerId);
            if (player == null)
                return;

            if (row.Cells["firstname"].Value is string firstName)
                player.firstname = firstName;

            if (row.Cells["lastname"].Value is string lastName)
                player.lastname = lastName;

            if (row.Cells["nationality"].Value is string nationality)
                player.nationality = nationality;

            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas zapisu zmian: " + ex.Message);
            }
        }


        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Błąd w danych: " + e.Exception.Message);
            e.Cancel = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageContracts)
            {
                if (_contractControl == null)
                {
                    _contractControl = new ContractControl();
                    _contractControl.Dock = DockStyle.Fill;
                    tabPageContracts.Controls.Add(_contractControl);
                }
                _contractControl.BringToFront();
                _contractControl.Visible = true;
            }
            else if (tabControl1.SelectedTab == tabPageTeam)
            {
                LoadPlayers();
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                if (_createGamesControl == null)
                {
                    _createGamesControl = new CreateGamesControl();
                    _createGamesControl.Dock = DockStyle.Fill;
                    tabPage2.Controls.Add(_createGamesControl);
                }
                _createGamesControl.BringToFront();
                _createGamesControl.Visible = true;
            }
            else if (tabControl1.SelectedTab == tabPage1)
            {
                if (_findPlayersControl == null)
                {
                    _findPlayersControl = new FindPlayersControl();
                    _findPlayersControl.Dock = DockStyle.Fill;
                    tabPage1.Controls.Add(_findPlayersControl);
                }
                _findPlayersControl.BringToFront();
                _findPlayersControl.Visible = true;
            }

        }

        private void LoadTeamsToComboBox()
        {
            var teams = _context.Players
                .Select(p => p.team)
                .Distinct()
                .Where(t => t != null)
                .OrderBy(t => t.name)
                .ToList();

        }

        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            var row = dataGridView1.Rows[e.RowIndex];

            if (row.IsNewRow || row.Cells["id"].Value == null)
                return;

            if (!int.TryParse(row.Cells["id"].Value.ToString(), out int playerId))
                return;

            var player = _context.Players.Find(playerId);
            if (player == null)
                return;

            string firstName = row.Cells["firstname"].Value?.ToString();
            string lastName = row.Cells["lastname"].Value?.ToString();
            string nationality = row.Cells["nationality"].Value?.ToString();

            int? jerseyNumber = null;
            int? teamId = null;

            if (int.TryParse(row.Cells["jerseynumber"].Value?.ToString(), out int jn))
                jerseyNumber = jn;

            if (int.TryParse(row.Cells["teamid"].Value?.ToString(), out int tid))
                teamId = tid;

            if (jerseyNumber == null || teamId == null)
                return;

            bool isDuplicate = false;
            if (teamId.HasValue && jerseyNumber.HasValue)
            {
                isDuplicate = _context.Players.Any(p =>
                    p.id != playerId &&
                    p.teamid == teamId.Value &&
                    p.jerseynumber == jerseyNumber.Value);
            }


            if (isDuplicate)
            {
                MessageBox.Show($"Numer {jerseyNumber} jest już zajęty w tej drużynie. Wybierz inny numer.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }

            player.firstname = firstName;
            player.lastname = lastName;
            if (jerseyNumber.HasValue)
                player.jerseynumber = jerseyNumber.Value;

            player.nationality = nationality;
            if (jerseyNumber.HasValue)
                player.teamid = teamId.Value;


            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas zapisu zmian: " + ex.Message);
                e.Cancel = true;
            }
        }



        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addplayerButton_Click(object sender, EventArgs e)
        {
            addplayerForm addplayerForm = new addplayerForm();
            addplayerForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            LoadPlayers();
            dataGridView1.Refresh();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznaczyć gracza do usunięcia.");
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];

            if (selectedRow.Cells["id"].Value == null ||
                !int.TryParse(selectedRow.Cells["id"].Value.ToString(), out int playerId))
            {
                MessageBox.Show("Nieprawidłowy identyfikator gracza.");
                return;
            }

            var player = _context.Players.Find(playerId);

            if (player == null)
            {
                MessageBox.Show("Nie znaleziono gracza w bazie danych.");
                return;
            }

            var confirmResult = MessageBox.Show(
                $"Czy na pewno chcesz usunąć gracza {player.firstname} {player.lastname}?",
                "Potwierdzenie usunięcia",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    _context.Players.Remove(player);
                    _context.SaveChanges();

                    LoadPlayers(); // Załaduj dane ponownie
                    MessageBox.Show("Gracz został usunięty.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas usuwania gracza: " + ex.Message);
                }
            }
        }

        private void editButton_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Wybierz gracza do edycji.");
                return;
            }

            var idCell = dataGridView1.CurrentRow.Cells["id"].Value;
            if (idCell == null || !int.TryParse(idCell.ToString(), out int playerId))
            {
                MessageBox.Show("Nieprawidłowy identyfikator gracza.");
                return;
            }

            var selectedPlayer = _context.Players.Find(playerId);
            if (selectedPlayer == null)
            {
                MessageBox.Show("Nie znaleziono gracza w bazie danych.");
                return;
            }

            var editForm = new addplayerForm(selectedPlayer); // Upewnij się, że masz taki konstruktor
            var result = editForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadPlayers();            // załaduj dane ponownie
                dataGridView1.Refresh();  // odśwież widok
            }
        }

        private void tabPageContracts_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
