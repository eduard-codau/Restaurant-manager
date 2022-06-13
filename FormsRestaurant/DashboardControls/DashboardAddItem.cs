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
using Controller;
using System.Text.RegularExpressions;

namespace restaurantInterf.DashboardControls
{
    /// <summary>
    /// Descrie dashboard-ul care permite adminului adaugarea unui nou produs
    /// </summary>
    public partial class DashboardAddItem : UserControl
    {
        /// <summary>
        /// Controllerul care face legatura adminului cu datele
        /// </summary>
        private AdminController _adminController;

        /// <summary>
        /// Meniul produsului care va fi adaugat
        /// </summary>
        private Meniu _categorie;

        /// <summary>
        /// Lista cu toate meniurile, folosita pentru a afla numărul meniului
        /// </summary>
        private List<Meniu> _meniu;

        /// <summary>
        /// Măsura produsului selectat
        /// </summary>
        private Masura _masura;

        /// <summary>
        /// Constructorul clasei, inițializează interfața si controllerul
        /// </summary>
        public DashboardAddItem()
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
        /// Funcția se apelează la incărcarea interfeței
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddItem_Load(object sender, EventArgs e)
        {
            // se completează câmpurile de tip combobox cu valori din model 
            _meniu = _adminController.GetMeniu();
            comboBoxCategory.Items.Clear();

            foreach(Meniu m in _meniu)
            {
                comboBoxCategory.Items.Add(m.Categorie);
            }

            comboBoxMasura.Items.Clear();

            // se transformă in string valorile de tip Enum
            foreach(string masura in Enum.GetNames(typeof(Masura)))
            {
                comboBoxMasura.Items.Add(masura);
                _masura = (Masura)Enum.Parse(typeof(Masura), masura);
            }
        }

        /// <summary>
        /// Metoda permite reținerea categoriei selectate atunci cand comboboxul corespunzător își schimbă valoarea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedCategorie = comboBoxCategory.Text;
            foreach (Meniu m in _meniu)
            {
                if(m.Categorie == selectedCategorie)
                {
                    _categorie = m;
                }
            }
        }

        /// <summary>
        /// Metoda permite reținerea măsurii selectate atunci când comboboxul corespunzător își schimbă valoarea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxMasura_SelectedValueChanged(object sender, EventArgs e)
        {
            _masura = (Masura)Enum.Parse(typeof(Masura), comboBoxMasura.Text);
        }

        /// <summary>
        /// Metoda apelată atunci cand se apasă butonul AddItem
        /// Preia datele de la interfață, le validează, si prin intermediul controllerului le adauga în baza de date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            if(comboBoxCategory.Text == "" || comboBoxMasura.Text == "" || textBoxItemName.Text == "" || textBoxItemPrice.Text == "" || textBoxGramaj.Text == "")
            {
                MessageBox.Show("Nu ati completat toate datele necesare.");
            }
            else
            {
                // validare pret
                string pricePattern = @"^\d{0,15}$";
                Regex priceRgx = new Regex(pricePattern);
                MatchCollection priceMatch = priceRgx.Matches(textBoxItemPrice.Text);
                if (priceMatch.Count < 1)
                {
                    MessageBox.Show("Pretul introdus este invalid.");
                    return;
                }

                // validare nume
                string namePattern = @"^([a-zA-Z]{0,25}[\W]?){1,3}$";
                Regex nameRgx = new Regex(namePattern);
                MatchCollection nameMatch = nameRgx.Matches(textBoxItemName.Text);
                
                if (nameMatch.Count < 1)
                {
                    MessageBox.Show("Numele introdus este invalid.");
                    return;
                }

                // validare gramaj
                string gramajPattern = @"^\d{0,15}$";
                Regex gramajRgx = new Regex(gramajPattern);
                MatchCollection gramajMatch = gramajRgx.Matches(textBoxGramaj.Text);
                if (gramajMatch.Count < 1)
                {
                    MessageBox.Show("Gramajul introdus este invalid.");
                    return;
                }

                if (_adminController.AddProdus(new Produs(textBoxItemName.Text, Convert.ToDouble(textBoxItemPrice.Text), Convert.ToInt32(textBoxGramaj.Text),_masura,_categorie.IdCategorie)))
                {
                    MessageBox.Show("Produs adaugat cu succes!");
                    // se actualizează valorile dispuse pe celelalte formulare
                    (this.Parent as FormAdminView).updateItem1.RefreshControl();
                    (this.Parent as FormAdminView).removeItem1.RefreshControl();
                    textBoxGramaj.Text = "";
                    textBoxItemName.Text = "";
                    textBoxItemPrice.Text = "";
                    comboBoxCategory.SelectedValue = "";
                    comboBoxMasura.SelectedValue = "";
                }
            }

        }
    }
}
