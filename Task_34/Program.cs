Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] fillArrayWithRandom(int size){
    int[] new_array = new int[size];
    Random num = new Random();
    for(int index = 0; index <= new_array.Length - 1; index++){
        new_array[index] = num.Next(100, 1000);
    }
    return new_array;
}
int[] array = fillArrayWithRandom(size);
Console.WriteLine("[" + string.Join(", ", array) + "]");

int findEvenNumbers(int[] arr){
    int count = 0;
    foreach(int num in arr){
        if(num % 2 == 0){
            count += 1;
        }
    }
    return count;
}

int result = findEvenNumbers(array);
Console.WriteLine($"В массиве [" + string.Join(", ", array) + $"] {result} четных чисел(ла)");