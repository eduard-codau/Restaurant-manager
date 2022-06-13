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
    /// Reprezintă un formular folosit pe post de coordonator între 
    /// formularul de autentificare si formularul de acces al aplicatiei
    /// </summary>
    public partial class FormPrincipal : Form
    {
        /// <summary>
        /// Formularul de autentificare
        /// </summary>
        public FormLoginView loginForm;

        /// <summary>
        /// Formularul de control al utilizatorului
        /// </summary>
        public FormUserView userDashboard;

        /// <summary>
        /// Formularul de control al administratorului
        /// </summary>
        public FormAdminView adminDashboard;

        /// <summary>
        /// Initializare intrefata si verificare autentificare
        /// </summary>
        public FormPrincipal()
        {
            InitializeComponent();
            
            CheckLogin();
        }

        /// <summary>
        /// Afiseaza formularul de autentificare si verifica datele prin prisma
        /// controllerului de sesiune
        /// </summary>
        public void CheckLogin()
        {
            loginForm = new FormLoginView();
            loginForm.ShowDialog();

            // aici se intra dupa ce formularul de autentificare a fost inchis
            if(loginForm.permission.Equals("User"))
            {
               
                userDashboard = new FormUserView("User",loginForm._sessionController.getUsername());
                userDashboard.ShowDialog();
                CheckLogin();

            }
            else if(loginForm.permission.Equals("Admin"))
            {
                adminDashboard = new FormAdminView("Admin", loginForm._sessionController.getUsername());
                adminDashboard.ShowDialog();
                CheckLogin();
            }   
        }
    }
}
