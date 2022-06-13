using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.Text.RegularExpressions;

namespace restaurantInterf.DashboardControls
{
    /// <summary>
    /// Descrie funcționalitățile interfeței care permite adminului să adauge si să șteargă utilizatori 
    /// </summary>
    public partial class DashboardUsersOperations : UserControl
    {
        /// <summary>
        /// Controllerul care face legătura adminului cu modelul
        /// </summary>
        private AdminController _adminController;

        /// <summary>
        /// Lista cu toți ospătarii, folosită pentru a afla numărul ospătarului 
        /// </summary>
        private List<Ospatar> _ospatari;

        /// <summary>
        /// Constructorul clasei, inițializează interfața si controllerul
        /// </summary>
        public DashboardUsersOperations()
        {
            InitializeComponent();
            _adminController = new AdminController();
        }


        /// <summary>
        /// Setează controllerul
        /// </summary>
        /// <param name="adminController">Controllerul care se setează</param>
        public void SetController(AdminController adminController)
        {
            _adminController = adminController;
        }

        /// <summary>
        /// Metoda apelata la încărcarea interfeței
        /// Adaugă datele utilizaotrilor din model in dataGridViewUsers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UsersOperations_Load(object sender, EventArgs e)
        {
            _ospatari = _adminController.GetOspatar();

            dataGridViewUsers.Rows.Clear();
            foreach(Ospatar o in _ospatari)
            {
                string[] row = new string[4];
                row[0] = o.Nume;
                row[1] = o.Telefon;
                row[2] = o.Username;
                dataGridViewUsers.Rows.Add(row);
            }
        }

        /// <summary>
        /// La apăsarea unei celule din tabel, datele din casete se autocompleteaza cu datele din tabel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxName.Text = dataGridViewUsers.SelectedRows[0].Cells[0].Value.ToString();
            textBoxPhoneNumber.Text = dataGridViewUsers.SelectedRows[0].Cells[1].Value.ToString();
            textBoxUsername.Text = dataGridViewUsers.SelectedRows[0].Cells[2].Value.ToString();
        }

        /// <summary>
        /// Actualizează datele afișate pe interfață
        /// </summary>
        private void RefreshControl()
        {
            _ospatari = _adminController.GetOspatar();

            dataGridViewUsers.Rows.Clear();
            foreach (Ospatar o in _ospatari)
            {
                string[] row = new string[4];
                row[0] = o.Nume;
                row[1] = o.Telefon;
                row[2] = o.Username;
                dataGridViewUsers.Rows.Add(row);
            }
        }

        /// <summary>
        /// La apăsarea butonului Adaugă, validează si introduce un nou utilizator în model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            // se preiau datele din formulare
            string nume = textBoxName.Text;
            string numarTelefon = textBoxPhoneNumber.Text;
            string username = textBoxUsername.Text;
            string password = textBoxUserPassword.Text;

            // validare nume
            string namePattern = @"^([a-zA-Z]*)\s*([a-zA-Z ]*)$";
            Regex nameRgx = new Regex(namePattern);
            MatchCollection nameMatch = nameRgx.Matches(nume);
            if (nameMatch.Count < 1)
            {
                MessageBox.Show("Numele ospatarului introdus este invalid.");
                return;
            }

            // validare numar de telefon
            string telefonPattern = @"^[0-9]{9,12}$";
            Regex telefonRgx = new Regex(telefonPattern);
            MatchCollection telefonMatch = telefonRgx.Matches(numarTelefon);
            if (telefonMatch.Count < 1)
            {
                MessageBox.Show("Numarul de telefon invalid sau nu corespunde unui format standard.");
                return;
            }

            // validare usernume
            string usernamePattern = @"^([^0-9]*)([a-zA-Z]*)*([\w._])$";
            Regex usernameRgx = new Regex(usernamePattern);
            MatchCollection usernameMatch = usernameRgx.Matches(username);
            if (usernameMatch.Count < 1)
            {
                MessageBox.Show("Numele utilizator este invalid.");
                return;
            }

            // se adauga in Login informatiile de logare
            if (_adminController.AddLogin(new Login(username, password, DateTime.Now, 0)))
            {
                // se adauga in Ospatar datele
                if (_adminController.AddOspatar(new Ospatar(_adminController.GetMaxNumberOfNrOspatar() + 1, nume, numarTelefon, username)))
                {
                    MessageBox.Show("Utilizator adaugat cu succes");
                    RefreshControl();
                }
            }
        }

        /// <summary>
        /// La apăsarea butonului Sterge, se preia numărul ospatarului si username-ul acestuia
        /// și pe baza lor se șterg intrările corespunzătoare din model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count < 1)
            {
                MessageBox.Show("Nu ati selectat niciun utilizator de sters.");
                return;
            }
            string nume = dataGridViewUsers.SelectedRows[0].Cells[0].Value.ToString();
            string username = dataGridViewUsers.SelectedRows[0].Cells[2].Value.ToString();

            // pe baza username-ului din lista, se afla numarul acestuia
            int numarOspatar = 0;

            foreach(Ospatar o in _ospatari)
            {
                if(o.Username == username)
                {
                    numarOspatar = o.NumarOspatar;
                }
            }

            // se executa stergerea din tabela Ospatar
            if(_adminController.RemoveOspatar(numarOspatar))
            {
                // daca a avut loc stergerea cu succes, se sterge din tabela Login intrarea cu username-ul corespunzator
                if(_adminController.RemoveLogin(username))
                {
                    MessageBox.Show("Ați șters utilizatorul cu succes!");
                    RefreshControl();
                }
            }


        }
    }
}
