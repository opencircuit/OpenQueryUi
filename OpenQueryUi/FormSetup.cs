using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace OpenQueryUi
{
    public partial class FormSetup : MaterialForm
    {
        private Excel.Application excel;
        private Excel.Workbook workbook;

        private Dictionary<string, ArrayList> columnDictionary;

        private string loadedSheetName;
        private string sqlFilePath;
        private bool createTable;
        private bool addIdColumn;

        public FormSetup()
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey900, Primary.Grey900,
                Primary.Grey900, Accent.LightBlue700,
                TextShade.WHITE
            );
        }

        private void action_FormLoad(object sender, EventArgs e)
        {
            columnDictionary = new Dictionary<string, ArrayList>();
            listviewColumns.Columns.Add("Column Name", 465);
            listviewColumns.ForeColor = Color.Blue;
        }

        private void action_SelectExcelFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK) { return; }
            else { textboxFilePath.Text = openFileDialog.FileName; }

            string filePath = textboxFilePath.Text;
            if (filePath.Length == 0 || !filePath.EndsWith(".xlsx")) {
                MessageBox.Show("Please select an appropriate Excel file (.xlsx).");
                textboxFilePath.Text = string.Empty;
                return;
            }

            columnDictionary.Clear();
            comboboxSheetNames.Items.Clear();
            listviewColumns.Items.Clear();
            event_AnalyzeExcelFile(filePath);
        }

        private void action_LoadSheetColumns(object sender, EventArgs e)
        {
            string sheetName = comboboxSheetNames.Text;
            if (sheetName.Length == 0) {
                MessageBox.Show("Please select a sheet to load.");
                return;
            }

            buttonExcludeSelectedColumn.Enabled = true;
            loadedSheetName = sheetName;
            listviewColumns.Items.Clear();
            ArrayList columnList = columnDictionary[sheetName];

            foreach (string columnName in columnList) {
                listviewColumns.Items.Add(columnName);
            }
        }

        private void action_RemoveSelectedColumn(object sender, EventArgs e)
        {
            try {

                int index = listviewColumns.SelectedItems[0].Index;
                listviewColumns.Items.RemoveAt(index);

                ArrayList columnList = columnDictionary[loadedSheetName];
                columnList.RemoveAt(index);
                columnDictionary[loadedSheetName] = columnList;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void action_CreateSqlFile(object sender, EventArgs e)
        {
            createTable = checkboxCreateTable.Checked;
            addIdColumn = checkboxGenerateID.Checked;
            string filePath = textboxFilePath.Text;
            int subStringLength = filePath.LastIndexOf("\\");
            filePath = filePath.Substring(0, subStringLength);
            sqlFilePath = filePath + "\\SQL-Data.sql";
            if (File.Exists(sqlFilePath)) { File.Delete(sqlFilePath); }
            event_GenerateQueries();
        }
    }
}