using Exercise_InheritanceGame_GameLogic;

namespace Exercise_InheritanceGame {
    class Program {
        static void Main(string[] args)
        {
            // Creating new player with 100 hitpoints
            Player player = new Player(100);

            // Creating instances of Juice and Bread and add them to the players inventory
            Juice juice = new Juice("Apple Juice", 20);
            Bread bread = new Bread("Whole Grain Bread", 15);
            player.Inventory.Items.Add(juice);
            player.Inventory.Items.Add(bread);

            // Add weapons to the player
            BroadSword broadSword = new BroadSword("BroadSword");
            Katana katana = new Katana("Katana sword");
            player.Inventory.Items.Add(broadSword);
            player.Inventory.Items.Add(katana);


            // Loop through the inventory, print the titles and use the 'is' operator to check type
            foreach (Item item in player.Inventory.Items) {
                Console.WriteLine("Item: " + item.ToString());

                if (item is Juice juiceItem)
                {
                    // If the item is of type Juice, call the Consume method
                    juiceItem.Consume(player);
                }
                else if (item is Bread breadItem)
                {
                    // If the item is of type Bread, call the Consume method
                    breadItem.Consume(player);
                }
                else if (item is Weapon weaponItem) 
                { 
                    // Call attack method
                    weaponItem.Attack(player);
                }
            }
            // Print the player's current hitpoints
            Console.WriteLine("Player's Hitpoints: " + player.Hitpoints);
        }
    }
}

