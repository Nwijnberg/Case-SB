using System;
using Microsoft.Data.Sqlite;

namespace AddressApp.db
{
    public class DataSource
    {

        public SqliteConnection getConnection()
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder();
            connectionStringBuilder.DataSource = "./sqliteDB.db";

            return new SqliteConnection(connectionStringBuilder.ConnectionString);
        }

        public void initializeDatabase()
        {
            using (var connection = getConnection())
            {
                connection.Open();

                // CREATE TABLE
                var tableCmd = connection.CreateCommand();
                tableCmd.CommandText = "CREATE TABLE COUNTRY (COUNTRY_NAME VARCHAR(56) PRIMARY KEY);";
                tableCmd.ExecuteNonQuery();

                tableCmd.CommandText = "CREATE TABLE CITY (CITY_NAME VARCHAR(85) PRIMARY KEY);";
                tableCmd.ExecuteNonQuery();

                tableCmd.CommandText = "CREATE TABLE ADDRESS_DATA (POSTCODE VARCHAR(6), STREET VARCHAR(58) NOT NULL, HOUSE_NUMBER INT(5) NOT NULL, CITY VARCHAR(85) NOT NULL, COUNTRY VARCHAR(56) NOT NULL, CONSTRAINT ADDRESS_DATA_PK PRIMARY KEY (POSTCODE, HOUSE_NUMBER), CONSTRAINT FK_COUNTRY FOREIGN KEY (COUNTRY) REFERENCES COUNTRY(COUNTRY_NAME), CONSTRAINT FK_CITY FOREIGN KEY (CITY) REFERENCES CITY(CITY_NAME));";
                tableCmd.ExecuteNonQuery();

                // INSERT RECORDS
                using (var transaction = connection.BeginTransaction())
                {
                    var insertCmd = connection.CreateCommand();
                    insertCmd.CommandText = "INSERT INTO CITY (CITY_NAME) VALUES ('Venray'), ('Amsterdam'), ('London'), ('Paris'), ('Rome'), ('Berlin'), ('Brussle'), ('Madrid'), ('Luxemburg');";
                    insertCmd.ExecuteNonQuery();

                    insertCmd.CommandText = "INSERT INTO COUNTRY (COUNTRY_NAME) VALUES ('Netherlands'), ('England'), ('France'), ('Italy'), ('Germany'), ('Belgium'), ('Spain'), ('Luxemburg');";
                    insertCmd.ExecuteNonQuery();

                    insertCmd.CommandText = "INSERT INTO ADDRESS_DATA (POSTCODE, STREET, HOUSE_NUMBER, CITY, COUNTRY) VALUES ('5456EE', 'Hoefblad', 11, 'Venray', 'Netherlands'), ('5349RO', 'Glanshof', 11, 'Amsterdam', 'Netherlands'), ('PO17GZ', 'Oxford Street', 11, 'London', 'England'), ('7500WD', 'Rue Montorgueil', 11, 'Paris', 'France'), ('4752KR', 'Via Garibaldi', 521, 'Rome', 'Italy'), ('8569LD', 'Kurfürstendamm', 432, 'Berlin', 'Germany'), ('9843HW', 'Grote Zavel', 13, 'Brussle', 'Belgium'), ('9485WS', 'Paseo de Recoletos', 45, 'Madrid', 'Spain'), ('9487HR', 'Hoornsterzwaag', 343, 'Luxemburg', 'Luxemburg');";
                    insertCmd.ExecuteNonQuery();

                    Console.WriteLine("The database has been created.");
                    transaction.Commit();
                }
            }
        }

    }
}