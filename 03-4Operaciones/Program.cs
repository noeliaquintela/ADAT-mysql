using MySql.Data.MySqlClient;

class Programa
{
    static void Main()
    {
        //hay que crear un usuario con permisos en la BBDD (localhost o % dependiendo desde que IP se aborde)
        string cadConexion = "server=localhost;port=3307;user=dam2;password=abc123.;database=w3schools;";
        try
        {
            //conectar
            using (MySqlConnection conn = new MySqlConnection(cadConexion))
            {
                conn.Open();
                //Console.WriteLine("Conexión con éxito");

                //inserción
                //ejemplo de myAdmin
                //INSERT INTO `employees` (`EmployeeID`, `LastName`, `FirstName`, `BirthDate`, `Photo`, `Notes`) VALUES (NULL, 'aaaa', 'bbb', '2025-12-17', NULL, NULL);
                string insertQuery = @"INSERT INTO employees (FirstName, LastName, BirthDate)
                                                    VALUES ('Martín', 'Viso', '1967-07-06')";
                using(MySqlCommand cmdInsert = new MySqlCommand(insertQuery, conn))
                {
                    int filasAfectadas = cmdInsert.ExecuteNonQuery();
                    Console.WriteLine($"Filas/registros/tuplas insertadas: {filasAfectadas}");
                }

                //modificación
                //UPDATE `employees` SET `LastName` = 'Vazquez', `FirstName` = 'Martin' WHERE `employees`.`EmployeeID` = 12;
                string updateQuery = @"UPDATE employees
                                       SET FirstName = 'Martín'
                                       WHERE EmployeeID = 12";
                using (MySqlCommand cmdUpdate = new MySqlCommand(updateQuery, conn))
                {
                    int filasAfectadas = cmdUpdate.ExecuteNonQuery();
                    Console.WriteLine($"Tuplas modificadas: {filasAfectadas}");
                }

                //borrado
                // "DELETE FROM employees WHERE `employees`.`EmployeeID` = 13"
                string deleteQuery = @"DELETE
                                       FROM employees
                                       WHERE EmployeeID = 12";
                using (MySqlCommand cmdDelete = new MySqlCommand(deleteQuery, conn))
                {
                    int filasAfectadas = cmdDelete.ExecuteNonQuery();
                    Console.WriteLine($"Tuplas borradas: {filasAfectadas}");
                }

                //consulta
                string selectQuery = "SELECT * FROM employees";
                using (MySqlCommand cmdSelect = new MySqlCommand(selectQuery, conn))
                {
                    using (MySqlDataReader dr = cmdSelect.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine($"ID: {dr["EmployeeID"]}, Nombre: {dr["FirstName"]}");
                        }
                    }
                }


                //cerrar automático al acabar el using conn
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Excepción: {ex.ToString()}");
        }
    }

}
