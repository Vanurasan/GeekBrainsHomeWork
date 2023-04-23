Console.Write("Введите А:");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B:");
int B = Convert.ToInt32(Console.ReadLine());
//Math.Pow(A, B); :)
int result = 1;
for (int i = 0; i<B; i++) {result=result*A;}
Console.WriteLine(result);