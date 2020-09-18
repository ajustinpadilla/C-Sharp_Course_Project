using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main()
        {
            //List<string> names = new List<string>() { "Mark", "Sally", "Jake", "Jennifer" };

            //Console.WriteLine("Please enter a last name: ");
            //string lName = Console.ReadLine();

            //for (int i = 0; i < names.Count; i++)
            //{
            //    string fullName = names[i] + " " + lName;
            //    names[i] = fullName;
            //}
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.WriteLine("\nNow let's get some spells!");

            //Console.ReadLine();

            //List<string> spellbook = new List<string>();
            //List<string> spells = new List<string>() { "acid splash", "chill touch", "dancing lights", "druidcraft", "eldritch blast", "fire bolt", "guidance", "light", "mage hand", "mending", "message", "minor illusion", "poison spray", "prestidigitation", "produce flame", "ray of frost", "resistance", "sacred flame", "shillelagh", "shocking grasp", "spare the dying", "thaumaturgy", "true strike", "vicious mockery" };
            //while (spellbook.Count < 5)
            //{
            //    int spellsneeded = 5 - spellbook.Count;
            //    Console.WriteLine("Please add " + spellsneeded + " spells to your spellbook.\n(one at a time)\n");
            //    Console.WriteLine("\nAcid Splash, Chill Touch, Dancing Lights, Druidcraft, Eldritch Blast, Fire Bolt, Guidance, Light, Mage Hand, Mending, Message, Minor Illusion, Poison Spray, Prestidigitation, Produce Flame, Ray of Frost, Resistance, Sacred Flame, Shillelagh, Shocking Grasp, Spare the Dying, Thaumaturgy, True Strike, Vicious Mockery\n");
            //    string spellChosen = Console.ReadLine();
            //    if (spells.Contains(spellChosen.ToLower()))
            //    {
            //        if (!spellbook.Contains(spellChosen))
            //        {
            //            spellbook.Add(spellChosen);
            //        }
            //        else
            //        {
            //            Console.WriteLine("\nYou've already chosen that spell, please choose another\n");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please choose a spell from the list:\n");
            //    }
            //}

            //Console.WriteLine("\nHere are your spells:");
            //foreach (string spell in spellbook)
            //{
            //    Console.WriteLine(spell);
            //}

            //Console.WriteLine("\n\nNow let's add to our inventory!\n\n");
            //Console.ReadLine();



            List<string> inventory = new List<string>();
            List<string> itemsAvailable = new List<string>() { "longsword", "dagger", "bow", "bedroll", "rations", "tinderbox", "arrows(15)", "backpack", "firewood", "rope", "tent", "armor", "robes" };

            while (inventory.Count <= 5)
            {
                int inventorySlots = 6 - inventory.Count;
                Console.WriteLine("\nPlease add " + inventorySlots + " more items to your inventory from this list\n");
                foreach (string item in itemsAvailable)
                {
                    Console.Write(item + ", ");
                }
                Console.Write("\n");
                string itemChosen = Console.ReadLine();
                if (itemsAvailable.Contains(itemChosen.ToLower()))
                {
                    inventory.Add(itemChosen);
                }
                else
                {
                    Console.WriteLine("Please choose a item from the list:\n");
                }
            }

            Console.WriteLine("\nHere's your inventory:");
            int invIndex = 0;
            foreach (string item in inventory)
            {
                Console.Write("\n" + item);

                if (invIndex > inventory.IndexOf(item))
                {
                    Console.Write("(This was already in your inventory at an earlier spot)");
                }
                invIndex += 1;
            }

            bool adventuring = true;

            while (adventuring)
            {
                Console.WriteLine("\n\nWhat would you like to do?\n(Search inventory, move foward, exit)\n");
                string action = Console.ReadLine().ToLower();

                if (action == "search inventory")
                {
                    Console.WriteLine("\nWhat would you like to search for");
                    string itemSearched = Console.ReadLine();
                    if (inventory.Contains(itemSearched))
                    {
                        int start = 0;
                        List<int> indices = new List<int>();
                        List<string> allQuantity = inventory.FindAll(i => i == itemSearched);
                        while (indices.Count != allQuantity.Count)
                        {
                            int itemIndex = inventory.IndexOf(itemSearched, start);
                            indices.Add(itemIndex);
                            start = itemIndex + 1;

                        }
                        foreach(int index in indices)
                        {
                        Console.WriteLine("\nyour {0} is in the {1} spot of your inventory", itemSearched, index);

                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("\n{} not found please try again");
                    }
                }

                else if (action == "move foward")
                {
                    Console.WriteLine("you move 6 paces foward.");
                }

                else if (action == "exit")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Not an available action!");
                }

            }

            Console.ReadLine();

        }
    }
}
