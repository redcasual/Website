using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website
{
     public interface IOrderItem
    {
        /// <summary>
        /// Price of item
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        double Price { get; }
        /// <summary>
        /// Calories in item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Gets what kind of item it is
        /// </summary>
        string Type { get; }

        /// <summary>
        /// Description of item
        /// </summary>
        string Description { get; }
    }
}
