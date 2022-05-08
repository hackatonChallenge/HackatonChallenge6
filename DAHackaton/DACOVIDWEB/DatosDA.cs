using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACOVIDWEB
{
    public class DatosDA
    {

        public static List<datos> getDatos()
        {

            using (var data = new HackatonEntities())
            {

                data.Configuration.LazyLoadingEnabled = false;

                return data.datos.ToList();

            }

        }


    }
}
