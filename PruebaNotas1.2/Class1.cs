using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaNotas1._2
{
    public class EstadisticasNotas  // esta clase nos calcula las estadísticas de un conjunto de notas
    {
        private int suspensos;  // Suspensos
        private int aprobados;  // Aprobados
        private int notables;  // Notables
        private int sobresalientes;  // Sobresalientes

        private double media;  // Nota media

        public int Suspensos
        {
            get => suspensos;
            set => suspensos = value;
        }
        public int Aprobados
        {
            get => aprobados;
            set => aprobados = value;
        }
        public int Notables
        {
            get => notables;
            set => notables = value;
        }
        public int Sobresalientes
        {
            get => sobresalientes;
            set => sobresalientes = value;
        }
        public double Media
        {
            get => media;
            set => media = value;
        }

        // Constructor vacío
        public EstadisticasNotas()
        {
            Suspensos = Aprobados = Notables = Sobresalientes = 0;  // inicializamos las variables
            Media = 0.0;
        }

        // Constructor a partir de un array, calcula las estadísticas al crear el objeto
        public EstadisticasNotas(List<int> listaNota)
        {
            Media = 0.0;

            for (int i = 0; i < listaNota.Count; i++)
            {
                if (listaNota[i] < 5)
                {
                    Suspensos++;  // Por debajo de 5 suspenso
                }
                else if (listaNota[i] > 5 && listaNota[i] < 7)
                {
                    Aprobados++;  // Nota para aprobar: 5
                }
                else if (listaNota[i] > 7 && listaNota[i] < 9)
                {
                    Notables++;  // Nota para notable: 7
                }
                else if (listaNota[i] > 9)
                {
                    Sobresalientes++;  // Nota para sobresaliente: 9
                }

                Media += listaNota[i];
            }

            Media /= listaNota.Count;
        }


        // Para un conjunto de listnot, calculamos las estadísticas
        // calcula la media y el número de suspensos/aprobados/notables/sobresalientes
        //
        // El método devuelve -1 si ha habido algún problema, la media en caso contrario	
        public double CalcularEstadisticas(List<int> listaNota)
        {
            Media = 0.0;

            //x TODO: hay que modificar el tratamiento de errores para generar excepciones
            //
            if (listaNota.Count <= 0)  // Si la lista no contiene elementos, devolvemos un error
            {
                throw new ArgumentOutOfRangeException("Error, la lista no contiene elementos");
            }

            //return -1;

            for (int i = 0; i < 10; i++)
                if (listaNota[i] < 0 || listaNota[i] > 10)  // comprobamos que las not están entre 0 y 10 (mínimo y máximo), si no, error
                {
                    throw new ArgumentOutOfRangeException("Error, Las notas no están entre el mínimo y máximo");
                }

            //return -1;

            for (int i = 0; i < listaNota.Count; i++)
            {
                if (listaNota[i] < 5)
                {
                    Suspensos++;  // Por debajo de 5 suspenso
                }
                else if (listaNota[i] >= 5 && listaNota[i] < 7)
                {
                    Aprobados++;  // Nota para aprobar: 5
                }
                else if (listaNota[i] >= 7 && listaNota[i] < 9)
                {
                    Notables++;  // Nota para notable: 7
                }
                else if (listaNota[i] > 9)
                {
                    Sobresalientes++;  // Nota para sobresaliente: 9
                }

                Media += listaNota[i];
            }

            Media /= listaNota.Count;

            return Media;
        }
    }
}
