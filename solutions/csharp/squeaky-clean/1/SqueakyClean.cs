using System.Text.RegularExpressions;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        List<char> myString = new List<char> {};
        string result = "";
        
        foreach(var c in identifier){
            myString.Add(c);
            
        }

        for(int i = 0; i < myString.Count; i++){
            char c = myString[i];
            if(char.IsLetter(c)){
                result += c;
            }
            if(char.IsControl(c)){
                result += "CTRL";
            }
            if(c == ' '){
                result += "_";
            }
            if(c == '-'){
                char upper = myString[i +1];
                upper = char.ToUpper(upper);
                result += upper;
                i++;
            }
        }
        result = Regex.Replace(result, @"[\u03B1-\u03C9]", "");
        return result;
    }
}







