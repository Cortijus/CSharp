using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MenuGenerator
{


    public class Dish
    {
        private string dishName;
        private int dishPrice, dishType;




        //const with param
        public Dish(string dishName = " ", int dishType = 0, int dishPrice = 0)
        {
            SetName(dishName);
            SetType(dishType);
            SetPrice(dishPrice);
        }



        //GETTERS

        /** Returns the name of the dish.
            @return: dish name
*/

        public string GetName() { return dishName; }


        /** Returns the type of dish ordered.
            @return: returns either appetizer, entree, or dessert
*/

        public new int GetType() { return dishType; }

        /** Returns the price of the dish.
            @return: dish price
*/

        public int GetPrice() { return dishPrice; }


        //SETTERS

        /** Updates name of dish.
            @param width: the updated dish name
*/

        public void SetName(string dishName) { this.dishName = dishName; }

        /** Updates the type of dish.
            @param width: the updated dish type
*/
        public void SetType(int dishType) { this.dishType = dishType; }

        /** Updates the type of dish.
            @param width: the updated dish type
*/

        public void SetPrice(int dishPrice) { this.dishPrice = dishPrice; }

        /** Customizes the output format of the menu.
            @return: a string representing the output format of the menu
         */

        public override string ToString() { return string.Format(dishName + " ($" + dishPrice + ")", GetName(), GetPrice()); }

    }
}
