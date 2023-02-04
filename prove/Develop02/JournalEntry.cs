using System;
using System.Collections.Generic;

public class JournalEntry
{
    public string _date = "";
    public string _prompt = "";
    public string _inputUser = "";

    public JournalEntry()
    {

    }

    public string CreateEntry()
    {
        string entry = ($"{_date}, {_prompt}: {_inputUser}");
        return entry;
    }
}