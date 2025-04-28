class TransformStringFinal: IStringTransformation
{
    public string Transform(string input)
    {
        List<IStringTransformation> listaTrasformaStringa = new List<IStringTransformation>()
        {
            new UpperCaseTransformer(),
            new AddWorldTransformer(),
            new ReverseTransformer(),
            new AddExclamationTransformer(),
            
        };

        var risultato = input;

        foreach (var item in listaTrasformaStringa)
        {
            risultato = item.Transform(risultato);
        }
        return risultato;
    }
}

class UpperCaseTransformer: IStringTransformation
{
    public string Transform(string input)
    {
        return input.ToUpper();
    }
}

class ReverseTransformer : IStringTransformation
{
    public string Transform(string input)
    {
        char [] charArray = input.ToCharArray();
        string reversedString = "";

        for (int i = charArray.Length - 1; i >= 0; i--)
        {
            reversedString += charArray[i];  
        }
        //char[] charArray = input.ToCharArray(); o anche cosi al posto del for
        //Array.Reverse(charArray);
        //return new string(charArray);
       

        return reversedString;
    }
}

class AddExclamationTransformer: IStringTransformation
{
    public string Transform(string input)
    {
        return "!" + input;
    }
}

class AddWorldTransformer : IStringTransformation
{
    public string Transform(string input)
    {
        return $"{input} WORLD";
    }
}
