using FTM2.Data;
using FTM2.Forms;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FTM2
{
    public partial class ContractControl : UserControl
    {
        private readonly AppDbContext _context;

        public ContractControl()
        {
            InitializeComponent();


            if (!DesignMode && !LicenseManager.UsageMode.Equals(LicenseUsageMode.Designtime))
            {
                var factory = new AppDbContextFactory();
                _context = factory.CreateDbContext(Array.Empty<string>());

                LoadContracts();
                LoadTeamsToTeamComboBox();

            }
        }




        private void LoadContracts()
        {
            try
            {
                var playersWithContracts = _context.Players
                    .Include(p => p.PlayerContract)
                    .Include(p => p.team)
                    .Select(p => new
                    {
                        p.id,
                        p.firstname,
                        p.lastname,
                        p.jerseynumber,
                        p.nationality,
                        teamid = p.team != null ? p.team.name : string.Empty,
                        salary = p.PlayerContract != null ? p.PlayerContract.salary : 0,
                        StartDate = p.PlayerContract != null ? p.PlayerContract.startdate : (DateTime?)null,
                        ContractEndDate = p.PlayerContract != null && p.PlayerContract.enddate.HasValue
                                            ? p.PlayerContract.enddate.Value
                                            : (DateTime?)null
                    })
                    .ToList();

                dataGridView1.DataSource = playersWithContracts;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd ładowania graczy: " + ex.Message);
            }
        }

        private void LoadTeamsToTeamComboBox()
        {
            try
            {
                var teams = _context.Teams
                    .OrderBy(t => t.name)
                    .ToList();

                teamComboBox.DataSource = teams;
                teamComboBox.DisplayMember = "name";
                teamComboBox.ValueMember = "id";
                teamComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd ładowania drużyn: " + ex.Message);
            }
        }






        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            string name = firstnameBox.Text.Trim().ToLower();
            string lastname = lastnameBox.Text.Trim().ToLower();
            string minSalaryText = minsalaryBox.Text.Trim();
            int.TryParse(minSalaryText, out int minSalary);
            bool filterSalary = !string.IsNullOrEmpty(minSalaryText);

            int? selectedTeamId = teamComboBox.SelectedValue as int?;

            var filteredPlayers = _context.Players
                .Where(p =>
                    (string.IsNullOrEmpty(name) || p.firstname.ToLower().Contains(name)) &&
                    (string.IsNullOrEmpty(lastname) || p.lastname.ToLower().Contains(lastname)) &&
                    (!selectedTeamId.HasValue || p.teamid == selectedTeamId.Value) &&
                    (!filterSalary || (p.PlayerContract != null && p.PlayerContract.salary >= minSalary))
                )
                .Select(p => new
                {
                    p.id,
                    p.firstname,
                    p.lastname,
                    p.jerseynumber,
                    p.nationality,
                    teamid = p.team != null ? p.team.name : string.Empty,
                    p.PlayerContract.salary,
                    StartDate = p.PlayerContract != null ? p.PlayerContract.startdate : (DateTime?)null,
                    ContractEndDate = p.PlayerContract != null && p.PlayerContract.enddate.HasValue
                                        ? p.PlayerContract.enddate.Value
                                        : (DateTime?)null
                })
                .ToList();

            dataGridView1.DataSource = filteredPlayers;
        }


        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadContracts();
            dataGridView1.Refresh();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var form = new addcontractForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadContracts();
            }
        }


        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Wybierz gracza z kontraktem do edycji.");
                return;
            }

            if (!int.TryParse(dataGridView1.CurrentRow.Cells["id"].Value?.ToString(), out int playerId))
            {
                MessageBox.Show("Nieprawidłowy identyfikator.");
                return;
            }

            var contract = _context.PlayerContracts
                .Include(c => c.Player)
                .FirstOrDefault(c => c.playerid == playerId);

            if (contract == null)
            {
                MessageBox.Show("Gracz nie ma przypisanego kontraktu.");
                return;
            }

            var form = new addcontractForm(_context, contract);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadContracts();
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Wybierz gracza z kontraktem do usunięcia.");
                return;
            }

            if (!int.TryParse(dataGridView1.CurrentRow.Cells["id"].Value?.ToString(), out int playerId))
            {
                MessageBox.Show("Nieprawidłowy identyfikator.");
                return;
            }

            var contract = _context.PlayerContracts
                .Include(c => c.Player)
                .FirstOrDefault(c => c.playerid == playerId);

            if (contract == null)
            {
                MessageBox.Show("Brak kontraktu do usunięcia.");
                return;
            }

            var confirm = MessageBox.Show(
                $"Czy na pewno chcesz usunąć kontrakt gracza {contract.Player.firstname} {contract.Player.lastname}?",
                "Potwierdzenie usunięcia",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _context.PlayerContracts.Remove(contract);
                    _context.SaveChanges();
                    LoadContracts();
                    MessageBox.Show("Kontrakt został usunięty.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas usuwania kontraktu: " + ex.Message);
                }
            }
        }

    }
}
