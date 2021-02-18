using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

//

namespace tarea1
{
    class clsEstructura
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        

        public List<clsEstructura> cargaDatosXLS()
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            int rCnt;
            int rw = 0;
            int cl = 0;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(@"C:\tmb\PRUEBA5.xlsx");
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            range = xlWorkSheet.UsedRange;
            rw = range.Rows.Count;
            cl = range.Columns.Count;

            List<clsEstructura> todos = new List<clsEstructura>();
            clsEstructura individual = new clsEstructura();

            for (rCnt = 1; rCnt <= rw; rCnt++)
            {

                individual.A = (int)(range.Cells[rCnt, 1] as Excel.Range).Value2;
                individual.B = (int)(range.Cells[rCnt, 2] as Excel.Range).Value2;
                individual.C = (int)(range.Cells[rCnt, 3] as Excel.Range).Value2;

                todos.Add(individual);
                individual = new clsEstructura();
            }

            xlWorkBook.Close(null, null, null);
            xlApp.Quit();

            
            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            return todos;

        }


        public void insertarDatos(int[,] matriz)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            xlApp = new Excel.Application();
            xlWorkBook= xlApp.Workbooks.Open(@"C:\tmb\PRUEBA5.xlsx");
            //xlApp.Visible = true;

           

            Excel._Worksheet workSheet = (Excel._Worksheet)xlApp.ActiveSheet;

            string[] columna = new string[3];
            columna[0] = "A";
            columna[1] = "B";
            columna[2] = "C";

            for (int i = 1; i < 4; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    workSheet.Cells[i, columna[j]] = matriz[i-1,j];
                }
            }
           
            xlWorkBook.Close(null,null,null);
            xlApp.Quit();
      
            Marshal.ReleaseComObject(workSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
        }
    }


}






