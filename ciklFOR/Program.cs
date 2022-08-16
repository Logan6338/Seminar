string Method4(int count, string Text)
{
    string result = string.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + Text;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);
