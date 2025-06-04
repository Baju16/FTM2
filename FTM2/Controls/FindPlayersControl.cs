using FTM2.Data;
using FTM2.Forms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FTM2
{
    public partial class FindPlayersControl : UserControl
    {
        private readonly AppDbContext _context;
        private List<dynamic> _allTeams;


        public FindPlayersControl()
        {
            InitializeComponent();

            var factory = new AppDbContextFactory();
            _context = factory.CreateDbContext(Array.Empty<string>());

            LoadTeams();
        }

        private void LoadTeams()
        {
            try
            {
                var allTeams = _context.Teams
                    .Select(t => new
                    {
                        id = t.id,
                        name = t.name,
                        coach = t.coach,
                        budget = t.budget,
                        league = t.league,
                        playersCount = t.Players.Count
                    })
                    .ToList();

                dataGridView1.DataSource = allTeams;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd ładowania drużyn: " + ex.Message);
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            string nameFilter = nameBox.Text.Trim().ToLower();
            string coachFilter = coachBox.Text.Trim().ToLower();
            string leagueFilter = leagueBox.Text.Trim().ToLower();

            try
            {
                var filteredTeams = _context.Teams
                    .Include(t => t.Players)
                    .Where(t =>
                        (string.IsNullOrEmpty(nameFilter) || t.name.ToLower().Contains(nameFilter)) &&
                        (string.IsNullOrEmpty(coachFilter) || t.coach.ToLower().Contains(coachFilter)) &&
                        (string.IsNullOrEmpty(leagueFilter) || t.league.ToLower().Contains(leagueFilter))
                    )
                    .Select(t => new
                    {
                        t.id,
                        t.name,
                        t.coach,
                        t.budget,
                        t.league,
                        playersCount = t.Players.Count
                    })
                    .ToList();

                dataGridView1.DataSource = filteredTeams;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd filtrowania drużyn: " + ex.Message);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var form = new addteamForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadTeams();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadTeams();
            dataGridView1.Refresh();
        }

        private void removeButton_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Wybierz drużynę do usunięcia.");
                return;
            }

            if (!int.TryParse(dataGridView1.CurrentRow.Cells["id"].Value?.ToString(), out int teamId))
            {
                MessageBox.Show("Nieprawidłowy identyfikator drużyny.");
                return;
            }

            var team = _context.Teams
                .Include(t => t.Players)
                .Include(t => t.HomeMatches)
                .Include(t => t.AwayMatches)
                .FirstOrDefault(t => t.id == teamId);

            if (team == null)
            {
                MessageBox.Show("Nie znaleziono drużyny do usunięcia.");
                return;
            }

            var confirm = MessageBox.Show(
                $"Czy na pewno chcesz usunąć drużynę {team.name}?",
                "Potwierdzenie usunięcia",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _context.Teams.Remove(team);
                    _context.SaveChanges();

                    LoadTeams();

                    MessageBox.Show("Drużyna została usunięta.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas usuwania drużyny: " + ex.Message);
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Wybierz drużynę do edycji.");
                return;
            }

            if (!int.TryParse(dataGridView1.CurrentRow.Cells["id"].Value?.ToString(), out int teamId))
            {
                MessageBox.Show("Nieprawidłowy identyfikator drużyny.");
                return;
            }

            var team = _context.Teams
                .Include(t => t.Players)
                .Include(t => t.HomeMatches)
                .Include(t => t.AwayMatches)
                .FirstOrDefault(t => t.id == teamId);

            if (team == null)
            {
                MessageBox.Show("Nie znaleziono drużyny do edycji.");
                return;
            }

            var form = new addteamForm(_context, team);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadTeams();
            }
        }
    }
}
