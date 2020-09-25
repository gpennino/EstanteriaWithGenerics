//----------------------------------------------------------------------------------
// <copyright file="GenericContainer.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//----------------------------------------------------------------------------------
using System.Collections.Generic;

namespace Generics
{
    /// <summary>
    /// Un objeto para generar una estantería de tipos <c>T</c>.
    /// </summary>
    /// <typeparam name="T">El tipo del objeto contenido.</typeparam>
    public class Estanteria<T>
    {
      
        private T[,] items;

        public Estanteria(int filas, int columnas)
        {
            items = new T[filas, columnas];
        }

        /// <summary>
        /// Agrega un objeto del tipo <c>T</c> al contenedor.
        /// </summary>
        /// <param name="item">El objeto del tipo <c>T</c> a agregar.</param>
        public void Add(T item, int fila, int columna)
        {
            this.items[fila, columna] =item;
        }

        /// <summary>
        /// Retorna todos los elementos que están en la estantería.
        /// </summary>
        /// <returns>Una lista de <T></returns>
        public IList<T> GetAll()
        {
            IList<T> resultado = new List<T>();
            for (int i=0; i<this.items.Length; i++)
            {   for (int j=0; i<this.items.GetLength(i); j++)
                {
                    if (this.items[i,j] != null)
                    {
                        resultado.Add(this.items[i,j]);
                    }

                }   

            }
            return resultado;
        }
   }
}