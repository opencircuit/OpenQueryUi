using MaterialSkin.Controls;
using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace OpenQueryUi
{
    internal class ModelSetup
    {
    }

    public partial class FormSetup : MaterialForm
    {
        private void event_AnalyzeExcelFile(string filePath)
        {
            excel = new Excel.Application();
            workbook = excel.Workbooks.Open(filePath);
            int sheetCount = workbook.Sheets.Count;

            foreach (Excel.Worksheet sheet in workbook.Sheets) {

                int columnCount = sheet.Rows[1].Columns.Count;

                ArrayList columnList;
                columnList = event_CollectSheetColumns(sheet, columnCount);
                columnDictionary.Add(sheet.Name, columnList);
                comboboxSheetNames.Items.Add(sheet.Name);
            }

            workbook.Close();
            excel.Quit();
        }

        private ArrayList event_CollectSheetColumns(Excel.Worksheet sheet, int columnCount)
        {
            ArrayList columnList = new ArrayList();

            for (int columnIndex = 1; columnIndex < columnCount; columnIndex++) {

                var cell = sheet.Cells[1, columnIndex].Value;
                if (cell == null) { break; }
                string columnName = cell.ToString();
                columnList.Add(columnName);
            }

            return columnList;
        }

        private void event_GenerateQueries()
        {
            string filePath = textboxFilePath.Text;
            excel = new Excel.Application();
            workbook = excel.Workbooks.Open(filePath);
            int sheetCount = workbook.Sheets.Count;

            foreach (Excel.Worksheet sheet in workbook.Sheets) {

                int columnCount = sheet.Rows[1].Columns.Count;
                event_CreateTableQuery(sheet);
                event_CreateInsertQuery(sheet);
            }

            workbook.Close();
            excel.Quit();
        }

        private void event_CreateTableQuery(Excel.Worksheet sheet)
        {
            if (!createTable) { return; }

            StringBuilder query = new StringBuilder();
            query.Append("CREATE TABLE [").Append(sheet.Name).Append("] (");
            if (addIdColumn) { query.Append("[ID] INT, "); }

            ArrayList columnList = columnDictionary[sheet.Name];

            for (int columnIndex = 0; columnIndex < columnList.Count; columnIndex++) {

                if (columnIndex > 0) { query.Append(", "); }
                string columnName = (string)columnList[columnIndex];
                query.Append("[").Append(columnName).Append("] VARCHAR(255)");
            }

            query.Append(")");
            File.AppendAllText(sqlFilePath, query.ToString() + Environment.NewLine);
        }

        private void event_CreateInsertQuery(Excel.Worksheet sheet)
        {
            string initialQuery = event_GenerateInitialInserQuery(sheet);
            int rowCount = sheet.Rows.Count;

            for (int rowIndex = 2; rowIndex <= rowCount; rowIndex++) {

                var cell = sheet.Cells[rowIndex, 1].Value;
                if (cell == null) { break; }
                string values = event_RetrieveCellData(sheet, rowIndex);
                File.AppendAllText(sqlFilePath, initialQuery + values + Environment.NewLine);
            }
        }

        private string event_GenerateInitialInserQuery(Excel.Worksheet sheet)
        {
            StringBuilder query = new StringBuilder();
            query.Append("INSERT INTO [").Append(sheet.Name).Append("] (");
            if (addIdColumn) { query.Append("[ID], "); }

            ArrayList columnList = columnDictionary[sheet.Name];

            for (int columnIndex = 0; columnIndex < columnList.Count; columnIndex++) {

                if (columnIndex > 0) { query.Append(", "); }
                string columnName = (string)columnList[columnIndex];
                query.Append("[").Append(columnName).Append("]");
            }

            query.Append(") VALUES (");

            return query.ToString();
        }

        private string event_RetrieveCellData(Excel.Worksheet sheet, int rowIndex)
        {
            ArrayList columnList = columnDictionary[sheet.Name];
            int columnCount = sheet.Rows[1].Columns.Count;
            StringBuilder values = new StringBuilder();
            if (addIdColumn) { values.Append(rowIndex - 1).Append(", "); }

            for (int columnIndex = 1; columnIndex < columnCount; columnIndex++) {

                var cell = sheet.Cells[1, columnIndex].Value;
                if (cell == null) { break; }
                string columnName = cell.ToString();
                if (!columnList.Contains(columnName)) { continue; }

                string dataValue;
                cell = sheet.Cells[rowIndex, columnIndex].Value;
                if (cell == null) { dataValue = ""; }
                else { dataValue = cell.ToString(); }

                if (columnIndex > 1) { values.Append(", "); }
                values.Append("'").Append(dataValue).Append("'");
            }

            values.Append(")");

            return values.ToString();
        }
    }
}
