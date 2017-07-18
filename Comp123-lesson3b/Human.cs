using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name:Dennis Kanzira
 * Date:July 11 2017
 * Description: This is the Abstract Human class
 * version: 0.1 - Added public abstract method DisplaySkills 
 * 
*/
namespace Comp123_lesson3b
{
    /// <summary>
    /// This is the Abstract Human Class
    /// </summary>
    public abstract class Human
    {
        //PUBLIC INSTANCE VARIABLES(FIELDS)
        private string _name;

        //PUBLIC PROPERITIES
        public string Name
        {

            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        /// <summary>
        /// This is the main constructor for the Human class
        /// It takes the paramenter - name(string)
        /// </summary>
        /// <param name="name"></param>
        //CONSTRUCTORS -----------------------------------------------------
        public Human(string name)
        {
            this.Name = name;
        }

        //PUBLIC ABSTRACT METHDS
        public abstract void DisplaySkills();
    }
}