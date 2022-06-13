using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   /// <summary>
   /// Enumerație relevantă pentru descrierea gradului de ocupare al unei mese
   /// </summary>
   public enum StatusEnum
    {
        Liber,
        Ocupat
    }

    /// <summary>
    /// Clasa încapsulează informațiile unei mese  
    /// </summary>
    public class Masa
    {
        /// <summary>
        /// Număr masă
        /// </summary>
        public int NumarMasa { get; }

        /// <summary>
        /// Numărul de locuri al mesei
        /// </summary>
        public int NumarLocuri { get; }

        /// <summary>
        /// Gradul de ocupare al mesei
        /// </summary>
        public StatusEnum StatusMasa { get; }

        /// <summary>
        /// Inițializare informații despre masă
        /// </summary>
        /// <param name="numarMasa">Numărul mesei</param>
        /// <param name="numarLocuri">Numărul de locuri</param>
        /// <param name="statusMasa">Gradul de ocupare al mesei</param>
        public Masa(int numarMasa, int numarLocuri, StatusEnum statusMasa)
        {
            this.NumarMasa = numarMasa;
            this.NumarLocuri = numarLocuri;
            this.StatusMasa = statusMasa;
        }

        /// <summary>
        /// Metoda permite afișarea formatată a informațiilor mesei
        /// </summary>
        /// <returns>Șirul de caractere cu informația prezentată</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("", 150);
            sb.Append("Numar masa: " + this.NumarMasa.ToString());
            sb.Append("\r\nNumar locuri: " + this.NumarLocuri.ToString());
            sb.Append("\r\nStatus masa: " + this.StatusMasa.ToString() + "\r\n");

            return sb.ToString();
        }
    }
}
