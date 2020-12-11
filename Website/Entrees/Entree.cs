using Website.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Website.Entrees
{
    /// <summary>
    /// A base class representing common properties of entrees
    /// </summary>
    public abstract class Entree : IOrderItem 
    {
        public abstract string Description { get; }

        public abstract string Type { get; }

        /// <summary>
        /// Price of entree
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        public abstract double Price { get; }
        /// <summary>
        /// Calories in entree
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// Special Instructions to prepare entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
