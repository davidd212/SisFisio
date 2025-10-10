using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Cambiar el espacio de nombres importado para usar el paquete correcto
using Microsoft.Data.SqlClient;

namespace SisFisio.Clases
{
    class Empleados
    {
        ConexionClase x = new ConexionClase();
        // Asegurarse de usar Microsoft.Data.SqlClient.SqlConnection
        SqlConnection con = new SqlConnection();

        // Resto del código permanece igual
    }
}
