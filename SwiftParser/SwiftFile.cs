using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftParser {
    public class SwiftFile {
        public string FileName { get; set; }
        public Dictionary<int, string> Data { get; set; }

        public SwiftFile(string fileName) {
            FileName = fileName;
            Data = new Dictionary< int, string> ();
        }

        public void LoadData(string path) {
            path += FileName;
            int rowNumber = 0;
            string line;

            using (StreamReader sr = new StreamReader(path)) {
                while (sr.Peek() >= 0) {
                    line = sr.ReadLine();
                    Data.Add(++rowNumber, line);
                }
            }
        }
    }
}
