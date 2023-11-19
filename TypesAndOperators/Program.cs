// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
{
    // Это сообщение будет выведено на экран
    /* Console.WriteLine("Hello, World!");
    {
        Console.WriteLine("Hello, World!");
    }
    const int MINUTES_IN_HOUR = 60;
    string name;
    
    name = "Bob";
    Console.WriteLine(name);

    name = "Bob1";
    Console.WriteLine(name);

    name = "Bob2";
    Console.WriteLine(name);

    Console.WriteLine(true);
    Console.WriteLine(false);
    Console.WriteLine(10);
    Console.WriteLine(-10);

    Console.WriteLine(1.224);
    Console.WriteLine(1.224F);


    Console.WriteLine('H');

    //Console.WriteLine(null);

    Console.WriteLine("Hello, \t World!");
    Console.WriteLine("Hello, \n World!");
    Console.WriteLine("Hello, \\ World!");

    bool flag = true;

    sbyte sb = 30;

    float a = 3.14F;
    float a1 = 3.14f;

    decimal b = 3.14M;
    decimal b = 3.14m;

    var d = 10;
    var d1 = 10.2f;
    var d2 = 'D';

    int g;
    g = 20;

    var g1 = 20;
    */

    /*
        Console.WriteLine("Добро пожаловать в С#");
        Console.Write("Надеюсь вы ");
        Console.Write("постигнете нюанчы в С# \n");
        Console.WriteLine("И все будет гуд");

        int g;
        g = 20;

        Console.WriteLine("g = " + g);

        string name = "Tom";
        int age 34;
        double height = 1.7;

        Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {height});
        Console.WriteLine($"Имя: {0} Возраст: {2} Рост: {1}, name, height, age);
    */

    /*
    Console.WriteLine("Введите свое имя:");
    string name = Console.ReadLine();
    Console.WriteLine($"Ваше имя {name}");

    Console.WriteLine("Введите свой возраст:");
    string age_str = Console.ReadLine();
    int age = Convert.ToInt32(age_str);
    Console.WriteLine($"Ваш возраст {age}");


   double x = 10.0;
   double z = x % 4;
   Console.WriteLine($"Результат {z}");

   byte a = 4;
   byte resullt = (byte)(a + 70);
   */

    /*
    if (условие)
    {

    }
    else
    {

    }
    */


    bool a = true;
    bool b = false;

    if (a || b)
    {
        Console.WriteLine("Верно");
    }

    else
    {
        Console.WriteLine("Не Верно");

    }





    // Решение нашей задачи
    // Подготовка данных
    bool isWhiteBreadFresh = true;
    ushort WhiteBreadPrice = 150;
    ushort ButterPrice = 230;
    ushort MillkPrice = 170;
    float MilkFatPercentage = 1.2F;
    ushort iceCreamPrice = 350;

    Console.Write("Введите начальную сумму: ");
    string? sumString = Console.ReadLine();
    short sum = Convert.ToInt16(sumString);

    if (sum > 0 )
    {
        if (!isWhiteBreadFresh)
        {
            if Console.WriteLine("Батон не свежий");
            {
                sum = (short)(sum - WhiteBreadPrice);
            }
          
        }
        else
        {
            Console.WriteLine("Батон не свежий");
        }

        sum = (short)(sum - ButterPrice);

        if (MilkFatPercentage == 1.2F)
        {
            sum = Convert.ToInt16(sum - MillkPrice);
        }

        if (sum >= iceCreamPrice) ;
        {
            sum = Convert.ToInt16(sum - iceCreamPrice);
        }

        Console.WriteLine($"Остаток суммы: {sum}");
    }
    else
    {
        Console.WriteLine("Сумма не может быть меньше нуля");
    }
}


int x = 1;
if (x==1)
{
    Console.WriteLine("1");
}
else if (x==2)
{
    Console.WriteLine("2");

}
else if (x == 3)
{
    Console.WriteLine("3");

}
else
{
    Console.WriteLine("Не соответствует условиям");
}

switch (x)
{
    case 1: Console.WriteLine("1");
        break;
    case 2: Console.WriteLine("2");
        break;
    case 3: Console.WriteLine("3");
        break;
    default: Console.WriteLine("Не соответствует условиям"); 
        break;

}