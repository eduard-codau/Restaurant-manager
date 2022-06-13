using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurantInterf.DashboardControls
{
    /// <summary>
    /// Descrie funcționalitățile dashboardului care permite adminului să manevreze categoriile din meniu
    /// </summary>
    public partial class DashboardCategoryOperations : UserControl
    {
        /// <summary>
        /// Controllerul care face legatura adminului cu datele
        /// </summary>
        private AdminController _adminController;

        /// <summary>
        /// Lista cu toate meniurile, folosita pentru a afla numărul meniului
        /// </summary>
        private List<Meniu> _meniu;

        /// <summary>
        /// Constructorul clasei, inițializează interfața si controllerul
        /// </summary>
        public DashboardCategoryOperations()
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
        /// Metoda permite refacerea valorilor de pe interfață odată ce a avut loc o schimbare in model
        /// </summary>
        public void RefreshControl()
        {
            List<Meniu> meniu = _adminController.GetMeniu();
            _meniu = meniu;
            if (_meniu != null)
            {
                dataGridViewCategories.Rows.Clear();
                foreach (Meniu m in _meniu)
                {
                    dataGridViewCategories.Rows.Add(m.Categorie);
                }
            }

        }

        /// <summary>
        /// Metoda apelată la incărcarea interfetei
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryOperations_Load(object sender, EventArgs e)
        {
            RefreshControl();
        }

        /// <summary>
        /// Metoda permite realizarea unei căutări pe baza valorii curente din textBoxSearchCategory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSearchCategory_TextChanged(object sender, EventArgs e)
        {
            dataGridViewCategories.Rows.Clear();
            foreach(Meniu m in _meniu)
            {
                if(m.Categorie.ToLower().Contains(textBoxSearchCategory.Text.ToLower()))
                {
                    dataGridViewCategories.Rows.Add(m.Categorie);
                }
            }
        }

        /// <summary>
        /// Permite declanșarea unui eveniment care să valideze și să actualizeze datele legate de un Meniu în model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdateCategory_Click(object sender, EventArgs e)
        {
            // verificăm daca s-a introdus un nume de actualizat
            if(textBoxAddCategoryName.Text != "")
            {
                string numeNewCategorie = textBoxAddCategoryName.Text;

                // verificăm dacă a fost selectată o categorie de actualizat
                if(dataGridViewCategories.SelectedCells.Count < 1)
                {
                    MessageBox.Show("Nu ați selectat nicio categorie de actualizat");
                }

                string numeSelectedCategorie = dataGridViewCategories.SelectedCells[0].Value.ToString();
                int idCategorie = 0;

                // verificam daca numele categoriei exista deja in model
                foreach (Meniu m in _meniu)
                {
                    if(m.Categorie == numeNewCategorie)
                    {
                        MessageBox.Show("Acest nume există deja.");
                        return;
                    }

                    if(m.Categorie == numeSelectedCategorie)
                    {
                        idCategorie = m.IdCategorie;
                    }
                }

                if (_adminController.UpdateMeniu(new Meniu(idCategorie, numeNewCategorie)))
                {
                    MessageBox.Show("Ați actualizat cu succes!");
                    RefreshControl();
                }
            }
            else
            {
                MessageBox.Show("Nu ați introdus numele noii categorii.");
            }
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            if (textBoxAddCategoryName.Text != "")
            {
                // verificam daca numele categoriei exista deja in db
                string numeNewCategorie = textBoxAddCategoryName.Text;

                //string numeSelectedCategorie = dataGridViewCategories.SelectedCells[0].Value.ToString();
                //int idCategorie = 0;

                foreach (Meniu m in _meniu)
                {
                    if (m.Categorie == numeNewCategorie)
                    {
                        MessageBox.Show("Acest nume exista deja");
                        return;
                    }
                }

                // trebuie obșinută categoria cu cel mai mare id
                int idCategorie = _adminController.GetMaxNumberOfIdCategorie();

                if (_adminController.AddMeniu(new Meniu(idCategorie+1, numeNewCategorie)))
                {
                    MessageBox.Show("Ați adaugat cu succes");
                    RefreshControl();
                }
            }
            else
            {
                MessageBox.Show("Nu ati introdus numele noii categorii");
            }
        }

        /// <summary>
        /// Evenimentul care se declașează la apăsarea butonului de ștergere
        /// Șterge o categorie selectată din dataGridViewCategories
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategories.SelectedCells.Count < 1)
            {
                MessageBox.Show("Nu ați selectat nicio categorie de șters.");
            }

            string numeSelectedCategorie = dataGridViewCategories.SelectedCells[0].Value.ToString();
            int idCategorie = 0;

        
            foreach (Meniu m in _meniu)
            {
                if (m.Categorie == numeSelectedCategorie)
                {
                    idCategorie = m.IdCategorie;
                }
            }

            if (_adminController.RemoveMeniu(new Meniu(idCategorie, numeSelectedCategorie)))
            {
                MessageBox.Show("Ați șters cu succes!");
                RefreshControl();
            }
        }
    }
}
