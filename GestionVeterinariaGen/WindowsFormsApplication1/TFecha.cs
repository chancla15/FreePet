using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class TFecha
    {
        /*private int initY, initM, initD;
        private int finY, finM, finD;
        private int Y, M, D;*/
        private DateTime init, fin, today;

      

        public TFecha(DateTime init, DateTime fin)
        {
            this.init = init;
            this.fin = fin;
            today = DateTime.Today;

           /* Y = DateTime.Today.Year;
            M = DateTime.Today.Month;
            D = DateTime.Today.Day;

            initY = init.Year;
            initM = init.Month;
            initD = init.Day;

            finY = init.Year;
            finM = fin.Month;
            finD = fin.Day;*/
        }

        public Boolean Validar()
        {
            Boolean ret = false;

            if (init >= today && fin >= today && init <= fin)
                ret = true;
                
            /*if (initY >= Y && initM >= M && initD >= D && finY >= Y && finM >= M && finD >= D)
                if (initY <= finY && initM <= finM && initD <= finD)
                    ret = true;*/

            return ret;
        }
    }
}
