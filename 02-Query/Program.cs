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
                Console.WriteLine("Conexión con éxito");

                //hacer consulta todos los productos de "Condiments"
                string query = @"
                    SELECT p.ProductName, p.Price
                    FROM products p
                    JOIN categories c ON p.CategoryID = c.CategoryID
                    WHERE c.CategoryName = 'Condiments';
                    ";
                //crear el comando
                using (MySqlCommand cmd = new MySqlCommand(query, conn)) {
                    using (MySqlDataReader dr = cmd.ExecuteReader()) {
                        while (dr.Read()) {
                            Console.WriteLine($"Producto: {dr["ProductName"]}, Precio: {dr["Price"]}");
                        }
                    }
                }

             // manual se cerraría así: conn.Close();
             //cerrar automático al acabar el using conn
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Excepción: {ex.ToString()}");
        }
    }

}
