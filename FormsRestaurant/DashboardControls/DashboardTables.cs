using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;

namespace restaurantInterf
{
    /// <summary>
    /// Descrie funcționalitățile interfeței ce permite utilizatorului să manevreze mesele din restaurant
    /// </summary>
    public partial class DashboardTables : UserControl
    {
        /// <summary>
        /// Controllerul care face legătura utilizatorului cu modelul
        /// </summary>
        private UserController _userController;

        /// <summary>
        /// Lista cu mese, necesară pentru identificarea fiecărei mese după poziția din listă
        /// </summary>
        private List<Panel> _tablesList = new List<Panel>();

        /// <summary>
        /// Listă ce conține datele fiecărei mese
        /// </summary>
        private List<Masa> mese = new List<Masa>();


        /// <summary>
        /// Inițializează interfața si lista meselor 
        /// </summary>
        public DashboardTables()
        {
            InitializeComponent();
            _userController = new UserController();

            panelTable6.DoubleClick += DoubleClickPanel;
            panelTable1.DoubleClick += DoubleClickPanel;
            panelTable2.DoubleClick += DoubleClickPanel;
            panelTable3.DoubleClick += DoubleClickPanel;
            panelTable4.DoubleClick += DoubleClickPanel;
            panelTable5.DoubleClick += DoubleClickPanel;
            panelTable7.DoubleClick += DoubleClickPanel;
            panelTable8.DoubleClick += DoubleClickPanel;

            _tablesList.Add(panelTable1);
            _tablesList.Add(panelTable2);
            _tablesList.Add(panelTable3);
            _tablesList.Add(panelTable4);
            _tablesList.Add(panelTable5);
            _tablesList.Add(panelTable6);
            _tablesList.Add(panelTable7);
            _tablesList.Add(panelTable8);

        }

        /// <summary>
        /// Setează controllerul
        /// </summary>
        /// <param name="userController">Controllerul care se setează</param>
        public void SetUserController(UserController userController)
        {
            this._userController = userController;
        }

        /// <summary>
        /// Actualizează datele afișate pe interfață
        /// </summary>
        public void RefreshControl()
        {
            mese = _userController.GetMese();
            int i = 0;
            foreach (Masa m in mese)
            {
                // colorarea fiecărei mese în funcție de gradul de ocupare al acesteia
                if (m.StatusMasa == StatusEnum.Ocupat)
                {
                    _tablesList[i].BackColor = Color.Red;
                }
                else
                {
                    _tablesList[i].BackColor = Color.Green;
                }
                i++;
            }
        }

        /// <summary>
        /// Realizează încărcarea datelor pe interfață
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DashboardTables_Load(object sender, EventArgs e)
        {
            RefreshControl();
        }

        /// <summary>
        /// Afișează un nou formular al comenzilor mesei, la executarea unui eveniment de tip double click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoubleClickPanel(object sender, EventArgs e)
        {
            // extrage indicele mesei
            int nrMasa = Convert.ToInt32((sender as Panel).Name[10]) - 48;

            foreach (Masa m in mese)
            {
                if (m.NumarMasa == nrMasa)
                {
                    // se verifica gradul de acces al unui ospatar la o masa
                    if (mese[nrMasa - 1].StatusMasa != StatusEnum.Liber)
                    {
                        Comanda c = _userController.GetComanda(nrMasa);

                        // dacă există deja o comandă pe masa respectivă, se incarcă toate produsele din model 
                        // corespunzătoare comenzii
                        if (c != null)
                        {
                            Ospatar o = _userController.GetOspatar(c.NumarOspatar);
                            //MessageBox.Show(o.Username);
                            //MessageBox.Show(_userController.GetUsername());
                            if (o.Username.Equals(_userController.GetUsername()))
                            {
                                FormOrder of1 = new FormOrder(nrMasa, this._userController, this);
                                of1.Show();
                            }
                            else
                            {
                                MessageBox.Show("Nu aveti acces la aceasta masa");
                            }
                        }
                    }
                    else
                    {
                        // se realizează vizualizarea unui formular nou de comandă
                        FormOrder of1 = new FormOrder(nrMasa, this._userController, this);
                        of1.Show();
                    }
                }
            }
        }
    }
}
