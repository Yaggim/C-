using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class EmpresaDeMudanza
    {
        private List<Empleado> _empleados = new List<Empleado>();

        public List<Empleado> Empleados
        {
            get { return _empleados; }
            set { _empleados =  value; }
        }

        private List<MediosDeTransporte> _mediosDeTransportes = new List<MediosDeTransporte>();

        public List<MediosDeTransporte> MediosDeTransportes
        {
            get { return _mediosDeTransportes; }
            set { _mediosDeTransportes = value; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _sitioWeb;

        public string SitioWeb
        {
            get { return _sitioWeb; }
            set { _sitioWeb = value; }
        }

        private string _telefono;

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
    }
}
