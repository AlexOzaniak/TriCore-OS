
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCore_OS.Programs
{
    internal class MomsFood
    {
        
            
        
           public void WriteFoodRecipes()
        {
            while (true) 
            {
                FirstPageRecipes();
                int choice = GetRecipeInput();
                ActualRecipes(choice);

                Console.WriteLine("\nDo you want to choose another recipe? (y/n)");
                string again = Console.ReadLine().ToLower();
                Console.Clear();
                if (again != "y")
                    break; 
                Console.Clear();
            }
        }

        
                
                
            









            public void DelayForFood()
        {
            Thread.Sleep(25);
        }

        public void FirstPageRecipes()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Special thanks to Iza, Matus, Michal, Patrik, David and Tom for contributing their recipes.");
            Thread.Sleep(2200);
            Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Thread.Sleep(300);
            Console.WriteLine("What would you like to cook?\r\nYou have the following recipes saved:");
            Console.ResetColor();
            DelayForFood();
            Console.WriteLine("(1)Bryndza dumplings");
            DelayForFood();
            Console.WriteLine("(2)Goulash");
            DelayForFood();
            Console.WriteLine("(3)Spaghetti Carbonara");
            DelayForFood();
            Console.WriteLine("(4)Cabbage soup");
            DelayForFood();
            Console.WriteLine("(5)Schnitzel with potatoes");
            DelayForFood();
            Console.WriteLine("(6) Salmon with Potatoes ");
            DelayForFood();
            Console.WriteLine("(7) Skalite Special- HOMEMADE PLUM BRANDY (Slivovica)");
            
           
        }
        public int GetRecipeInput()
        {
            int choice = 0;
            try
            {
                 choice = int.Parse(Console.ReadLine());
                Convert.ToInt32(choice);

                
            }
            catch (FormatException) { Console.WriteLine("try Using an number"); }
            return choice;
        }

        public void ActualRecipes(int choice)
        {
            

            if (choice == 1)
            {
                Console.Clear();
                Console.WriteLine(@"
==============================
1) BRYNDZA DUMPLINGS (Slovak)
==============================

Ingredients:
- 1 kg potatoes
- 300 g all-purpose flour
- Salt
- 200–250 g bryndza cheese
- 100 g bacon

Steps:
1. Peel and finely grate the potatoes.
2. Add flour and salt.
3. Mix into a thick dough.
4. Bring salted water to a boil.
5. Push dough through a dumpling maker into boiling water.
6. Cook until dumplings float, then 2–3 more minutes.
7. Fry bacon until crispy.
8. Drain dumplings and mix with bryndza.
9. Top with bacon and fat.
10. Serve immediately.
");
            }
            else if (choice == 2)
            {
                Console.Clear();
                Console.WriteLine(@"
==============================
2) CLASSIC GOULASH
==============================

Ingredients:
- 600 g beef
- 2 large onions
- 3 cloves garlic
- 2 tbsp ground paprika
- 1 tsp caraway seeds
- Salt, black pepper
- 1 tbsp tomato paste
- Oil or lard
- Water or broth

Steps:
1. Cut beef into cubes.
2. Finely chop onions.
3. Fry onions in fat until dark brown.
4. Add garlic briefly.
5. Remove from heat and add paprika.
6. Add beef and mix well.
7. Season with salt, pepper, caraway, tomato paste.
8. Add water, cover, and simmer for 2 hours.
9. Add more water if needed.
10. Cook until meat is tender.
11. Serve with bread or dumplings.
");
            }
            else if (choice == 3)
            {
                Console.Clear();
                Console.WriteLine(@"
==============================
3) SPAGHETTI CARBONARA
==============================

Ingredients:
- 400 g spaghetti
- 150 g guanciale or bacon
- 3 eggs
- 80 g parmesan or pecorino
- Black pepper
- Salt

Steps:
1. Boil salted water for pasta.
2. Cut bacon into small pieces.
3. Fry until crispy.
4. Beat eggs in a bowl.
5. Add grated cheese and black pepper.
6. Cook spaghetti al dente.
7. Save some pasta water.
8. Add pasta to pan with bacon.
9. Remove from heat.
10. Add egg mixture and stir quickly.
11. Add pasta water if needed.
12. Create a creamy sauce (do not scramble).
13. Serve immediately.
");
            }
            else if (choice == 4)
            {
                Console.Clear();
                Console.WriteLine(@"
==============================
CABBAGE SOUP (Kapustnica)
==============================

Ingredients:
- Sauerkraut
- Smoked meat or sausage
- 1 onion
- 2 cloves garlic
- Dried mushrooms (optional)
- Ground paprika
- Bay leaf
- Salt, black pepper
- Water

Steps:
1. If using dried mushrooms, soak them in hot water.
2. Chop the onion and garlic.
3. Fry the onion until golden.
4. Add garlic and paprika briefly.
5. Add sauerkraut and mushrooms.
6. Add smoked meat or sausage.
7. Pour in water and add bay leaf.
8. Simmer for 60–90 minutes.
9. Season with salt and pepper.
10. Serve hot.
");
            }
            else if (choice == 5)
            {
                Console.Clear();
                Console.WriteLine(@"
==============================
SCHNITZEL WITH MASHED POTATOES
==============================

Ingredients:
- Pork or chicken schnitzel
- Salt, pepper
- Flour
- Eggs
- Breadcrumbs
- Oil for frying

Mashed Potatoes:
- Potatoes
- Butter
- Milk
- Salt

Steps:
1. Season schnitzel with salt and pepper.
2. Coat in flour, egg, then breadcrumbs.
3. Heat oil in a pan.
4. Fry schnitzel until golden on both sides.
5. Peel and boil potatoes until soft.
6. Mash potatoes with butter, milk, and salt.
7. Serve schnitzel with mashed potatoes.
");
            }
            else if (choice == 6)
            {
                Console.Clear();
                Console.WriteLine(@"
==============================
SALMON WITH POTATOES
==============================

Ingredients:
- Salmon fillets
- Salt, black pepper
- Lemon
- Olive oil
- Garlic (optional)
- Fresh herbs (dill or parsley)

Potatoes:
- Potatoes
- Butter or olive oil
- Salt

Steps:
1. Season salmon with salt and black pepper.
2. Drizzle with olive oil and lemon juice.
3. Add garlic and herbs on top.
4. Let rest for 10 minutes.
5. Preheat pan or oven to medium heat.
6. Cook salmon skin-side down for 4–5 minutes.
7. Flip and cook 2–3 more minutes.
8. Boil potatoes in salted water until soft.
9. Drain potatoes and add butter or olive oil.
10. Serve salmon with potatoes and lemon.
");

            }
            else if ( choice == 7)
            {
                Console.Clear();
                Console.WriteLine(@"
==============================
HOMEMADE PLUM BRANDY (Slivovica)
==============================

Ingredients:
- Ripe plums
- Clean water
- Sugar (optional, if plums are not sweet)
- Yeast (optional, natural fermentation preferred)

Steps:
1. Wash plums and remove pits.
2. Crush plums into a mash.
3. Place mash into a clean fermentation container.
4. Add a little water if mash is too thick.
5. Optionally add sugar if plums lack sweetness.
6. Cover loosely to allow gases to escape.
7. Let ferment in a warm place for 2–4 weeks.
8. Stir occasionally during fermentation.
9. Fermentation is done when bubbling stops.
10. Distill the fermented mash using a still.
11. Collect the distillate carefully.
12. Let the brandy rest for several weeks.
13. Dilute with water to desired strength if needed.
14. Store in glass bottles or wooden barrel.
15. Serve responsibly.
");

            }

            else
            {
                Console.WriteLine("Oops Looks Like You  Found An Error, Please Try Again!");
                
            }
        }
    }
}



    



