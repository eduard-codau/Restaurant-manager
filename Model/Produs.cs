using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Enumerație relevantă pentru unitatea de masură a fiecărui produs
    /// </summary>
    public enum Masura
    {
        Gram,
        Kilogram,
        Litru,
        Bucata,
        None
    }

    /// <summary>
    /// Clasa încapsulează informații despre produs
    /// </summary>
    public class Produs
    {
        /// <summary>
        /// Numele produsui
        /// </summary>
        public string NumeProdus { get; }

        /// <summary>
        /// Prețul produsului
        /// </summary>
        public double PretProdus { get; }

        /// <summary>
        /// Gramajul produsului(cantitativ)
        /// </summary>
        public int Gramaj { get; }

        /// <summary>
        /// Numărul categoriei din care face parte produsul
        /// </summary>
        public int IdCategorie { get; }

        /// <summary>
        /// Unitatea de măsură a produsului
        /// </summary>
        public Masura MasuraProdus { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numeProdus">Numele produsui</param>
        /// <param name="pretProdus">Prețul produsului</param>
        /// <param name="gramaj">Gramajul produsului(cantitativ)</param>
        /// <param name="masura">Unitatea de măsură a produsului</param>
        /// <param name="idCategorie">Numărul categoriei din care face parte produsul</param>
        public Produs(string numeProdus, double pretProdus, int gramaj, Masura masura, int idCategorie)
        {
            this.NumeProdus = numeProdus;
            this.PretProdus = pretProdus;
            this.Gramaj = gramaj;
            this.MasuraProdus = masura;
            this.IdCategorie = idCategorie;
        }

        /// <summary>
        /// Metoda permite afișarea formatată a informațiilor produsului
        /// </summary>
        /// <returns>Șirul de caractere cu informația prezentată</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("", 150);
            sb.Append("Numar produs: " + this.NumeProdus.ToString());
            sb.Append("\r\nPret produs: " + this.PretProdus.ToString());
            sb.Append("\r\nGramaj: " + this.Gramaj.ToString());
            sb.Append("\r\nMasura produs: " + this.MasuraProdus.ToString());
            sb.Append("\r\nId categorie: " + this.IdCategorie.ToString() + "\r\n");

            return sb.ToString();
        }

    }
}
