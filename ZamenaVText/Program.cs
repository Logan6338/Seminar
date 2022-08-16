string text ="- Я думаю, - сказал князь, улыбаясь, - что, "
            +"ежеле бы вас поставили вместо нашего милого Винцергероду,";

//string s = "qwert"
//            012 
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);