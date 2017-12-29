using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data
{
    public class Sumador
    {

        int sumando;
        int sumador;

        public Sumador(int sumando, int sumador)
        {
            this.sumando = sumando;
            this.sumador = sumador;
        }
            
        public int proceso()
        {
            return (this.sumando + this.sumador);
        }
    }
}
