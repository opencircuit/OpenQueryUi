namespace OpenQueryUi
{
    partial class FormSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetup));
            this.panelBackground = new System.Windows.Forms.Panel();
            this.listviewColumns = new MetroFramework.Controls.MetroListView();
            this.buttonCreateSqlFile = new System.Windows.Forms.Button();
            this.buttonExcludeSelectedColumn = new System.Windows.Forms.Button();
            this.buttonLoadSheetColumns = new System.Windows.Forms.Button();
            this.comboboxSheetNames = new MetroFramework.Controls.MetroComboBox();
            this.checkboxCreateTable = new MaterialSkin.Controls.MaterialCheckBox();
            this.checkboxGenerateID = new MaterialSkin.Controls.MaterialCheckBox();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.textboxFilePath = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.White;
            this.panelBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBackground.Controls.Add(this.listviewColumns);
            this.panelBackground.Controls.Add(this.buttonCreateSqlFile);
            this.panelBackground.Controls.Add(this.buttonExcludeSelectedColumn);
            this.panelBackground.Controls.Add(this.buttonLoadSheetColumns);
            this.panelBackground.Controls.Add(this.comboboxSheetNames);
            this.panelBackground.Controls.Add(this.checkboxCreateTable);
            this.panelBackground.Controls.Add(this.checkboxGenerateID);
            this.panelBackground.Controls.Add(this.buttonSelectFile);
            this.panelBackground.Controls.Add(this.textboxFilePath);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 60);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Padding = new System.Windows.Forms.Padding(20);
            this.panelBackground.Size = new System.Drawing.Size(740, 365);
            this.panelBackground.TabIndex = 0;
            // 
            // listviewColumns
            // 
            this.listviewColumns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listviewColumns.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listviewColumns.ForeColor = System.Drawing.Color.Black;
            this.listviewColumns.FullRowSelect = true;
            this.listviewColumns.Location = new System.Drawing.Point(23, 114);
            this.listviewColumns.MultiSelect = false;
            this.listviewColumns.Name = "listviewColumns";
            this.listviewColumns.OwnerDraw = true;
            this.listviewColumns.Size = new System.Drawing.Size(486, 228);
            this.listviewColumns.TabIndex = 14;
            this.listviewColumns.Theme = MetroFramework.MetroThemeStyle.Light;
            this.listviewColumns.UseCompatibleStateImageBehavior = false;
            this.listviewColumns.UseCustomForeColor = true;
            this.listviewColumns.UseSelectable = true;
            this.listviewColumns.View = System.Windows.Forms.View.Details;
            // 
            // buttonCreateSqlFile
            // 
            this.buttonCreateSqlFile.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonCreateSqlFile.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonCreateSqlFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonCreateSqlFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonCreateSqlFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateSqlFile.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateSqlFile.ForeColor = System.Drawing.Color.White;
            this.buttonCreateSqlFile.Location = new System.Drawing.Point(515, 313);
            this.buttonCreateSqlFile.Name = "buttonCreateSqlFile";
            this.buttonCreateSqlFile.Size = new System.Drawing.Size(200, 29);
            this.buttonCreateSqlFile.TabIndex = 12;
            this.buttonCreateSqlFile.Text = "Create SQL File";
            this.buttonCreateSqlFile.UseVisualStyleBackColor = false;
            this.buttonCreateSqlFile.Click += new System.EventHandler(this.action_CreateSqlFile);
            // 
            // buttonExcludeSelectedColumn
            // 
            this.buttonExcludeSelectedColumn.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonExcludeSelectedColumn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonExcludeSelectedColumn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonExcludeSelectedColumn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonExcludeSelectedColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcludeSelectedColumn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcludeSelectedColumn.ForeColor = System.Drawing.Color.White;
            this.buttonExcludeSelectedColumn.Location = new System.Drawing.Point(515, 115);
            this.buttonExcludeSelectedColumn.Name = "buttonExcludeSelectedColumn";
            this.buttonExcludeSelectedColumn.Size = new System.Drawing.Size(200, 29);
            this.buttonExcludeSelectedColumn.TabIndex = 10;
            this.buttonExcludeSelectedColumn.Text = "Exclude Selected Column";
            this.buttonExcludeSelectedColumn.UseVisualStyleBackColor = false;
            this.buttonExcludeSelectedColumn.Click += new System.EventHandler(this.action_RemoveSelectedColumn);
            // 
            // buttonLoadSheetColumns
            // 
            this.buttonLoadSheetColumns.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonLoadSheetColumns.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonLoadSheetColumns.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonLoadSheetColumns.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonLoadSheetColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadSheetColumns.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadSheetColumns.ForeColor = System.Drawing.Color.White;
            this.buttonLoadSheetColumns.Location = new System.Drawing.Point(515, 79);
            this.buttonLoadSheetColumns.Name = "buttonLoadSheetColumns";
            this.buttonLoadSheetColumns.Size = new System.Drawing.Size(200, 29);
            this.buttonLoadSheetColumns.TabIndex = 8;
            this.buttonLoadSheetColumns.Text = "Load Sheet Columns";
            this.buttonLoadSheetColumns.UseVisualStyleBackColor = false;
            this.buttonLoadSheetColumns.Click += new System.EventHandler(this.action_LoadSheetColumns);
            // 
            // comboboxSheetNames
            // 
            this.comboboxSheetNames.DropDownHeight = 200;
            this.comboboxSheetNames.FormattingEnabled = true;
            this.comboboxSheetNames.IntegralHeight = false;
            this.comboboxSheetNames.ItemHeight = 23;
            this.comboboxSheetNames.Location = new System.Drawing.Point(23, 79);
            this.comboboxSheetNames.Name = "comboboxSheetNames";
            this.comboboxSheetNames.Size = new System.Drawing.Size(486, 29);
            this.comboboxSheetNames.TabIndex = 7;
            this.comboboxSheetNames.UseSelectable = true;
            // 
            // checkboxCreateTable
            // 
            this.checkboxCreateTable.AutoSize = true;
            this.checkboxCreateTable.Depth = 0;
            this.checkboxCreateTable.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkboxCreateTable.Location = new System.Drawing.Point(515, 186);
            this.checkboxCreateTable.Margin = new System.Windows.Forms.Padding(0);
            this.checkboxCreateTable.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkboxCreateTable.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkboxCreateTable.Name = "checkboxCreateTable";
            this.checkboxCreateTable.Ripple = true;
            this.checkboxCreateTable.Size = new System.Drawing.Size(197, 30);
            this.checkboxCreateTable.TabIndex = 5;
            this.checkboxCreateTable.Text = "Create Tables From Sheets";
            this.checkboxCreateTable.UseVisualStyleBackColor = true;
            // 
            // checkboxGenerateID
            // 
            this.checkboxGenerateID.AutoSize = true;
            this.checkboxGenerateID.Depth = 0;
            this.checkboxGenerateID.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkboxGenerateID.Location = new System.Drawing.Point(515, 236);
            this.checkboxGenerateID.Margin = new System.Windows.Forms.Padding(0);
            this.checkboxGenerateID.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkboxGenerateID.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkboxGenerateID.Name = "checkboxGenerateID";
            this.checkboxGenerateID.Ripple = true;
            this.checkboxGenerateID.Size = new System.Drawing.Size(153, 30);
            this.checkboxGenerateID.TabIndex = 4;
            this.checkboxGenerateID.Text = "Generate ID Column";
            this.checkboxGenerateID.UseVisualStyleBackColor = true;
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSelectFile.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonSelectFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonSelectFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectFile.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectFile.ForeColor = System.Drawing.Color.White;
            this.buttonSelectFile.Location = new System.Drawing.Point(515, 23);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(200, 30);
            this.buttonSelectFile.TabIndex = 3;
            this.buttonSelectFile.Text = "Select && Analyze Excel File";
            this.buttonSelectFile.UseVisualStyleBackColor = false;
            this.buttonSelectFile.Click += new System.EventHandler(this.action_SelectExcelFile);
            // 
            // textboxFilePath
            // 
            this.textboxFilePath.Depth = 0;
            this.textboxFilePath.Enabled = false;
            this.textboxFilePath.Hint = "Excel File Path";
            this.textboxFilePath.Location = new System.Drawing.Point(23, 27);
            this.textboxFilePath.MaxLength = 32767;
            this.textboxFilePath.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxFilePath.Name = "textboxFilePath";
            this.textboxFilePath.PasswordChar = '\0';
            this.textboxFilePath.SelectedText = "";
            this.textboxFilePath.SelectionLength = 0;
            this.textboxFilePath.SelectionStart = 0;
            this.textboxFilePath.Size = new System.Drawing.Size(486, 23);
            this.textboxFilePath.TabIndex = 2;
            this.textboxFilePath.TabStop = false;
            this.textboxFilePath.UseSystemPasswordChar = false;
            // 
            // FormSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 425);
            this.Controls.Add(this.panelBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSetup";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenQuery";
            this.Load += new System.EventHandler(this.action_FormLoad);
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Button buttonSelectFile;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxFilePath;
        private MaterialSkin.Controls.MaterialCheckBox checkboxCreateTable;
        private MaterialSkin.Controls.MaterialCheckBox checkboxGenerateID;
        private System.Windows.Forms.Button buttonLoadSheetColumns;
        private MetroFramework.Controls.MetroComboBox comboboxSheetNames;
        private System.Windows.Forms.Button buttonCreateSqlFile;
        private System.Windows.Forms.Button buttonExcludeSelectedColumn;
        private MetroFramework.Controls.MetroListView listviewColumns;
    }
}

