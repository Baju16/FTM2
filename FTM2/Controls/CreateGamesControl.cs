using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FTM2.Data;
using FTM2.Models;
using Microsoft.EntityFrameworkCore;

namespace FTM2
{

    public partial class CreateGamesControl : UserControl
    {
        private readonly AppDbContext _context;
        private List<Team> _allTeams;

        public CreateGamesControl()
        {
            InitializeComponent();

            var factory = new AppDbContextFactory();
            _context = factory.CreateDbContext(Array.Empty<string>());

            LoadGames();
            LoadTeamsToComboBoxes();
            button1.Click += button1_Click;

        }

        private void LoadGames()
        {
            try
            {
                var gamesList = _context.Matches
                    .Include(m => m.hometeam)
                    .Include(m => m.awayteam)
                    .Select(m => new
                    {
                        m.id,
                        m.matchdate,
                        HomeTeam = m.hometeam.name,
                        AwayTeam = m.awayteam.name,
                        m.stadium,
                        m.result
                    })
                    .ToList();

                dataGridView1.DataSource = gamesList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd ładowania meczów: " + ex.Message);
            }
        }

        private void LoadTeamsToComboBoxes()
        {
            try
            {
                _allTeams = _context.Teams
                                    .OrderBy(t => t.name)
                                    .ToList();

                comboBox1.DataSource = new List<Team>(_allTeams);
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id";

                comboBox2.DataSource = new List<Team>(_allTeams);
                comboBox2.DisplayMember = "name";
                comboBox2.ValueMember = "id";

                comboBox1.SelectedIndexChanged += ComboBoxes_SelectedIndexChanged;
                comboBox2.SelectedIndexChanged += ComboBoxes_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd ładowania drużyn: " + ex.Message);
            }
        }

        private void ComboBoxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Team selectedHome &&
                comboBox2.SelectedItem is Team selectedAway)
            {
                if (selectedHome.id == selectedAway.id)
                {
                    ComboBox changedBox = (ComboBox)sender;

                    if (changedBox == comboBox1)
                    {
                        comboBox2.SelectedIndex = -1;
                    }
                    else
                    {
                        comboBox1.SelectedIndex = -1;
                    }

                    MessageBox.Show("Nie można wybrać tej samej drużyny jako gospodarzy i gości.",
                                    "Błąd wyboru",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Wybierz obie drużyny.");
                return;
            }

            if (comboBox1.SelectedValue.Equals(comboBox2.SelectedValue))
            {
                MessageBox.Show("Drużyny gospodarzy i gości nie mogą być takie same.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Uzupełnij wszystkie pola tekstowe.");
                return;
            }

            try
            {
                var homeTeam = _context.Teams.Find((int)comboBox1.SelectedValue);
                var awayTeam = _context.Teams.Find((int)comboBox2.SelectedValue);

                var newMatch = new Match
                {
                    matchdate = dateTimePicker1.Value.ToUniversalTime(),
                    hometeamid = homeTeam.id,
                    awayteamid = awayTeam.id,
                    hometeam = homeTeam,
                    awayteam = awayTeam,
                    stadium = textBox2.Text,
                    result = textBox1.Text,
                };

                _context.Matches.Add(newMatch);
                _context.SaveChanges();

                MessageBox.Show("Mecz został dodany.");

                LoadGames();

                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                textBox1.Clear();
                textBox2.Clear();
                dateTimePicker1.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                var errorMsg = ex.Message;
                if (ex.InnerException != null)
                    errorMsg += "\nInner Exception:\n" + ex.InnerException.Message;

                MessageBox.Show("Błąd podczas dodawania meczu:\n" + errorMsg);
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
