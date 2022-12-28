//Написать программу, которая из имеющегося массива строк
//формирует массив из строк, длина которых меньше, либо
//равна 3 символа. Первоначальный массив можно ввести с клавитуры
//либо задать на старте выполнения алгоритма. При решении
//не рекомендуется пользоваться коллекциями, лучше обойтись
//исключительно массивами.

int IntegerPrompt(string message)
{
    Console.Write($"{message} >");              
    return Convert.ToInt32(Console.ReadLine()); 
}

string[,] FillArray(string[,] list)
{
    for (int i = 0; i < list.GetLength(0); i++)
    {
        for (int j = 0; j < list.GetLength(1); j++)
        {
            Console.Write($"Введите значение строки {1+i} колонки {1+j}: ");
            list[i,j]=Convert.ToString(Console.ReadLine());
            if (list[i,j] == "") {
                list[i,j] = ":)";
            }
        }
    }
    return list;
}

void PrintArray(string[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + " ");
    }
}


void PrintArrayTwo(string [,] matr)
{
    
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i,j]} \t");
        }
        System.Console.WriteLine();
    }   

}

string [] ThreeElemntsInArray (string [,] matr, int value) {
    
    int index = 0;
    string[] secondArray = new string [value];
       
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i,j].Length <=3) {
                
                secondArray[index] = matr[i,j];
                index++;
            
            }
            
        }
    }    

    return secondArray;
}

int ValueOfElementsInArray (string [,] matr) {
    int index = 0;   
    
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i,j].Length <= 3) index++;
        }
    }
    return index;
}

int m = IntegerPrompt("Введите количество строк ");
int n = IntegerPrompt("Введите колличество столбцов ");

string [,] array = new string[m,n];

PrintArrayTwo(FillArray(array));
string [] rows = ThreeElemntsInArray(array, ValueOfElementsInArray(array));

Console.WriteLine("Отсортированный массив:");
PrintArray(rows);
