using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerAlbumDeFotos
{
    internal class Albumdefotos
    {
        private int numDePag;
        private int numFotos;

        public int NumdePag
        {
            get
            {
                return numDePag;
            }
            set
            {
                numDePag = value;
            }
        }

        public int NumFotos
        {
            get
            {
                return numFotos;
            }
            set
            {
                numFotos = value;
            }
        }

        public string Suporta()
        {
            int numTotalDePags = numDePag * 2;
            string AguentaOuNao = "";

            if (numTotalDePags < numFotos)
            {
                AguentaOuNao = "O seu álbum NÃO aguenta todas as suas fotos.";
            }
            else
            {
                AguentaOuNao = "O seu álbum aguenta todas as suas fotos.";
            }

            return AguentaOuNao;
        }
    }
}
