using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name:Dennis Kanzira
 * Date:July 15 2017
 * Description: Interface that defines a Karma Property that must be implemented in any class
 * version: 0.1 - Created IHasKarma
*/
namespace Comp123_lesson3b
{
    /// <summary>
    /// This is the IHasKarma 
    /// </summary>
    public interface IHasKarma
    {
        //PUBLIC PROPERTIES
        int Karma { get; set; }
    }
}