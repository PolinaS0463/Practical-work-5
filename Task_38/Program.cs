Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] fillArrayWithRandom(int size){
    double[] new_array = new double[size];
    Random num = new Random();
    for(int index = 0; index <= new_array.Length - 1; index++){
        new_array[index] = Math.Round(num.NextDouble() * (15 - (-15)) + (-15), 2);
    }
    return new_array;
}
double[] array = fillArrayWithRandom(size);
Console.WriteLine("[" + string.Join(", ", array) + "]");

double min = array[0];
double max = array[0];

double findDifferenceBetweenMinMax(double[] arr){
    foreach(double num in arr){
        if(num < min){
            min = num;
        }
        if(num > max){
            max = num;
        }
    }
    double difference = max - min;
    return difference;
}

double result = findDifferenceBetweenMinMax(array);
Console.WriteLine($"В массиве [" + string.Join(", ", array) + $"] разница максимального и минимального числа равна {Math.Round(result, 3)}");