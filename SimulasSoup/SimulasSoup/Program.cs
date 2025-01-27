// Caitlin Sheeran
// 1/27/2025


namespace SimulasSoup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calls the Soup Combo method and creates a tuple
            (Type, MainIngredient, Seasoning ) soup = SoupCombo();
            Console.WriteLine($"{soup.Item3} {soup.Item2} {soup.Item1}");


            // METHODS

            // Calls of other methods and stores it in the tuple and returns it
            (Type, MainIngredient, Seasoning) SoupCombo()
            {
                Type type = GetType();
                MainIngredient mainIngredient = GetMainIngredient();
                Seasoning seasoning = GetSeasoning();
                return(type, mainIngredient, seasoning);
            }

            // Gets a type for the soup
            Type GetType()
            {
                while (true)
                {
                    Console.Write("Would you like Soup, Stew, or Gumbo: ");
                    string input = Console.ReadLine();

                    if (input == "Soup") return Type.Soup;
                    else if (input == "Stew") return Type.Stew;
                    else if (input == "Gumbo") return Type.Gumbo;

                    Console.WriteLine("\nPlease type Soup, Stew or Gumbo\n");
                }
            }

            // Gets a main ingredient for the soup
            MainIngredient GetMainIngredient()
            {
                while (true)
                {
                    Console.Write("Would you like Mushrooms, Chicken, Carrots, or Potatoes: ");
                    string input = Console.ReadLine();

                    if (input == "Mushrooms") return MainIngredient.Mushrooms;
                    else if (input == "Chicken") return MainIngredient.Chicken;
                    else if (input == "Carrots") return MainIngredient.Carrots;
                    else if (input == "Potatoes") return MainIngredient.Potatoes;

                    Console.Write("\n Please select Mushrooms, Chicken, Carrots, or Potatoes\n");
                }
            }

            // Gets a seasoning for the soup
            Seasoning GetSeasoning()
            {
                while (true)
                {
                    Console.Write("Would you like it to be Spicy, Salty, or Sweet: ");
                    string input = Console.ReadLine();

                    if (input == "Spicy") return Seasoning.Salty;
                    else if (input == "Salty") return Seasoning.Salty;
                    else if (input == "Sweet") return Seasoning.Sweet;

                    Console.Write("\nPlease select Spicy, Salty, or Sweet\n");
                }
            }



            
        }
    }

    // The enum types for the choices of soups
    enum Type {Soup, Stew, Gumbo}
    enum MainIngredient {Mushrooms, Chicken, Carrots, Potatoes}
    enum Seasoning {Spicy, Salty, Sweet}
}
