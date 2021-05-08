using BaseDeDatos.Clases.BaseDatos;
using System;
using System.Data;

namespace BaseDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsConexion cn = new ClsConexion();

            DataTable dt = cn.consultaTablaDirecta("SELECT *  FROM [tb_estudiantes1]");

            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine($"Nombre:   {dr[1]}    Parcial 1:    {dr[2]}    Parcial 2:    {dr[3]}    Parcial 3:    {dr[4]}");
            }

            Console.WriteLine("FIN DE DATOS");
        }
    }
}
