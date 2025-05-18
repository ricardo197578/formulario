using System.Data.SQLite;
using System.IO;

namespace LoginEjemplo
{
    public static class DB
    {
        private static string dbFile = "usuarios.db";
        private static string connectionString = "Data Source=" + dbFile + ";Version=3;";

        public static string ConnectionString
        {
            get { return connectionString; }
        }

        public static void InitializeDatabase()
        {
            if (!File.Exists(dbFile))
            {
                SQLiteConnection.CreateFile(dbFile);

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string tableCmd = @"
                        CREATE TABLE Usuarios (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            NombreUsuario TEXT NOT NULL UNIQUE,
                            Contrasena TEXT NOT NULL,
                            Tipo TEXT NOT NULL
                        );

                        INSERT INTO Usuarios (NombreUsuario, Contrasena, Tipo)
                        VALUES 
                            ('admin' , 'admin'),
                            ('socio', 'socio');
                    ";

                    SQLiteCommand cmd = new SQLiteCommand(tableCmd, connection);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

