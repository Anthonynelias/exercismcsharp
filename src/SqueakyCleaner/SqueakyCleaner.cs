using System;
using System.Text.RegularExpressions;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        if (identifier == ""){
            return identifier;
        }
        identifier = SpacesCleaner(identifier);
        identifier = ControlReplacer(identifier);
        identifier = CamelCaseConverter(identifier);
        identifier = OmitNonLetter(identifier);
        
        return identifier;
        
        
    }
    private static string SpacesCleaner(string identifier){
        StringBuilder sb = new StringBuilder(identifier);
        return sb.Replace(' ', '_').ToString();
    }

    private static string ControlReplacer(string identifier){
        StringBuilder sb = new StringBuilder(identifier);
        return sb.Replace("\0", "CTRL").ToString();
    }
    private static string CamelCaseConverter(string identifier){
        string[] words = identifier.Split('-');
        for(int i = 1; i< words.Length; i++){
            string word = words[i];
            words[i] = word[0].ToString().ToUpper() + word.Substring(1);
        }
        return words.ToString();
    }
    private static string OmitNonLetter(string identifier){
        Regex re = new Regex(@"([a-zA-Z]+)(\d+)");
        Match result = re.Match(identifier);  
        string alphaPart = result.Groups[1].Value;
    
        return alphaPart;
    }
}
