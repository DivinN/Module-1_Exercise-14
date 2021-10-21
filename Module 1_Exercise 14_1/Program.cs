using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Exercise_14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание кошки
            Console.WriteLine("Создадим кошку =)");
            Cat cat = new Cat();
            Console.WriteLine("Как кошку назовем?");
            cat.Name = Console.ReadLine();
            Console.WriteLine("Итак, нашу кошку зовут {0}.", cat.Name);
            
            Console.Write("Она говорит: ");
            cat.Say();

            Console.WriteLine();
            // Создание собаки
            Console.WriteLine("А теперь создадим собаку =)");
            Dog dog = new Dog();
            Console.WriteLine("Как собачку назовем?");
            dog.Name = Console.ReadLine();
            Console.WriteLine("Итак, нашу собаку зовут {0}.", dog.Name);

            Console.Write("Она говорит: ");
            dog.Say();

            Console.ReadKey();
        }


        abstract class Animal
        {
            public abstract string Name { get; set; }

            public Animal()
            {
                Name = "Самое лучшее животное";
            }

            public abstract void Say();

            public void ShowInfo()
            {
                Console.WriteLine(Name);
                Say();
            }
        }

        class Cat : Animal
        {
            string name;
            public override string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            public override void Say()
            {
                Console.WriteLine("Мяу!");
            }
        }

        class Dog : Animal
        {
            string name;
            public override string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            public override void Say()
            {
                Console.WriteLine("Гав!");
            }
        }

    }
}
