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
    /// Descrie interfața care permite adminului sa actualizeze un produs din model
    /// </summary>
    public partial class DashboardUpdateItem : UserControl
    {
        /// <summary>
        /// Controllerul care face legătura adminului cu modelul
        /// </summary>
        private AdminController _adminController;

        /// <summary>
        /// Lista cu toate produsele, folosita pentru a afla numărul produsului de actualizat
        /// </summary>
        private List<Produs> _produse;

        /// <summary>
        /// Lista cu toate meniurile, folosită pentru a afla numărul meniului
        /// </summary>
        private List<Meniu> _meniu;

        /// <summary>
        /// Constructorul clasei, inițializează interfața si controllerul
        /// </summary>
        public DashboardUpdateItem()
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
        /// Obține numele categoriei unui produs, pe baza numărului acesteia
        /// </summary>
        /// <param name="produs">Produsul din care se obține numele categoriei</param>
        /// <param name="meniu">O listă cu toate categoriile din model</param>
        /// <returns>Numele categoriei de căutat</returns>
        private string SearchCategoryName(Produs produs, List<Meniu> meniu)
        {
            foreach (Meniu m in meniu)
            {
                if (produs.IdCategorie == m.IdCategorie)
                {
                    return m.Categorie;
                }
            }

            return "";
        }

        /// <summary>
        /// Metoda apelata la încărcarea interfeței
        /// Adaugă toate produsele din model in dataGridViewUpdateItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateItem_Load(object sender, EventArgs e)
        {
            _produse = _adminController.GetProdus();
            _meniu = _adminController.GetMeniu();

            dataGridViewUpdateItem.Rows.Clear();

            foreach (Produs p in _produse)
            {
                string[] row = new string[5];
                row[0] = SearchCategoryName(p, _meniu);
                row[1] = p.NumeProdus;
                row[2] = p.PretProdus.ToString();
                row[3] = p.MasuraProdus.ToString();
                row[4] = p.Gramaj.ToString();
                dataGridViewUpdateItem.Rows.Add(row);
            }

            // incarcare numele categoriilor
            comboBoxCategory.Items.Clear();
            foreach (Meniu m in _meniu)
            {
                comboBoxCategory.Items.Add(m.Categorie);
            }

            //incarcare numele masurilor
            comboBoxMasura.Items.Clear();
            foreach (string masura in Enum.GetNames(typeof(Masura)))
            {
                comboBoxMasura.Items.Add(masura);
            }

        }

        /// <summary>
        /// Metoda permite realizarea unei căutări pe baza valorii curente din textBoxSearchUpdateItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSearchUpdateItem_TextChanged(object sender, EventArgs e)
        {
            dataGridViewUpdateItem.Rows.Clear();

            foreach (Produs p in _produse)
            {
                if (p.NumeProdus.ToLower().Contains(textBoxSearchUpdateItem.Text.ToLower()) || SearchCategoryName(p, _meniu).ToLower().Contains(textBoxSearchUpdateItem.Text.ToLower()))
                {
                    string[] row = new string[5];
                    row[0] = SearchCategoryName(p, _meniu);
                    row[1] = p.NumeProdus;
                    row[2] = p.PretProdus.ToString();
                    row[3] = p.MasuraProdus.ToString();
                    row[4] = p.Gramaj.ToString();
                    dataGridViewUpdateItem.Rows.Add(row);
                }
            }
        }

        /// <summary>
        /// Actualizează datele afișate pe interfață
        /// </summary>
        public void RefreshControl()
        {
            _produse = _adminController.GetProdus();
            _meniu = _adminController.GetMeniu();

            dataGridViewUpdateItem.Rows.Clear();

            foreach (Produs p in _produse)
            {
                string[] row = new string[5];
                row[0] = SearchCategoryName(p, _meniu);
                row[1] = p.NumeProdus;
                row[2] = p.PretProdus.ToString();
                row[3] = p.MasuraProdus.ToString();
                row[4] = p.Gramaj.ToString();
                dataGridViewUpdateItem.Rows.Add(row);
            }
        }

        /// <summary>
        /// La apăsarea unei celule din tabel, datele din casete se autocompleteaza cu datele din tabel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewUpdateItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxCategory.SelectedItem = dataGridViewUpdateItem.SelectedRows[0].Cells[0].Value.ToString();
            comboBoxMasura.SelectedItem = dataGridViewUpdateItem.SelectedRows[0].Cells[3].Value.ToString();

            textBoxGramaj.Text = dataGridViewUpdateItem.SelectedRows[0].Cells[4].Value.ToString();
            textBoxItemPrice.Text = dataGridViewUpdateItem.SelectedRows[0].Cells[2].Value.ToString();
        }

        /// <summary>
        /// La apăsarea butonului, se valideaza si se actualizeaza datele din model  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdateItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewUpdateItem.SelectedRows.Count < 1)
            {
                MessageBox.Show("Nu ati selectat niciun produs de actualizat.");
                return;
            }

            if (comboBoxCategory.Text == "" || comboBoxMasura.Text == "" || textBoxGramaj.Text == "" || textBoxItemPrice.Text == "")
            {
                MessageBox.Show("Nu ati introdus toate informatiile necesare.");
                return;
            }

            // datele se preiau si se valideaza
            string categorie = comboBoxCategory.Text;
            Masura masura = (Masura)Enum.Parse(typeof(Masura), comboBoxMasura.Text);

            // validare pret
            string pricePattern = @"^\d{0,15}$";
            Regex priceRgx = new Regex(pricePattern);
            MatchCollection priceMatch = priceRgx.Matches(textBoxItemPrice.Text);
            if (priceMatch.Count < 1)
            {
                MessageBox.Show("Pretul introdus este invalid.");
                return;
            }

            double pret = Convert.ToDouble(textBoxItemPrice.Text);

            // validare gramaj
            string gramajPattern = @"^\d{0,15}$";
            Regex gramajRgx = new Regex(gramajPattern);
            MatchCollection gramajMatch = gramajRgx.Matches(textBoxGramaj.Text);
            if (gramajMatch.Count < 1)
            {
                MessageBox.Show("Gramajul introdus este invalid.");
                return;
            }

            int gramaj = Convert.ToInt32(textBoxGramaj.Text);


            int idCategorie = 0;

            foreach (Meniu m in _meniu)
            {
                if (m.Categorie == categorie)
                {
                    idCategorie = m.IdCategorie;
                }
            }

            if (_adminController.UpdateProdus(new Produs(dataGridViewUpdateItem.SelectedRows[0].Cells[1].Value.ToString(), pret, gramaj, masura, idCategorie)))
            {
                MessageBox.Show("Ati actualizat cu succes!");
                RefreshControl();
            }

        }
    }
}
