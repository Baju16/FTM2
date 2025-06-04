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

namespace FTM2.Forms
{
    public partial class addplayerForm : Form
    {
        private readonly AppDbContext _context;
        private Player? _editingPlayer;

        public addplayerForm()
        {
            InitializeComponent();

            var factory = new AppDbContextFactory();
            _context = factory.CreateDbContext(Array.Empty<string>());

            LoadTeams();
            button1.Click += button1_Click;
        }

        public addplayerForm(Player playerToEdit) : this()
        {
            _editingPlayer = _context.Players
                .Include(p => p.PlayerContract)
                .FirstOrDefault(p => p.id == playerToEdit.id);

            if (_editingPlayer == null)
            {
                MessageBox.Show("Nie znaleziono gracza.");
                Close();
                return;
            }

            firstnameBox.Text = _editingPlayer.firstname;
            lastnameBox.Text = _editingPlayer.lastname;
            ageBox.Text = _editingPlayer.age.ToString();
            jerseyBox.Text = _editingPlayer.jerseynumber.ToString();
            positionBox.Text = _editingPlayer.position;
            nationalityBox.Text = _editingPlayer.nationality;
            teamComboBox.SelectedValue = _editingPlayer.teamid;
        }

        private void LoadTeams()
        {
            var teams = _context.Teams.OrderBy(t => t.name).ToList();
            teamComboBox.DataSource = teams;
            teamComboBox.DisplayMember = "name";
            teamComboBox.ValueMember = "id";
            teamComboBox.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = firstnameBox.Text.Trim();
                string lastName = lastnameBox.Text.Trim();
                string position = positionBox.Text.Trim();
                string nationality = nationalityBox.Text.Trim();
                string ageText = ageBox.Text.Trim();
                string jerseyText = jerseyBox.Text.Trim();

                if (!int.TryParse(ageText, out int age))
                {
                    MessageBox.Show("Wprowadź poprawny wiek.");
                    return;
                }

                if (age < 16 || age > 45)
                {
                    MessageBox.Show("Wiek musi być w przedziale od 16 do 45 lat.");
                    return;
                }

                if (!int.TryParse(jerseyText, out int jerseyNumber))
                {
                    MessageBox.Show("Wprowadź poprawny numer koszulki.");
                    return;
                }

                if (teamComboBox.SelectedValue is not int selectedTeamId)
                {
                    MessageBox.Show("Wybierz drużynę.");
                    return;
                }

                var selectedTeam = _context.Teams.Find(selectedTeamId);
                if (selectedTeam == null)
                {
                    MessageBox.Show("Nie znaleziono wybranej drużyny.");
                    return;
                }

                Player player;

                if (_editingPlayer == null)
                {
                    player = new Player
                    {
                        firstname = firstName,
                        lastname = lastName,
                        age = age,
                        jerseynumber = jerseyNumber,
                        position = position,
                        nationality = nationality,
                        teamid = selectedTeamId,
                        team = selectedTeam
                    };

                    if (checkBox.Checked)
                    {
                        var contract = new PlayerContract
                        {
                            startdate = DateTime.UtcNow,
                            enddate = DateTime.UtcNow.AddYears(1),
                            Player = player
                        };

                        player.PlayerContract = contract;
                    }

                    _context.Players.Add(player);
                }
                else
                {
                    player = _editingPlayer;
                    player.firstname = firstName;
                    player.lastname = lastName;
                    player.age = age;
                    player.jerseynumber = jerseyNumber;
                    player.position = position;
                    player.nationality = nationality;
                    player.teamid = selectedTeamId;
                    player.team = selectedTeam;

                    if (player.PlayerContract != null)
                    {
                        player.PlayerContract.startdate = DateTime.UtcNow;
                        player.PlayerContract.enddate = DateTime.UtcNow.AddYears(1);
                    }
                }

                _context.SaveChanges();
                MessageBox.Show(_editingPlayer == null ? "Gracz został dodany." : "Gracz został zaktualizowany.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                var errorMsg = new StringBuilder();
                errorMsg.AppendLine("Błąd dodawania gracza:");

                Exception? currentEx = ex;
                while (currentEx != null)
                {
                    errorMsg.AppendLine(currentEx.Message);
                    currentEx = currentEx.InnerException;
                }

                MessageBox.Show(errorMsg.ToString());
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // pozostawione puste
        }


    }
}
