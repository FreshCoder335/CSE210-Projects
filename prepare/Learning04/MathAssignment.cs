using System;

public class JParithmeticAssignment : JPAssignment
{
    private string _JPassignedTextbook;
    private string _JPassignedEquations;

    public JParithmeticAssignment(string JPgivenName, string JPgivenTopic, string JPassignedTextbook, string JPassignedEquations)
        : base(JPgivenName, JPgivenTopic)
    {
        _JPassignedEquations = JPassignedEquations;
        _JPassignedTextbook = JPassignedTextbook;
    }
        public string JPsaveHomeworkAssignment()
        {
            return $"Section {_JPassignedTextbook} Problems {_JPassignedEquations}";
        }
}