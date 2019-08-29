using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Numeros
    {
        private int i, f;
        public Numeros(int i, int f)
        {
            if (f > i)
            {
                this.i = i;
                this.f = f;
            }
        }
        private int[] termos = new int[100];
        public int[] Calcular(bool impar, bool par)
        {
            if (par && impar)
            {
                int cont = 0;
                for (int j = 0; j <= f - i; j++)
                {
                    termos[j] = i + j;
                    cont++;
                }
                int[] retorno = new int[cont];
                Array.Copy(termos, retorno, cont);
                return retorno;
            }
            else if (par)
            {
                int cont = 0;
                if (i % 2 == 0) i++;
                for (int j = 0; j <= (f - i) / 2; j++)
                {
                    termos[j] = i + j * 2;
                    cont++;
                }
                int[] retorno = new int[cont];
                Array.Copy(termos, retorno, cont);
                return retorno;
            }
            else if (impar)
            {
                int cont = 0;
                if (i % 2 != 0) i++;
                for (int j = 0; j <= (f - i) / 2; j++)
                {
                    termos[j] = i + j * 2;
                    cont++;
                }
                int[] retorno = new int[cont];
                Array.Copy(termos, retorno, cont);
                return retorno;
            }
            return termos;
        }
    }
}
