using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static LagerApp_final_.Ordre;

namespace LagerApp_final_
{

    public class Database
    {
        private readonly string _connectionString;

        public Database(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddProdukt(Produkter produkt)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();


            using var command = new SqlCommand("INSERT INTO Produkter ( Navn, Beskrivelse, Dato, Minimumsbeholdning, Maksimumsbeholdning, Pris) " +
              "VALUES (@Navn, @Beskrivelse, @Dato, @Minimumsbeholdning, @Maksimumsbeholdning, @Pris)", connection);


            //command.Parameters.AddWithValue("@SalgsID", produkt.SalgsID);
            command.Parameters.AddWithValue("@Navn", produkt.Navn);
            command.Parameters.AddWithValue("@Beskrivelse", produkt.Beskrivelse);
            command.Parameters.AddWithValue("@Dato", produkt.Dato);
            command.Parameters.AddWithValue("@Minimumsbeholdning", produkt.Minimumsbeholdning);
            command.Parameters.AddWithValue("@Maksimumsbeholdning", produkt.Maksimumsbeholdning);
            command.Parameters.AddWithValue("@Pris", produkt.Pris);

            command.ExecuteNonQuery();
        }


        //read
        public MedarbejderLogin ReadWorker(string username, string password)
        {
            string MedarbejderID = null;
            string Password = null;


            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            using var command = new SqlCommand("SELECT MedarbejderID, Password FROM Medarbejder WHERE MedarbejderID = @username AND Password = @password", connection);

            //Dett gør man kun så der ikke kan laves sql injections
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


        public List<OrdreLager> ReadOrdre()
        {
            var ordreliste = new List<OrdreLager>();
            //Connection til sql
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            string query = "SELECT * FROM Ordre";

            using var command = new SqlCommand(query, connection);

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var ordre = new OrdreLager
                {
                    OrdreId = reader.GetInt32(0),        // OrdreID
                    Info = reader.GetString(1),         // Info
                    Dato = reader.GetString(2), // Dato (konverteres til streng)
                    KundeID = reader.GetInt32(3),       // KundeID
                    Leverandoer = reader.GetString(4)    // Leverandør
                };

                ordreliste.Add(ordre);
            }

            return ordreliste;
        }




    }
}





