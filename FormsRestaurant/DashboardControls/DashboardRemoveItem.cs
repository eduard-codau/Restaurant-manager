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

namespace restaurantInterf.DashboardControls
{
    /// <summary>
    /// Descrie funcționalitățile dashboardului care permite adminului sa șteargă produse din model
    /// </summary>
    public partial class DashboardRemoveItem : UserControl
    {
        /// <summary>
        /// Controllerul care face legatura adminului cu datele
        /// </summary>
        private AdminController _adminController;

        /// <summary>
        /// Lista cu toate men produsele, folosita pentru a afla numărul produsului de șters
        /// </summary>
        private List<Produs> _produse;

        /// <summary>
        /// Lista cu toate meniurile, folosită pentru a afla numărul meniului
        /// </summary>
        private List<Meniu> _meniu;

        /// <summary>
        /// Setează controllerul
        /// </summary>
        /// <param name="adminController">Controllerul care se setează</param>
        public void SetController(AdminController adminController)
        {
            _adminController = adminController;
        }

        /// <summary>
        /// Constructorul clasei, inițializează interfața si controllerul
        /// </summary>
        public DashboardRemoveItem()
        {
            InitializeComponent();
            _adminController = new AdminController();
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
        /// Adaugă toate produsele din model in dataGridViewRemoveItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItem_Load(object sender, EventArgs e)
        {
            _produse = _adminController.GetProdus();
            _meniu = _adminController.GetMeniu();

            dataGridViewRemoveItem.Rows.Clear();

            foreach (Produs p in _produse)
            {
                string[] row = new string[5];
                row[0] = SearchCategoryName(p, _meniu);
                row[1] = p.NumeProdus;
                row[2] = p.PretProdus.ToString();
                row[3] = p.MasuraProdus.ToString();
                row[4] = p.Gramaj.ToString();
                dataGridViewRemoveItem.Rows.Add(row);
            }
        }

        /// <summary>
        /// Actualizează datele afișate pe interfață
        /// </summary>
        public void RefreshControl()
        {
            _produse = _adminController.GetProdus();

            dataGridViewRemoveItem.Rows.Clear();

            foreach (Produs p in _produse)
            {
                string[] row = new string[5];
                row[0] = SearchCategoryName(p, _meniu);
                row[1] = p.NumeProdus;
                row[2] = p.PretProdus.ToString();
                row[3] = p.MasuraProdus.ToString();
                row[4] = p.Gramaj.ToString();
                dataGridViewRemoveItem.Rows.Add(row);
            }
        }

        /// <summary>
        /// Metoda permite realizarea unei căutări pe baza valorii curente din textBoxSearchUpdateItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSearchUpdateItem_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Realizează ștergerea la apăsarea butonului Delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
           if( _adminController.RemoveProdus(dataGridViewRemoveItem.SelectedRows[0].Cells[1].Value.ToString()))
            {
                MessageBox.Show("Ati sters produsul cu succes!");
                RefreshControl();
            }
        }

        /// <summary>
        /// Metoda permite realizarea unei căutări pe baza valorii curente din textBoxSearchUpdateItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSearchRemoveItem_TextChanged(object sender, EventArgs e)
        {
            dataGridViewRemoveItem.Rows.Clear();

            foreach (Produs p in _produse)
            {
                if (p.NumeProdus.ToLower().Contains(textBoxSearchRemoveItem.Text.ToLower()) || SearchCategoryName(p, _meniu).Contains(textBoxSearchRemoveItem.Text.ToLower()))
                {
                    string[] row = new string[5];
                    row[0] = SearchCategoryName(p, _meniu);
                    row[1] = p.NumeProdus;
                    row[2] = p.PretProdus.ToString();
                    row[3] = p.MasuraProdus.ToString();
                    row[4] = p.Gramaj.ToString();
                    dataGridViewRemoveItem.Rows.Add(row);
                }

            }
        }
    }
}
