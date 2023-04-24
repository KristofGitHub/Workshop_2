// int MaxDigit (int randomNum){
//     int dec = randomNum / 10;
//     int ed = randomNum % 10;
//     if (dec > ed) return dec;
//     else return ed;
// }

// int num = new Random().Next(10, 99 + 1);
// int result = MaxDigit(num);
// Console.WriteLine($"{num} = {result}");

bool Kratn (int num1, int num2){
    if (num1 % num2 == 0) return true;
    else return false;
} 

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{num1}, {num2}, --> {Kratn(num1, num2)}, остаток равен {num1 % num2}");
