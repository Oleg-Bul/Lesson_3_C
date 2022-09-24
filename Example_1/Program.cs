//Вид 1 (ничего не принимает, ничего не возвращает)
void Method1() //функция без аргумента
{
    Console.WriteLine("Автор....");
}
//Method1();// для вызова функции(метода) нужно указать название и пустые скобки()
//........................................................................................
//Вид 2 (что-то принимает, ничего не возвращает)
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");
//............................................................................................
//Вид 2_1 (что-то принимает, ничего не возвращает)
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
    
}
//Method21(msg: "Текст",count: 4);// текст будет обращатся к msg, а "4" количество раз
//Method21(count: 4, msg: "новый Текст");//можно в любом порядке оба аргумента
//.........................................................................................................
// Вид 3 (ничего не принимает, что-то возвращает)
int Method3()
{
    return DateTime.Now.Year;//сегодняшний год
}
int year = Method3();//присвоили переменной "year" выполнение функции Method3
//Console.WriteLine(year);

//Вид4 (Что-то принимает, что-то возвращает)
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "qwerty");//склейка 10 текстов "qwerty" через String.Empty
Console.WriteLine(res);
