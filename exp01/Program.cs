// Мктод 1
void Method1()
{
    Console.WriteLine("Автор...");
}
//Method1();

//Метод 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg:"Текст сообщения");

void Method21(string msg, int count)
{
    int i=0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Текс", count: 4);
//Method21(count: 4, msg: "новый текст");

//Метод 3

int Method3()
{
    return DateTime.Now.Year;
}
//int Year = Method3();
//Console.WriteLine(Year);

//Метод 4

string Method4(int count, string Text)
{
    int i = 0;
    string result = string.Empty;

    while (i < count)
    {
        
        result = result + Text;
        i++;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);