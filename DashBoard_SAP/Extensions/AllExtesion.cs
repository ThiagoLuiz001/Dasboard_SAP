using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace System
{
     static class AllExtesion
    {
        /// <summary>
        /// retorna a diferença entre o tamanho pré estabelicido e o tamanho da tela
        /// </summary>
        /// <returns></returns>
        static int GetValue()
        {
            int tam = 1440;
            return tam.CompareTo(Screen.PrimaryScreen.Bounds.Width);
        }
        /// <summary>
        /// retorna o valor em porcetangem da diferença do tamanho
        /// </summary>
        /// <returns></returns>
        static double calc()
        {
            return (100 - (1440 * 100) / Screen.PrimaryScreen.Bounds.Width) / 100.00;
        }
        /// <summary>
        /// Retorna o tamanho da fonte a partir de alteração do tamanho pré estabelecido da tela
        /// </summary>
        /// <param name="font"></param>
        /// <param name="tam"></param>
        /// <returns></returns>
        public static int GetNewHeight(this Font font, int tam)
        {
            double cont = calc();
            if (cont >= 0.12)
            {
                if (GetValue() == -1)
                {
                    return tam + (int)Math.Ceiling(tam * cont);
                }
                if (GetValue() == 1)
                {
                    return tam - (int)Math.Ceiling(tam * cont);
                }
            }
            return tam;
        }
        /// <summary>
        /// Retorna um novo valor de X a partir de alteração do tamanho pré estabelecido da tela 
        /// </summary>
        /// <param name="pt"></param>
        /// <param name="tam"></param>
        /// <returns></returns>
        public static int GetNewSizeX(this Size pt, int tam)
        {
            double cont = calc();
            if (cont >= 0.12) 
            { 
                if (GetValue() == -1)
                {
                    return tam + (int)Math.Ceiling(tam * cont);
                }
                if (GetValue() == 1)
                {
                    return tam - (int)Math.Ceiling(tam * cont);
                }
             }
            return tam;
        }
    }
}
