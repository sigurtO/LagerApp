﻿using System;
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


        //read
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


        public List<OrdreLager> ReadOrdre(int userInput)
        {
            var ordreliste = new List<OrdreLager>();
            //Connection til sql
            using var connection = new SqlConnection(_connectionString);
            connection.Open();


            using var command = new SqlCommand("SELECT * FROM Ordre where OrdreID = @OrdreID", connection);
            command.Parameters.AddWithValue("@OrdreID", userInput);

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





