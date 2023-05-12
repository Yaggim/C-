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
    public partial class MostrarObjetosDelCamion : Form
    {
        public MostrarObjetosDelCamion()
        {
            InitializeComponent();
        }

        private MediosDeTransporte _medioDeTrasporte;

        public MediosDeTransporte MediosDeTransporte
        {
            get { return _medioDeTrasporte; }
            set { _medioDeTrasporte = value; }
        }


        private void MostrarObjetosDelCamion_Load(object sender, EventArgs e)
        {
            this.grillaDeObjetosDelCamion.DataSource = _medioDeTrasporte.ObjetosMostrados;
            
        }
    }
}
