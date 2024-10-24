using System.Reflection;

namespace Upcasting_Downcasting_Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit[] basket = new Fruit[]
        {
            new Apple { Price = 1.5m, Sort = "Fuji" },
            new Pineapple { Price = 3.0m, Sort = "Cayenne" },
            new Orange { Price = 1.2m, Sort = "Navel" }
        };

            foreach (var fruit in basket)
            {
                Console.WriteLine($"{fruit.GetType().Name} details:");

              
                Console.WriteLine($"Sort: {fruit.Sort}");

            
                if (fruit is Apple apple)
                {
                    Console.WriteLine($"Vitamin A: {apple.VitaminA}");
                    Console.WriteLine($"Vitamin B: {apple.VitaminB}");
                }
                else if (fruit is Pineapple pineapple)
                {
                    Console.WriteLine($"Vitamin E: {pineapple.VitaminE}");
                    Console.WriteLine($"Vitamin D: {pineapple.VitaminD}");
                }
                else if (fruit is Orange orange)
                {
                    Console.WriteLine($"Vitamin C: {orange.VitaminC}");
                }

                Console.WriteLine();
            }
            //foreach (var fruit in basket)
            //{
            //    Type type = fruit.GetType();
            //    Console.WriteLine($"{type.Name} details:");

            //    
            //    FieldInfo[] fields = type.GetFields();
            //    foreach (FieldInfo field in fields)
            //    {
            //        object value = field.GetValue(fruit);
            //        Console.WriteLine($"{field.Name}: {value}");
            //    }

            //   
            //    FieldInfo[] baseFields = typeof(Fruit).GetFields();
            //    foreach (FieldInfo baseField in baseFields)
            //    {
            //        object value = baseField.GetValue(fruit);
            //        Console.WriteLine($"{baseField.Name}: {value}");
            //    }

            //    Console.WriteLine();
            //}
    }
}
  }      

