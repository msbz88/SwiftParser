using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spire.Xls;


namespace SwiftParser {
    class ExcelHandler {
        public Workbook ExcelWorkbook { get; set; }
        public Worksheet ExcelSheet { get; set; }
        static int MasterRow { get; set; } = 2;
        static int MasterColumn { get; set; } = 1;
        static int TestRow { get; set; } = 2;
        static int TestColumn { get; set; } = 4;

        public ExcelHandler(string path, string name) {
            ExcelWorkbook = new Workbook();
            ExcelSheet = ExcelWorkbook.Worksheets[0];
            ExcelSheet.Name = "Comparison";
            ExcelWorkbook.SaveToFile(path + name + ".xls", ExcelVersion.Version2013);
            ExcelWorkbook.Worksheets.Remove("Sheet2");
            ExcelWorkbook.Worksheets.Remove("Sheet3");
            AddHeadersToFile();
        }

        private void AddHeadersToFile() {
            ExcelSheet.Range["A1"].Text = "Master File name";
            ExcelSheet.Range["B1"].Text = "Master Order";
            ExcelSheet.Range["C1"].Text = "Master Content";
            ExcelSheet.Range["D1"].Text = "Test File name";
            ExcelSheet.Range["E1"].Text = "Test Order";
            ExcelSheet.Range["F1"].Text = "Test Content";
            ExcelSheet.Range["G1"].Text = "Comparison";
            ExcelSheet.Range["H1"].Text = "Description";
            ExcelSheet.Range["A1:H1"].Style.Font.IsBold = true;
        }

        public void PutDataToExcel(SwiftFile masterSwift, SwiftFile testSwift) {

            foreach (KeyValuePair<int, string> row in masterSwift.Data) {
                ExcelSheet.Range[MasterRow, MasterColumn].Text = masterSwift.FileName;
                ExcelSheet.Range[MasterRow, MasterColumn + 1].Text = row.Key.ToString();
                ExcelSheet.Range[MasterRow, MasterColumn + 2].Text = row.Value;
                MasterRow++;
            }

            foreach (KeyValuePair<int, string> row in testSwift.Data) {
                ExcelSheet.Range[TestRow, TestColumn].Text = testSwift.FileName;
                ExcelSheet.Range[TestRow, TestColumn + 1].Text = row.Key.ToString();
                ExcelSheet.Range[TestRow, TestColumn + 2].Text = row.Value;
                TestRow++;
            }

            for (int i = 1; i < masterSwift.Data.Count; i++) {
                if (masterSwift.Data[i] != testSwift.Data[i]) {
                    ExcelSheet.Range[i + 1, 7].Text = masterSwift.Data[i] + " | " + testSwift.Data[i];
                }
            }

            ExcelSheet.AllocatedRange.AutoFitColumns();
            ExcelWorkbook.Save();
        }

        public void ExecuteComparison(string master, string test) {
            //IEnumerable<char> diff;
            //ExcelFont fontColor = ExcelWorkbook.CreateFont();
            //fontColor.KnownColor = ExcelColors.Red;

            for (int i = 2; i < ExcelSheet.LastRow; i++) {

                if (master != test) {
                    ExcelSheet.Range[i, 7].Text = master + " | " + test;
                }

                Console.WriteLine("row " + i + " of " + ExcelSheet.LastRow + " compared.");

                /*
                if (result.Count > 0) {
                    RichText richText = ExcelSheet.Range[i, 7].RichText;
                    richText.Text = result.ToString();
                    richText.SetFont(0, richText.Text.Length, fontColor);
                    */
                //ExcelSheet.Range[i, 7].RichText.Text = result.ToString();}

            }
        }
    }
}
