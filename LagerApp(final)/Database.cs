﻿using System;
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

        public void AddProdukt(Produkter produkt)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();


            using var command = new SqlCommand("INSERT INTO Produkter ( Navn, Beskrivelse, Dato, Minimumsbeholdning, Maksimumsbeholdning) " +
              "VALUES (@Navn, @Beskrivelse, @Dato, @Minimumsbeholdning, @Maksimumsbeholdning)", connection);


            //command.Parameters.AddWithValue("@SalgsID", produkt.SalgsID);
            command.Parameters.AddWithValue("@Navn", produkt.Navn);
            command.Parameters.AddWithValue("@Beskrivelse", produkt.Beskrivelse);
            command.Parameters.AddWithValue("@Dato", produkt.Dato);
            command.Parameters.AddWithValue("@Minimumsbeholdning", produkt.Minimumsbeholdning);
            command.Parameters.AddWithValue("@Maksimumsbeholdning", produkt.Maksimumsbeholdning);

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

    }
}
