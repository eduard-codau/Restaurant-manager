using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Clasa încapsulează datele unei comenzi, preluate din baza de date 
    /// </summary>
    public class Comanda
    {
        /// <summary>
        /// Numărul comenzii
        /// </summary>
        public int NumarComanda { get; }

        /// <summary>
        /// Data inițierii comenzii
        /// </summary>
        public DateTime DataComenzii { get; }

        /// <summary>
        /// Numărul ospătarului
        /// </summary>
        public int NumarOspatar { get; }

        /// <summary>
        /// Numărul mesei la care a fost inițiată comanda
        /// </summary>
        public int NumarMasa { get; }

        /// <summary>
        /// Dicționarul ce conține produsele din comandă și cantitățile în care se regăsesc acestea
        /// </summary>
        public Dictionary<string, int> DetaliiComanda { get; } 

        /// <summary>
        /// Inițializarea datelor despre comandă
        /// </summary>
        /// <param name="numarComanda">Numărul comenzii</param>
        /// <param name="dataComenzii">Data inițierii comenzii</param>
        /// <param name="numarOspatar">Numărul ospătarului</param>
        /// <param name="numarMasa">Numărul mesei</param>
        /// <param name="detaliiComanda">Produsele si cantitățile acestora</param>
        public Comanda(int numarComanda, DateTime dataComenzii, int numarOspatar, int numarMasa, Dictionary<string,int> detaliiComanda)
        {
            this.NumarComanda = numarComanda;
            this.DataComenzii = dataComenzii;
            this.NumarOspatar = numarOspatar;
            this.NumarMasa = numarMasa;
            this.DetaliiComanda = new Dictionary<string,int>(detaliiComanda);
        }

        /// <summary>
        /// Metoda permite afișarea formatată a informațiilor comenzii
        /// </summary>
        /// <returns>Șirul de caractere cu informația prezentată</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("", 150);
            sb.Append("Numar comanda: " + this.NumarComanda.ToString());
            sb.Append("\r\nData comenzii: " + this.DataComenzii.ToString());
            sb.Append("\r\nNumar ospatar: " + this.NumarOspatar.ToString());
            sb.Append("\r\nNumar masa: " + this.NumarMasa.ToString());
            sb.Append("\r\nDetalii comanda: ");

            foreach(string produs in this.DetaliiComanda.Keys)
            {
                sb.Append("\r\n\tNume produs: " + produs);
                sb.Append("\r\n\tCantitate produs: " + this.DetaliiComanda[produs] + "\r\n");
            }

            return sb.ToString();
        }
    }
}
