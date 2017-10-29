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
    class Program {
        static void Main(string[] args) {
            Cat siriusBlack = new Cat();

            //***********************************************************************************
            // Hook into the event: now we are listening. 
            siriusBlack.OnTable += new Cat.dgEventRaiserOnTable(CatOnTableEventHandler);
            //***********************************************************************************

            siriusBlack.name = "Sirius Black";
            // Run the cat around 10 times. Eventuallty it will jump on the table
            for (int i = 0; i < 10; i++) {
                //Console.WriteLine(siriusBlack.name + " is running around...");
                siriusBlack.RunAround();
            }
        }
        /// <summary>
        /// This method will be called by the event handler in Cat. 
        /// </summary>
        static void CatOnTableEventHandler() {
            Console.WriteLine("Red Alert: CAT IS ON TABLE");
        }
    }
}
