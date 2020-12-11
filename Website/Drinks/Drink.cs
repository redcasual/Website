using Website.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Website.Drinks
{
    /// <summary>
    /// A base class representing common properties of drinks
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        public abstract string Description { get; }

        public abstract string Type { get; }

        /// <summary>
        /// Size of drink
        /// </summary>
        public virtual Size Size { get; set; }
        /// <summary>
        /// Price of drink
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        public abstract double Price { get; }
        /// <summary>
        /// Calories in drink
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// Special Instructions to prepare drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
