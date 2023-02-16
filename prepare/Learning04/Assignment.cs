// Jeremiah Powell 2/15/23
using System;

public class JPAssignment
{
    private string _JPgivenName;
    private string _JPgivenTopic;

    public JPAssignment(string JPgivenName, string JPgivenTopic)
    {
        _JPgivenName = JPgivenName;
        _JPgivenTopic = JPgivenTopic;
    }
    public string JPsaveGivenName()
    {
        return _JPgivenName;
    }
    public string JPsaveGivenTopic()
    {
        return _JPgivenTopic;
    }
    public string JPcreateSummary()
    {
        return _JPgivenName + " - " + _JPgivenTopic;
    }
}