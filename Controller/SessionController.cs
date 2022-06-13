using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace Controller 
{
    /// <summary>
    /// Descrie operațiile care fac posibilă identificarea utilizatorului și accesarea 
    /// principalelor interfețe din aplicație
    /// </summary>
    public class SessionController : Controller
    {
        #region Private Member Variables
        /// <summary>
        /// Utilizatorul care se va transmite mai departe view-ului accesat după logare
        /// </summary>
        private string _username;

        #endregion

        #region Constructor

        /// <summary>
        /// Reține numele utilizatorului, in scopul procesărilor viitoare
        /// </summary>
        /// <param name="username">Numele utilizatorului</param>
        public SessionController(string username)
        {
            _username = username;
        }
        #endregion

        #region OperatiiUser
        /// <summary>
        /// Obținerea numelui utilizatorului
        /// </summary>
        /// <returns>Numele utilizatorului</returns>
        public string getUsername()
        {
            return _username;
        }

        /// <summary>
        /// Verifică dacă datele de autentificare furnizate de utilizator se regăsesc in lista de utilizatori
        /// </summary>
        /// <param name="username">Nume utilizator</param>
        /// <param name="password">Parolă</param>
        /// <param name="isAdmin">Variablă de tip flag care indică prezența unui administrator</param>
        /// <returns></returns>
        public bool GetUser(String username, String password, out bool isAdmin)
        {
            return RestaurantDAO.GetInstance().GetUser(username, password, out isAdmin);
        }
        #endregion
    }
}