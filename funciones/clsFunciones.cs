using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1.funciones
{
    class clsFunciones
    {

        /*
         * 1,1,1  f2*f1=1,0,1 
         * 1,0,1  f2*0= 0,0,0
         * 1,1,1  f2*f3=1,0,1
         * 
         * 1,1,0  f2*f1=1,1,0
         * 1,1,1  f3=0= 0,0,0
         * 1,1,1  f2*f3=1,1,0
         */
         public int aleatoriouwu()
        {
            Random rnd= new Random();
            int numero = rnd.Next(3);
            return numero;
        }

        public void reiniciar(int[,] matriz)
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    matriz[i, j] = 1;
                }
                
            }
        }

        public int buscarCero(int[,] matriz)
        {
            int flocaliz = 0;
            
            for (int x = 0; x < 3; x++)
            {
                for (int z = 0; z < 3; z++)
                {
                    if (matriz[x, z] == 0)
                    {
                       flocaliz = x;
                    }
                }

            }

            return flocaliz;
        }


    }
}
