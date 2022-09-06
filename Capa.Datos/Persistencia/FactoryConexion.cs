using System;
using System.Configuration;
using System.Text;


class FactoryConexion
{
    public static string CreateConnection()
    {
        return ConfigurationManager.ConnectionStrings["prueba.Properties.Settings.Cadena"].ConnectionString;
    }

}

