using Parser.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Parser
{
    class Parse
    {
        private IParseSettings settings;

        private int nowpagecounter ;
        private string NewUri { get; set; }
        private List<string> PageTitles = new List<string>();
        private string[] Uris;
        public Parse(IParseSettings settings)
        {
            this.settings = settings;
            this.nowpagecounter = settings.PageStartIndex - 1;
            Uris = new string[settings.PageEndIndex];
            Uris[0] = settings.Uri;
            for (int i = settings.PageStartIndex-1; i < Uris.Length; i++)
            {
                Uris[i] = FindNewUri();
            }
        }
        public List<string> StartParse()
        {

            Parallel.For(settings.PageStartIndex-1, this.Uris.Length, this._StartParse);
            WriteTitlesToFile();
            return this.PageTitles;
        }
        private void WriteTitlesToFile()
        {
            FileStream _fileStream = null;
            StreamWriter _fileWriter = null;
            try
            {
                _fileStream = new FileStream("text.txt", FileMode.OpenOrCreate);
                _fileWriter = new StreamWriter(_fileStream);
                foreach (string _str in this.PageTitles)
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
            string uri = this.Uris[num];

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
                this.PageTitles.Add("");
                this.PageTitles.Add("Next page not Found");
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
                _startnum = htmlstr.IndexOf(settings.PageClass, _lastnum) + 1;
                if (_startnum - 1 == -1) break;
                _startnum = htmlstr.IndexOf(">", _startnum) + 1;
                _endnum = htmlstr.IndexOf("<", _startnum);
                _str = htmlstr.Substring(_startnum, _endnum - _startnum);
                _str = RaiseSpan(_str);
                this.PageTitles.Add(_str);
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
            this.nowpagecounter++;
            return settings.Uri + "/ru/page" + this.nowpagecounter + "/";
        }
    } 
}
