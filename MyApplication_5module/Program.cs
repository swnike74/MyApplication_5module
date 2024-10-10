﻿namespace MyApplication_5module
{//Задание 5.5.3 - recursive function with background color
    internal class Program
    {
        static string ShowColor(string username, int userage)
        {
            Console.WriteLine("{0},{1} лет,\nНапишите свой любимый цвет на английском с маленькой буквы",username, userage);
            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            return color;
        }

        static int[] GetArrayFromConsole(ref int num)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }

        static void SortArray(in int[] array, out int[] sortarrayasc, out int[] sortarraydesc)
        {
            sortarrayasc = SortArrayasc(array);
            sortarraydesc = SortArraydesc(array);

        }
        static int[] SortArrayasc(int[] inarray) 
        {
            int temp = 0;
            int[] result = new int[inarray.Length];
            for(int i=0; i < inarray.Length; i++)
            {
                result[i] = inarray[i];
            }

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if(result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }    
                }
            }
            return result;
        }

        static int[] SortArraydesc(int[] inarray)
        {
            int temp = 0;
            int[] result = new int[inarray.Length];
            for (int i = 0; i < inarray.Length; i++)
            {
                result[i] = inarray[i];
            }
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] < result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }
            return result;
        }

        static void ShowArray(int[] array, bool IsSort = false)
        {
            var temp = array;
            if(IsSort)
            {
                //temp = SortArray(array);
            }

            foreach (var item in temp)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
        }

        static void GetName(ref string name)
        {
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
        }

        static void BigDataOperation(in int[] arr)
        {
            arr[0] = 4;
        }


        static void Echo(string saidworld, int deep)
        {
            var modif = saidworld;

            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }

            Console.BackgroundColor = (ConsoleColor)deep;

            Console.WriteLine("..." + modif);

            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Напишите что-то");
            var str = Console.ReadLine();

            Console.WriteLine("Укажите глубину эха");
            var deep = int.Parse(Console.ReadLine());


            

            Echo(str, deep);



            /*var (name, age) = ("Евгения", 27);

            var arr = new int[] { 1, 2, 3 };
            BigDataOperation(arr);
            Console.WriteLine(arr[0]);

            Console.WriteLine("name{0}", name);
            GetName(ref name);
            Console.WriteLine("name after \n{0}", name);*/


            /*int number = 7;
            var array = GetArrayFromConsole(ref number);

            int[] arrayasc = new int[number];
            int[] arraydesc = new int[number];
             
            SortArray(in array,out arrayasc, out arraydesc);
            ShowArray(array, false);
            ShowArray(arrayasc, false);
            ShowArray(arraydesc, false);*/

            /*var (name, age) = ("Евгения", 27);

            Console.WriteLine("Моё имя: {0}", name);
            Console.WriteLine("Мой возраст: {0}", age);

            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами:");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);

            var favcolors = new string[3];
            for(int i = 0;i < favcolors.Length;i++)
            {
                favcolors[i] = ShowColor(name,age);
            }

            Console.WriteLine("Ваши любимые цвета;");
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }*/
            Console.ReadKey();
        }
    }
}
