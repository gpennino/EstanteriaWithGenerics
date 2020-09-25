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
    public class Congelado
    {
        /// <summary>
        /// Crea una nueva canción con los valores pasados como parámetro.
        /// </summary>
        /// <param name="nombre">El nombre del congelado.</param>
        /// <param name="marca">La marca del congelado.</param>
        /// <param name="vencimiento">El vencimiento.</param>
        /// <returns>El congelado.</returns>
        public Congelado(string nombre, string marca, string vencimiento)
        {
            this.Nombre = nombre;
            this.Marca = marca;
            this.Vencimiento = vencimiento;
        }

        /// <summary>
        /// Nombre del congelado.
        /// </summary>
        /// <returns>El nombre del congelado.</returns>
        public string Nombre { get; }

        /// <summary>
        /// La marca de la bebida.
        /// </summary>
        /// <returns>La marca de la bebida.</returns>
        public string Marca { get; }

        /// <summary>
        /// El vencimiento.
        /// </summary>
        /// <returns>El Vencimiento del congelado.</returns>
        public String Vencimiento { get; }
    }
}