using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name:Dennis Kanzira
 * Date:July 11 2017
 * Description: This is the SuperHuman class that extends the Human abstract class
 * version: 0.5 - Added Stub method DisplaySkills to conform to Human Abstract Method
*/
namespace Comp123_lesson3b
{
    /// <summary>
    /// This is the Super Human class
    /// </summary>
    public class SuperHuman : Human
    {
        //PRIVATE INSTANCE VARIABLES(FIELDS)
        private List<Power> _powers;
        //PUBLIC PROPERITIES
        public List<Power> Powers
        {
            get
            {
                return this._powers;
            }

        }

        //CONSTRUCTORS -----------------------------------------------------
        /// <summary>
        /// This is the main constructor for SuperHuman Class
        /// It takes one parameter - name(string)
        /// </summary>
        /// <param name="name"></param>
        public SuperHuman(string name)
            : base(name)
        {
            this._intialize();
        }

        //PRIVATE METHODS
        /// <summary>
        /// This method initializes, instantiates ans ass
        /// </summary>
        private void _intialize()
        {
            this._powers = new List<Power>();//Creates an empty list
        }

        //PUBLIC METHODS
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public void AddPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }
        /// <summary>
        /// This method displays 
        /// </summary>
        public void DisplayPowers()
        {
            foreach (Power power in this.Powers)
            {

                Console.WriteLine("Power:" + power.Name + "Rank:" + power.Rank);
            }
        }
        //PUBLIC OVERRIDE METHOD
        /// <summary>
        /// The ToString method overrides the built-in Object.ToString method.
        /// It outputs a string that displays the superhuman's name and their power list.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = "";
            outputString += "===========================================================\n";
            outputString += "SuperVillain Name:" + this.Name + "\n";
            outputString += "===========================================================\n";

            foreach (Power power in this.Powers)
            {
                outputString += "Power: " + power.Name + " Rank: " + power.Rank + "\n";
            }
            outputString += "===========================================================\n";
            return outputString;
        }

        public override void DisplaySkills()
        {
            Console.WriteLine("Not Implemented");
        }


    }
}