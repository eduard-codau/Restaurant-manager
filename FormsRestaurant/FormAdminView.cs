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
    /// Descrie principalele componente ale interfeței prezentate adminului 
    /// </summary>
    public partial class FormAdminView : Form
    {
        /// <summary>
        /// Controllerul care face legătura adminului cu modelul
        /// </summary>
        private AdminController _adminController;

        /// <summary>
        /// Constructorul clasei
        /// </summary>
        public FormAdminView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructorul parametrizat al clasei, inițializează interfața și utilizatorul curent
        /// </summary>
        /// <param name="permission">Permisiunile utilizatorului</param>
        /// <param name="user">Numele utilizatorului curent</param>
        public FormAdminView(String permission, String user)
        {
            InitializeComponent();

            if (user == "Admin")
            {
                _adminController = new AdminController(user);
                
                // setare controler pentru controalele copil
                categoryOperations1.SetController(_adminController);
                addItem1.SetController(_adminController);
                updateItem1.SetController(_adminController);
                removeItem1.SetController(_adminController);
                usersOperations1.SetController(_adminController);

                // afisare butoane
                buttonCategoryManager.Show();
                buttonAddItem.Show();
                buttonUpdateItem.Show();
                buttonDeleteItem.Show();
                buttonUsersManager.Show();
                
                // afisare interfetei de primire
                userWelcome1.Show();
                categoryOperations1.Hide();
                addItem1.Hide();
                updateItem1.Hide();
                removeItem1.Hide();
                usersOperations1.Hide();

            }
        }

        /// <summary>
        /// Afișează meniul de adăugare al unui produs în model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddItemMenu_Click(object sender, EventArgs e)
        {
            addItem1.Show();

            userWelcome1.Hide();
            categoryOperations1.Hide();
            updateItem1.Hide();
            removeItem1.Hide();
            usersOperations1.Hide();

        }

        /// <summary>
        /// Afișează meniul de modificare al unei categorii
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModifyCategory_Click(object sender, EventArgs e)
        {
            categoryOperations1.Show();

            userWelcome1.Hide();
            addItem1.Hide();
            updateItem1.Hide();
            removeItem1.Hide();
            usersOperations1.Hide();
        }

        /// <summary>
        /// Afișează meniul de actualizare al unui produs din model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdateItem_Click(object sender, EventArgs e)
        {
            updateItem1.Show();

            userWelcome1.Hide();
            categoryOperations1.Hide();
            addItem1.Hide();
            removeItem1.Hide();
            usersOperations1.Hide();

        }

        /// <summary>
        /// Afișează meniul de ștergere al unui produs din model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            removeItem1.Show();

            userWelcome1.Hide();
            categoryOperations1.Hide();
            addItem1.Hide();
            updateItem1.Hide();
            usersOperations1.Hide();

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
        /// Afișează meniul de adăugare si ștergere al utilizatorilor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUsersManager_Click(object sender, EventArgs e)
        {
            usersOperations1.Show();

            userWelcome1.Hide();
            categoryOperations1.Hide();
            addItem1.Hide();
            updateItem1.Hide();
            removeItem1.Hide();
        }
        /// <summary>
        /// Reprezinta punctul de ajutor din view-ul admin
        /// Deschide un fisier help cu informatii care vin in ajutorul managerului
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AdminHelp.chm");
        }
    }
}
