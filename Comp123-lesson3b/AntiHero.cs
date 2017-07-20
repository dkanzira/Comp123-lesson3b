using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Dennis Kanzira
 * Date: July 20, 2017
 * Description: This is the AntiHero Class.
 * It extends the SUperHuman base class and implements both IHasKarma and IHasMalice interfaces
 * Version: 0.1 - created the AntiHero Class.
 */
namespace Comp123_lesson3b
{
    public class AntiHero : SuperHuman, IHasKarma, IHasMalice
    {
        //PRIVATE INSTANCE VARIABLES(FIELDS)
        private int _karma;
        private int _malice;
        //PUBLIC PROPERITIES
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

        public int Malice
        {
            get
            {
                return this._malice;
            }

            set
            {
                this._malice = value;
            }
        }


        //CONSTRUCTORS -----------------------------------------------------
        /// <summary>
        /// This is the maun cnstructor for the AntiHero Class.
        /// It takes three arguements -name(string) - Karma(int) -
        /// </summary>
        /// <param name="name"></param>
        /// <param name="karma"></param>
        /// <param name="malice"></param>
        public AntiHero(string name, int karma,int malice)
            : base(name)
        {
            this._karma = karma;
            this._malice = malice;
        }
        //PRIVATE METHODS

        //PUBLIC METHODS

    }
}