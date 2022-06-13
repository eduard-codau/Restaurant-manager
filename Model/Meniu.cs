using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Clasa incapsulează informații despre meniu
    /// </summary>
    public class Meniu
    {
        /// <summary>
        /// Numărul categoriei unui produl
        /// </summary>
        public int IdCategorie { get; }

        /// <summary>
        /// Numele categoriei unui produs
        /// </summary>
        public string Categorie { get; }

        /// <summary>
        /// Inițializare informații despre meniu
        /// </summary>
        /// <param name="idCategorie">Numărul categoriei</param>
        /// <param name="categorie">Numele categoriei</param>
        public Meniu(int idCategorie, string categorie)
        {
            this.IdCategorie = idCategorie;
            this.Categorie = categorie;
        }

        /// <summary>
        /// Metoda permite afișarea formatată a informațiilor meniului
        /// </summary>
        /// <returns>Șirul de caractere cu informația prezentată</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("", 150);
            sb.Append("Id categorie: " + this.IdCategorie.ToString());
            sb.Append("\r\nCategorie: " + this.Categorie.ToString() + "\r\n");


            return sb.ToString();
        }
    }
}
