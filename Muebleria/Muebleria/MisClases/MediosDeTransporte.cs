using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public abstract class MediosDeTransporte
    {
        private string _patente;

        public string Patente
        {
            get { return _patente; }
            set { _patente = value; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        private List<ObjetosDeMudanza> _objetosFragiles = new List<ObjetosDeMudanza>();

        public List<ObjetosDeMudanza> ObjetosFragiles
        {
            get { return _objetosFragiles; }
            set { _objetosFragiles = value; }
        }

        private List<ObjetosDeMudanza> _objetosNoFragiles = new List<ObjetosDeMudanza>();

        public List<ObjetosDeMudanza> ObjetosNoFragiles 
        {
            get { return _objetosNoFragiles; }
            set { _objetosNoFragiles = value; }
        }

        private List<ObjetosDeMudanza> _objetosMostrados = new List<ObjetosDeMudanza>();

        public List<ObjetosDeMudanza> ObjetosMostrados
        {
            get { return _objetosMostrados; }
            set { _objetosMostrados = value; }
        }


        public abstract void Subir(ObjetosDeMudanza objetoDeMudanza);

        public void Quitar(ObjetosDeMudanza objetoDeMudanza)
        {

        }


    }
}
