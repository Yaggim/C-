using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisClases
{
    public class Flete : MediosDeTransporte
    {
      
       public override void Subir(ObjetosDeMudanza objetoDeMudanza)
        {
            if (objetoDeMudanza.EsFragil == false)
            {
                this.ObjetosNoFragiles.Add(objetoDeMudanza);
                this.ObjetosMostrados.Add(objetoDeMudanza);
            }
        }



    }
}
