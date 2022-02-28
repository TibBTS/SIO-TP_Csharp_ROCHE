// <copyright file="GestionPortException.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace GestionNavire.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Gestion des exception (classe héritière).
    /// </summary>
    internal class GestionPortException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GestionPortException"/> class.
        /// Affiche l'exception avec le nom du system et la date ainsi que le message.
        /// </summary>
        /// <param name="message">Le paramètre message permet d'afficher l'erreur en question.</param>
        public GestionPortException(string message)
            : base("Erreur de : " + System.Environment.UserName + " le " + DateTime.Now.ToLocalTime() + "\n" + message)
        {
        }
    }
}
