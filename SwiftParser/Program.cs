using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftParser{
    class Program{
        static void Main(string[] args){
            string path = @"C:\Users\msbz\Desktop\swift_test\";
            FilesNames filesNames = new FilesNames(path);
            ExcelHandler excelHandler = new ExcelHandler(path, "Swift_test");

            for (int i = 0; i < filesNames.Master.Count; i++) {
                string curentMaster = filesNames.Master.[i];
                string curentTest = filesNames.Test[i];

                SwiftFile MswiftFile = new SwiftFile(curentMaster);
                MswiftFile.LoadData(path);

                SwiftFile TswiftFile = new SwiftFile(curentTest);
                TswiftFile.LoadData(path);

                excelHandler.PutDataToExcel(MswiftFile, TswiftFile);
               // Console.WriteLine($"{fileName} parse complited.");
            }
    
            Console.WriteLine("File saved.");
        }
    }
}
