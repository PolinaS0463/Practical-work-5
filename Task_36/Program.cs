Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] fillArrayWithRandom(int size){
    int[] new_array = new int[size];
    Random num = new Random();
    for(int index = 0; index <= new_array.Length - 1; index++){
        new_array[index] = num.Next(-20, 21);
    }
    return new_array;
}
int[] array = fillArrayWithRandom(size);
Console.WriteLine("[" + string.Join(", ", array) + "]");

int countSumOnOddPositions(int[] arr){
    int sum = 0;
    for(int index = 1; index <= arr.Length-1; index += 2){
        sum += arr[index];
    }
    return sum;
}

int result = countSumOnOddPositions(array);
Console.WriteLine($"В массиве [" + string.Join(", ", array) + $"] сумма чисел, стоящих на нечетных позициях равна {result}");