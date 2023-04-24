int MaxDigit (int randomNum){
    int dec = randomNum / 10;
    int ed = randomNum % 10;
    if (dec > ed) return dec;
    else return ed;
}

int num = new Random().Next(10, 99 + 1);
int result = MaxDigit(num);
Console.WriteLine($"{num} = {result}");
