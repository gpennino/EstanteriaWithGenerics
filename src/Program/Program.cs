//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------
using System;
using System.Collections;

namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Congelado cg1 = new Congelado("Papas", "Frío", "30/09/2020");
            Comestible cm1 = new Comestible("Arroz", "No perecedero", 500);
            Bebida b1 = new Bebida("UcuFanta", "Naranja", true);
            
            Estanteria<Congelado> estanteria1 = new Estanteria<Congelado>(10,10);
            Estanteria<Comestible> estanteria2 = new Estanteria<Comestible>(20,20);
            Estanteria<Bebida> estanteria3 = new Estanteria<Bebida>(12,12);

            

            Console.WriteLine(cg1.Marca);
        }
    }
}
