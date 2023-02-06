using CsvHelper;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelToCsvUtf8Converter
{
    public partial class MainForm : Form
    {
        string filePath = string.Empty;
        string fileName = string.Empty;
        string directory = string.Empty;

        public MainForm()
        {
            InitializeComponent();

        }

        private void buttonStartConvert_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            fileName = Path.GetFileNameWithoutExtension(filePath);
            directory = Path.GetDirectoryName(filePath);
            XSSFWorkbook workbook = new XSSFWorkbook(file);
            file.Close();
            DataTable dataTable = new DataTable();
            ISheet sheet = workbook.GetSheetAt(0);
            List<string> header = new List<string>();
            IRow row = sheet.GetRow(0);
            for (int cellNum = 0; cellNum < row.LastCellNum; cellNum++)
            {
                header.Add(row.GetCell(cellNum).ToString());
                dataTable.Columns.Add(row.GetCell(cellNum).ToString(), typeof(string));
            }

            for (int i = 1; i <= sheet.LastRowNum; i++)
            {
                var dataRow = dataTable.NewRow();
                IRow wrokbookRow = sheet.GetRow(i);
                for (int cellNum = 0; cellNum < row.LastCellNum; cellNum++)
                {
                    ICell cell = wrokbookRow.GetCell(cellNum);
                    dataRow[header[cellNum]] = (cell is null) ? string.Empty : cell.ToString();
                }
                dataTable.Rows.Add(dataRow);
            }

            using (TextWriter writer = new StreamWriter(directory + "/" + fileName + ".csv", false, System.Text.Encoding.UTF8))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    foreach (DataColumn dc in dataTable.Columns)
                    {
                        csv.WriteField(dc.ColumnName);
                    }
                    csv.NextRecord();

                    foreach (DataRow dr in dataTable.Rows)
                    {
                        foreach (DataColumn dc in dataTable.Columns)
                        {
                            csv.WriteField(dr[dc]);
                        }
                        csv.NextRecord();
                    }                   

                }
            }
            MessageBox.Show("Ok");
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"d:\";
                openFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    fileName = Path.GetFileNameWithoutExtension(filePath);
                    directory = Path.GetDirectoryName(filePath);


                    textBoxFileDirector.Text = filePath;
                }
            }
        }

        public int GetColumnByName(XSSFWorkbook workbook, string columnName)
        {
            IRow firstRow = workbook.GetSheetAt(0).GetRow(0);

            for (int i = 0; i < firstRow.LastCellNum; i++)
            {
                if (firstRow.GetCell(i).ToString() == columnName)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
