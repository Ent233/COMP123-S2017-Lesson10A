using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2017_Lesson10A
{
    public class SuperVillain : SuperHuman, IHasMalice
    {
        // PRIVATE INSTANCE VARIABLES
        private int _malic;

        // PUBLIC PROPERTIES
        public int Malice
        {
            get
            {
                return this._malic;
            }

            set
            {
                this._malic = value;
            }
        }

        // CONSTRUCTORS

        /// <summary>
        /// This is the main constructor for the SuperVillain class
        /// It takes two arguments - name (string) - malice (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="malice"></param>
        public SuperVillain(string name, int malice)
            : base(name)
        {
            this.Malice = malice;
        }

        // PRIVATE METHODS

        // PUBLIC METHODS
    }
}
