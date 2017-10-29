/************************************************
 * A simple event handler demo
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * Reference: https://www.intertech.com/Blog/c-sharp-tutorial-understanding-c-events/
 * **********************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpEventHandlerDemo {
    /// <summary>
    /// This class models a cat and the cat jumps onto the table. That causes an event
    /// We need to know when that happens, hence the event.
    /// </summary>
    class Cat {
        
        // Set up a random number generator to simulate cat behavior. 
        private static Random randomBehavior = new Random();
        
        /// <summary>
        /// The cat name. Every cat should have a name
        /// </summary>
        public String name { get; set; }
        
        /// <summary>
        /// A delegate that will receive the event notification
        /// </summary>
        public delegate void dgEventRaiserOnTable();

        /// <summary>
        /// The "Cat on Table" event. Delegates will listen for this event...
        /// </summary>
        public event dgEventRaiserOnTable OnTable;


        /// <summary>
        /// The Cat runs around like a maniac. Randomly he will jump on the table, causing an event to be raised.
        /// </summary>
        public void RunAround() {
            Console.WriteLine(name + " is running around maniacally...");
            if (randomBehavior.Next() % 3 == 0) {       // Every third episode he will jump on the table
                this.OnTable();     // Raise the event. Someone will be listening!
            }
        }
    }
}
