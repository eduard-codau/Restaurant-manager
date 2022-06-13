using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAO;
using System.Windows.Forms;

namespace Controller
{
    /// <summary>
    /// Conține operațiile pe care le poate efectua un utilizator
    /// </summary>
    public class UserController : Controller
    {
        #region Private Member Variables

        /// <summary>
        /// Numele utlizatorului curent
        /// </summary>
        private string _username;
        
        #endregion

        #region Constructor

        /// <summary>
        /// Constructorul clasei, inițializează numele utilizatorului curent
        /// </summary>
        /// <param name="username">Numele utilizatorului</param>
        public UserController(string username="")
        {
            _username = username;
        }

        #endregion

        #region UsernameGetter

        /// <summary>
        /// Obținerea numelui utilizator
        /// </summary>
        /// <returns>Numele utilizatorului</returns>
        public string GetUsername()
        {
            return _username;
        }
        #endregion

        #region OperatiiComanda

        /// <summary>
        /// Obține numarul maxim din lista de comenzi, folosită pentru a adaugă o comandă
        /// cu un număr de ordine mai mare cu o unitate decât numărul maxim
        /// </summary>
        /// <returns>Numărul maxim de identificare al unei comenzi dintr-o listă curentă</returns>
        public int getMaxNumberOfComanda()
        {
            List<Comanda> comenzi = RestaurantDAO.GetInstance().GetComenzi();
            int max = 0;

            foreach (Comanda c in comenzi)
            {
                if (max < c.NumarComanda)
                {
                    max = c.NumarComanda;
                }
            }

            return max;
        }

        /// <summary>
        /// Adaugă o comandă în baza de date
        /// </summary>
        /// <param name="comanda">Comanda de adăugat</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool AddComanda(Comanda comanda)
        {
            return RestaurantDAO.GetInstance().AddComanda(comanda);
        }

        /// <summary>
        /// Actulizează o comandă în baza de date
        /// </summary>
        /// <param name="comanda">Comanda de actualizat</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool UpdateComanda(Comanda comanda)
        {
            return RestaurantDAO.GetInstance().UpdateComanda(comanda);
        }

        /// <summary>
        /// Șterge un produs dintr-o comandă
        /// </summary>
        /// <param name="comanda">Comanda din care se șterge produsul</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool RemoveFromComanda(Comanda comanda)
        {
            return RestaurantDAO.GetInstance().RemoveFromComanda(comanda);
        }

        /// <summary>
        /// Șterge o comandă în baza de date
        /// </summary>
        /// <param name="numarComanda">Comanda din care se șterge produsul</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool RemoveComanda(int numarComanda)
        {
            return RestaurantDAO.GetInstance().RemoveComanda(numarComanda);
        }

        /// <summary>
        /// Obține o comandă după numărul mesei
        /// </summary>
        /// <param name="numarMasa">Numărul mesei din comandă</param>
        /// <returns>Comanda corespunzătoare mesei</returns>
        public Comanda GetComanda(int numarMasa)
        {
            List<Comanda> comenzi = RestaurantDAO.GetInstance().GetComenzi();

            foreach(Comanda c in comenzi)
            {
                if(c.NumarMasa == numarMasa)
                {
                    return c;
                }
            }

            return null;
        }

        #endregion

        #region OperatiiProdus

        /// <summary>
        /// Obține un obiect de tip produs pe baza numelui acestuia
        /// </summary>
        /// <param name="numeProdus">Numele produsului</param>
        /// <returns>Produsul corespuzător</returns>
        public Produs GetProdus(string numeProdus)
        {
            List<Produs> produse = RestaurantDAO.GetInstance().GetProdus();

            foreach(Produs p in produse)
            {
                if(p.NumeProdus == numeProdus)
                {
                    return p;
                }
            }

            return null;
        }

        /// <summary>
        /// Obține o listă de produse pe baza categoriei din care fac parte
        /// </summary>
        /// <param name="idCategorie">Numărul categoriei din baza de date</param>
        /// <returns>Lista corespuzătoare</returns>
        public List<Produs> GetProduseByCategorie(int idCategorie)
        {
            List<Produs> produse = RestaurantDAO.GetInstance().GetProdus();
 
            List<Produs> result = new List<Produs>();

            foreach (Produs p in produse)
            {
                if (p.IdCategorie == idCategorie)
                {
                    result.Add(p);
                }
            }

            return result;
        }

        #endregion

        #region OspatarGetters

        /// <summary>
        /// Obține un obiect de tip ospătar pe baza numărului din baza de date
        /// </summary>
        /// <param name="numarOspatar">Numărul ospătarului</param>
        /// <returns>Ospătarul corespunzător</returns>
        public Ospatar GetOspatar(int numarOspatar)
        {
            List<Ospatar> ospatari = RestaurantDAO.GetInstance().GetOspatar();

            foreach(Ospatar o in ospatari)
            {
                if(o.NumarOspatar == numarOspatar)
                {
                    return o;
                }
            }

            return null;
        }

        /// <summary>
        /// Obține un obiect de tip ospătar pe baza numelui utilizator din baza de date
        /// </summary>
        /// <param name="numarOspatar">Numele utilizator al ospătarului</param>
        /// <returns>Ospătarul corespunzător</returns>
        public Ospatar GetOspatar(string usernameOspatar)
        {
            List<Ospatar> ospatari = RestaurantDAO.GetInstance().GetOspatar();

            foreach (Ospatar o in ospatari)
            {
                if (o.Username == usernameOspatar)
                {
                    return o;
                }
            }

            return null;
        }

        #endregion

        #region OperatiiMasa

        /// <summary>
        /// Obține o listă cu mesele din restaurant 
        /// </summary>
        /// <returns>Lista cu mese</returns>
        public List<Masa> GetMese()
        {
            return RestaurantDAO.GetInstance().GetMese();
        }

        /// <summary>
        /// Actualizează o masă
        /// </summary>
        /// <param name="masa">Obiectul de tip masă</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool UpdateMasa(Masa masa)
        {
            return RestaurantDAO.GetInstance().UpdateMasa(masa);
        }
        #endregion

        #region OperatiiMeniu

        /// <summary>
        /// Obține o listă cu obiecte de tip meniu
        /// </summary>
        /// <returns>O lista cu meniuri</returns>
        public List<Meniu> GetMeniu()
        {
            return RestaurantDAO.GetInstance().GetMeniu();
        }

        /// <summary>
        /// Obține numărul unei categorii din baza de date pe baza numelui categoriei
        /// </summary>
        /// <param name="numeCategorie">Numele categoriei</param>
        /// <returns>Numărul categoriei</returns>
        public int GetIdCategorie(string numeCategorie)
        {
            List<Meniu> meniu = RestaurantDAO.GetInstance().GetMeniu();

            foreach (Meniu m in meniu)
            {
                if (m.Categorie == numeCategorie)
                {
                    return m.IdCategorie;
                }
            }

            return 0;
        }
        #endregion
    }
}
