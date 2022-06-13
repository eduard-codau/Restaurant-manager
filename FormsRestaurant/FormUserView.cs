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

namespace restaurantInterf
{
    /// <summary>
    /// Descrie principalele componente ale interfeței prezentate utilizatorului
    /// </summary>
    public partial class FormUserView : Form
    {
        /// <summary>
        /// Controllerul care face legătura utilizatorului cu modelul
        /// </summary>
        private UserController _controller;

        /// <summary>
        /// Constructorul clasei
        /// </summary>
        public FormUserView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructorul parametrizat al clasei, inițializează interfața și utilizatorul curent
        /// </summary>
        /// <param name="permission">Permisiunile utilizatorului</param>
        /// <param name="user">Numele utilizatorului curent</param>
        public FormUserView(String permission, String username)
        {
            InitializeComponent();


            if (permission == "User")
            {
                _controller = new UserController(username);
                tables1.SetUserController(_controller);

                buttonRestaurant.Show();
                tables1.Hide();
                userWelcome1.Show();
                userWelcome1.textBoxUser.Text = username.Split('.')[0];

            }
        }
        
        /// <summary>
        /// Afișează meniul de vizualizare al meselor din restaurant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRestaurant_Click(object sender, EventArgs e)
        {
            tables1.Show();
            userWelcome1.Hide();
        }

        /// <summary>
        /// Reprezintă punctul de ieșire din aplicația principală
        /// Face revenire la fereastra de autentificare
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            FormLoginView loginInt = new FormLoginView();
            loginInt.Show();
            this.Close();
        }

        /// <summary>
        /// Reprezinta punctul de ajutor din view-ul user
        /// Deschide un fisier help cu informatii care vin in ajutorul ospatarului
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "UserHelp.chm");
        }
    }
}
