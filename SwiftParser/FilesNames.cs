using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftParser {
    public class FilesNames {
        public List<string> InitialPaths { get; set; }
        public List<string> Master { get; set; }
        public List<string> Test { get; set; }
        public List<string> Common { get; set; }

        public FilesNames(string path) {
            InitialPaths = Directory.GetFiles(path).ToList();
            Master = new List<string>();
            Test = new List<string>();
            Common = new List<string>();
            DistributeFilesNames();
        }

        private void DistributeFilesNames() {
            string fileName;
            string versionMarker;

            foreach (string filePath in InitialPaths) {
                fileName = Path.GetFileName(filePath);
                versionMarker = fileName.Substring(0, 1);

                if (versionMarker == "[") {
                    Master.Add(fileName);
                }
                else if (versionMarker == "]") {
                    Test.Add(fileName);
                }
                else {
                    Common.Add(fileName);
                }
            }
        }
    }
}
