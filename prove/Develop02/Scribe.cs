using System;
using System.Collections.Generic;

public class Scribe
{
    public string _fileName = "";

    public Scribe()
    {

    }

    public void SaveToFile(List<string> entries)
    {
        StreamWriter fileSave = new StreamWriter($"C:\\Users\\Grant Hibbert\\Documents\\CSE210-files\\CSE210Template\\prove\\Develop02\\{_fileName}");
        foreach (string entry in entries)
        {
            fileSave.WriteLine(entry);
        }
        fileSave.Close();
    }

    public List<string> LoadFromFile()
    {
        List<string> entryList = new List<string>();

        StreamReader fileLoad = new StreamReader($"C:\\Users\\Grant Hibbert\\Documents\\CSE210-files\\CSE210Template\\prove\\Develop02\\{_fileName}");
        string entry = fileLoad.ReadLine();

        while (entry != null)
        {
            entryList.Add(entry);
            entry = fileLoad.ReadLine();
        }
        fileLoad.Close();

        return entryList;
    }


}


// Data and information recieved from https://learn.microsoft.com/en-us/troubleshoot/developer/visualstudio/csharp/language-compilers/read-write-text-file
// for saving and loading files.