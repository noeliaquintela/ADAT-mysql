using MySql.Data.MySqlClient;

class Programa {
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
            }
            //procesar

                //cerrar
        }
        catch (Exception ex) { 
            Console.WriteLine($"Excepción: {ex.ToString()}");
        }
    }

}
