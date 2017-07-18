using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name:Dennis Kanzira
 * Date:July 11 2017
 * Description: This is the Power Class
 * version: 0.1 - Created the Power class Class
 * 
*/
namespace Comp123_lesson3b
{
    /// <summary>
    /// This is the Power class which will be used as a data type
    /// </summary>
    public class Power
    {
        //PUBLIC PROPERTIES
        public string Name { get; set; }

        public int Rank { get; set; }

        //CONSTRUCTORS -----------------------------------------------------
        /// <summary>
        /// This is the main constructor fpr the Power class.
        /// It takes two arguements - name(string) -rank(int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public Power(string name, int rank)
        {
            this.Name = name;
            this.Rank = rank;
        }
    }
}