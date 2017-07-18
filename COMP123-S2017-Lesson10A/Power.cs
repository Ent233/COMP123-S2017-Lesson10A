using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Tom Tsiliopoulos
 * Date: July 11, 2017
 * Description: Demo for Lesson 9
 * Version: 0.3 - overload >
 */

namespace COMP123_S2017_Lesson10A
{

    /// <summary>
    /// This is the Power class which will be used as a Data type
    /// </summary>
    public class Power
    {
        // PUBLIC PROPERTIES
        public string Name { get; set; }
        public int Rank { get; set; }

        // CONSTRUCTORS -----------------------------------

        /// <summary>
        /// This is the main constructor for the Power class.
        /// It takes two arguments - name (string) - rank (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public Power(string name, int rank)
        {
            this.Name = name;
            this.Rank = rank;
        }
        //overload
        /// <summary>
        /// overload >operator for the power class.
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns>the power that is greater in rank</returns>
        public static Power operator >(Power lhs, Power rhs)
        {
            return (lhs.Rank > rhs.Rank) ? lhs : rhs;
        }
        public static Power operator <(Power lhs, Power rhs)
        {
            return (lhs.Rank < rhs.Rank) ? lhs : rhs;
        }
    }
}