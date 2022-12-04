
string[] input = System.IO.File.ReadAllLines(@"C:\Users\evka\Documents\adventofcode.txt");

static int ConvertToscore(char c)
{
    byte test = (byte)c;
    return Char.IsUpper(c) ? (int)test - 38 : (int)test - 96;
}

var sum = 0;
for (int i = 0; i < input.Length; i = i + 3)
{
    foreach (char c in input[i])
    {
        if (input[i + 1].Contains(c) && input[i + 2].Contains(c))
        {
            Console.WriteLine(ConvertToscore(c) + " - " + c);
            sum += ConvertToscore(c);
            break;
        }
    }

}
foreach (string line in input)
{
    var firstRucksackLength = line.Length / 2;
    var secondRucksackLength = line.Length - firstRucksackLength;
    var firstRucksack = line.Substring(0, firstRucksackLength);
    var secondRucksack = line.Substring(line.Length / 2, secondRucksackLength);
    foreach (char c in firstRucksack)
    {
        if (secondRucksack.Contains(c))
        {
            sum += ConvertToscore(c);
            Console.WriteLine(c);
            break;
        }
    }

    Console.WriteLine("RESULTAT = " + sum);