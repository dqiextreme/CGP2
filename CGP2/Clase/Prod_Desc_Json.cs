using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using CGP2.Models;

namespace CGP2.Clase
{
    public class Prod_Desc_Json
    {
        //var b = new jsonmeth { cont = "controller", meth = "method", clas = new par { clien = "cliente", otro = "otro" } };
        public void test()
        {
            //var a = new prod_desc { ProductoC = "11", clas = new VST_T3_PRODUCTO_DESCARGA { c_nomb_comer = "1", cproducto = "1", ccompany = "1", ccostobruto_u1 = 1, cname = "1", cnamefc = "1", cprecioventamax = 1, cvendedor = "1" } };
            VST_T3_PRODUCTO_DESCARGA ls = new VST_T3_PRODUCTO_DESCARGA();
            var b = new prod_desc2 { ProductoC = "11", res = ls };
            List<prod_desc2> lst = new List<prod_desc2>();

            lst.Add(b);
        }
        
        public void test2()
        {
            List<VST_T3_PRODUCTO_DESCARGA> ls1 = new List<VST_T3_PRODUCTO_DESCARGA>();
            ls1.Add(new VST_T3_PRODUCTO_DESCARGA { cproducto = "1" });
            //ls1.Add(new VST_T3_PRODUCTO_DESCARGA { cproducto = "2" });

            var a = new prod_desc3 { ProductoC = "1", res = ls1 };

            
        }

        public class prod_desc3
        {
            public string ProductoC { get; set; }
            public List<VST_T3_PRODUCTO_DESCARGA> res { get; set; }
        }

        public class prod_desc2
        {
            public string ProductoC { get; set; }
            public VST_T3_PRODUCTO_DESCARGA res { get; set; }
        }
    }
}