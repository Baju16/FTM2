using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FTM2.Data;
using FTM2.Models;
using Microsoft.EntityFrameworkCore;

namespace FTM2.Forms
{
    public partial class addcontractForm : Form
    {
        private readonly AppDbContext _context;
        private readonly PlayerContract? _editingContract;

        public addcontractForm()
        {
            InitializeComponent();

            var factory = new AppDbContextFactory();
            _context = factory.CreateDbContext(Array.Empty<string>());

            LoadPlayers();
            saveButton.Click += SaveButton_Click;
        }


        public addcontractForm(PlayerContract contractToEdit) : this()
        {
            _editingContract = _context.PlayerContracts
                .Include(c => c.Player)
                .FirstOrDefault(c => c.id == contractToEdit.id);

            if (_editingContract == null)
            {
                MessageBox.Show("Nie znaleziono kontraktu.");
                Close();
                return;
            }

            playerComboBox.SelectedValue = _editingContract.playerid;
            startDatePicker.Value = _editingContract.startdate;
            if (_editingContract.enddate.HasValue)
            {
                endDatePicker.Value = _editingContract.enddate.Value;
                endDatePicker.Checked = true;
            }
            else
            {
                endDatePicker.Checked = false;
            }

            salaryBox.Text = _editingContract.salary?.ToString("F2") ?? string.Empty;
        }

        public addcontractForm(AppDbContext context, PlayerContract contractToEdit) : this()
        {
            _context = context; // nadpisujemy kontekst

            _editingContract = _context.PlayerContracts
                .Include(c => c.Player)
                .FirstOrDefault(c => c.id == contractToEdit.id);

            if (_editingContract == null)
            {
                MessageBox.Show("Nie znaleziono kontraktu.");
                Close();
                return;
            }

           LoadPlayers(_editingContract.playerid);


            startDatePicker.Value = _editingContract.startdate;
            if (_editingContract.enddate.HasValue)
            {
                endDatePicker.Value = _editingContract.enddate.Value;
                endDatePicker.Checked = true;
            }
            else
            {
                endDatePicker.Checked = false;
            }

            salaryBox.Text = _editingContract.salary?.ToString("F2") ?? string.Empty;
        }

        private void LoadPlayers(int? preselectPlayerId = null)

        {
            var players = _context.Players
                .Include(p => p.PlayerContract)
                .Where(p => p.PlayerContract == null || (_editingContract != null && p.id == _editingContract.playerid))
                .OrderBy(p => p.lastname)
                .ThenBy(p => p.firstname)
                .ToList();

            MessageBox.Show($"Znaleziono {players.Count} graczy bez kontraktu.");

            playerComboBox.DataSource = players;
            playerComboBox.DisplayMember = "firstname";
            playerComboBox.ValueMember = "id";
            playerComboBox.SelectedIndex = -1;

            if (preselectPlayerId.HasValue)
                playerComboBox.SelectedValue = preselectPlayerId.Value;
            else
                playerComboBox.SelectedIndex = -1;
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (playerComboBox.SelectedValue is not int selectedPlayerId)
                {
                    MessageBox.Show("Wybierz gracza.");
                    return;
                }

                DateTime startDate = DateTime.SpecifyKind(startDatePicker.Value, DateTimeKind.Utc);
                DateTime? endDate = endDatePicker.Checked
                    ? DateTime.SpecifyKind(endDatePicker.Value, DateTimeKind.Utc)
                    : null;


                if (!decimal.TryParse(salaryBox.Text.Trim(), out decimal salary))
                {
                    MessageBox.Show("Wprowadź poprawną pensję.");
                    return;
                }

                if (_editingContract == null)
                {
                    var player = _context.Players.Find(selectedPlayerId);
                    if (player == null)
                    {
                        MessageBox.Show("Nie znaleziono gracza.");
                        return;
                    }

                    var contract = new PlayerContract
                    {
                        playerid = selectedPlayerId,
                        Player = player,
                        startdate = startDate,
                        enddate = endDate,
                        salary = salary
                    };

                    _context.PlayerContracts.Add(contract);
                }
                else
                {
                    _editingContract.startdate = startDate;
                    _editingContract.enddate = endDate;
                    _editingContract.salary = salary;
                }

                _context.SaveChanges();
                MessageBox.Show(_editingContract == null ? "Kontrakt został dodany." : "Kontrakt został zaktualizowany.");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                var msg = new StringBuilder("Błąd zapisu kontraktu:\n");
                while (ex != null)
                {
                    msg.AppendLine(ex.Message);
                    ex = ex.InnerException;
                }
                MessageBox.Show(msg.ToString());
            }
        }
    }
}
