namespace PruebaNotas1._2
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///  Clase nos calcula las estadísticas de un conjunto de notas.
    /// </summary>
    public class EstadisticasNotas  // 
    {
        /// <summary>
        /// Atributo que define los suspensos.
        /// </summary>
        private int suspensos;

        /// <summary>
        /// Atributo que define los aprobados.
        /// </summary>
        private int aprobados;

        /// <summary>
        /// Atributo que define los notables.
        /// </summary>
        private int notables;

        /// <summary>
        /// Atributo que define los sobresalientes.
        /// </summary>
        private int sobresalientes;

        /// <summary>
        /// Atributo que define la nota  media.
        /// </summary>
        private double media;

        /// <summary>
        /// Gets or sets the Suspensos.
        /// </summary>
        public int Suspensos { get => suspensos; set => suspensos = value; }

        /// <summary>
        /// Gets or sets the Aprobados.
        /// </summary>
        public int Aprobados { get => aprobados; set => aprobados = value; }

        /// <summary>
        /// Gets or sets the Notables.
        /// </summary>
        public int Notables { get => notables; set => notables = value; }

        /// <summary>
        /// Gets or sets the Sobresalientes.
        /// </summary>
        public int Sobresalientes { get => sobresalientes; set => sobresalientes = value; }

        /// <summary>
        /// Gets or sets the Media.
        /// </summary>
        public double Media { get => media; set => media = value; }

        // Constructor vacío
        /// <summary>
        /// Inicializa las variables de la clase <see cref="EstadisticasNotas"/>.
        /// </summary>
        public EstadisticasNotas()
        {
            Suspensos = Aprobados = Notables = Sobresalientes = 0;  // inicializamos las variables
            Media = 0.0;
        }

        // Constructor a partir de un array, calcula las estadísticas al crear el objeto
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="EstadisticasNotas"/> y calcula las estadísticas al crear el objeto.
        /// </summary>
        /// <param name="listaNota"> Valor del parámetro de tipo int que especifica una lista con las notas<see cref="List{int}"/>.</param>
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




        // El método devuelve -1 si ha habido algún problema, la media en caso contrario
        /// <summary>
        ///Método que calcula las estadísticas para un conjunto de notas de la lista.
        /// </summary>
        /// <param name="listaNota">Valor del parámetro de tipo int que especifica una lista con las notas<see cref="List{int}"/>.</param>
        /// <returns>Devuelve la media y el número de suspensos/aprobados/notables/sobresalientes</returns>
        /// <exception cref="Exception">Lanza una excepción con una advertencia de "Error" si la lista  es menor o igual a cero</exception>
        /// <exception cref="ArgumentOutOfRangeException"> Lanza esta excepción si las notas no se encuentran entre el mínimo y el máximo</exception>
        public double CalcularEstadisticas(List<int> listaNota)
        {
            Media = 0.0;

            //x TODO: hay que modificar el tratamiento de errores para generar excepciones
            //
            if (listaNota.Count <= 0)  // Si la lista no contiene elementos, devolvemos un error
            {
                throw new Exception("Error, la lista no contiene elementos");
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
