using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class ArchivoTexto
    {
        public string texto;
        public string path;
        public enum eModo { LECTURA, ESCRITURA }
        
        public ArchivoTexto(string path)
        {
            this.path = path;
            this.AbrirArchivo(eModo.LECTURA);
        }

        public void AbrirArchivo(eModo modo)
        { 
            if (modo == eModo.LECTURA)
            {
                StreamReader miArchivo = new StreamReader(this.path);
                this.texto = miArchivo.ReadToEnd();
            }
        }


    }
}
