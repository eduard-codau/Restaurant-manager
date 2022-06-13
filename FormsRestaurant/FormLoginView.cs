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

namespace restaurantInterf
{
    /// <summary>
    /// Descrie funcționalitatea interfeței de autentificare
    /// </summary>
    public partial class FormLoginView : Form
    {
        /// <summary>
        /// Controllerul care face posibilă autentificare utilizatorilor
        /// </summary>
        public SessionController _sessionController;

        /// <summary>
        /// Permisiunile utilizatorului autentificare
        /// </summary>
        public string permission = "";

        /// <summary>
        /// Inițializare interfață
        /// </summary>
        public FormLoginView()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Apăsarea butonului de Login efectuează validarea datelor și setarea permisiunilor 
        /// daca autentificarea a avut loc cu succes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // datele de autentificare
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            _sessionController = new SessionController(username);

            Boolean isAdmin = false;

            if (_sessionController.GetUser(username,password,out isAdmin))
            {
                if (isAdmin)
                {
                    permission = "Admin";
                    
                    Close();
                }
                else
                {
                    permission = "User";
                    
                    Close();
                }
            }
            else
            { 
                MessageBox.Show("Autentificare eșuată!");
                permission = "";  
            }

            textBoxUsername.Clear();
            textBoxPassword.Clear();
       
        }

        /// <summary>
        /// Executa ieșirea din aplicație, la apăsarea butonul Exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Reprezinta punctul de ajutor din fereastra login
        /// Deschide un fisier help cu informatii care vin in ajutorul utilizatorului care incearca sa se conecteze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "HelpLogin.chm");
        }
    }
}
