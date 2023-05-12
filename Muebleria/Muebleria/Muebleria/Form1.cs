using MisClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Muebleria
{
    public partial class AgregarObjetosAlCamion : Form
    {
        public AgregarObjetosAlCamion()
        {
            InitializeComponent();
        }

        private EmpresaDeMudanza objEmpresaDeMudanza;
        /// <summary>
        /// Inicializamos la empresa de transporte, con una flota de camiones/fletes agregandolos a una lista, tambien empleados agregandolos a otra lista
        /// Creamos un lbox para mostrar el listado de camiones y fletes, creamos un segundo lbox para mostrar el listado de empleados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            objEmpresaDeMudanza = new EmpresaDeMudanza();
            Camion camion1 = new Camion();
            camion1.Nombre = "Camion1";
            camion1.Patente = "boc123";

            Camion camion2 = new Camion();
            camion2.Nombre = "Camion2";
            camion2.Patente = "riv000";
            Flete flete = new Flete();
            flete.Nombre = "flete1";
            flete.Patente = "sal000";

            objEmpresaDeMudanza.MediosDeTransportes.Add(camion1);
            objEmpresaDeMudanza.MediosDeTransportes.Add(camion2);
            objEmpresaDeMudanza.MediosDeTransportes.Add(flete);

            Empleado cadete1 = new Empleado();
            cadete1.Nombre = "Juan";
            cadete1.ToleranciaPeso = 70;

            Empleado cadete2 = new Empleado();
            cadete2.Nombre = "Roberto";
            cadete2.ToleranciaPeso = 50;

            objEmpresaDeMudanza.Empleados.Add(cadete1);
            objEmpresaDeMudanza.Empleados.Add(cadete2);

            lboxMediosDeTransporte.DataSource = objEmpresaDeMudanza.MediosDeTransportes;
            lboxMediosDeTransporte.DisplayMember = "Nombre";

            lboxEmpleados.DataSource = objEmpresaDeMudanza.Empleados;
            //lboxEmpleados.DisplayMember = "Nombre";


        }
        /// <summary>
        /// Agregamos el boton agregar al camion que cuando se le da click, instancia un objeto de mudanza y toma los valores introducidos en los tbox, nbox y cbox del form
        /// selecciona un medio de transporte y empleado del lbox e intenta subir el objeto al medio de transporte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarAlCamion_Click(object sender, EventArgs e)
        {
            ObjetosDeMudanza objetoDeMudanza1 = new ObjetosDeMudanza();
            objetoDeMudanza1.EsFragil = cboxEsFragil.Checked;
            objetoDeMudanza1.Alto = (double)nboxAlto.Value;
            objetoDeMudanza1.Ancho = (double)nboxAncho.Value;
            objetoDeMudanza1.Largo = (double)nboxLargo.Value;
            objetoDeMudanza1.Peso = (double)nboxPeso.Value;
            objetoDeMudanza1.Nombre = tboxNombre.Text;

            Empleado empleadoSeleccionado = (Empleado)lboxEmpleados.SelectedValue;

            MediosDeTransporte medioDeTransporteSeleccionado = (MediosDeTransporte)lboxMediosDeTransporte.SelectedValue;

            try
            {
                empleadoSeleccionado.SubirObjeto(objetoDeMudanza1, medioDeTransporteSeleccionado);
                MessageBox.Show(string.Format("El objeto {0} se ha subido con exito", objetoDeMudanza1.Nombre));
            }
            catch (ExcepcionPorPeso objExcepcion)
            {

                MessageBox.Show(objExcepcion.Mensaje);
            }
            
        }

        private void btnMostrarObjetosDelCamion_Click(object sender, EventArgs e)
        {
            MostrarObjetosDelCamion formularioMostrarGrilla = new MostrarObjetosDelCamion();
            formularioMostrarGrilla.MediosDeTransporte = (MediosDeTransporte)lboxMediosDeTransporte.SelectedValue;
            formularioMostrarGrilla.Show();
        }
    }
}
