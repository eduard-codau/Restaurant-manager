using Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Globalization;

namespace DAO
{
    /// <summary>
    /// Reprezintă un intermediar care face legătura între baza de date și aplicație
    /// Manipularea datelor se realizează cu ajutorul descrierilor din biblioteca Model
    /// DAO - Data Access Object
    /// </summary>
    public class RestaurantDAO
    {
        #region Private Member Variables

        /// <summary>
        /// Obiectul care inițializează si gestionează conexiunea cu baza de date
        /// </summary>
        private OracleConnection _oracleConnection;

        /// <summary>
        /// Datele de autentificare cu serverul de baze de date
        /// </summary>
        private string _oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = ORACL)));" + "User Id=edi_db;Password=123456789;";

        /// <summary>
        /// Instanța specifică șablonului de proiectare Singleton, poate fi accesată doar prin metoda GetInstance()
        /// Asigură o singură conexiune cu baza de date pe durata executării aplicației
        /// </summary>
        private static RestaurantDAO _instance = null;

        #endregion

        #region Constructor

        private RestaurantDAO()
        {
            //Deschidere conexiune
            try
            {
                this._oracleConnection = new OracleConnection(_oradb);
                this._oracleConnection.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine("Eroare la conexiune: " + e.Message);
            }
        }

        //un get instance(Singleton)
        /// <summary>
        /// Obține instanța Singleton responsabilă de accesul la baza de date
        /// </summary>
        /// <returns>Instanța unica a clasei RestaurantDAO</returns>
        public static RestaurantDAO GetInstance()
        {
            if (_instance == null)
            {
                _instance = new RestaurantDAO();
            }

            return _instance;
        }

        #endregion

        #region OperatiiLogin
        /// <summary>
        /// Verifică dacă un utilizator există sau nu în baza de date
        /// </summary>
        /// <param name="username">Numele utilizatorului</param>
        /// <param name="password">Parola</param>
        /// <param name="isAdmin">Drepturi de administrator</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool GetUser(string username, string password, out bool isAdmin)
        {
            try
            {
                if (username == "" || password == "")
                {

                    throw new Exception("Creditentiale invalide");
                }

                if (this._oracleConnection == null)
                {
                    throw new Exception("Conexiune nula");
                }

                using (OracleCommand cmd = this._oracleConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Login where username=\'" + username + "\'";
                    OracleDataReader odr = cmd.ExecuteReader();
                    if (odr.Read())
                    {
                        if (Convert.ToString(odr["parola"]).Equals(password))
                        {
                            if (Convert.ToInt32(odr["admin"]) == 1)
                            {
                                isAdmin = true;
                            }
                            else
                            {
                                isAdmin = false;
                            }
                            return true;
                        }
                        isAdmin = false;
                        return false;
                    }

                    isAdmin = false;
                    return false;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Eroare la selectarea utilizatorului   : " + e.ToString());
                isAdmin = false;
                return false;
            }

        }

        /// <summary>
        /// Obține lista cu datele utilizatorilor din tabela Login
        /// </summary>
        /// <returns>Lista cu datele utilizatorilor</returns>
        public List<Login> GetLogin()
        {
            try
            {
                List<Login> listaRezultat = new List<Login>();
                using (OracleCommand cmd = this._oracleConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM LOGIN";
                    OracleDataReader odr = cmd.ExecuteReader();

                    while (odr.Read())
                    {
                        string username = Convert.ToString(odr["USERNAME"]);
                        string parola = Convert.ToString(odr["PAROLA"]);

                        // În funcție de cum este setată data pe calculatorul pe care rulează apllicația, se decomentează 
                        //DateTime lastLogin = (DateTime.ParseExact(Convert.ToString(odr["LAST_LOGIN"]).Split(' ')[0], new string[] { "m/d/yyyy", "mm/dd/yyyy", "m/dd/yyyy", "mm/d/yyyy" }, CultureInfo.InvariantCulture, DateTimeStyles.None));

                        DateTime lastLogin = DateTime.Parse(Convert.ToString(odr["LAST_LOGIN"]));
                        int isAdmin = Convert.ToInt32(odr["ADMIN"]);
                        listaRezultat.Add(new Login(username, parola, lastLogin, isAdmin));


                    }
                    return listaRezultat;
                }
            }
            catch (Exception e)
            {
                // afișare fereastră in caz de eroare
                MessageBox.Show("Eroare la afisarea login: " + e.Message.ToString());
                return new List<Login>();

            }
        }
        /// <summary>
        /// Adaugă o nouă intrare in tabela Login
        /// </summary>
        /// <param name="login">Obiectul de tip Login ce incaspuleaza informațiile necesare</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool AddLogin(Login login)
        {
            try
            {
                if (login.Username == null)
                {
                    throw new Exception("Username-ul este invalid!");
                }
                using (OracleCommand cmd = this._oracleConnection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO LOGIN(USERNAME,PAROLA,LAST_LOGIN, ADMIN) VALUES(\'" + login.Username + "\',\'" + login.Parola +
                        "\',TO_DATE(\'" + login.LastLogin.Day + "/" + login.LastLogin.Month + "/" + login.LastLogin.Year + "\',\'dd/mm/yyyy\')," + login.IsAdmin + ")";
                    Console.WriteLine(cmd.CommandText);
                    cmd.ExecuteNonQuery();
                    return true;
                }

            }
            catch (Exception e)
            {
                // afișare fereastră in caz de eroare
                MessageBox.Show("Eroare la adaugarea unui login: " + e.Message.ToString());
                return false;

            }
        }

        /// <summary>
        /// Șterge o intrare din tabela Login pe baza numelui utilizatorului(unic)
        /// </summary>
        /// <param name="username">Numele utilizatorului</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool RemoveLogin(string username)
        {
            try
            {

                if (username == null)
                {
                    throw new Exception("Username-ul este invalid!");
                }
                using (OracleCommand cmd = this._oracleConnection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM OSPATAR WHERE USERNAME=\'" + username + "\'";
                    Console.WriteLine(cmd.CommandText);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "DELETE FROM LOGIN WHERE USERNAME=\'" + username + "\'";
                    Console.WriteLine(cmd.CommandText);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception e)
            {
                // afișare fereastră in caz de eroare
                MessageBox.Show("Eroare la stergerea login: " + e.Message.ToString());
                return false;

            }
        }

        #endregion

        #region OperatiiMasa
        
        /// <summary>
        /// Obține o lista cu toate intrările din tabela Masa
        /// </summary>
        /// <returns>Lista cu obiecte de tip masă</returns>
        public List<Masa> GetMese()
        {
            try
            {
                List<Masa> listaRezultat = new List<Masa>();
                using (OracleCommand cmd = this._oracleConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM MASA ORDER BY NR_MASA";
                    OracleDataReader odr = cmd.ExecuteReader();
                    while (odr.Read())
                    {
                        int numarMasa = Convert.ToInt32(odr["NR_MASA"]);
                        int numarLocuri = Convert.ToInt32(odr["NR_LOCURI"]);
                        string status = Convert.ToString(odr["STATUS"]);

                        if (status == "libera")
                        {
                            listaRezultat.Add(new Masa(numarMasa, numarLocuri, StatusEnum.Liber));
                        }
                        else
                        {
                            listaRezultat.Add(new Masa(numarMasa, numarLocuri, StatusEnum.Ocupat));
                        }
                    }

                    return listaRezultat;
                }
            }
            catch(Exception e)
            {
                // afișare fereastră in caz de eroare
                MessageBox.Show("Eroare la obtinerea listei cu mese: " + e.Message.ToString());
                return new List<Masa>();
            }
        }

        /// <summary>
        /// Adaugă o intrare nouă in tabela Masa
        /// </summary>
        /// <param name="masa">Masa de adăugat</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool AddMasa(Masa masa)
        {
            try
            {
                if(masa.NumarMasa <= 0)
                {
                    throw new Exception("Numar masa invalid");
                }
                using(OracleCommand cmd = this._oracleConnection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Masa(NR_MASA,NR_LOCURI,STATUS) VALUES(" + masa.NumarMasa + "," + masa.NumarLocuri;

                    if (masa.StatusMasa == StatusEnum.Liber)
                    {
                        cmd.CommandText += ",\'libera\')";
                    }
                    else
                    {
                        cmd.CommandText += ",\'ocupata\')";
                    }
                    Console.WriteLine(cmd.CommandText);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch(Exception e)
            {
                // afișare fereastră in caz de eroare
                MessageBox.Show("Eroare la adaugarea unei mese: " + e.Message.ToString());
                return false;
            }
        }

        /// <summary>
        /// Șterge o intrare din tabela Masa, corespunzătoare numărului mesei
        /// </summary>
        /// <param name="numar">Numărul mesei de șters</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool RemoveMasa(int numar)
        {
            try
            {
                if(numar <= 0)
                {
                    throw new Exception("Numarul mesei este invalid(<=0)");
                }
                using (OracleCommand cmd = this._oracleConnection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM COMANDA WHERE NR_MASA=" + numar;
                    cmd.ExecuteNonQuery();
                    Console.WriteLine(cmd.CommandText);

                    cmd.CommandText = "DELETE FROM MASA WHERE NR_MASA=" + numar;
                    cmd.ExecuteNonQuery();
                    Console.WriteLine(cmd.CommandText);

                    return true;
                }
            }
            catch(Exception e)
            {
                // afișare fereastră in caz de eroare
                MessageBox.Show("Eroare la stergerea mesei: " + e.Message.ToString());
                return false;
            }
        }

        /// <summary>
        /// Actualizează informațiile unei mese
        /// </summary>
        /// <param name="masa">Informațiile mesei ce urmează să fie actualizată</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool UpdateMasa(Masa masa)
        {
            try
            {
                if(masa.NumarMasa <= 0 || masa.NumarLocuri <=0 )
                {
                    throw new Exception("Numarul mesei sau numarul de locuri invalid");
                }

                using (OracleCommand cmd = this._oracleConnection.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Masa SET NR_LOCURI=" + masa.NumarLocuri + ", STATUS=";
                    if (masa.StatusMasa == StatusEnum.Liber)
                    {
                        cmd.CommandText += "\'libera\'";
                    }
                    else
                    {
                        cmd.CommandText += "\'ocupata\'";
                    }
                    cmd.CommandText += "WHERE NR_MASA=" + masa.NumarMasa;
                    Console.WriteLine(cmd.CommandText);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch(Exception e)
            {
                // afișare fereastră in caz de eroare
                MessageBox.Show("Eroare la actualizarea mesei: " + e.Message.ToString());
                return false;
            }
        }

        #endregion

        #region OperatiiComanda
        
        /// <summary>
        /// Obține o lista cu toate intrările din tabela Comandă
        /// </summary>
        /// <returns>O listă cu informațiile tuturor comenzilor</returns>
        public List<Comanda> GetComenzi()
        {
            try
            {
                List<Comanda> listaRezultat = new List<Comanda>();

                using (OracleCommand cmd = this._oracleConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM COMANDA";
                    OracleDataReader odr = cmd.ExecuteReader();

                    while(odr.Read())
                    {
                        int numarComanda = Convert.ToInt32(odr["NR_COMANDA"]);
                        
                        DateTime dataComenzii = Convert.ToDateTime(DateTime.ParseExact(Convert.ToString(odr["DATA_COMENZII"]).Split(' ')[0], new string[] { "m/d/yyyy", "mm/dd/yyyy", "m/dd/yyyy", "mm/d/yyyy" }, CultureInfo.InvariantCulture, DateTimeStyles.None));

                        int numarOspatar = Convert.ToInt32(odr["NR_OSPATAR"]);
                        int numarMasa = Convert.ToInt32(odr["NR_MASA"]);

                        // extragere detalii pentru fiecare comanda
                        cmd.CommandText = "SELECT * FROM DETALII_COMANDA WHERE NR_COMANDA=" + numarComanda;
                        OracleDataReader odrPrim = cmd.ExecuteReader();

                        Dictionary<string, int> detalii = new Dictionary<string, int>();

                        while(odrPrim.Read())
                        {
                            string numeProdus = Convert.ToString(odrPrim["NUME_PRODUS"]);
                            int cantitate = Convert.ToInt32(odrPrim["CANTITATE"]);
                            detalii.Add(numeProdus, cantitate);

                        }

                        listaRezultat.Add(new Comanda(numarComanda, dataComenzii, numarOspatar, numarMasa, detalii));
                    }

                    return listaRezultat;
                }
            }
            catch(Exception e)
            {
                // afișare fereastră in caz de eroare
                MessageBox.Show("Eroare la obtinerea comenzilor: " + e.Message.ToString());
                return new List<Comanda>();
            }
        }

        /// <summary>
        /// Adaugă o comandă in baza de date
        /// </summary>
        /// <param name="comanda">Informațiile comenzii ce urmează sa fie adăugate</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool AddComanda(Comanda comanda)
        {
            try
            {
                if(comanda.NumarComanda <= 0)
                {
                    throw new Exception("Numarul comenzii este invalid");
                }



                if(comanda.NumarMasa <=0 )
                {
                    throw new Exception("Numarul mesei este invalid");
                }

                if(comanda.NumarOspatar <=0 )
                {
                    throw new Exception("Numarul ospatarului este invalid");
                }

                using (OracleCommand cmd = this._oracleConnection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Comanda(NR_COMANDA,DATA_COMENZII,NR_OSPATAR,NR_MASA) VALUES(" + comanda.NumarComanda + ",TO_DATE(\'"
                        + comanda.DataComenzii.Day + "/" + comanda.DataComenzii.Month + "/" + comanda.DataComenzii.Year + "\',\'dd/mm/yyyy\')," + comanda.NumarOspatar + "," + comanda.NumarMasa + ")";
                    Console.WriteLine(cmd.CommandText);
                    cmd.ExecuteNonQuery();

                    if (comanda.DetaliiComanda.Count > 0)
                    {
                        foreach (string produs in comanda.DetaliiComanda.Keys)
                        {
                            cmd.CommandText = "INSERT INTO DETALII_COMANDA(NR_COMANDA,NUME_PRODUS,CANTITATE) VALUES(" + comanda.NumarComanda + ",\'" + produs + "\'," + comanda.DetaliiComanda[produs] + ")";
                            Console.WriteLine(cmd.CommandText);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return true;
                }
            }
            catch(Exception e)
            {
                // afișare fereastră in caz de eroare
                MessageBox.Show("Eroare la adaugarea unei comenzi: " + e.Message.ToString());
                return false;
            }
        }

        /// <summary>
        /// Actualizează informațiile unei comenzi in baza de date
        /// </summary>
        /// <param name="comanda">Informațiile comenzii de actualizat</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool UpdateComanda(Comanda comanda)
        {
            try
            {
                if (comanda.NumarComanda <= 0)
                {
                    throw new Exception("Numarul comenzii este invalid");
                }

                if (comanda.NumarMasa <= 0)
                {
                    throw new Exception("Numarul mesei este invalid");
                }

                if (comanda.NumarOspatar <= 0)
                {
                    throw new Exception("Numarul ospatarului este invalid");
                }

                using (OracleCommand cmd = this._oracleConnection.CreateCommand())
                {
                    cmd.CommandText = "UPDATE COMANDA SET DATA_COMENZII=TO_DATE(\'"
                        + comanda.DataComenzii.Day + "/" + comanda.DataComenzii.Month + "/" + comanda.DataComenzii.Year + "\',\'dd/MM/YYYY\')" +
                        ",NR_OSPATAR=" + comanda.NumarOspatar + ",NR_MASA=" + comanda.NumarMasa + " WHERE NR_COMANDA=" + comanda.NumarComanda;
                    Console.WriteLine(cmd.CommandText);
                    cmd.ExecuteNonQuery();

                    foreach(string numeProdus in comanda.DetaliiComanda.Keys)
                    {
                        cmd.CommandText = "INSERT INTO DETALII_COMANDA(NR_COMANDA,NUME_PRODUS,CANTITATE) VALUES(" + comanda.NumarComanda + ",\'" + numeProdus + "\'," + comanda.DetaliiComanda[numeProdus] + ")";
                        Console.WriteLine(cmd.CommandText);
                        cmd.ExecuteNonQuery();
                    }
                    return true;
                }

            }
            catch (Exception e)
            {
                // afișare fereastră in caz de eroare
                MessageBox.Show("Eroare la actualizarea comenzii: " + e.Message.ToString());
                return false;
            }
        }

        /// <summary>
        /// Șterge o comandă din tabela Comanda pe baza numărului acesteia
        /// </summary>
        /// <param name="numar">Numărul comenzii de șters</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool RemoveComanda(int numar)
        {
            try
            {
                if (numar <= 0)
                {
                    throw new Exception("Numarul comenzii este invalid");
                }

                using (OracleCommand cmd = this._oracleConnection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM DETALII_COMANDA WHERE NR_COMANDA=" + numar;
                    Console.WriteLine(cmd.CommandText);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "DELETE FROM COMANDA WHERE NR_COMANDA=" + numar;
                    Console.WriteLine(cmd.CommandText);
                    cmd.ExecuteNonQuery();


                    return true;
                }

            }
            catch(Exception e)
            {
                // afișare fereastră in caz de eroare
                MessageBox.Show("Eroare la stergerea comenzii: " + e.Message.ToString());
                return false;
            }
        }

        /// <summary>
        /// Șterge produsele dintr-o comanda, specificate printr-un obiect de tip Comanda
        /// </summary>
        /// <param name="comanda">Comanda ale cărei produse vor fi șterse</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool RemoveFromComanda(Comanda c)
        {
            try
            {
                if (c.NumarComanda <= 0)
                {
                    throw new Exception("Numarul comenzii este invalid");
                }

                using (OracleCommand cmd = this._oracleConnection.CreateCommand())
                {
                    foreach(string produs in c.DetaliiComanda.Keys)
                    {
                        cmd.CommandText = "DELETE FROM DETALII_COMANDA WHERE NR_COMANDA=" + c.NumarComanda + "AND NUME_PRODUS=\'" + produs + "\' AND CANTITATE=" + c.DetaliiComanda[produs];
                        Console.WriteLine(cmd.CommandText);
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception e)
            {
                // afișare fereastră in caz de eroare
                MessageBox.Show("Eroare la stergerea din detalii comanda: " + e.Message);
                return false;
            }
        }

        #endregion

        #region OperatiiProdus

        /// <summary>
        /// Obține o listă cu toate intrările din tabela Produs
        /// </summary>
        /// <returns>O listă cu toate produsele</returns>
        public List<Produs> GetProdus()
        {
            try
            {
                List<Produs> listaRezultat = new List<Produs>();
                using (OracleCommand cmd = this._oracleConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM PRODUS";
                    OracleDataReader odr = cmd.ExecuteReader();
                    while (odr.Read())
                    {
                        string nume = Convert.ToString(odr["nume_produs"]);
                        double pret = Convert.ToDouble(odr["pret"]);
                        int gramaj = Convert.ToInt32(odr["gramaj"]);
                        string masura = Convert.ToString(odr["masura"]);
                        int categorie = Convert.ToInt32(odr["id_categorie"]);

                        Masura m;

                        // identificare masură
                        switch (masura)
                        {
                            case "gram":
                                m = Masura.Gram;
                                break;
                            case "bucata":
                                m = Masura.Bucata;
                                break;
                            case "litru":
                                m = Masura.Litru;
                                break;
                            default:
                                m = Masura.None;
                                break;
                        }

                        listaRezultat.Add(new Produs(nume, pret, gramaj, m, categorie));
                    }

                    return listaRezultat;
                }
            }
            catch (Exception e)
            {
                // afișare fereastră în caz de eroare
                MessageBox.Show("Eroare la obtinerea produselor: " + e.Message);
                return new List<Produs>();
            }
        }

        /// <summary>
        /// Adaugă un produs in tabela Produs
        /// </summary>
        /// <param name="produs">Informațiile produsului de adăugat</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool AddProdus(Produs produs)
        {
            try
            {
                if (produs.PretProdus <= 0)
                {
                    throw new Exception("Pretul produsului este invalid");
                }

                if (produs.Gramaj <= 0)
                {
                    throw new Exception("Gramajul produsului este invalid");
                }

                using (OracleCommand cmd = this._oracleConnection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO PRODUS(NUME_PRODUS,PRET,GRAMAJ,MASURA,ID_CATEGORIE) VALUES(\'" + produs.NumeProdus + "\'," + produs.PretProdus + "," + produs.Gramaj + ",";
                    switch (produs.MasuraProdus)
                    {
                        case Masura.Bucata:
                            cmd.CommandText += "\'bucata\',";
                            break;
                        case Masura.Gram:
                            cmd.CommandText += "\'gram\',";
                            break;
                        case Masura.Kilogram:
                            cmd.CommandText += "\'kilogram\',";
                            break;
                        case Masura.Litru:
                            cmd.CommandText += "\'litru\',";
                            break;
                    }

                    cmd.CommandText += produs.IdCategorie + ")";
                    Console.WriteLine(cmd.CommandText);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception e)
            {
                // afișare fereastră in caz de eroare
                MessageBox.Show("Eroare la adaugare produs: " + e.Message.ToString());
                return false;
            }
        }

        /// <summary>
        /// Șterge un produs din tabela Produs
        /// </summary>
        /// <param name="nume">Numele produsului de șters</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool RemoveProdus(string nume)
        {
            try
            {
                if (nume == null)
                {
                    throw new Exception("Numele produsului nu poate fi nul!");
                }
                using (OracleCommand cmd = this._oracleConnection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM PRODUS WHERE NUME_PRODUS=\'" + nume + "\'";
                    Console.WriteLine(cmd.CommandText);
                    cmd.ExecuteNonQuery();
                    return true;

                }
            }
            catch (Exception e)
            {
                // afișare fereastră in caz de eroare
                MessageBox.Show("Eroare la stergerea unui produs: " + e.Message.ToString());
                return false;
            }
        }

        /// <summary>
        /// Actualizează un produs pe baza informațiilor din obiectul cu același nume
        /// </summary>
        /// <param name="produs">Informațiile produsului de actualizat</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool UpdateProdus(Produs produs)
        {
            try
            {
                using (OracleCommand cmd = this._oracleConnection.CreateCommand())
                {
                    cmd.CommandText = "UPDATE produs SET PRET=" + produs.PretProdus + ", GRAMAJ=" + produs.Gramaj + ", MASURA=";

                    switch (produs.MasuraProdus)
                    {
                        case Masura.Bucata:
                            cmd.CommandText += "\'bucata\'";
                            break;
                        case Masura.Gram:
                            cmd.CommandText += "\'gram\'";
                            break;
                        case Masura.Kilogram:
                            cmd.CommandText += "\'kilogram\'";
                            break;
                        case Masura.Litru:
                            cmd.CommandText += "\'litru\'";
                            break;
                    }

                    cmd.CommandText += ", ID_CATEGORIE=" + produs.IdCategorie + " WHERE NUME_PRODUS=\'" + produs.NumeProdus + "\'";
                    Console.WriteLine(cmd.CommandText);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception e)
            {
                // afișare fereastră in caz de eroare
                MessageBox.Show("Eroare la actualizarea produselor: " + e.Message.ToString());
                return false;
            }
        }

        #endregion

        #region OperatiiMeniu

        /// <summary>
        /// Obține o listă cu toate intrările din tabela Meniu
        /// </summary>
        /// <returns>O listă cu toate meniurile</returns>
        public List<Meniu> GetMeniu()
        {
            try
            {
                List<Meniu> listaRezultat = new List<Meniu>();
                using (OracleCommand cmd = this._oracleConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM MENIU";
                    OracleDataReader odr = cmd.ExecuteReader();
                    while (odr.Read())
                    {
                        int id_categorie = Convert.ToInt32(odr["ID_CATEGORIE"]);
                        string categorie = Convert.ToString(odr["CATEGORIE"]);

                        listaRezultat.Add(new Meniu(id_categorie, categorie));
                    }
                    return listaRezultat;
                }

            }
            catch (Exception e)
            {
                // afișare fereastră in caz de eroare
                MessageBox.Show("Eroare la obtinerea meniurilor: " + e.Message.ToString());
                return new List<Meniu>();

            }
        }

        /// <summary>
        /// Adaugă o nouă intrare in tabela Meniu
        /// </summary>
        /// <param name="meniu">Informațiile asociate meniului</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool AddMeniu(Meniu meniu)
        {
            try
            {
                if (meniu.IdCategorie <= 0)
                {
                    throw new Exception("Id-ul categoriei nu poate fi vid!");
                }

                using (OracleCommand cmd = this._oracleConnection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO MENIU(ID_CATEGORIE, CATEGORIE) VALUES(" + meniu.IdCategorie + ",\'" + meniu.Categorie + "\')";
                    Console.WriteLine(cmd.CommandText);
                    cmd.ExecuteNonQuery();
                    return true;
                }

            }
            catch (Exception e)
            {
                // afișare fereastră in caz de eroare
                MessageBox.Show("Eroare la adaugare meniu: " + e.Message.ToString());
                return false;
            }
        }

        /// <summary>
        /// Șterge o intrare din tabela Meniu pe baza numărului meniului
        /// </summary>
        /// <param name="id">Numarul meniului de șters</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool RemoveMeniu(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new Exception("Id-ul nu poate fi negativ!");
                }
                using (OracleCommand cmd = this._oracleConnection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM PRODUS WHERE ID_CATEGORIE=" + id;
                    Console.WriteLine(cmd.CommandText);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "DELETE FROM MENIU WHERE ID_CATEGORIE=" + id;
                    Console.WriteLine(cmd.CommandText);
                    cmd.ExecuteNonQuery();
                    return true;
                }

            }
            catch (Exception e)
            {
                // afișare fereastră in caz de eroare
                MessageBox.Show("Eroare la stergerea unui meniu: " + e.Message.ToString());
                return false;

            }
        }

        /// <summary>
        /// Actualizează informațiile unei intrări din tabela Meniu
        /// </summary>
        /// <param name="meniu">Informațiile meniului de actualizat</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool UpdateMeniu(Meniu meniu)
        {
            try
            {

                if (meniu.IdCategorie <= 0)
                {
                    throw new Exception("Numarul categoriei este invalid!");
                }
                using (OracleCommand cmd = this._oracleConnection.CreateCommand())
                {

                    cmd.CommandText = "UPDATE Meniu SET categorie=\'" + meniu.Categorie + "\' WHERE id_categorie=\'" + meniu.IdCategorie + "\'";
                    Console.WriteLine(cmd.CommandText);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception e)
            {
                // afișare fereastră in caz de eroare
                MessageBox.Show("Eroare la actualizarea meniurilor: " + e.Message.ToString());
                return false;
            }
        }

        #endregion

        #region OperatiiOspatar

        /// <summary>
        /// Obține o listă cu toate intrările din tabela Ospatar
        /// </summary>
        /// <returns>O listă cu toți ospătarii</returns>
        public List<Ospatar> GetOspatar()
        {
            try
            {
                List<Ospatar> listaRezultat = new List<Ospatar>();
                using ( OracleCommand cmd=this._oracleConnection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM OSPATAR";
                    OracleDataReader odr = cmd.ExecuteReader();
                    while(odr.Read())
                    {
                        int numarOspatar = Convert.ToInt32(odr["NR_OSPATAR"]);
                        string numeOspatar = Convert.ToString(odr["NUME"]);
                        string telefonOspatar = Convert.ToString(odr["TELEFON"]);
                        string usernameOspatar = Convert.ToString(odr["USERNAME"]);

                        listaRezultat.Add(new Ospatar(numarOspatar, numeOspatar, telefonOspatar, usernameOspatar));
                    }

                    return listaRezultat;
                }
            }
            catch(Exception e)
            {
                // afișare fereastră în caz de eroare
                MessageBox.Show("Eroare la obtinerea listei cu ospatar: " + e.Message.ToString());
                return new List<Ospatar>();
            }
        }

        /// <summary>
        /// Adaugă o nouă intrare in tabela Ospatar
        /// </summary>
        /// <param name="ospatar">Informațiile ospătarului de adăugat</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool AddOspatar(Ospatar ospatar)
        {
            try
            {
                if(ospatar.NumarOspatar<=0)
                {
                    throw new Exception("Numarul ospatarului este invalid! ");
                }

                using(OracleCommand cmd=this._oracleConnection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO ospatar(NR_OSPATAR, NUME, TELEFON, USERNAME) VALUES(" + ospatar.NumarOspatar + ",\'" + ospatar.Nume + "\',\'" + ospatar.Telefon + "\',\'" +
                        ospatar.Username + "\')";
                    Console.WriteLine(cmd.CommandText);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch(Exception e)
            {
                // afișare fereastră in caz de eroare
                MessageBox.Show("Eroare la adaugarea unui ospatar: " + e.Message.ToString());
                return false;
            }
        }

        /// <summary>
        /// Șterge un ospătar din tabela Ospatar pe baza numărului său
        /// </summary>
        /// <param name="numar">Numărul ospătarului de șters</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool RemoveOspatar(int numar)
        {
            try
            {
                if (numar <= 0)
                {
                    throw new Exception("Numarul ospatarului este invalid.");

                }

                using (OracleCommand cmd = this._oracleConnection.CreateCommand())
                {
                    string usernameOspatar = "";
                    cmd.CommandText = "SELECT USERNAME FROM OSPATAR WHERE NR_OSPATAR=" + numar;
                    OracleDataReader odr = cmd.ExecuteReader();
                    while (odr.Read())
                    {
                        usernameOspatar = Convert.ToString(odr["USERNAME"]);
                    }

                    // ștergerea comenzilor asociate(dacă există)
                    cmd.CommandText = "DELETE FROM DETALII_COMANDA WHERE NR_COMANDA=(SELECT NR_COMANDA FROM COMANDA WHERE NR_OSPATAR=" + numar + ")";
                    Console.WriteLine(cmd.CommandText);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "DELETE FROM COMANDA WHERE NR_OSPATAR=" + numar;
                    Console.WriteLine(cmd.CommandText);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "DELETE FROM OSPATAR WHERE NR_OSPATAR=" + numar;
                    Console.WriteLine(cmd.CommandText);
                    cmd.ExecuteNonQuery();


                    cmd.CommandText = "DELETE FROM LOGIN WHERE USERNAME=\'" + usernameOspatar + "\'";
                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception e)
            {
                // afișare fereastră in caz de eroare
                MessageBox.Show("eroare la stergerea ospatarului: " + e.Message.ToString());
                return false;
            }
        }

        /// <summary>
        /// Actualizare informații ospătar
        /// </summary>
        /// <param name="ospatar">Informațiile ospătarului de actualizat</param>
        /// <returns>Valoare de adevăr corespunzătoare executării cu succes a operației</returns>
        public bool UpdateOspatar(Ospatar ospatar)
        {
            try
            {
                if (ospatar.NumarOspatar <= 0)
                {
                    throw new Exception("Numarul ospatarului este invalid.");

                }
                using (OracleCommand cmd = this._oracleConnection.CreateCommand())
                {

                    cmd.CommandText = "UPDATE OSPATAR SET nume=\'" + ospatar.Nume + "\', telefon=\'" + ospatar.Telefon + "\' where nr_ospatar=" + ospatar.NumarOspatar;
                    Console.WriteLine(cmd.CommandText);
                    cmd.ExecuteNonQuery();
                    return true;
                }

            }
            catch (Exception e)
            {
                // afișare fereastră in caz de eroare
                MessageBox.Show("Eroare la actualizarea ospatarilor: " + e.Message.ToString());
                return false;
            }
        }

        #endregion
    }
}
