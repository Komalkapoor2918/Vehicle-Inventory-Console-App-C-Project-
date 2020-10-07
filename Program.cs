using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Modify Vehicles");
            Console.WriteLine("2) Modify Inventory");
            Console.WriteLine("3) Modify Repair");
            Console.WriteLine("4) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ModifyVehicles();
                    return true;
                case "2":
                    ModifyInventory();
                    return true;
                case "3":
                    ModifyRepairs();
                    return true;
                case "4":
                    return false;
                default:
                    return true;
            }
        }

        private static string CaptureInput()
        {
            return Console.ReadLine();
        }

        private static bool ModifyVehicles()
        {
            Console.Clear();
            Console.WriteLine("Modify Vehicles");
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) List all the vehicles");
            Console.WriteLine("2) Add a new vehicle");
            Console.WriteLine("3) Update ");
            Console.WriteLine("4) Delete");
            Console.WriteLine("5) Return to main menu");
            Console.Write("\r\nSelect an option: ");



            switch (Console.ReadLine())
            {
                case "1":
                    Listallthevehicles();
                    return true;
                case "2":
                    Addanewvehicle();
                    return true;
                case "3":
                    Update();
                    return true;
                case "4":
                    Delete();
                    return true;
                case "5":
                    return false;
                default:
                    return true;
            }



            static void Listallthevehicles()
            {
                Console.Clear();
                Console.WriteLine(" List of all the vehicles");
                Console.Clear();
               

                
            }
            static void Addanewvehicle()
            {
                Console.Clear();
                Console.WriteLine("Add a new vehicle");
                Console.Clear();
                Console.WriteLine("Choose an option:");

                char[] charArray = CaptureInput().ToCharArray();
                Array.Reverse(charArray);
                DisplayResult(String.Concat(charArray));
            }

            static void Update()
            {
                Console.Clear();
                Console.WriteLine("Update Vehicles");
                Console.Clear();
                Console.WriteLine("Choose an option:");
                char[] charArray = CaptureInput().ToCharArray();
                Array.Reverse(charArray);
                DisplayResult(String.Concat(charArray));
            }

            static void Delete()
            {
                Console.Clear();
                Console.WriteLine("Delete Vehicles");
                Console.Clear();
                Console.WriteLine("Choose an option:");
                char[] charArray = CaptureInput().ToCharArray();
                Array.Reverse(charArray);
                DisplayResult(String.Concat(charArray));
            }

        

        }
        private static bool ModifyInventory()
        {
            Console.Clear();
            Console.WriteLine("Modify Inventory");
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Insert a new inventory");
            Console.WriteLine("2) View Inventory for a vehicle");
            Console.WriteLine("3) Inventory updation");
            Console.WriteLine("4) Return to main menu");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Insertanewinventory();
                    return true;
                case "2":
                    ViewInventoryforavehicle();
                    return true;
               // case "3":
                  //  Inventoryupdation();
                    //return true;
                case "4":
                    return false;
                default:
                    return true;
            }



            static void Insertanewinventory()
            {
                Console.Clear();
                Console.WriteLine(" Insert a new inventory");
                Console.Clear();
                Console.WriteLine("Choose an option:");

                char[] charArray = CaptureInput().ToCharArray();
                Array.Reverse(charArray);
                DisplayResult(String.Concat(charArray));

            }
            static void ViewInventoryforavehicle()
            {
                Console.Clear();
                Console.WriteLine("View Inventory for a vehicle");
                Console.Clear();
                Console.WriteLine("Choose an option:");

                char[] charArray = CaptureInput().ToCharArray();
                Array.Reverse(charArray);
                DisplayResult(String.Concat(charArray));
            }

                  
        }

        private static int deleteaninventory()
        {
            throw new NotImplementedException();
        }

        private static void ModifyRepairs()
        {
            Console.Clear();
            Console.WriteLine("Modify Repairs");
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) View all repairs");
            Console.WriteLine("2) Add/Update/delete new repair");
            Console.WriteLine("3) Return to main menu ");
            Console.Write("\r\nSelect an option: ");
            char[] charArray = CaptureInput().ToCharArray();
            Array.Reverse(charArray);
            DisplayResult(String.Concat(charArray));

        }

        private static void DisplayResult(string message)
            {
                Console.Write("\r\nPress Enter to return to Main Menu");
                Console.ReadLine();
            }
        }
    }

    
