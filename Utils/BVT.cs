using Spire.Xls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ECO_DX_For_PUR.Utils
{
    public static class BVT
    {
        public static void ClickButtonMenu(Button btn, Panel panle)
        {
            foreach (Button item in panle.Controls.OfType<Button>())
            {
                item.BackColor = Color.LightYellow;
                item.FlatStyle = FlatStyle.Popup;
            }
            btn.BackColor = System.Drawing.Color.White;
            btn.FlatStyle = FlatStyle.Flat;
        }

        public static void AddFormToPanel(Form form, Panel panel)
        {
            panel.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            panel.Controls.Add(form);
            form.Show();
        }
        public static void StartFormLoading()
        {
            FormLoading formLoading = new FormLoading();
            var formList = Application.OpenForms.Cast<Form>();
            var formActive = formList.Where(w => w.Name == "FormLoading").ToList();
            if (formActive.Count() == 0)
            {
                Thread thread = new Thread(() =>
                {
                    formLoading.ShowDialog();
                });
                thread.Start();
            }

        }
        public static void CloseFormLoading()
        {
            var formList = Application.OpenForms.Cast<Form>();
            var formLoad = formList.Where(w => w.Name == "FormLoading").ToList();
            if (formLoad.Count > 0)
            {
                foreach (var form in formLoad)
                {
                    form.Invoke(new MethodInvoker(delegate ()
                    {
                        form.Close();
                    }));
                }
            }
        }
        public static string GetFilePathFromXml(string nodeXML)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("config.xml"); // để trong debug

            XmlNode filePathNode = xmlDoc.SelectSingleNode($"/Config/{nodeXML}");

            return filePathNode?.InnerText;
        }

        public static void CloseForm(string formName)
        {
            var formList = Application.OpenForms.Cast<Form>();
            var formInsert = formList.Where(w => w.Name == formName).ToList();
            foreach (var form in formInsert)
            {
                form.Close();
            }
        }
        #region Excel
        public static DataTable dataTable;

        public static DataTable ImportExcel(string filePath)
        {
            // Create a workbook
            Workbook workbook = new Workbook();

            // Load the Excel file
            workbook.LoadFromFile(filePath);

            // Assume you are working with the first worksheet
            Worksheet sheet = workbook.Worksheets[0];

            // Create a DataTable
            dataTable = new DataTable();
            //dataTable.Columns.Add("STT");
            // Set up DataTable columns based on Excel columns
            for (int col = 1; col <= sheet.LastColumn; col++)
            {
                dataTable.Columns.Add(sheet[1, col].Text);
            }
            //int index = 1;
            // Read data from the worksheet and fill DataTable
            for (int row = 2; row <= sheet.LastRow; row++)
            {

                DataRow dataRow = dataTable.NewRow();
                //dataRow[0] = index;
                for (int col = 1; col <= sheet.LastColumn; col++)
                {
                    // Access cell value using sheet[row, col].Text
                    string cellValue = sheet[row, col].DisplayedText;
                    dataRow[col - 1] = cellValue;
                }
                dataTable.Rows.Add(dataRow);
                //index++;
            }

            // Close the workbook
            workbook.Dispose();
            return dataTable;
        }
        public static string GetExelFilePath()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xls;*.xlsx",
                Title = "Select an Excel File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return null;
        }
        public static DataTable GetColumnHeader(string filePath)
        {
            // Create a workbook
            Workbook workbook = new Workbook();

            // Load the Excel file
            workbook.LoadFromFile(filePath);

            // Assume you are working with the first worksheet
            Worksheet sheet = workbook.Worksheets[0];

            // Create a DataTable
            dataTable = new DataTable();
            //dataTable.Columns.Add("STT");
            // Set up DataTable columns based on Excel columns
            for (int col = 1; col <= sheet.LastColumn; col++)
            {
                dataTable.Columns.Add(sheet[1, col].Text);
            }
            // Close the workbook
            workbook.Dispose();
            return dataTable;
        }

        public static void ExportData(DataTable dataResult, string savePath)
        {
            Workbook workbook = new Workbook();
            workbook.LoadFromFile(savePath);

            // Get the first worksheet
            Worksheet sheet = workbook.Worksheets[0];
            int startRow = sheet.LastRow + 1; // Start from the next row after the last used row

            // Insert data into the worksheet
            for (int i = 0; i < dataResult.Rows.Count; i++)
            {
                DataRow row = dataResult.Rows[i];

                for (int j = 0; j < dataResult.Columns.Count; j++)
                {
                    sheet.Range[startRow + i, j + 1].Text = row[j].ToString();
                    // Enable text wrapping for the cell
                    sheet.Range[startRow + i, j + 1].AutoFitColumns();
                }
            }

            // Save the modified workbook
            workbook.SaveToFile(savePath, ExcelVersion.Version2013);
        }
        public static void ExportData(DataTable listData, string pathBase, string fileName)
        {
            try
            {
                Workbook workbook = new Workbook();
                workbook.LoadFromFile(pathBase);

                // Get the first worksheet
                Worksheet sheet = workbook.Worksheets[0];
                int startRow = sheet.LastRow + 1; // Start from the next row after the last used row

                // Insert data into the worksheet
                for (int i = 0; i < listData.Rows.Count; i++)
                {
                    DataRow row = listData.Rows[i];

                    for (int j = 0; j < listData.Columns.Count; j++)
                    {
                        var text = row[j].ToString();
                        if (j == 0)
                        {
                            text = DateTime.Parse(text).Date.ToString("MM/dd/yyyy");
                        }
                        sheet.Range[startRow + i, j + 1].Text = text;
                        // Enable text wrapping for the cell
                        sheet.Range[startRow + i, j + 1].AutoFitColumns();
                    }
                }

                // Save the modified workbook
                workbook.SaveToFile(fileName, ExcelVersion.Version2013);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void ExportExcel(DataGridView dgv)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel|xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StartFormLoading();
                    Workbook wookbook = new Workbook();
                    wookbook.LoadFromFile((@"path"));

                    Worksheet sheetNew = wookbook.Worksheets.Create();
                    int countColumns = dgv.ColumnCount;
                    //spire dòng file excel bắt đầu từ 1

                    //tạo tiêu đề cho cột excel

                    for (int i = 1; i <= countColumns; i++)
                    {
                        sheetNew.Range[1, i].Value = dgv.Columns[i - 1].HeaderText.ToString();
                        sheetNew.Range[1, i].Style.Color = Color.FromArgb(189, 215, 238);
                        sheetNew.Range[1, i].Style.Font.IsBold = true;
                        sheetNew.Range[1, i].AutoFitColumns();
                    }
                    int countRows = dgv.RowCount;

                    // ghi dữ liệu
                    for (int row = 0; row < countRows; row++)
                    {
                        for (int cell = 0; cell < countColumns; cell++)
                        {
                            sheetNew.Range[row + 2, cell + 1].Value = dgv.Rows[row].Cells[cell].Value == null ? "" : dgv.Rows[row].Cells[cell].Value.ToString().Trim();
                        }
                    }
                    wookbook.Worksheets.Remove(0);
                    wookbook.SaveToFile(saveFileDialog.FileName + ".xlsx");
                    CloseFormLoading();
                    MessageBox.Show("Thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                CloseFormLoading();
                MessageBox.Show("Thất bại", "Thông báo");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                CloseFormLoading();
            }
        }
        #endregion

        #region Xử lý linh tinh
        public static bool IsNullOrEmpty(params string[] textboxList)
        {
            foreach (var txt in textboxList)
            {
                if (string.IsNullOrWhiteSpace(txt)) return true;
            }
            return false;
        }
        public static int? ConvertINT(object value)
        {

            int result;
            if (value != null)
            {
                if (int.TryParse(value.ToString(), out result))
                {
                    return result;
                }
            }
            return null;
        }
        public static int? ConvertINT(string value)
        {

            int result;
            if (value != null)
            {
                if (int.TryParse(value.ToString(), out result))
                {
                    return result;
                }
            }
            return null;
        }
        public static double? convertDouble(object value)
        {
            double result;
            if (value != null)
            {
                if (double.TryParse(value.ToString(), out result))
                {
                    return result;
                }
            }
            return null;
        }
        public static string ConvertString(object str)
        {
            if (str != null)
            {
                return str.ToString();
            }
            return null;
        }

        public static DateTime? ConvertDate(object date)
        {
            DateTime result;
            if (date != null)
            {
                if (DateTime.TryParse(date.ToString(), out result))
                {
                    return result;
                }
            }
            return null;
        }
        public static DateTime? ConvertDate(string date)
        {
            DateTime result;
            if (date != null)
            {
                if (DateTime.TryParse(date.ToString(), out result))
                {
                    return result;
                }
            }
            return null;
        }

        public static string ConvertDate(DateTime? eCN_ReceiveDate)
        {
            DateTime result;
            if (eCN_ReceiveDate != null)
            {
                if (DateTime.TryParse(eCN_ReceiveDate.ToString(), out result))
                {
                    return result.Date.ToString("MM/dd/yyyy");
                }
            }
            return null;
        }
        #endregion
        #region datatable
        public static DataTable ReverseDataTableRows(DataTable originalDataTable)
        {
            // Clone the structure of the original DataTable
            DataTable reversedDataTable = originalDataTable.Clone();

            // Add rows in reverse order
            for (int i = originalDataTable.Rows.Count - 1; i >= 0; i--)
            {
                DataRow originalRow = originalDataTable.Rows[i];
                reversedDataTable.ImportRow(originalRow);
            }

            return reversedDataTable;
        }

        static DataTable ToDataTable<T>(IQueryable<T> query)
        {
            DataTable dataTable = new DataTable();

            // Create columns based on the entity properties
            foreach (var property in typeof(T).GetProperties())
            {
                dataTable.Columns.Add(property.Name);
            }

            // Populate the DataTable with data from the query
            foreach (var item in query)
            {
                DataRow row = dataTable.NewRow();
                foreach (var property in typeof(T).GetProperties())
                {
                    //if (item is Tbl_ECO_ControlSheet)
                    //{
                    //var controlSheet = item as Tbl_ECO_ControlSheet;
                    //string date = ConvertDate(controlSheet.ECN_ReceiveDate);
                    //if (property.Name == "ECN_ReceiveDate")
                    //{
                    //    row[property.Name] = date;
                    //}
                    //else
                    //{
                    row[property.Name] = property.GetValue(item);
                    //}
                    //}
                }
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
        #endregion
        #region XML
        public static bool UpdateFilePathToXml(string filePath, string nodeXML)
        {
            if (IsValidPath(filePath))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("config.xml");

                XmlNode filePathNode = xmlDoc.SelectSingleNode($"/Config/{nodeXML}");

                if (filePathNode != null)
                {
                    filePathNode.InnerText = filePath;
                    xmlDoc.Save("config.xml");
                }
                return true;
            }
            return false;
        }
        public static void SaveFilePathToXml(string filePath, string xmlFileName)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement root = xmlDoc.CreateElement("Config");
            xmlDoc.AppendChild(root);

            XmlElement filePathElement = xmlDoc.CreateElement("FilePath");
            filePathElement.InnerText = filePath;
            root.AppendChild(filePathElement);

            xmlDoc.Save(xmlFileName);
        }
        public static bool IsValidPath(string path)
        {
            // Check if the path is rooted
            if (Path.IsPathRooted(path))
            {
                // Check if it's a valid directory path
                if (Directory.Exists(path))
                {
                    return true;
                }
                else if (File.Exists(path))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion
        #region openForm
        //Button btn = sender as Button;
        //Common.ClickButtonMenu(btn, panelButton);
        //    FormPEDM openForm = (FormPEDM)Application.OpenForms["FormPEDM"];
        //    if (openForm == null)
        //    {
        //        this.panelPasteForm.TabPages.Add((Form)new FormPEDM());
        //    }
        //    else
        //    {
        //        this.panelPasteForm.TabPages[(Form)openForm].Select();
        //    }
        //Common.AddFormToPanel(new FormPEDM(), panelPasteForm);
        #endregion
        #region disable button
        public static void DisableAllButtons(Form form)
        {
            // Recursively disable buttons in the form and its child controls
            foreach (Control control in form.Controls)
            {
                // Disable the button
                control.Enabled = false;
            }
        }
        #endregion
        public static string ConvertText(double? currentApprovePrice)
        {
            if (currentApprovePrice != null)
            {
                double number = (double)currentApprovePrice;
                string formattedNumber;
                if (number % 2 == 0 || number % 2 == 1)
                {
                    formattedNumber = ((int)number).ToString("#,##0");
                    return formattedNumber;
                }
                else
                {
                    formattedNumber = number.ToString("#,##0.###");
                    return formattedNumber;
                }
            }
            return null;
        }
        public static string ConvertToFormattedString(double value)
        {

            int integerValue = (int)value; // Extract the integer part
            string numberString = integerValue.ToString(); // Convert the integer value to string
            string formattedString = "";

            // Add comma separators every 3 characters from right to left
            for (int i = numberString.Length - 1, count = 0; i >= 0; i--, count++)
            {
                formattedString = numberString[i] + formattedString;
                if (count % 3 == 2 && i > 0)
                {
                    formattedString = "," + formattedString;
                }
            }

            return formattedString;
        }
        public static bool IsSunday(DateTime givenDate)
        {
            string today = givenDate.DayOfWeek.ToString();
            return today == "Sunday";
        }

        public static bool IsMung1AmLich(DateTime givenDate)
        {
            HijriCalendar hijriCalendar = new HijriCalendar();
            // Convert the Gregorian date to a Hijri date
            int hijriYear = hijriCalendar.GetYear(givenDate);
            int hijriMonth = hijriCalendar.GetMonth(givenDate);
            int hijriDay = hijriCalendar.GetDayOfMonth(givenDate);
            return hijriDay == 1;
        }
        #region procedure
    //    using (DBContextBOM context = new DBContextBOM())
    //            {
    //                var StaffCodeParam = new SqlParameter("@Data", dataTable)
    //                {
    //                    TypeName = "dbo.Udt_PUR_PART_PRICE",
    //                    SqlDbType = SqlDbType.Structured
    //                };
    //var window = new SqlParameter("@windowUser", "System");

    //context.Database.ExecuteSqlCommand("exec PurPartPrice_Update @Data , @windowUser", StaffCodeParam, window);
                //}
        #endregion
    }
}
