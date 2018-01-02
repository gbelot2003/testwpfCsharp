using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("UnitTestProject1")]

namespace WpfApp1.Prestaciones
{
    class Prestaciones
    {
        private String inicio;
        private String final;
        private Decimal salario;

        public Prestaciones(String inicio, String final, Decimal salario)
        {
            this.inicio = inicio;
            this.final = final;
            this.salario = salario;
        }

        /// <summary>
        /// Serializa fechas para calculos posteriores
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        private DateTime convertToDatePartial(String date)
        {
            DateTime dates = DateTime.ParseExact(date, "yyyy-MM-dd", null);
            return dates;
        }

        /// <summary>
        /// Calcula cantidad de años
        /// </summary>
        /// <returns></returns>
        public int getYears()
        {
            /// Retorna el total de años
            DateTime zeroTime = new DateTime(1, 1, 1);

            DateTime a = this.convertToDatePartial(this.inicio);
            DateTime b = this.convertToDatePartial(this.final);

            TimeSpan span = b - a;
            // Because we start at year 1 for the Gregorian
            // calendar, we must subtract a year here.
            int years = (zeroTime + span).Year - 1;

            return years;
        }

        /// <summary>
        /// Calcula dias Promedio + 1
        /// </summary>
        /// <returns></returns>
        public int getDays()
        {
            // returna el total Dias Promedio
            return 0;
        }

        private Double getPreAviso()
        {
            Double result = Convert.ToDouble("0,00");
            return result;
        }

        private Double GetAuxilioCesantia()
        {
            Double result = Convert.ToDouble("0,00");
            return result;
        }

        private Double getAuxilioCesantiaPromedio()
        {
            Double result = Convert.ToDouble("0,00");
            return result;
        }

        protected Double getSUbtotal()
        {
            Double result = Convert.ToDouble("0,00");
            return result;
        }



        
    }
}
