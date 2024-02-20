namespace LogicCalculator;

/// <summary>
/// <para>
///     Main class for the Calculator function
///     The Calculator will receive and parse a logical formula
/// </para>
/// 
/// <para>
///     Due to the way logical operators are used, some symbols will be replaced in order to fit mainstream keyboards
/// </para>
/// 
/// <para>
///     Set relations and other more advanced capabilities will be explored and programmed in another section of the Calculator Solution
/// </para>
/// </summary>
public class Calculator{

    private static Dictionary<string, string> ValueDict = new();
    private static Formula PostFormula;

    public Calculator(string FormulaString){
        ValueDict = new();
        PostFormula = new Formula(FormulaString);
    }   

    public Calculator(Dictionary<string, string> values){
        ValueDict = values;
    }  

    public Dictionary<string, string> getValueDictionary(){
        return ValueDict;
    }

    public string getValue(string key){
        if (ValueDict.ContainsKey(key))
            return ValueDict[key];
        return "";
    }
    public void AddValue(string key, string value){
        if (ValueDict.ContainsKey(key))
            ValueDict[key] = value;
        else
            ValueDict.Add(key, value);
    }
}