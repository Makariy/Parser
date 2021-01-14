using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Parser
{
    class Parse
    {
        private IParseSettings m_Settings;

        private int m_NowPageCounter;
        private string m_NewUri { get; set; }
        private List<string> m_PageTitles = new List<string>();
        private string[] m_Uris;
        public Parse(IParseSettings settings)
        {
            this.m_Settings = settings;
            this.m_NowPageCounter = settings.PageStartIndex - 1;
            m_Uris = new string[settings.PageEndIndex];
            m_Uris[0] = settings.Uri;
            for (int i = settings.PageStartIndex-1; i < m_Uris.Length; i++)
            {
                m_Uris[i] = FindNewUri();
            }
        }
        public List<string> StartParse()
        {

            Parallel.For(m_Settings.PageStartIndex-1, this.m_Uris.Length, this._StartParse);
            WriteTitlesToFile();
            return this.m_PageTitles;
        }
        private void WriteTitlesToFile()
        {
            FileStream _fileStream = null;
            StreamWriter _fileWriter = null;
            try
            {
                _fileStream = new FileStream("text.txt", FileMode.OpenOrCreate);
                _fileWriter = new StreamWriter(_fileStream);
                foreach (string _str in this.m_PageTitles)
                {
                    _fileWriter.WriteLine(_str);
                }
                _fileWriter.Flush();
            }
            catch
            {
                if (_fileWriter != null) _fileWriter.WriteLine("Шот не то");
            }
            finally
            {
                if (_fileStream != null) _fileStream.Close();
            }
        }
        private void _StartParse(int num)
        {
            string uri = this.m_Uris[num];

            HttpWebRequest request = null;
            HttpWebResponse response = null;
            StreamReader reader = null;
            string str;
            try
            {
                request = (HttpWebRequest)HttpWebRequest.Create(uri);
                response = (HttpWebResponse)request.GetResponse();
                reader = new StreamReader(response.GetResponseStream());
            }
            catch(WebException exc)
            {
                this.m_PageTitles.Add("");
                this.m_PageTitles.Add("Next page not Found");
                return;
            }
            
            str = reader.ReadToEnd();
            FindNewPageTitles(str);
            
            
            if (response != null) response.Close();
            if (reader != null) reader.Close();
        }
        private void FindNewPageTitles(string htmlstr)
        {
            int _startnum;
            int _endnum = 0;
            int _lastnum = 0;
            string _str;
            while (_endnum != -1)
            {
                _startnum = htmlstr.IndexOf(m_Settings.PageClass, _lastnum) + 1;
                if (_startnum - 1 == -1) break;
                _startnum = htmlstr.IndexOf(">", _startnum) + 1;
                _endnum = htmlstr.IndexOf("<", _startnum);
                _str = htmlstr.Substring(_startnum, _endnum - _startnum);
                _str = RaiseSpan(_str);
                this.m_PageTitles.Add(_str);
                _lastnum = _endnum;
            }
        }
        private string RaiseSpan(string htmlstr)
        {
            string _str1;
            string _str2;
            int _start = 0;
            int _end;
            while(_start != -1)
            {
                _start = htmlstr.IndexOf('<');
                if (_start == -1) break;
                _end = htmlstr.IndexOf('>', _start);
                _str1 = htmlstr.Substring(0, _start);
                _str2 = htmlstr.Substring(_end);
                htmlstr = string.Concat(_str1, _str2);
            }
            return htmlstr;
        }
        private string FindNewUri()
        {
            this.m_NowPageCounter++;
            return m_Settings.Uri + "/ru/page" + this.m_NowPageCounter + "/";
        }
    } 
}
