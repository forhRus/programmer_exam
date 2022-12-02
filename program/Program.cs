// Задача: Написать программу, которая из имещегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 

//метод принимает массив и выводит его на экран. 
//По условию программа этого не делает, но просто для наглядности.
void PrintArray(string[] array) 
{
    System.Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($", {array[i]}");
    }
    System.Console.WriteLine("");
}

//метод принимает массив и, увеличив длину массива на один элемент, возвращает его копию
string[] IncreaseArray(string[] array) 
{
    string[] tempArray = new string[array.Length + 1];
    for (int i = 0; i < array.Length; i++)
    {
        tempArray[i] = array[i];
    }
    return tempArray;
}

//Метод принимает массив и переменную (длина строки) 
//и возвращает массив с элементами, которые не больше этой переменной
string[] ArraySorting(string[] array, int nLatter) 
{
    string[] tempArray = { String.Empty };
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= nLatter)
        {
            if (j == 0)
            {
                tempArray[j] = array[i];
            }
            else
            {
                tempArray = IncreaseArray(tempArray);
                tempArray[j] = array[i];
            }
            j++;
        }
    }
    return tempArray;
}

//метод принимает сообщение о заполнение массива и условиях завершения ввода
string[] FillArray(string message) 
{
    //по другому не придумал, в любом случае будет возвращать массив с одним элементом
    string[] array = { string.Empty };
    int index = 0;
    string element = string.Empty;
    // Изначально условием выхода был "null" в элементе, который достигался зажатием CTRL + Z, 
    // но в гит баш прога не реагировала на такую комбинацию, и пришлось наколхозить
    string exit = "***";
    while (element != exit) //выход из цикла по вводу "***"
    {
        System.Console.Write(message);
        element = Console.ReadLine();
        if (element == exit) break;
        // увеличиваю массив на единицу
        if (index != 0) array = IncreaseArray(array); 
        array[index] = element;
        index++;
    }
    return array;
}

string[] startArray = FillArray("Введите текст, чтобы заполнить элемент массив. Для окончания ввода элемента массива нажмите 'Enter'. Для завершения заполнения массива нажмите '***'. -> ");

//по условию три буквы
int numberOfLatter = 3; 

//формирую массив из элеменотов другого массива с элементами до трёх букв
string[] sortArray = ArraySorting(startArray, numberOfLatter); 

// вывод массива
PrintArray(sortArray); 
