using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;


namespace ConsoleApp2
{
    internal class Program : Data
    {
        // True id is 01234569874
        static void Main(string[] args)
        {
            string id;
            
            // We used Instance
            Data dta = new Data();
            
            StartUser:
            string TotalBill;
            Console.WriteLine("Hi User");
            // Ask to user to ID number
            Console.Write("Please, type your ID number : ");
            id = Console.ReadLine();
            if (id == null || id.Length != 11) // If id entered bu user is empty or its length is more than 11 user can not open the shopping part
            {
                Console.WriteLine("Please enter a valid ID number! The number you entered is" + id.Length + "character");
            }


            else if(id == dta.customers[0, 2])
            {
                Console.WriteLine("Welcome to our land please enjoy the shopping <3");
                // We showed the products
                Console.WriteLine("Our products are as listed below :) You can choose according to the specified instructions");
                Console.WriteLine("Enter the id of the product you want to select...");
                StartProduct:
                for (int i = 0; i < dta.products.Length/4; i++)
                {
                    
                    // string name = (dta.products[0,0] == 100) ? "Sweatshirt" : "";
                    string name = (dta.products[i, 0] == 100) ? "Sweatshirt" : (dta.products[i, 0] == 101) ? "Pantolon" : (dta.products[i, 0] == 102) ? "Ceket" : (dta.products[i, 0] == 103) ? "Bluz" : (dta.products[i, 0] == 104) ? "Ayakkabı" : (dta.products[i, 0] == 105) ? "Mont" : "Giysi";
                        
                        Console.Write("{0} {1} Product ID = {2}",name ,dta.products[i,1], dta.products[i,0]);

                        
                    
                    Console.WriteLine();

                }
                string decision;
                string selectid ;
                Console.Write("Enter the product id : ");
                selectid = Console.ReadLine();
                Console.WriteLine("Would you like to buy another product? Y - N");
                decision = Console.ReadLine();
                if (decision == "Y" || decision == "y")
                {
                    goto StartProduct;
                }
                else if (decision == "N" || decision == "n")
                {
                    Console.WriteLine("Your shop is done. Please message to accounting");
                }

            }
            else // User is asked to sign up
            {
                string key;
                Console.WriteLine("Sorry, You don't have any membership :( But you can join our family... ");
                Console.WriteLine("Pleasee say YES 💍");
                Console.WriteLine("Y or N");
                key = Console.ReadLine();
                if (key == "Y" || key == "y")
                {
                    Console.WriteLine("Welcome to our land please enjoy the shopping <3");
                }
                else if(key == "N" || key == "n")
                {
                    Console.WriteLine("Maybe another life...");
                    Console.WriteLine("I can't keep you here forever. So if you want we can make a fresh start (Press Y)" + "If you want to break up with me... (Press N)");
                    key = Console.ReadLine();
                    if (key == "Y" || key == "y")
                    {
                        goto StartUser;
                    }
                    else if (key == "N" || key == "n")
                    {
                        Console.WriteLine("Please Press ENTER");
                    }
                }
                
            }
            
        }

    }
}
