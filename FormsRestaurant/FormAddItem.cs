using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;

namespace restaurantInterf
{
    /// <summary>
    /// Descrie interfața de adăugare a unui produs la o comandă
    /// </summary>
    public partial class FormAddItem : Form
    {
        /// <summary>
        /// Reține formularul precedent, in scopul actualizării datelor afișate
        /// la adăugarea produsului
        /// </summary>
        private FormOrder _orderForm;

        /// <summary>
        /// Controllerul care face legătura utilizatorului cu modelul
        /// </summary>
        private UserController _userController;

        /// <summary>
        /// Lista cu toate produsele, folosita pentru a afla numărul produsului de actualizat
        /// </summary>
        private List<Produs> _produse;

        /// <summary>
        /// Numărul categoriei din care va face parte produsul adăugat
        /// </summary>
        private int _idCategorie;

        /// <summary>
        /// Numele categoriei din care va face parte produsul adăugat
        /// </summary>
        private string _numeCategorie;

        /// <summary>
        /// Comanda din care va face parte produsul adăugat
        /// </summary>
        private Comanda _comanda;

        /// <summary>
        /// Constructorul clasei 
        /// </summary>
        public FormAddItem()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructorul parametrizat, inițializează interfața, comanda din care va face parte produsul
        /// și formularul de comanda în care se regăsesc datele
        /// </summary>
        /// <param name="userController">Controllerul care permite utilizatorului sa faca operatii</param>
        /// <param name="comanda">Comanda mesei curente</param>
        /// <param name="orderForm">Formularul de comanda al mesei curente</param>
        public FormAddItem(UserController userController,Comanda comanda, FormOrder orderForm)
        {
            InitializeComponent();
            _comanda = comanda;
            _orderForm = orderForm;
            _userController = userController;
        }

        /// <summary>
        /// Butonul prin intermediul caruia se iese din formularul de adaugare produs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExitItemList_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metoda apelata la încărcarea interfeței
        /// Adaugă toate categoriile in combobox-ul categoriei
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddItemForm_Load(object sender, EventArgs e)
        {
            List<Meniu> meniu = _userController.GetMeniu();
            comboBoxCategory.Items.Clear();
            foreach(Meniu m in meniu)
            {
                comboBoxCategory.Items.Add(m.Categorie.ToString());
            }
        }

        /// <summary>
        /// Metoda permite realizarea unei căutări pe baza valorii curente din textBoxSearchItemSearch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxItemSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = textBoxItemSearch.Text.ToLower();
            listBoxItems.Items.Clear();

            foreach (Produs p in _produse)
            {
                if(p.NumeProdus.ToLower().Contains(searchQuery))
                {
                    listBoxItems.Items.Add(p.NumeProdus);
                }
            }

        }

        /// <summary>
        /// Metoda permite afișarea produselor din aceeași categorie, în funcție de categoria 
        /// selectată din combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            // se salveaza intr-o lista produsele din categoriile respective
            _numeCategorie = comboBoxCategory.SelectedItem.ToString();
            _idCategorie = _userController.GetIdCategorie(_numeCategorie);

            _produse = new List<Produs>();

            var produse = _userController.GetProduseByCategorie(_idCategorie);
  
            listBoxItems.Items.Clear();

            foreach(Produs p in produse)
            {
                _produse.Add(p);
                listBoxItems.Items.Add(p.NumeProdus);
            }

        }

        /// <summary>
        /// Apasarea butonului Add declașează adăugarea unui nou produs in comanda curentă
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddItemToList_Click(object sender, EventArgs e)
        {
            if(listBoxItems.SelectedIndex < 0)
            {
                MessageBox.Show("Nu ați selectat niciun produs");
            }
            else
            {
                string numeProdus = listBoxItems.SelectedItem.ToString();

                Produs selectedProdus = null;

                foreach(Produs p in _produse)
                {
                    if(p.NumeProdus == numeProdus)
                    {
                        selectedProdus = p;
                        break;
                    }
                }

                // actualizarea comenzii cu noile date
                Dictionary<string, int> detaliiComanda = new Dictionary<string, int>();
                detaliiComanda.Add(selectedProdus.NumeProdus, Convert.ToInt32(numericUpDownItemQuantity.Value));
                Comanda newComanda = new Comanda(_comanda.NumarComanda, _comanda.DataComenzii, _comanda.NumarOspatar, _comanda.NumarMasa, detaliiComanda);

                _userController.UpdateComanda(newComanda);
                _orderForm.RefreshControl();
                this.Close();

            }

        }
    }
}
