using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject1
{
    public static class Game
    {
        static string itemSelection_Input;
        static int itemSelection;
        static string locationSelection_Input;
        static int locationSelection;
        static List<string> Inventory = new List<string>();
        static Location[] locations = LocationArray();
        static ItemPickups[] items = ItemArray();
        static Player player1 = NewPlayer();
        static Player ronald = NewNPC();
        static Random random = new Random();
        static int number;


        public static void Play()
        {
            
            Console.WriteLine("Welcome to Limbo, time to find your way out\nThe game will end when you have collected 5 items or you perish");
            Console.WriteLine("You will have a few opportunities to pick up items, choose wisely");
            Console.ReadKey();
            Console.Clear();

            while (player1.health > 0 || Inventory.Count <= 4)
            {
                PickupItem();
                EnterLocation();
            }

            EndGame();

            
        }

        private static Location[] LocationArray()
        {
            Location[] locations = new Location[10];
            locations[0] = new Location
            {
                name = "Cave",
                hazard = "Extreme darkness hinders your vision",
                survivaltool = "Flashlight",
            };
            locations[1] = new Location
            {
                name = "Arakkis",
                hazard = "The arid landscape saps your water",
                survivaltool = "Stillsuit",
            };
            locations[2] = new Location
            {
                name = "Atlantis",
                hazard = "The aquatic landscape drowns you",
                survivaltool = "Scuba Gear",
            };
            locations[3] = new Location
            {
                name = "Insect Land",
                hazard = "Hordes of man-eating bugs swarm over you",
                survivaltool = "Bug Spray",
            };
            locations[4] = new Location
            {
                name = "",
                hazard = "",
                survivaltool = "",
            };
            locations[5] = new Location
            {
                name = "",
                hazard = "",
                survivaltool = "",
            };
            return locations;
        }

        private static ItemPickups[] ItemArray()
        {
            ItemPickups[] items = new ItemPickups[10];
            items[0] = new ItemPickups
            {
                name = "Flashlight",
                description = "A Flashlight"
            };
            items[1] = new ItemPickups
            {
                name = "Stillsuit",
                description = "A suit to preserve the body's moisture"
            };
            items[2] = new ItemPickups
            {
                name = "Scuba Gear",
                description = "Equipment allowing for aquatic travel"
            };
            items[3] = new ItemPickups
            {
                name = "Bug Spray",
                description = "All-purpose bug repellent"
            };
            items[4] = new ItemPickups
            {
                name = ""
            };
            items[5] = new ItemPickups
            {
                name = ""
            };
            return items;
        }

        private static Player NewNPC()
        {
            Player ronald = new Player();
            ronald.health = 4;
            ronald.name = "Ronald";
            return ronald;
        }

        private static Player NewPlayer()
        {
            Console.WriteLine("Welcome to the game!\nWhat is your name?");
            Player player1 = new Player();
            player1.health = 4;
            player1.name = Console.ReadLine();
            Console.WriteLine("Press Enter to continue.");
            Console.ReadKey();
            Console.Clear();
            return player1;
        }

        public static void PickupItem()
        {
            Console.WriteLine($"Congratulations {player1.name}, you are currently alive!\nWhich item would you like to pick up?");
            Console.WriteLine("You can select one of the following items, please select your item by inputing the desired item number.\n1. Flashlight, 2. Stillsuit, 3. Scuba Gear, 4. Bug Spray, 5. Check Inventory");
            itemSelection_Input = Console.ReadLine();
            itemSelection = int.Parse(itemSelection_Input);
            Console.Clear();
            if (itemSelection == 1)
            {
                Inventory.Add(items[0].name);
                Console.WriteLine(items[0].description);
                return;
            }
            if (itemSelection == 2)
            {
                Inventory.Add(items[1].name);
                Console.WriteLine(items[1].description);
                return;
            }
            if (itemSelection == 3)
            {
                Inventory.Add(items[2].name);
                Console.WriteLine(items[2].description);
                return;
            }
            if (itemSelection == 4)
            {
                Inventory.Add(items[3].name);
                Console.WriteLine(items[3].description);
                return;
            }
            if (itemSelection == 5)
            {
                foreach (string items in Inventory)
                {
                    Console.WriteLine(items);
                }
                return;
            }
            if (itemSelection <= 0)
            {
                Console.WriteLine($"Hello my name is {ronald.name}, gimme your money");
                Console.ReadKey();
                Console.Clear();
                number = random.Next(5);
                Inventory.Remove(items[number].name);
                return;
            }
            else
            {
                Console.ReadKey();
                Inventory.Add("Useless Item");
                Console.WriteLine("You have selected a useless item");
                Console.ReadKey();
                Console.Clear();
                
            }
            
        }

        public static void EnterLocation()
        {
            Console.WriteLine("Congratulations, you have the opportunity to teleport to a new location");
            Console.WriteLine("Where would you like to go?\n1. Cave, 2. Arakkis, 3. Atlantis, 4. Insect Land");
            locationSelection_Input = Console.ReadLine();
            locationSelection = int.Parse(locationSelection_Input);
            Console.Clear();
            if (locationSelection == 1)
            {
                if (Inventory.Contains(items[0].name))
                {
                    Console.WriteLine("Description of location");
                    Console.WriteLine("Congratulations, You survived this new location");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Sorry, you did not have the right item to survive here");
                    player1.health --;
                    
                }
            }
            if (locationSelection == 2)
            {
                if (Inventory.Contains(items[1].name))
                {
                    Console.WriteLine("Congratulations, You survived this new location");
                }
                else
                {
                    Console.WriteLine("Sorry, you did not have the right item to survive here");
                    player1.health--;
                    
                }
            }
            if (locationSelection == 3)
            {
                if (Inventory.Contains(items[2].name))
                {
                    Console.WriteLine("Congratulations, You survived this new location");
                }
                else
                {
                    Console.WriteLine("Sorry, you did not have the right item to survive here");
                    player1.health--;
                    
                }
            }
            if (locationSelection == 4)
            {
                if (Inventory.Contains(items[3].name))
                {
                    Console.WriteLine("Congratulations, You survived this new location");
                }
                else
                {
                    Console.WriteLine("Sorry, you did not have the right item to survive here");
                    player1.health--;
                    
                }
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"You have {player1.health} health points remaining");
            Console.ReadKey();
            Console.Clear();
            
        }

        public static void EndGame()
        {
            Console.WriteLine("End Game");
            Console.WriteLine($"Congratulations {player1.name} you completed the game");
            if (player1.health == 0)
            {
                Console.WriteLine("Unfortunatley you perished on your journey and must try again");
            }
            else
            {
                Console.WriteLine("Congratulations, you have all the items");
                foreach (string items in Inventory)
                {
                    Console.WriteLine(items);
                }
            }

         
        }
    }
}
