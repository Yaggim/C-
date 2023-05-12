using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class ObjetosDeMudanza
    {

        private double _alto;

        public double Alto
        {
            get { return _alto; }
            set { _alto = value; }
        }

        private double _ancho;

        public double Ancho
        {
            get { return _ancho; }
            set { _ancho = value; }
        }

        private double _largo;

        public double Largo
        {
            get { return _largo; }
            set { _largo = value; }
        }

        private bool _esFragil;

        public bool EsFragil
        {
            get { return _esFragil; }
            set { _esFragil = value; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private double _peso;

        public double Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }

        public double Dimension()
        {
            return 0;
        }

    }
}
