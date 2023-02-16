using System;

public class JPliteratureAssignment : JPAssignment
{
    private string _JParticle;

    public JPliteratureAssignment(string JPgivenName, string JPgivenTopic, string JParticle)
        : base(JPgivenName, JPgivenTopic)
    {
        _JParticle = JParticle;
    }
    public string JPsaveWritingWork()
    {
        string JPgivenName = JPsaveGivenName();
        return $"{_JParticle} by {JPgivenName}";
    }
}