using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name:Dennis Kanzira
 * Date:July 11 2017
 * Description: This is the SuperHuman class that extends the Human abstract class
 * Version: 0.7 - Added the DisplaySkills stub method to satisfy the Human super class requirements
 * Version: 0.8 - Added private _getPowerIndex method 
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

        private int _getPowerIndex(string name)
        {
            int index = 0;
            foreach (Power power in this.Powers)
            {
                if (name.Equals(power.Name))
                {
                    break;
                }
                index++;
                if (this.Powers.Count == index)
                {
                    index = -1; // this means that we did not find the Power in the list
                }
            }
            return index++;
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
            Console.WriteLine("Not Implemented!");
        }


    }
}