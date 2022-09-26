void Method1() //метод который НЕ принимает аргументы и ничего не возвращает
{
    Console.WriteLine("Автор ...");
}
// Method1();

void Method2(string msg, int count) //метод который принимает аргументы но ничего не возвращает
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method2(msg:"Hello", count:5);

int Method3() // метод возвращает значение , но ничего НЕ принимает
{
    return DateTime.Now.Year;
}
//int year=Method3();
//Console.WriteLine(year);


string Method4(int count, string text) // метод принимает аргументы и возвращает результат работы функции 
{
    int i = 0;
    string result = String.Empty; // пустая строка
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
// // string res=Method4(10,"asdf");
// // Console.WriteLine(res);

string Method41(int count, string text) // метод принимает аргументы и возвращает результат работы функции 
{
    string result = String.Empty; // пустая строка
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
// string res = Method41(10, "g");
// Console.WriteLine(res);


////ЦИКЛ В ЦИКЛЕ (таблица умножения)
// for (int i = 2; i <= 10; i++)
//     {
//         for (int j = 2; j <=10; j++)
//         {
//         Console.WriteLine($"{i}x{j}={i*j}");
//         }
//         Console.WriteLine();
//     }

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”

string Replace(string text,char oldValue,char newValue)
{
    string result=String.Empty;
    int length=text.Length;
    for(int i=0;i<length;i++)
    {
        if(text[i]==oldValue) result=result+$"{newValue}";
        else result=result+$"{text[i]}";
    }
    return result;
}

// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
// + "ежели бы вас послали вместо нашего милого Винценгероде,"
// + "вы бы взяли приступом согласие прусского короля."
// + "Вы так красноречивы. Вы дадите мне чаю?";

// string newText=Replace(text,' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText=Replace(newText,'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText=Replace(newText,'С', 'с');
// Console.WriteLine(newText);
// Console.WriteLine();



/////// Сортировка массива методом выбора

int [] arr={ 1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count=array.Length;
    for(int i=0; i<count;i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

void SelectionSort(int [] array)
{

    for(int i=0; i<array.Length-1;i++)
    {
        int minPosition=i;
        
        for(int j=i+1; j<array.Length;j++)
    {
        if(array[j]<array[minPosition]) minPosition=j;
    }
        int temporary=array[i];
        array[i]=array[minPosition];
        array[minPosition]=temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);






