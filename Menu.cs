using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;


namespace MenuGenerator
{
    class HellsKitchen
    {


        public static void Main(string[] args)
        {

            //Opening and creating input and output file
            FileStream inputFile = new FileStream("Dishes.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inputFile);
            FileStream outputFile = new FileStream("Menu.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outputFile);


            //creating lists for dish types
            List<Dish> appetizer = new List<Dish>();
            List<Dish> entree = new List<Dish>();
            List<Dish> dessert = new List<Dish>();


            //while loop to read entire input file
            while (!reader.EndOfStream)
            {

                string[] nextLine = reader.ReadLine().Split('\t', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

                int dishType1 = 0;
                string dishName = nextLine[2];
                int dishPrice = Convert.ToInt32(nextLine[1]);
                string dishType = nextLine[0];
                Dish dish = new Dish();

                //conditional for dish types
                if (dishType == "Appetizer")
                {
                    dishType1 = 0;
                    dish.SetType(dishType1);
                    dish.SetName(dishName);
                    dish.SetPrice(dishPrice);
                    appetizer.Add(dish);
                }
                else if (dishType == "Entree")
                {
                    dishType1 = 1;
                    dish.SetType(dishType1);
                    dish.SetName(dishName);
                    dish.SetPrice(dishPrice);
                    entree.Add(dish);
                }
                else if (dishType == "Dessert")
                {
                    dishType1 = 2;
                    dish.SetType(dishType1);
                    dish.SetName(dishName);
                    dish.SetPrice(dishPrice);
                    dessert.Add(dish);
                }

                
            }

            //formatting and displaying list contents for menu
            writer.WriteLine("Menu\n");
            writer.WriteLine("Appetizer\n");

            for (int i = 0; i < appetizer.Count; i++)
            {
                writer.WriteLine(appetizer[i]);
            }

            
            writer.WriteLine("\nEntree\n");

            for (int i = 0; i < entree.Count; i++)
            {
                writer.WriteLine(entree[i]);
            }

            writer.WriteLine("\nDessert\n");

            for (int i = 0; i < dessert.Count; i++)
            {
                writer.WriteLine(dessert[i]);
            }





            // Close the input and output file.
            writer.Close();
            outputFile.Close();
            reader.Close();
            inputFile.Close();






        }
    }

}
