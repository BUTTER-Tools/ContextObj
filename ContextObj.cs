namespace ContextObj
{
    public class ContextObj
    {
        public string[] LeftContext { get; set; }
        public string[] RightContext { get; set; }
        public string[] MatchedWords { get; set; }

        public ContextObj(string[] l, string[] r, string[] w)
        {
            LeftContext = l;
            RightContext = r;
            MatchedWords = w;
        }

    }
}
