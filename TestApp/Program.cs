using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //RestaurantDAO restaurantDAO = new RestaurantDAO();


            /* Console.WriteLine(restaurantDAO.RemoveLogin("ceva"));

            List<Login> ll1 = restaurantDAO.GetLogin();
            foreach (Login l in ll1)
            {
                Console.WriteLine(l);
            }


           // Console.WriteLine(restaurantDAO.AddLogin(new Login("ceva", "ceva",new DateTime(2008,6,1))));
           
            List<Meniu> lm1 = restaurantDAO.GetMeniu();
            foreach (Meniu m in lm1)
            {
                Console.WriteLine(m);
            }

             //Console.WriteLine(restaurantDAO.AddMeniu(new Meniu("ceva")));
            //Console.WriteLine(restaurantDAO.RemoveMeniu("ceva"));

            List<Ospatar> lo1 = restaurantDAO.GetOspatar();
            foreach (Ospatar o in lo1)
            {
                Console.WriteLine(o);
            }

            //Console.WriteLine(restaurantDAO.RemoveOspatar(4));
            Console.WriteLine(restaurantDAO.AddOspatar(new Ospatar(4, "Nichiforeac Cristina", "0745699871", "cristina.nichiforeac")));

            List<Ospatar> lo2 = restaurantDAO.GetOspatar();
            foreach (Ospatar o in lo2)
            {
                Console.WriteLine(o);
            }

           
            // TESTARE SELECT
            // SELECT PE COMENZI + DETALII COMENZI
            List<Comanda> lc1 = restaurantDAO.GetComenzi();

            foreach(Comanda c in lc1)
            {
                Console.WriteLine(c);
            }

            // SELECT PE MASA

          

            List<Masa> lm1 = restaurantDAO.GetMese();

            foreach(Masa m in lm1)
            {
                Console.WriteLine(m);
            }

            // TESTARE INSERT-URI/DELETE-uri
            // Insert masa

            //Console.WriteLine(restaurantDAO.AddMasa(new Masa(7, 3, StatusEnum.Liber)).ToString());


            // Remove masa
            Console.WriteLine(restaurantDAO.RemoveMasa(7).ToString());

            lm1 = restaurantDAO.GetMese();

            foreach (Masa m in lm1)
            {
                Console.WriteLine(m);
            }

            // Insert comanda
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict["Diavolo"] = 1;
            dict["Sprite"] = 1;

            //Console.WriteLine(restaurantDAO.AddComanda(new Comanda(2, Convert.ToDateTime("3.4.2020"), 1, 1,
              // dict)));
            lc1 = restaurantDAO.GetComenzi();

            foreach (Comanda c in lc1)
            {
                Console.WriteLine(c);
            }

            // Delete comanda
            //Console.WriteLine(restaurantDAO.RemoveComanda(2));
            lc1 = restaurantDAO.GetComenzi();

            foreach (Comanda c in lc1)
            {
                Console.WriteLine(c);
            }

            // Update comanda
            Console.WriteLine(restaurantDAO.UpdateComanda(new Comanda(2, Convert.ToDateTime("3.4.2020"), 2, 1, dict)));

            // Add produs
            //Console.WriteLine(restaurantDAO.AddProdus(new Produs("Tzuica", 100, 300, Masura.Litru, "bauturi alcoolice")));

            // Remove produs
            Console.WriteLine(restaurantDAO.RemoveProdus("Tzuica"));
            */
        }
    }
}
