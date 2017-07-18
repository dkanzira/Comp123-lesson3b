using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name:Dennis Kanzira
 * Date:July 15 2017
 * Description: This is the SuperHero Class which inherits from the SuperHuman Class
 * and implements the IHasKarma Interfece class
 * version: 0.1 - Created IHasKarma
*/
namespace Comp123_lesson3b
{
    /// <summary>
    /// This is the Karma interf
    /// </summary>
    public class SuperHero : SuperHuman, IHasKarma
    {
        //PRIVATE INSTANCE VARIABLES
        private int _karma;

        //PUBLIC PROPERTIES
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
        //CONSTRUCTORS
        /// <summary>
        /// This the main constructor, it takes one Arguement - name(string)
        /// </summary>
        /// <param name="name"></param>
        public SuperHero(string name, int karma)
            : base(name)
        {
            this.Karma = karma;
        }

    }
}