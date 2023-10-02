Random rand = new Random();
int i = rand.Next(100);
int need;
Console.WriteLine("Компьютер загадал число от 0 до 100. Попробуйте отгодать его за три попытки.");
int popa = 5;

while (popa<6)


{
    Console.WriteLine("\nМеню игр Тагира\n1.Игра угадай число\n2.Таблица умножения\n3.Вывод делителей числа\n4.Выход");
    int select = Convert.ToInt32(Console.ReadLine());
    switch (select)
    { case 1:
            while (true)

            {

                Console.WriteLine("Введите число:");
                need = Convert.ToInt32(Console.ReadLine());
                if (need == i)
                {
                    Console.WriteLine("Ты молодец!!!");
                    break;

                }
                else
                {
                    Console.WriteLine("Ты не угадал");
                    if (need > i)
                    {
                        Console.WriteLine("Надо меньше");
                    }

                    else
                    {
                        Console.WriteLine("Надо больше");
                    }

                }
            }
            break;

        case 2:
            for (int y = 1; y <= 9; y++)
            {


                for (int x = 1; x <= 9; x++)
                {



                    Console.Write(Convert.ToString(y * x) + "\t");

                }
                Console.WriteLine();
    } break;
        case 3:
            Console.WriteLine("Введите число:" );
            int yebak  = Convert.ToInt32(Console.ReadLine());
            for (int gnom = 1; gnom <= yebak; gnom++)
            {
            if(yebak%gnom==0) Console.Write(Convert.ToString(gnom) + "     ");
            


            }
            break;
        case 4: popa = 6;
            break;

    }
      

    
        





















}
