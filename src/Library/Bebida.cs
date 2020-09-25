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
    public class Bebida
    {
        /// <summary>
        /// Crea una nueva canción con los valores pasados como parámetro.
        /// </summary>
        /// <param name="nombre">El nombre de la bebida.</param>
        /// <param name="sabor">El sabor de la bebida.</param>
        /// <param name="dulce">Si la bebida es dulce.</param>        
        /// <returns>La bebida recién creada.</returns>
        public Bebida(string nombre, string sabor, bool dulce)
        {
            this.Nombre = nombre;
            this.Sabor = sabor;
            this.Dulce = dulce;
        }

        /// <summary>
        /// Nombre de la bebida.
        /// </summary>
        /// <returns>El nombre de la bebida.</returns>
        public string Nombre { get; }

        /// <summary>
        /// Sabor de la bebida.
        /// </summary>
        /// <returns>El sabor de la bebida.</returns>
        public string Sabor { get; }

        /// <summary>
        /// Si la bebida es dulce.
        /// </summary>
        /// <returns>Si la bebida es dulce.</returns>
        public bool Dulce { get; }
    }
}