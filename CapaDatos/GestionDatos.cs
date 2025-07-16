// <copyright file="GestionDatos.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Datos
{
    using System;
    using Inventario;

    /// <summary>
    /// Con esta parte verifivo la existencia del archivo.
    /// </summary>
    public class GestionDatos
    {
        /// <summary>
        /// Metodo para verificar si un archivo existe, sino lo crea.
        /// </summary>
        /// <param name="archivo">parametro para archivo.</param>
        /// <param name="entrada">parametro para buscar el archivo.</param>
        public void VerificarArchivo(string archivo, string entrada)
        {
            if (!File.Exists(archivo))
            {
                File.WriteAllText(archivo, entrada + Environment.NewLine);
            }
        }
    }
}
