using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LagerApp_final_
{

    public class Database
    {
        private readonly string _connectionString;

        public Database(string connectionString)
        {
            _connectionString = connectionString;
        }

        //ADD CRUD
        public void AddProdukt(Produkter produkt)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();


            using var command = new SqlCommand("INSERT INTO Produkter ( ProduktID, Navn, SalgsID, Antal, Vaegt, Maal,  Beskrivelse, Dato, Minimumsbeholdning, Maksimumsbeholdning, Moebeltype, Materialer, Kostpris, Salgspris) " +
              "VALUES (@ProduktID, @Navn, @SalgsID, @Antal, @Vaegt, @Maal, @Beskrivelse, @Dato, @Minimumsbeholdning, @Maksimumsbeholdning, @Moebeltype, @Materialer, @Kostpris, @Salgspris)", connection);


            //command.Parameters.AddWithValue("@SalgsID", produkt.SalgsID);
            command.Parameters.AddWithValue("@ProduktID", produkt.ProduktID);
            command.Parameters.AddWithValue("@Navn", produkt.Navn);
            command.Parameters.AddWithValue("@SalgsID", produkt.ProduktID);
			command.Parameters.AddWithValue("@Antal", produkt.Antal);
            command.Parameters.AddWithValue("@Vaegt", produkt.Vaegt);
			command.Parameters.AddWithValue("@Maal", produkt.Maal);
			command.Parameters.AddWithValue("@Beskrivelse", produkt.Beskrivelse);
            command.Parameters.AddWithValue("@Dato", produkt.Dato);
            command.Parameters.AddWithValue("@Minimumsbeholdning", produkt.Minimumsbeholdning);
            command.Parameters.AddWithValue("@Maksimumsbeholdning", produkt.Maksimumsbeholdning);
			command.Parameters.AddWithValue("@Moebeltype", produkt.Moebeltype);
            command.Parameters.AddWithValue("@Materialer", produkt.Materialer);
            command.Parameters.AddWithValue("@Kostpris", produkt.Kostpris);
			command.Parameters.AddWithValue("@Salgspris", produkt.SalgsPris);

            
			command.ExecuteNonQuery();
        }


        //read Read
       public MedarbejderLogin ReadWorker(string username, string password)
        {
            string MedarbejderID = null;
            string Password = null;


            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            using var command = new SqlCommand("SELECT MedarbejderID, Password FROM Medarbejder WHERE MedarbejderID = @username AND Password = @password", connection);

            //Dette gør man kun så der ikke kan laves sql injections
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        MedarbejderID = reader["MedarbejderID"].ToString();
                        Password = reader["Password"].ToString();
                    }
                }


            if (MedarbejderID == null || Password == null)
            {
                return null;
            }

            return new MedarbejderLogin(MedarbejderID, Password);

        }

    }
}
