using Website.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Website.Sides
{
    /// <summary>
    /// A base class representing common properties of sides
    /// </summary>
    public abstract class Side : IOrderItem
    {
        public abstract string Description { get; }

        public abstract string Type { get; }

        /// <summary>
        /// Size of side
        /// </summary>
        public virtual Size Size { get; set; }
        /// <summary>
        /// Price of side
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        public abstract double Price { get; }
        /// <summary>
        /// Calories in side
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// Special Instructions to prepare side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
