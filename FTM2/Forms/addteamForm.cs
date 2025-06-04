using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FTM2.Data;
using FTM2.Models;

namespace FTM2.Forms
{
    public partial class addteamForm : Form
    {
        private readonly AppDbContext _context;
        private Team? _editingTeam;

        public addteamForm()
        {
            InitializeComponent();

            var factory = new AppDbContextFactory();
            _context = factory.CreateDbContext(Array.Empty<string>());

            button1.Click += button1_Click;
        }

        // Konstruktor do edycji drużyny
        public addteamForm(AppDbContext context, Team teamToEdit) : this()
        {
            _context = context; // nadpisujemy kontekst utworzony w domyślnym konstruktorze
            _editingTeam = _context.Teams.Find(teamToEdit.id);

            if (_editingTeam == null)
            {
                MessageBox.Show("Nie znaleziono drużyny.");
                Close();
                return;
            }

            nameBox.Text = _editingTeam.name;
            coachBox.Text = _editingTeam.coach;
            budgetBox.Text = _editingTeam.budget?.ToString("F2") ?? string.Empty;
            leagueBox.Text = _editingTeam.league;
            button1.Text = "Update team";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameBox.Text.Trim();
                string coach = coachBox.Text.Trim();
                string budgetText = budgetBox.Text.Trim();
                string league = leagueBox.Text.Trim();

                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Podaj nazwę drużyny.");
                    return;
                }

                if (string.IsNullOrEmpty(coach))
                {
                    MessageBox.Show("Podaj nazwisko trenera.");
                    return;
                }

                if (string.IsNullOrEmpty(league))
                {
                    MessageBox.Show("Podaj ligę.");
                    return;
                }

                decimal? budget = null;
                if (!string.IsNullOrEmpty(budgetText))
                {
                    if (!decimal.TryParse(budgetText, out decimal parsedBudget))
                    {
                        MessageBox.Show("Wprowadź poprawny budżet (liczba).");
                        return;
                    }
                    budget = parsedBudget;
                }

                if (_editingTeam == null)
                {
                    var newTeam = new Team
                    {
                        name = nameBox.Text.Trim(),
                        coach = coachBox.Text.Trim(),
                        league = leagueBox.Text.Trim(),
                        budget = decimal.TryParse(budgetBox.Text.Trim(), out var b) ? b : (decimal?)null,
                        Players = new List<Player>(),
                        HomeMatches = new List<Match>(),
                        AwayMatches = new List<Match>()
                    };

                    _context.Teams.Add(newTeam);
                }
                else
                {
                    _editingTeam.name = name;
                    _editingTeam.coach = coach;
                    _editingTeam.budget = budget;
                    _editingTeam.league = league;
                }

                _context.SaveChanges();

                MessageBox.Show(_editingTeam == null ? "Drużyna została dodana." : "Drużyna została zaktualizowana.");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                var errorMsg = new StringBuilder();
                errorMsg.AppendLine("Błąd dodawania drużyny:");

                Exception? currentEx = ex;
                while (currentEx != null)
                {
                    errorMsg.AppendLine(currentEx.Message);
                    currentEx = currentEx.InnerException;
                }

                MessageBox.Show(errorMsg.ToString());
            }
        }
    }
}
