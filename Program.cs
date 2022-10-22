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
// Console.WriteLine("для нахождения точки пересечения 2х прямых заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
// Console.WriteLine("введите b1");
// double b1 = double.Parse(Console.ReadLine()!);
// Console.WriteLine("введите k1");
// double k1 = double.Parse(Console.ReadLine()!);
// Console.WriteLine("введите b2");
// double b2 = double.Parse(Console.ReadLine()!);
// Console.WriteLine("введите b1");
// double k2 = double.Parse(Console.ReadLine()!);
// Console.WriteLine("введите k2");
// double [] mass = new double[2];
// IntersectionLine(b1,k1,b2,k2);

// дополнительяная задача, чисто по кайфу
/*Найти произведение всех элементов массива целых чисел, меньших заданного числа. 
Размерность массива –10. Заполнение массива осуществить случайными числами от 50 до 100.*/
int [] mass = GetArray(10, 50, 100);// вызов метода с массивом
Console.WriteLine($"[{String.Join(",",mass)}]");
Console.WriteLine("введите число больше которого выполняется перемножение чисел масива ");
int Predel = int.Parse(Console.ReadLine()!);
int ProductOfNumbers = 1;
Proizv (Predel);


// блок массивов

// метод нахождения точек пересечения двух прямых (вторая задача)
// void IntersectionLine (double nums1, double nums2, double nums3, double nums4){
// double x=(nums3-nums1)/(nums2-nums4);
// double y=nums2*(nums3-nums1)/(nums2-nums4)+nums1;
// mass [0] = x;
// mass [1] = y;
// Console.WriteLine($"точка пересечения ([{String.Join("] [",mass)}])");
// }

// метод для расчета произведения (доп задача)
void Proizv (int nums){
for (int i =0; i<mass.Length;i++){
    if (mass[i]>nums){
        ProductOfNumbers *=mass[i];
    }
}
Console.WriteLine($"результат произведения чисел массива больше {Predel} равен {ProductOfNumbers}");
}

// метод для заполнения массива
int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}