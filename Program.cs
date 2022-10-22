// вариант решения 1 задачи
// bool a = true;
// int count = 0;
// while (a!=false){
//     Console.WriteLine("введите число");
//     int nums = int.Parse(Console.ReadLine()!);
//     if (nums>0){
//     count++;
//     }
//     Console.WriteLine("Для продолжения введите (true), для остановки (false)");
//     bool b = bool.Parse(Console.ReadLine()!);
//     a = b;
// }
// Console.WriteLine($"количество введеных чисел больше 0 = {count}");

//вторя задача
Console.WriteLine("для нахождения точки пересечения 2х прямых заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("введите b1");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("введите k1");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("введите b2");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("введите b1");
double k2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("введите k2");
double [] mass = new double[2];
IntersectionLine(b1,k1,b2,k2);

// блок массивов

// метод нахождения точек пересечения двух прямых (вторая задача)
void IntersectionLine (double nums1, double nums2, double nums3, double nums4){
double x=(nums3-nums1)/(nums2-nums4);
double y=nums2*(nums3-nums1)/(nums2-nums4)+nums1;
mass [0] = x;
mass [1] = y;
Console.WriteLine($"точка пересечения ([{String.Join("] [",mass)}])");
}