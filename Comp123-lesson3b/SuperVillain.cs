using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name:Dennis Kanzira
 * Date:July 11 2017
 * Description: This is the SuperVillain  subClass
 * version: 0.1 - Created the SuperVillain Class
 * 
*/
namespace Comp123_lesson3b
{
    public class SuperVillain : SuperHuman, IHasMalice
    {
        //PRIVATE INSTANCE VARIABLES
        private int _malice;

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
        //CONSTRUCTORS
        /// <summary>
        /// This the main constructor, it takes one Arguement - name(string) , malice(int)
        /// </summary>
        /// <param name="name"></param>
        public SuperVillain(string name, int malice)
            : base(name)
        {
            this.Malice = malice;
        }
    }
}