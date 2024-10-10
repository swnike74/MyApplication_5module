using System.Xml.Linq;

namespace MyApplication_5module
{//Итоговый проект - 5 модуль
    internal class Program
    {
        static (string Name, string LastName, int Age, string[] Pets, string[] favcolors) EnterUser()
        {
            (string Name, string LastName, int Age, string[] Pets, string[] favcolors) User;

            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            User.LastName = Console.ReadLine();

            string age = "";
            int intage = 0;
            do
            {
                Console.WriteLine("Введите возраст цифрами");
                age = Console.ReadLine();

            } while (!CheckNum(age, out intage));
            User.Age = intage;

            bool IsPet;
            string sPet;
            Console.WriteLine("Наличие питомца (Да/Нет)");
            sPet = Console.ReadLine();
            if (sPet == "Да") IsPet = true;
            else IsPet = false;

            string numpets = "";
            int intnumpets = 0;
            string nameofpet = "";
            string nameofpetchecked = "";
            if (IsPet)
            {
                do
                {
                    Console.WriteLine("Введите количество питомцев");
                    numpets = Console.ReadLine();
                } while (!CheckNum(numpets, out intnumpets));
                User.Pets = CreateArrayPet(intnumpets);


                for (int i = 0; i < User.Pets.Length; i++)
                {
                    do
                    {
                        Console.WriteLine("Введите {0} имя питомца", i + 1);
                        nameofpet = Console.ReadLine();
                    } while (!CheckName(nameofpet, out nameofpetchecked));
                    User.Pets[i] = nameofpetchecked;
                }
            }
            else
            {
                User.Pets = CreateArrayPet(0);
            }




            string numcolors = "";
            int intncolors = 0;
            do
            {
                Console.WriteLine("Сколько у вас любимых цветов?");
                numcolors = Console.ReadLine();
            } while (!CheckNum(numcolors, out intncolors));
            User.favcolors = CreateArrayPet(intncolors);

            string color = "";
            string colorchecked = "";
            for (int i = 0; i < User.favcolors.Length; i++)
            {
                do
                {
                    Console.WriteLine("Введите {0} свой любимый цвет на английском с маленькой буквы", i + 1);
                    color = Console.ReadLine();
                } while (!CheckName(color, out colorchecked));
                User.favcolors[i] = colorchecked;
            }

            return User;
        }

        static bool CheckNum(string number, out int corrnumber)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {
                    corrnumber = intnum;
                    return true;
                }
            }
            corrnumber = 0;
            return false;
        }

        static bool CheckName(string namein, out string nameout)
        {
            if (int.TryParse(namein, out int result) || namein == string.Empty)
            {
                nameout = string.Empty;
                return false;
            }
            else
            {
                nameout = namein;
                return true;
            }
        }

        static string[] CreateArrayPet(int num)
        {
            bool IsRight = false;
            if (num > 0) IsRight = true;

            if (IsRight)
            {
                string[] arr = new string[num];
                return arr;
            }
            else
            {
                string[] arr = { string.Empty };
                return arr;
            }
            
        }

        static void GetData((string Name, string LastName, int Age, string[] Pets, string[] favcolors) User)
        {
            Console.WriteLine("Имя = {0}", User.Name);
            Console.WriteLine("Фамилия = {0}",User.LastName);
            Console.WriteLine("Возраст= {0} лет",User.Age);
            if(User.Pets.Length > 0 && User.Pets[0] != string.Empty) 
            {
                for (int i = 0; i < User.Pets.Length; i++)
                {
                    Console.WriteLine("Pet {0},{1}",i + 1,User.Pets[i]);
                }
            }
            else
            {
                Console.WriteLine("Нет питомцев");
            }

            if (User.favcolors.Length > 0)
            {
                for (int i = 0; i < User.favcolors.Length; i++)
                {
                    Console.WriteLine("Color {0},{1}", i + 1, User.favcolors[i]);
                }
            }
            else
            {
                Console.WriteLine("Нет любимых цветов");
            }
        }



        static void Main(string[] args)
        {
            var myUser = EnterUser();
            GetData(myUser);
            
            Console.ReadKey();
        }
    }
}
