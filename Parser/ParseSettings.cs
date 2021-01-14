namespace Parser
{
    interface IParseSettings
    {
        string Uri { get; set; }
        int PageStartIndex { get; set; }
        int PageEndIndex { get; set; }
        string PageClass { get; set; }
    }
    class ParseSettings : IParseSettings
    {
        public string Uri { get ; set; }
        public int PageStartIndex { get ; set; }
        public int PageEndIndex { get; set; }
        public string PageClass { get; set; }
    }
}
