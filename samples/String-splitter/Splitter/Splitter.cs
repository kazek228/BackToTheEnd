namespace Splitter;
public class Splitter
{
    public string CheckItOut(string str)
    {
        //60 
        int a; 
        foreach (var item in str)
        {
            a = item;
            if (a < 97)
                throw new($"{item}");
        }
        return str;
    }
}
