using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tarea1.funciones;

namespace tarea1
{
    public partial class Form1 : Form
    {
        int[,] matriz7w7 = new int[3, 3];
        bool click = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            click = true;
            if (click)
            {
                var estructura = new clsEstructura().cargaDatosXLS();
                string info = "";
                int i = 0;
                foreach (var datos in estructura)
                {
                    matriz7w7[i, 0] = datos.A;
                    matriz7w7[i, 1] = datos.B;
                    matriz7w7[i, 2] = datos.C;
                    info += matriz7w7[i, 0] + "\t" + matriz7w7[i, 1] + "\t" + matriz7w7[i, 2] + "\r\n";
                    i++;
                }
                txtMatriz.Text = info;
            }
        }


        private void btn_resolver_Click(object sender, EventArgs e)
        {
            clsFunciones f = new clsFunciones();
               click = false;
               string info = "";
               int fila=f.buscarCero(matriz7w7); //busca la fila y columna donde esta obicado el 0


            //multiplica una fila por otra guardando resultados hasta poder llegar al numero de ceros deseado
            for (int i = 0; i <2; i++)
               {
                   //fila 1 * 2
                   for(int j = 0; j < 3; j++)
                   {
                       matriz7w7[i, j] = matriz7w7[i, j] * matriz7w7[i+1, j];//1*2
                       matriz7w7[i+1, j] = matriz7w7[i, j] * matriz7w7[i+1, j];//2*1 /3*1/1*3
                       matriz7w7[2, j] = matriz7w7[2, j] * matriz7w7[i, j];
                       matriz7w7[i, j] = matriz7w7[i, j] * matriz7w7[2, j];
                   }                                                          

               }
            //convierte en 0 la fila donde estaba ubicado el primer cero
            for (int i = 0; i < 3; i++)
            {
                matriz7w7[fila, i] = 0;
            }
            
          
            var estructura = new clsEstructura();
            estructura.insertarDatos(matriz7w7);
            int x = 0;
            foreach(var datos in estructura.cargaDatosXLS())
            {
                matriz7w7[x, 0] = datos.A;
                matriz7w7[x, 1] = datos.B;
                matriz7w7[x, 2] = datos.C;
                info += matriz7w7[x, 0] + "\t" + matriz7w7[x, 1] + "\t" + matriz7w7[x, 2] + "\r\n";
                x++;
            }
            txtMatriz.Text = info;

        }

        private void btn_aleatorio_Click(object sender, EventArgs e)
        {
            clsFunciones a = new clsFunciones();
            var estructura = new clsEstructura();
            a.reiniciar(matriz7w7);
            matriz7w7[a.aleatoriouwu(),a.aleatoriouwu()] = 0;

            estructura.insertarDatos(matriz7w7);
            int i = 0;
            string info="";
            foreach (var datos in estructura.cargaDatosXLS())
            {
                matriz7w7[i, 0] = datos.A;
                matriz7w7[i, 1] = datos.B;
                matriz7w7[i, 2] = datos.C;
                info += matriz7w7[i, 0] + "\t" + matriz7w7[i, 1] + "\t" + matriz7w7[i, 2] + "\r\n";
                i++;
            }
            txtMatriz.Text = info;

        }
    }
}
