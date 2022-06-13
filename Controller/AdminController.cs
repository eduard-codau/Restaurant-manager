using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Model;

namespace Controller
{
    /// <summary>
    /// Clasa descrie operatiile pe care le poate executa un administrator
    /// </summary>
    public class AdminController : Controller
    {
        #region Private Member Variable
        /// <summary>
        /// Numele administratorului
        /// </summary>
        private string _username;
        #endregion

        #region Constructor

        /// <summary>
        /// Constructorul clase, initializeaza numele administratorului
        /// </summary>
        /// <param name="username"></param>
        public AdminController(string username="")
        {
            _username = username;
        }
        #endregion

        #region Username

        /// <summary>
        /// Obține numele administratorului
        /// </summary>
        /// <returns></returns>
        public string GetUsername()
        {
            return _username;
        }
        #endregion

        #region OperatiiMeniu

        /// <summary>
        /// Obține lista cu toate meniurile din baza de date
        /// </summary>
        /// <returns>Lista cu meniuri</returns>
        public List<Meniu> GetMeniu()
        {
            return RestaurantDAO.GetInstance().GetMeniu();
        }

        /// <summary>
        /// Actualizează un meniu, încapsulat într-un obiect de același tip
        /// </summary>
        /// <param name="meniu">Meniul de actualizat</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool UpdateMeniu(Meniu meniu)
        {
            return RestaurantDAO.GetInstance().UpdateMeniu(meniu);
        }

        /// <summary>
        /// Adaugă un meniu
        /// </summary>
        /// <param name="meniu">Meniul de adăugat</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool AddMeniu(Meniu meniu)
        {
            return RestaurantDAO.GetInstance().AddMeniu(meniu);
        }

        /// <summary>
        /// Obține numarul maxim din lista de meniu, folosit pentru a adăuga o nouă intrare in tabela Meniu
        /// cu un număr de ordine mai mare cu o unitate decât numărul maxim
        /// </summary>
        /// <returns>Numărul maxim al unui meniu din listă</returns>
        public int GetMaxNumberOfIdCategorie()
        {
            List<Meniu> meniu = RestaurantDAO.GetInstance().GetMeniu();
            int result = 0;

            foreach(Meniu m in meniu)
            {
                if(m.IdCategorie > result)
                {
                    result = m.IdCategorie;
                }
            }

            return result;

        }

        /// <summary>
        /// Ștergerea unui meniu din baza de date 
        /// </summary>
        /// <param name="meniu">Meniu de șters</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool RemoveMeniu(Meniu meniu)
        {
            return RestaurantDAO.GetInstance().RemoveMeniu(meniu.IdCategorie);
        }

        #endregion

        #region OperatiiProdus

        /// <summary>
        /// Adaugă un produs în baza de date
        /// </summary>
        /// <param name="produs">Produsul de adăugat</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool AddProdus(Produs produs)
        {
            return RestaurantDAO.GetInstance().AddProdus(produs);
        }

        /// <summary>
        /// Obține o listă cu toate produsele din baza de date
        /// </summary>
        /// <returns>Lista cu toate produsele</returns>
        public List<Produs> GetProdus()
        {
            return RestaurantDAO.GetInstance().GetProdus();
        }

        /// <summary>
        /// Actualizează un produs în baza de date, încapsulat îintr-un obiect cu același nume
        /// </summary>
        /// <param name="produs">Produsul de actualizat</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool UpdateProdus(Produs produs)
        {
            return RestaurantDAO.GetInstance().UpdateProdus(produs);
        }

        /// <summary>
        /// Șterge produsul din baza de date, identificat prin nume
        /// </summary>
        /// <param name="nume">Numele produsului de șters</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool RemoveProdus(string nume)
        {
            return RestaurantDAO.GetInstance().RemoveProdus(nume);
        }

        #endregion

        #region OperatiiOspatar

        /// <summary>
        /// Obține toți ospătarii din baza de date
        /// </summary>
        /// <returns>Lista cu ospătari</returns>
        public List<Ospatar> GetOspatar()
        {
            return RestaurantDAO.GetInstance().GetOspatar();
        }

        /// <summary>
        /// Adaugă un ospătar în baza de date
        /// </summary>
        /// <param name="o">Ospătarul de adăugat</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool AddOspatar(Ospatar o)
        {
            return RestaurantDAO.GetInstance().AddOspatar(o);
        }

        /// <summary>
        /// Obține numărul maxim din lista de opătari, folosit pentru a adăuga o nouă intrare in tabela Ospătar
        /// cu un număr de ordine mai mare cu o unitate decât numărul maxim
        /// </summary>
        /// <returns>Numărul maxim al unui ospătar din listă</returns>
        public int GetMaxNumberOfNrOspatar()
        {
            List<Ospatar> ospatari = RestaurantDAO.GetInstance().GetOspatar();
            int max = 0;

            foreach(Ospatar o in ospatari)
            {
                if(o.NumarOspatar > max)
                {
                    max = o.NumarOspatar;
                }
            }

            return max;
        }

        /// <summary>
        /// Șterge un ospătar din baza de date
        /// </summary>
        /// <param name="numarOspatar">Numărul ospătarului de șters</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool RemoveOspatar(int numarOspatar)
        {
            return RestaurantDAO.GetInstance().RemoveOspatar(numarOspatar);
        }

        #endregion

        #region OperatiiLogin

        /// <summary>
        /// Adaugă datele unui nou utilizator al aplicației în baza de date
        /// </summary>
        /// <param name="login">Obiectul Login ce incapsulează datele utilizatorului de adăugat</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool AddLogin(Login login)
        {
            return RestaurantDAO.GetInstance().AddLogin(login);
        }

        /// <summary>
        /// Șterge un utilizator al aplicației pe baza numelui acestuia
        /// </summary>
        /// <param name="username">Numele utilizatorului</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool RemoveLogin(string username)
        {
            return RestaurantDAO.GetInstance().RemoveLogin(username);
        }
        #endregion
    }
}
