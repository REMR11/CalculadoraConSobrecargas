using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MR100823
{
    /// <summary>
    /// Clase que registra operaciones realizadas en tiempo de ejecucion
    /// </summary>
    /// <remarks>
    /// <autor>Ronald Mejia</autor>
    /// MR100823
    /// </remarks>
    internal class HistorialOperaciones
    {
        /// <summary>
        /// Lista de operaciones registradas
        /// </summary>
        private ICollection<string> operaciones;

        /// <summary>
        /// Constructor vacio que inicializa una nueva lista vacia
        /// </summary>
        public HistorialOperaciones()
        {
            operaciones = new List<string>();
        }

        /// <summary>
        /// Metodo que se encarga de registrar nuevas operaciones
        /// </summary>
        /// <param name="pOperacion"></param>
        public void RegistrarOperacion(string pOperacion) { 
            operaciones.Add("|"+DateTime.Now + "| " + pOperacion+"\t\t|");

        }

        /// <summary>
        /// Metodo que se encarga de devolver la lista de operaciones realizadas
        /// </summary>
        /// <returns>Historial de operaciones</returns>
        public List<string> GetOperaciones()
        {
            return operaciones.ToList();
        }
    }
}
