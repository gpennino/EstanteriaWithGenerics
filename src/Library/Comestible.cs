//-------------------------------------------------------------------------
// <copyright file="Song.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------
using System;

namespace Generics
{
    /// <summary>
    /// Una obra que es una canción.
    /// </summary>
    public class Comestible
    {
        /// <summary>
        /// Crea una nueva canción con los valores pasados como parámetro.
        /// </summary>
        /// <param name="nombre">El nombre del comestible.</param>
        /// <param name="tipo">El tipo de comestible.</param>
        /// <param name="peso">El peso del comestible.</param>
        /// <returns>La canción recién creada.</returns>
        public Comestible(string nombre, string tipo, double peso)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Peso = peso;
        }

        /// <summary>
        /// Nombre del comestible
        /// </summary>
        /// <returns>El nombre del comestible.</returns>
        public string Nombre { get; }

        /// <summary>
        /// Sabor de la bebida.
        /// </summary>
        /// <returns>El tipo del comestible.</returns>
        public string Tipo { get; }

        /// <summary>
        /// Si la bebida es dulce.
        /// </summary>
        /// <returns>El peso del comestible.</returns>
        public double Peso { get; }
    }
}