// вариант решения 1 задачи
bool a = true;
int count = 0;
while (a!=false){
    Console.WriteLine("введите число");
    int nums = int.Parse(Console.ReadLine()!);
    if (nums>0){
    count++;
    }
    Console.WriteLine("Для продолжения введите (true), для остановки (false)");
    bool b = bool.Parse(Console.ReadLine()!);
    a = b;
}
Console.WriteLine($"количество введеных чисел больше 0 = {count}");
