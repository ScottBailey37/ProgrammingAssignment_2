using System;


namespace ProgrammingAssignment_2_CSIS209
{
    class Program
    {
        // Declare our constants based upon the assignments supplied values
        const double item1 = 239.99;
        const double item2 = 129.75;
        const double item3 = 99.95;
        const double item4 = 350.89;

        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Declare local variables
            string name;
            int intItem = 0;
            int intQuantity = 0;
            double dblItemSales = 0.0;
            double dblTotalSales = 0.0;

            // Prompt the user for the name of the salesperson
            Console.Write("Enter a salesperson's name: ");
            name = Console.ReadLine(); 
            Console.WriteLine();            
            
            // Now, prompt the user for the item # and quantity of the salesperson's sale
            //   NOTE: This loop will continue incrementing the total sales of the salesperson
            //      as many times as the user wants. It will exit when the user enters
            //      -1 for the item #.
            do
            {
                // Prompt the user for a valid item #
                Console.Write("Enter an item number between 1 and 4 or -1 to quit: ");                
                intItem = int.Parse(Console.ReadLine()); 

                // Make sure the user supplied a valid entry for item #
                //   NOTE: No error checking for nonnumeric entries
                if (intItem > 0 && intItem <= 4) // Only entries 1 to 4 are excepted
                {
                    // They did. So, get the quantity sold of this particular item
                    Console.Write("Enter the quantity sold: ");
                    intQuantity = int.Parse(Console.ReadLine());

                    // Calculate the current item sales and store in variable
                    dblItemSales = CurrentItemSales(intItem, intQuantity);

                    // Print the current item sales 
                    Console.WriteLine("Salesperson {0} sold {1} of item #{2} at {3:C}", name, intQuantity, intItem, dblItemSales);
                    Console.WriteLine();
                    
                    // Now, increment salesperson's total sales with the 
                    // current item sales
                    dblTotalSales += dblItemSales;
                }
                                
                else if (intItem != -1) // Not a valid item # or quit entry
                {
                    // Notify user of invalid entry for item number
                    Console.WriteLine("Invalid entry.");
                }
            } while (intItem != -1);// Exit the loop if user enters -1.

            // Print the salesperson's total sales
            Console.WriteLine("Salesperson {0} sold a total of {1:C}", name, dblTotalSales);
            Console.WriteLine();

            // Wait for user to press the enter key before exiting
            Console.WriteLine("Press the [enter] key to continue.");
            // Intercept all other keys except enter key
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }
        
        /// <summary>
        /// Calculates the item sales, given the item number and quantity of items sold.
        /// </summary>
        /// <param name="itemNum">The item number.</param>
        /// <param name="quantity">The quantity of items.</param>
        /// <returns>Floating point value of the item sales. Otherwise, zero.</returns>
        static double CurrentItemSales(double itemNum, double quantity)
        {
            double itemSales = 0;
            // Calculate the item sales using our const values variables
            switch (itemNum)
            {
                case 1:
                    itemSales = (quantity * item1);
                    break;
                case 2:
                    itemSales = (quantity * item2);
                    break;
                case 3:
                    itemSales = (quantity * item3);
                    break;
                case 4:
                    itemSales = (quantity * item4);
                    break;                
            }
            // Return the item sales or a zero if default
            return itemSales;
        }
    }
}
