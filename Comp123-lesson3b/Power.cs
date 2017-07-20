using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name:Dennis Kanzira
 * Date:July 11 2017
 * Description: This is the Power Class
 * version: 0.3 - Overloaded the > and < operators for the Power Claass
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
        //PUBLIC OVERLOAD OPERATORS -----------------------------------------
        /// <summary>
        /// This method overloads the >for use with Powe Class
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns>Returns true if lhs.Rank is >rhs.Rank </returns>
        
        public static bool operator >(Power lhs,Power rhs)
        {
            return (lhs.Rank < rhs.Rank);
        }
        /// <summary>
        /// This method overloads the <for use with the Power Class
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        public static bool operator <(Power lhs, Power rhs)

        {

            return (lhs.Rank < rhs.Rank);

        }
    }
}