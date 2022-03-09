
    static (string name, string lastname, int age, string[] petname, string[] favcolor) NewUser()
    {
        (string name, string lastname, int age, string[] petname, string[] favcolor) User;


        Console.WriteLine("Введите ваше имя: ");
        User.name = StringCheck(Console.ReadLine());

        Console.WriteLine("Введите вашу фамилию: ");
        User.lastname = StringCheck(Console.ReadLine());

        Console.WriteLine("Введите ваш возраст: ");
        User.age = NumCheck(Console.ReadLine());

        Console.WriteLine("У вас есть животное (Да/Нет)?: ");// Любое значение кроме "Да" будет засчитано как нет.
        if (Console.ReadLine() == "Да")
        {
            Console.WriteLine("Введите колличество животных: ");
            int num = NumCheck(Console.ReadLine());
            User.petname = Array(num);
        }
        else
        {
            User.petname = new string[] { "Нет животных" };
        }

        Console.WriteLine("У вас есть любимый цвет (Да/Нет)?: ");// Любое значение кроме "Да" будет засчитано как нет.
        if (Console.ReadLine() == "Да")
        {
            Console.WriteLine("Введите колличество цветов: ");
            int num = NumCheck(Console.ReadLine());
            User.favcolor = Array(num);
        }
        else
        {
            User.favcolor = new string[] { "Нет любимых цветов" };
        }
        return User;
    }

    static int NumCheck(string forcheck)
    {
        bool check = false;
        int num = -1;

        while (check == false || num <= 0)
        {
            check = int.TryParse(forcheck, out num); ;
        }
        return num;

    }

    static string StringCheck(string forcheck)
    {
        while (String.IsNullOrEmpty(forcheck) == true)
        {
            Console.WriteLine("Некорректный ввод!");
            forcheck = Console.ReadLine();
        }
        return forcheck;
    }

    static string[] Array(int num)
    {
        string[] array = new string[num];
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Введите название №{0}: ", i);
            array[i] = StringCheck(Console.ReadLine());
        }
        return array;
    }

    static void ShowUser((string name, string lastname, int age, string[] petname, string[] favcolor) User)
    {
        Console.WriteLine("\n{0}\n{1}\n{2}", User.name, User.lastname, User.age);
        for (int i = 0; i < User.petname.Length; i++)
        {
            Console.Write(User.petname[i], ", ");
        }
        for (int i = 0; i < User.favcolor.Length; i++)
        {
            Console.Write(User.favcolor[i], ", ");
        }
    }

    var FirstUser = NewUser();

    ShowUser(FirstUser);