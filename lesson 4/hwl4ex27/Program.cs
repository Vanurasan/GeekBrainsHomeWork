//Не знаю читаете ли вы комментарии к коду, но в дз 3 у меня были проблемы в VS Code
//Он не принимает строку
//char[] a = Console.ReadLine().ToCharArray();
//Visual Studio Принимает её спокойно (Я уже писал на C# и мне привычнее переносить код из VS в VSC)
//Поэтому тут реализую обычный способ разбить число (Я таким в Паскале пользовался, XD)
int x = Convert.ToInt32(Console.ReadLine());
int sum=0;
for (int i = 0; i < x.ToString().Length; i++)
{
    int a = x % 10;
    x /= 10;
    sum=sum+a;
}
sum=sum+x;
Console.WriteLine(sum);