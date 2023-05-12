using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class Empleado
    {
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private double _toleranciaPeso;

        public double ToleranciaPeso
        {
            get { return _toleranciaPeso; }
            set { _toleranciaPeso = value; }
        }

        public void SubirObjeto(ObjetosDeMudanza objetoDeMudanza, MediosDeTransporte medioDeTransporte){

             if(objetoDeMudanza.Peso> this.ToleranciaPeso)
            {
                throw new ExcepcionPorPeso(string.Format("El empleado {0}, tolera hasta {1}KG, no puede subir el {2} que pesa {3}KG", this.Nombre, this.ToleranciaPeso, objetoDeMudanza.Nombre, objetoDeMudanza.Peso));
            }
            else
            {
                medioDeTransporte.Subir(objetoDeMudanza);
            }     

        }

        public void BajarObjeto(ObjetosDeMudanza objetoDeMudanza, MediosDeTransporte medioDeTransporte)
        {

        }

        public override string ToString()
        {
            return this.Nombre + " " + this.ToleranciaPeso + "KG";
        }
    }
}
