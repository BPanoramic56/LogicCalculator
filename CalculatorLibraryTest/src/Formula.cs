using System.Reflection.Metadata.Ecma335;
using System.Xml;

namespace LogicCalculator;

public class Formula{

    private List<string> Tokens;
    
    public Formula(string PreFormula){

        Tokens = Tokenize(PreFormula);
    }

    private static List<string> Tokenize(string Given){
        List<string> tokens = new();

        

        return tokens;
    }
}