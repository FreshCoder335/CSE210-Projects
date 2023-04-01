// Jeremiah Powell 
// 3/21/23
using System;
using System.IO;

public class JPfileManager
{
    public JPfileManager()
    {

    }

    public List<List<string>> JPfileLoader()
    {
        List<List<string>> JPlines = new List<List<string>>();
        string JPfileName = "Inventory.txt";
        string[] JPlinesSplit = System.IO.File.ReadAllLines(JPfileName);

        foreach (string JPlineSplit in JPlinesSplit)
        {
            List<string> JPpartsofTxt = new List<string>();
            string[] JParraysChunk = JPlineSplit.Split("|");

            foreach (string JParrayChunk in JParraysChunk)
            {
                JPpartsofTxt.Add(JParrayChunk);
            }

            JPlines.Add(JPpartsofTxt);
        }
        return JPlines;
    }

    public void JPfileSave(List<string> JPinventoryList)
    {
        string JPfileName = "Inventory.txt";
        string[] JPlinesSplit = System.IO.File.ReadAllLines(JPfileName);
        List<string> JPlines = new List<string>();
        foreach (string JPlineSplit in JPlinesSplit)
        {
            JPlines.Add(JPlineSplit);
        }

        string JPfirearmCount = JPinventoryList.ToString();

        JPlines[0] = JPfirearmCount;

        foreach (string JPinventoryCount in JPinventoryList)
        {
            JPlines.Add(JPinventoryCount);
        }

        TextWriter JPsystemWipe = new StreamWriter(JPfileName, false);
        JPsystemWipe.Write(string.Empty);
        JPsystemWipe.Close();

        using (StreamWriter JPuserFile = new StreamWriter(JPfileName))
        {
            foreach (string JPline in JPlines)
            {
                JPuserFile.WriteLine($"{JPline}");
            }
        }
    }

}