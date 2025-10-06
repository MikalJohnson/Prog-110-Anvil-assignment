/********************************************************************* 
*    Course:     PROG 110 
*    Instructor: Phil Duncan
*    Term:       Fall 2025
*
*    Programmer: Mikal Johnson
*    Assignment: Data (ACME Anvils Order Taking)
*    
*    Description:  This program will allow a clerk to take an order.
*    the customer's shipping information and the items they wish to order.
* 
*    Revision    Date               Release Comment 
*    --------     ----------        ------------------------------------------------------ 
*    1.0         mm/dd/yyyy         Initial Release 
*    1
* 
*/
// Enable ANSI encoding to display bold fonts
Console.OutputEncoding = System.Text.Encoding.UTF8;

//Set default values for variables
int numberOfAnvils = 0;
string customerName = "";
string customerAddress = "";
string customerCity = "";
string customerState = "";
string customerZip = "";

Console.Write("Please enter the number of anvils you wish to order: ");
numberOfAnvils = Convert.ToInt32(Console.ReadLine());


// Assign company name and motto to variables
// and create welcome message
string companyName = "Acme Anvils Corporation";
string companyMotto = "Supporting the animation industry since 1949!!";
string welcomeMessage = $"Welcome to {companyName}\n{companyMotto}";

// Welcome message
Console.WriteLine("\n"+welcomeMessage + "\n\n" + "Hi I'm Mikal. How many anvils would you like to order?");
Console.Write("Number of anvils: " + numberOfAnvils + "\n");

Console.Write("I can certainly help you with that Could you please give me your name and address?\npress enter to continue...");
Console.ReadKey();

// Gather customer Name and address
Console.Write("Please enter your first and last name: ");
customerName = Console.ReadLine();
Console.Write("Please enter your address: ");
customerAddress = Console.ReadLine();
Console.Write("Please enter your city: ");
customerCity = Console.ReadLine();
Console.Write("Please enter your state: ");
customerState = Console.ReadLine();
Console.Write("Please enter your zip code: ");
customerZip = Console.ReadLine();

// Display order summary
//Bold and highlighted text using ANSI escape codes \u001b[1m \u001b[43m To reset \u001b[0m"
Console.Write("First and last name:\t" + "\u001b[1m\u001b[43m" + customerName + "\u001b[0m\n"
            + "Address:\t\t" + "\u001b[1m\u001b[43m" + customerAddress + "\u001b[0m\n"
            + "City:\t\t\t" + "\u001b[1m\u001b[43m" + customerCity + "\u001b[0m\n"
            + "State:\t\t\t" + "\u001b[1m\u001b[43m" + customerState + "\u001b[0m\n"
            + "Zip Code:\t\t" + "\u001b[1m\u001b[43m" + customerZip + "\u001b[0m\n"
            + "Number of Anvils:\t" + "\u001b[1m\u001b[43m" + numberOfAnvils + "\u001b[0m\n"
            + "Press any key to exit...");
Console.ReadKey();

//Display invoice
Console.WriteLine("*********************** INVOICE ************************\n");
Console.Write("*** ACME Anvils Corporation ***\n"
            + "Supporting the animation industry since 1949!!\n\n"
            + "Ship To:\n"
            + "\t" + customerName + "\n"
            + "\t" + customerAddress + "\n"
            + "\t" +  customerCity + ", " + customerState + " " + customerZip + "\n\n"
            + "Item\t\tQty\tPrice\tTotal\n"
            + "------------------------------------------------------\n"
            + "Anvil\t\t" + numberOfAnvils + "\t$99.99\t$" + (numberOfAnvils * 99.99).ToString("0.00") + "\n"
            + "------------------------------------------------------\n"
            + "\t\t\tSubtotal:\t$" + (numberOfAnvils * 99.99).ToString("0.00") + "\n"
            + "\t\t\tTax (7%):\t$" + (numberOfAnvils * 99.99 * 0.07).ToString("0.00") + "\n"
            + "\t\t\tTotal:\t$" + (numberOfAnvils * 99.99 * 1.07).ToString("0.00") + "\n"
            + "******************************************************\n"
            + "Thank you for your order!\n");