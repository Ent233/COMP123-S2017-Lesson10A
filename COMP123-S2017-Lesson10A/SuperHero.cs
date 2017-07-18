using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Tom Tsiliopoulos
 * Date: July 13, 2017
 * Description: This is the SuperHero class which inherits from the SuperHuman class
 * Version: 0.1 - implemented the ToString method of the superhuman class
 */

namespace COMP123_S2017_Lesson10A
{
    /// <summary>
    /// This is the SuperHero class
    /// </summary>
    public class SuperHero : SuperHuman, IHasKarma
    {
        // PRIVATE INSTANCE VARIABLES
        private int _karma;

        // PUBLIC PROPERTIES
        public int Karma
        {
            get
            {
                return this._karma;
            }

            set
            {
                this._karma = value;
            }
        }

        // CONSTRUCTORS

        /// <summary>
        /// This is the main constructor for the SuperHero class
        /// It takes two arguments - name (string) - karma (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="karma"></param>
        public SuperHero(string name, int karma)
            : base(name)
        {
            this.Karma = karma;
        }

        // PRIVATE METHODS

        // PUBLIC METHODS
    }
}