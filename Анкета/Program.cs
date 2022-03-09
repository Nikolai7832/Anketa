(string Name, string Login, int LoginLeght, bool HavePet, int Age, string [] FavColor) User;

bool Check = false;

for (int k = 0; k < 3; k++)
{
    while (Check == false)
    {
        Console.WriteLine("Введите ваше имя: ");
        User.Name = Console.ReadLine();

        if (String.IsNullOrEmpty(User.Name) == true)
        {
            Console.WriteLine("Некорректный ввод!");
        }
        else
        {
            Console.WriteLine("Здравствуйте, {0}!", User.Name);
            Check = true;
        }

    }

    Check = false;
    while (Check == false)
    {
        Console.WriteLine("Введите ваше логин: ");
        User.Login = Console.ReadLine();

        if (String.IsNullOrEmpty(User.Login) == true)
        {
            Console.WriteLine("Некорректный ввод!");
        }
        else
        {
            User.LoginLeght = User.Login.Length;
            Console.WriteLine("Длина логина: {0}", User.LoginLeght);
            Check = true;
        }

    }


    Check = false;
    while (Check == false)
    {
        Console.WriteLine("У вас есть животное (д/н)?: ");
        if (Console.ReadLine() == "д")
        {
            User.HavePet = true;
            Check = true;
        }
        else if (Console.ReadLine() == "н")
        {
            User.HavePet = false;
            Check = true;
        }
        else { Console.WriteLine("Некорректный ввод!"); }

    }
    Check = false;
    while (Check == false)
    {
        Console.WriteLine("Введите ваш возраст: ");
        Check = int.TryParse(Console.ReadLine(), out User.Age);
        if (Check == false)
        {
            Console.WriteLine("Некорректный ввод!");
        }
        else
        {
            break;
        }
    }
    User.FavColor = new string[3];
    for (int i = 0; i < User.FavColor.Length; i++)
    {
        Check = false;
        while (Check == false)
        {
            Console.WriteLine("Введите ваш любимый цвет №{0}: ", i);
            User.FavColor[i] = Console.ReadLine();

            if (String.IsNullOrEmpty(User.FavColor[i]) == true)
            {
                Console.WriteLine("Некорректный ввод!");
            }
            else
            {
                Check = true;
            }

        }
    }
}