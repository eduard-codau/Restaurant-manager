using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Clasa încapsulează informații despre ospătar
    /// </summary>
    public class Ospatar
    {
        /// <summary>
        /// Numărul ospătarului
        /// </summary>
        public int NumarOspatar { get; }

        /// <summary>
        /// Numele ospătarului
        /// </summary>
        public string Nume { get; }

        /// <summary>
        /// Numărul de telefon al ospătarului
        /// </summary>
        public string Telefon { get; }

        /// <summary>
        /// Numele utilizator asociat ospătarului
        /// </summary>
        public string Username { get; }

        /// <summary>
        /// Inițializare informații despre ospătar
        /// </summary>
        /// <param name="numarOspatar">Numărul ospătarului</param>
        /// <param name="nume">Numele ospătarului</param>
        /// <param name="telefon">Numărul de telefon al ospătarului</param>
        /// <param name="username">Numele utilizator asociat ospătarului</param>
        public Ospatar(int numarOspatar, string nume, string telefon, string username)
        {
            this.NumarOspatar = numarOspatar;
            this.Nume = nume;
            this.Telefon = telefon;
            this.Username = username;
        }

        /// <summary>
        /// Metoda permite afișarea formatată a informațiilor ospătarului
        /// </summary>
        /// <returns>Șirul de caractere cu informația prezentată</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("", 150);
            sb.Append("Numar ospatar: " + this.NumarOspatar.ToString());
            sb.Append("\r\nNume: " + this.Nume.ToString());
            sb.Append("\r\nTelefon: " + this.Telefon.ToString());
            sb.Append("\r\nUsername: " + this.Username.ToString() + "\r\n");

            return sb.ToString();
        }
    }
}
