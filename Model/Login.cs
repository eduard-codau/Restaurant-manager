using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Clasa încapsulează informații despre utilizatorul aplicației
    /// </summary>
    public class Login
    {
        /// <summary>
        /// Numele utilizator
        /// </summary>
        public string Username { get; }

        /// <summary>
        /// Parola
        /// </summary>
        public string Parola { get; }

        /// <summary>
        /// Data ultimei intrări in aplicație
        /// </summary>
        public DateTime LastLogin { get; }

        /// <summary>
        /// Indicator al drepturilor de administrator
        /// </summary>
        public int IsAdmin { get; }

        /// <summary>
        /// Inițializarea datelor despre utilizator
        /// </summary>
        /// <param name="username">Numele utilizator</param>
        /// <param name="parola">Parola</param>
        /// <param name="lastLogin">Data ultimei logări</param>
        /// <param name="isAdmin">Drepturile de administrator</param>
        public Login(string username, string parola, DateTime lastLogin, int isAdmin)
        {
            this.Username = username;
            this.Parola = parola;
            this.LastLogin = lastLogin;
            this.IsAdmin = isAdmin;
        }

        /// <summary>
        /// Metoda permite afișarea formatată a informațiilor utilizatorului
        /// </summary>
        /// <returns>Șirul de caractere cu informația prezentată</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("", 150);
            sb.Append("Username: " + this.Username.ToString());
            sb.Append("\r\nParola: " + this.Parola.ToString());
            sb.Append("\r\nUltima logare: " + this.LastLogin.ToString());
            sb.Append("\r\nAdmin: " + this.IsAdmin.ToString() + "\r\n");
            return sb.ToString();
        }
    }
}
