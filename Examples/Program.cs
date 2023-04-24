// int MaxDigit (int randomNum){
//     int dec = randomNum / 10;
//     int ed = randomNum % 10;
//     if (dec > ed) return dec;
//     else return ed;
// }

// int num = new Random().Next(10, 99 + 1);
// int result = MaxDigit(num);
// Console.WriteLine($"{num} = {result}");





// bool Kratn (int num1, int num2){
//     if (num1 % num2 == 0) return true;
//     else return false;
// } 

// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{num1}, {num2}, --> {Kratn(num1, num2)}, остаток равен {num1 % num2}");



// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14  ->  нет
// 46  ->  нет
// 161 ->  да


// Console.WriteLine("Введите первое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// bool Kratn (int num){
//     if ((num % 7 == 0) && (num % 23 == 0)) return true;
//     else return false;
// }
// Console.WriteLine($"Введено число {num}, Кратно ли оно 7 и 23 одновременно - {Kratn(num)}");



// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool Kv (int num1, int num2){
    if ((num1 == num2 * num2) || (num2 == num1*num1)) return true;
    else return false;
}
if (Kv(num1, num2) == true) Console.WriteLine($"Одно число является квадратом другого");
else Console.WriteLine($"Одно число НЕ является квадратом другого");
