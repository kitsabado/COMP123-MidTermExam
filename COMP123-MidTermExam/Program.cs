using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_MidTermExam
{
    /*****************************************************************
     * Author               : Kristopher G. Sabado
     * 
     * Studen Number        : 301118188
     * 
     * Date Last Modified   : July 17, 2020
     * 
     * Program Description  : This program simulates a lotto game in
     * which the player will be able to select a lotto game then the
     * program will be able to generate lottery tickets with random
     * numbers inside
     * 
     * Revision History     : 
     * 
     * Date         Author          Revision
     * 2015-02-24   tsiliopoulos    Initial commit to add default .gitIgnore and .gitAttribute files.
     * 
     * 
     * <summary>
     * This is the driver class
     * </summary>
     * 
     * @class Program
     *****************************************************************/
    public class Program
    {
        // Instantiate lotto649 object
        static Lotto649 lotto649 = new Lotto649();
        // Instantiate lottoMax object
        static LottoMax lottoMax = new LottoMax();

        /**
         * @static
         * @method Main
         * @returns {void}
         */
        public static void Main(string[] args)
        {     
            // Call the Menu
            LottoMenu();
        }

        /**
         * <summary>
         * This utility method creates a console menu that allows the user to choose
         * a Lotto game to execute.
         * </summary>
         * 
         * @static
         * @method LottoMenu
         * @returns {void}
         */
        public static void LottoMenu()
        {
            // declare a variable to record if menu is active
            bool menuActive = true;

            // While the menu is active...loop
            while(menuActive)
            {
                // show options in the console menu
                Console.WriteLine("++++++++++++++++++++++++++++++++");
                Console.WriteLine(" Please make your selection");
                Console.WriteLine(" 1. Lotto 6/49");
                Console.WriteLine(" 2. Lotto Max");
                Console.WriteLine(" 3. Exit");
                Console.WriteLine("++++++++++++++++++++++++++++++++");

                // read the user selection
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1: // The "1" Key - Select Lotto 6 / 49
                        Console.Clear();
                        Console.WriteLine("+ Lotto 6/49 +++++++++++++++++++");
                        lotto649.GenerateLottoNumbers();
                        Console.WriteLine("++++++++++++++++++++++++++++++++");
                        Console.WriteLine("Please press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D2: // The "2" Key - Select Lotto Max
                        Console.Clear();
                        Console.WriteLine("+ Lotto MAX ++++++++++++++++++++");
                        lottoMax.GenerateLottoNumbers();
                        Console.WriteLine("++++++++++++++++++++++++++++++++");
                        Console.WriteLine("Please press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D3: // The "3" Key - Exit the menu
                        menuActive = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }         
        }
    }
}
