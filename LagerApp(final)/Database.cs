using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;
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

        public void AddRaavare(Raavare raavare)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            using var command = new SqlCommand("INSERT INTO Raavare (Navn, Antal, Minimumsbeholdning, Maksimumsbeholdning, Maal, Vaegt, Lokation, MaterialeID, MaterialeType) " +
            "VALUES (@Navn, @Antal, @Minimumsbeholdning, @Maksimumsbeholdning, @Maal, @Vaegt, @Lokation, @MaterialeID, @MaterialeType)", connection);


            //Dette er for at forhindre SQL Injections//
            command.Parameters.AddWithValue("@Navn", raavare.Navn);
            command.Parameters.AddWithValue("@Antal", raavare.Antal);
            command.Parameters.AddWithValue("@Minimumsbeholdning", raavare.Minimumsbeholdning);
            command.Parameters.AddWithValue("@Maksimumsbeholdning", raavare.Maksimumsbeholdning);
            command.Parameters.AddWithValue("@Maal", raavare.Maal);
            command.Parameters.AddWithValue("@Vaegt", raavare.Vaegt);
            command.Parameters.AddWithValue("@Lokation", raavare.Lokation);
            command.Parameters.AddWithValue("@MaterialeID", raavare.MaterialeID);
            command.Parameters.AddWithValue("@MaterialeType", raavare.MaterialeType);


            command.ExecuteNonQuery();

        }





        public void SaveUpdatedProdukt(Produkter produkt)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var query = @"UPDATE Produkter
                  SET Navn = @Navn, 
                      SalgsID = @SalgsID, 
                      Antal = @Antal, 
                      Vaegt = @Vaegt, 
                      Maal = @Maal, 
                      Beskrivelse = @Beskrivelse, 
                      Dato = @Dato, 
                      Minimumsbeholdning = @Minimumsbeholdning, 
                      Maksimumsbeholdning = @Maksimumsbeholdning, 
                      Moebeltype = @Moebeltype, 
                      Materialer = @Materialer, 
                      Kostpris = @Kostpris, 
                      SalgsPris = @SalgsPris
                  WHERE ProduktID = @ProduktID";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ProduktID", produkt.ProduktID);
            command.Parameters.AddWithValue("@Navn", produkt.Navn ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@SalgsID", produkt.SalgsID);
            command.Parameters.AddWithValue("@Antal", produkt.Antal);
            command.Parameters.AddWithValue("@Vaegt", produkt.Vaegt ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Maal", produkt.Maal ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Beskrivelse", produkt.Beskrivelse ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Dato", produkt.Dato ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Minimumsbeholdning", produkt.Minimumsbeholdning);
            command.Parameters.AddWithValue("@Maksimumsbeholdning", produkt.Maksimumsbeholdning);
            command.Parameters.AddWithValue("@Moebeltype", produkt.Moebeltype ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Materialer", produkt.Materialer ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Kostpris", produkt.Kostpris);
            command.Parameters.AddWithValue("@SalgsPris", produkt.SalgsPris);

            command.ExecuteNonQuery();


        }

		public void SaveUpdatedRaavare(Raavare raavare)
		{
			using var connection = new SqlConnection(_connectionString);
			connection.Open();

			var query = @"UPDATE Raavare
          SET Navn = @Navn, 
              Antal = @Antal, 
              Vaegt = @Vaegt, 
              Maal = @Maal, 
              Maksimumsbeholdning = @Maksimumsbeholdning, 
              Minimumsbeholdning = @Minimumsbeholdning, 
              Lokation = @Lokation, 
              MaterialeType = @MaterialeType
              WHERE MaterialeID = @MaterialeID";

			using var command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@MaterialeID", raavare.MaterialeID);
			command.Parameters.AddWithValue("@Navn", raavare.Navn ?? (object)DBNull.Value);
			command.Parameters.AddWithValue("@Antal", raavare.Antal);
			command.Parameters.AddWithValue("@Vaegt", raavare.Vaegt);
			command.Parameters.AddWithValue("@Maal", raavare.Maal);
			command.Parameters.AddWithValue("@Maksimumsbeholdning", raavare.Maksimumsbeholdning);
			command.Parameters.AddWithValue("@Minimumsbeholdning", raavare.Minimumsbeholdning);
			command.Parameters.AddWithValue("@Lokation", raavare.Lokation ?? (object)DBNull.Value);
			command.Parameters.AddWithValue("@MaterialeType", raavare.MaterialeType ?? (object)DBNull.Value);

			command.ExecuteNonQuery();


		}



        //Ordre Update
        public void UpdateOrdre(Ordre ordre)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            using var command = new SqlCommand("UPDATE Ordre SET Info = @Info, Dato = @Dato, Levandor = @Leverandoer WHERE OrdreID = @OrdreID", connection);
            command.Parameters.AddWithValue("@Info", ordre.Info);
            command.Parameters.AddWithValue("@Dato", ordre.Dato);
            command.Parameters.AddWithValue("@Leverandoer", ordre.Leverandoer);
            command.Parameters.AddWithValue("@OrdreID", ordre.OrdreId);


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


        //Read Kunde
        public List<Ordre> ReadAllKunde()
        {
            var ordreliste = new List<Ordre>();

            // Connection to SQL
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            using var command = new SqlCommand(
            "Select * From Kunde", connection);



            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var ordre = new Ordre
                {
                    KundeID = reader.GetInt32(0),        // OrdreID
                    KundeNavn = reader.GetString(1),     // Kunde Name
                    TlfNummer = reader.GetInt32(2),     // Kunde Name
                };

                ordreliste.Add(ordre);
            }

            return ordreliste;
        }

        //Read Ordre (inkl Kunde)
        public List<Ordre> ReadOrdre(int userInput)
        {
            var ordreliste = new List<Ordre>();

            // Connection to SQL
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            using var command = new SqlCommand(
            "Select Ordre.OrdreID, Kunde.KundeID, Kunde.Navn, Ordre.Info, Ordre.Dato, Ordre.Levandor, Kunde.TlfNummer " +
            "FROM Ordre " +
            "INNER JOIN Kunde ON  Ordre.KundeID = Kunde.KundeID WHERE Kunde.KundeID = @KundeID", connection);

            // Use parameterized query to prevent SQL injection
            command.Parameters.AddWithValue("@KundeID", userInput);

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var ordre = new Ordre
                {
                    OrdreId = reader.GetInt32(0),        // OrdreID
                    KundeID = reader.GetInt32(1),        // KundeID
                    KundeNavn = reader.GetString(2),     // Kunde Name
                    Info = reader.GetString(3),          // Info
                    Dato = reader.GetString(4),          // Dato (converted to string)
                    Leverandoer = reader.GetString(5),    // Leverandør
                    TlfNummer = reader.GetInt32(6)    // Leverandør
                };

                ordreliste.Add(ordre);
            }

            return ordreliste;
        }

        public List<Produkter> ReadProdukt(int userinput)
        {

            var produktListe = new List<Produkter>();

            using var connection = new SqlConnection(_connectionString);
            connection.Open();


            using var command = new SqlCommand("SELECT * FROM Produkter WHERE ProduktID = @ProduktID", connection);
            command.Parameters.AddWithValue("@ProduktID", userinput);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var produkt = new Produkter
                {
                    ProduktID = reader.GetInt32(0),
                    Navn = reader.GetString(1),
                    SalgsID = reader.GetInt32(2),
                    Antal = reader.GetInt32(3),
                    Vaegt = reader.GetString(4),
                    Maal = reader.GetString(5),
                    Beskrivelse = reader.GetString(6),
                    Dato = reader.GetString(7),
                    Minimumsbeholdning = reader.GetInt32(8),
                    Maksimumsbeholdning = reader.GetInt32(9),
                    Moebeltype = reader.GetString(10),
                    Materialer = reader.GetString(11),
                    Kostpris = reader.GetInt32(12),
                    SalgsPris = reader.GetInt32(13),

                };

                produktListe.Add(produkt);
            }

            return produktListe;



        }

        public List<Produkter> ReadAllProdukt()
        {

            var produktListe = new List<Produkter>();

            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            

            using var command = new SqlCommand("SELECT * FROM Produkter ", connection);
           
            using var reader = command.ExecuteReader();


            while (reader.Read())
            {
                var produkt = new Produkter
                {
                    ProduktID = reader.GetInt32(0),
                    Navn = reader.GetString(1),
                    SalgsID = reader.GetInt32(2),
                    Antal = reader.GetInt32(3),
                    Vaegt = reader.GetString(4),
                    Maal = reader.GetString(5),
                    Beskrivelse = reader.GetString(6),
                    Dato = reader.GetString(7),
                    Minimumsbeholdning = reader.GetInt32(8),
                    Maksimumsbeholdning = reader.GetInt32(9),
                    Moebeltype = reader.GetString(10),
                    Materialer = reader.GetString(11),
                    Kostpris = reader.GetInt32(12),
                    SalgsPris = reader.GetInt32(13),

                };

                produktListe.Add(produkt);
            }

            return produktListe;

        }

        //ReadAllRaavare
        public List<Raavare> ReadAllRaavare()
        {

            var raavareListe = new List<Raavare>();
            using var connection = new SqlConnection(_connectionString);
            connection.Open();


            using var command = new SqlCommand("SELECT * FROM Raavare", connection);

            using var reader = command.ExecuteReader();


            while (reader.Read())
            {
                var raavare = new Raavare
                {
                    Navn = reader.GetString(0),
                    Antal = reader.GetInt32(1),
                    Minimumsbeholdning = reader.GetInt32(2),
                    Maksimumsbeholdning = reader.GetInt32(3),
                    Maal = reader.GetString(4),
                    Vaegt = reader.GetInt32(5),
                    Lokation = reader.GetString(6),
                    MaterialeID = reader.GetInt32(7),
                    MaterialeType = reader.GetString(8),
                };

                raavareListe.Add(raavare);
            }

            return raavareListe;

        }

        //readraavare
        public List<Raavare> ReadRaavare(int userinput)
        {

            var raavareListe = new List<Raavare>();
            using var connection = new SqlConnection(_connectionString);
            connection.Open();


            using var command = new SqlCommand("SELECT * FROM Raavare WHERE MaterialeID = @MaterialeID", connection);
            command.Parameters.AddWithValue("@MaterialeID", userinput);
            using var reader = command.ExecuteReader();


            while (reader.Read())
            {
                var raavare = new Raavare
                {
                    Navn = reader.GetString(0),
                    Antal = reader.GetInt32(1),
                    Minimumsbeholdning = reader.GetInt32(2),
                    Maksimumsbeholdning = reader.GetInt32(3),
                    Maal = reader.GetString(4),
                    Vaegt = reader.GetInt32(5),
                    Lokation = reader.GetString(6),
                    MaterialeID = reader.GetInt32(7),
                    MaterialeType = reader.GetString(8),


                };

                raavareListe.Add(raavare);
            }

            return raavareListe;




        }

        public void ExportToCsv(int userinput, string filePath)
        {
            //Henter liste fra Readprodukt
            var produktListe = ReadProdukt(userinput);

            var header = "ProduktID,Navn,SalgsID,Antal,Vaegt,Maal,Beskrivelse,Dato,Minimumsbeholdning,Maksimumsbeholdning,Moebeltype,Materialer,Kostpris,SalgsPris";

            
            var rows = new List<string> { header };

            // Loop igennem ProduktListe og lav en CSV row
            foreach (var produkt in produktListe)
            {
                var row = $"{produkt.ProduktID}," +
                          $"{EscapeCsv(produkt.Navn)}," +
                          $"{produkt.SalgsID}," +
                          $"{produkt.Antal}," +
                          $"{EscapeCsv(produkt.Vaegt)}," +
                          $"{EscapeCsv(produkt.Maal)}," +
                          $"{EscapeCsv(produkt.Beskrivelse)}," +
                          $"{EscapeCsv(produkt.Dato)}," +
                          $"{produkt.Minimumsbeholdning}," +
                          $"{produkt.Maksimumsbeholdning}," +
                          $"{EscapeCsv(produkt.Moebeltype)}," +
                          $"{EscapeCsv(produkt.Materialer)}," +
                          $"{produkt.Kostpris}," +
                          $"{produkt.SalgsPris}";

                rows.Add(row);
            }

            // Write the rows to the CSV file
            File.WriteAllLines(filePath, rows);
        }

        // Helper method to escape CSV values (handle commas and quotes in data)
        private string EscapeCsv(string value)
        {
            if (value.Contains(",") || value.Contains("\""))
            {
                // Escape quotes by doubling them
                value = "\"" + value.Replace("\"", "\"\"") + "\"";
            }
            return value;
        }


        public void DeleteProdukt(int produktID)
        {
            try
            {
                using var connection = new SqlConnection(_connectionString);
                connection.Open();

                using var command = new SqlCommand("DELETE FROM Produkter WHERE ProduktID = @ProduktID", connection);
                command.Parameters.AddWithValue("@ProduktID", produktID);

                // Udfør DELETE og få antal rækker påvirket
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                   MessageBox.Show("Posten blev slettet!");
                }
                else
                {
                    MessageBox.Show("Ingen post fundet med det ID.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Databasefejl: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"En fejl opstod: {ex.Message}");
            }
            
        }

       

        public Produkter GetProduktById(int produktId)
		{
			using var connection = new SqlConnection(_connectionString);
			connection.Open();

			using var command = new SqlCommand("SELECT * FROM Produkter WHERE ProduktID = @ProduktID", connection);
			command.Parameters.AddWithValue("@ProduktID", produktId);

			using var reader = command.ExecuteReader();

			if (reader.Read())
			{
				return new Produkter
				{
					ProduktID = reader.GetInt32(0),
					Navn = reader.GetString(1),
					SalgsID = reader.GetInt32(2),
					Antal = reader.GetInt32(3),
					Vaegt = reader.GetString(4),
					Maal = reader.GetString(5),
					Beskrivelse = reader.GetString(6),
					Dato = reader.GetString(7),
					Minimumsbeholdning = reader.GetInt32(8),
					Maksimumsbeholdning = reader.GetInt32(9),
					Moebeltype = reader.GetString(10),
					Materialer = reader.GetString(11),
					Kostpris = reader.GetInt32(12),
					SalgsPris = reader.GetInt32(13),
				};
			}

			return null; // Return null hvis intet er fundet.
		}


        


        public void DeleteRaavare(int materialeID)
        {
            try
            {
                using var connection = new SqlConnection(_connectionString);
                connection.Open();

                using var command = new SqlCommand("DELETE FROM Raavare WHERE MaterialeID = @MaterialeID", connection);
                command.Parameters.AddWithValue("@MaterialeID", materialeID);

                // Udfør DELETE og få antal rækker påvirket
                int rowsAffected1 = command.ExecuteNonQuery();

                if (rowsAffected1 > 0)
                {
                    MessageBox.Show("Råvare blev slettet!");
                }
                else
                {
                    MessageBox.Show("Ingen råvare fundet med det ID.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Databasefejl: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"En fejl opstod: {ex.Message}");
            }

        }



        public Raavare GetRaavareById(int materialeId)
		{
			using var connection = new SqlConnection(_connectionString);
			connection.Open();

			using var command = new SqlCommand("SELECT * FROM Raavare WHERE MaterialeID = @MaterialeID", connection);
			command.Parameters.AddWithValue("@MaterialeID", materialeId);

			using var reader = command.ExecuteReader();

			if (reader.Read())
			{
				return new Raavare
				{
					Navn = reader.GetString(0),
					Antal = reader.GetInt32(1),
					Minimumsbeholdning = reader.GetInt32(2),
					Maksimumsbeholdning = reader.GetInt32(3),
					Maal = reader.GetString(4),
					Vaegt = reader.GetInt32(5),
					Lokation = reader.GetString(6),
					MaterialeID = reader.GetInt32(7),
					MaterialeType = reader.GetString(8)
				};
			}

			return null; // Return null if no product is found.
		}

	}

}



