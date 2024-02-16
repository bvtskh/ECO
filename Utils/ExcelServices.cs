using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spire.Xls;
using System.Data;
using System.Windows.Forms;
using ECO_DX_For_PUR.DATA.COST_SYSTEM;
using ECO_DX_For_PUR.DATA.COST_SYSTEM.Repository;
using System.Data.SqlClient;
using System.IO;
using System.Globalization;
using OfficeOpenXml;
using ExcelDataReader;
using ECO_DX_For_PUR.DATA.Entities.ECN_ECO;

namespace ECO_DX_For_PUR.Utils
{
    public class ExcelServices
    {
        IMPORT_INFO_Repository _importInfo = new IMPORT_INFO_Repository();
        private DataTable dataTable;
        public DataTable ImportExcel(string filePath)
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

        public string GetExelFilePath()
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
        public DataTable GetColumnHeader(string filePath)
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

        public void ImportZMM70(string filepath)
        {
            if (filepath != null)
            {
                // Create a workbook
                Workbook workbook = new Workbook();

                // Load the Excel file
                workbook.LoadFromFile(filepath);

                // Assume you are working with the first worksheet
                Worksheet sheet = workbook.Worksheets[0];

                // Create a DataTable
                dataTable = new DataTable();
                dataTable.Columns.Add("PUR_INFO_REC", typeof(string));
                dataTable.Columns.Add("QUOTE_DATE", typeof(DateTime));
                dataTable.Columns.Add("PART_NO", typeof(string));
                dataTable.Columns.Add("RATE_UNIT", typeof(string));
                dataTable.Columns.Add("UNIT_PRICE", typeof(decimal));
                dataTable.Columns.Add("REF_NO", typeof(string));
                dataTable.Columns.Add("CREATE_USER", typeof(string));
                dataTable.Columns.Add("CREATE_DATE", typeof(DateTime));
                dataTable.Columns.Add("VALID_FROM", typeof(DateTime));
                dataTable.Columns.Add("VALID_TO", typeof(DateTime));
                dataTable.Columns.Add("SUPPLIER", typeof(string));
                dataTable.Columns.Add("SUPPLIER_NAME", typeof(string));
                dataTable.Columns.Add("FIXED_VENDOR", typeof(bool));
                dataTable.Columns.Add("MANUFACTURER_NAME", typeof(string));

                if (!IsZMM70File(sheet))
                {
                    MessageBox.Show("ZMM70 file is not correct!");
                    return;
                }
                var refNo = DateTime.Now.ToString("yyMMddHHss");
                for (int row = 2; row <= sheet.LastRow; row++)
                {
                    var infoRec = sheet[row, 1].DisplayedText;
                    var partNo = sheet[row, 2].DisplayedText;
                    DateTime quoteDate;
                    if (!DateTime.TryParse(sheet[row, 10].DisplayedText, out quoteDate))
                    {
                        continue;
                    }
                    var price = decimal.Parse(sheet[row, 12].DisplayedText, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint);
                    DateTime dateParse;
                    DateTime? createDate = null;
                    if (DateTime.TryParse(sheet[row, 10].DisplayedText, out dateParse))
                    {
                        createDate = dateParse;
                    }
                    DateTime validFrom;
                    DateTime validTo;
                    if (!DateTime.TryParse(sheet[row, 16].DisplayedText, out validFrom)) continue;
                    if (!DateTime.TryParse(sheet[row, 17].DisplayedText, out validTo)) continue;
                    var rateUnit = sheet[row, 11].DisplayedText;
                    var createUser = sheet[row, 25].DisplayedText;
                    var supplier = sheet[row, 8].DisplayedText;
                    var supplierName = sheet[row, 9].DisplayedText;
                    var fixVendor = sheet[row, 18].DisplayedText;
                    var manufacturerName = sheet[row, 24].DisplayedText;
                    dataTable.Rows.Add(new object[] { infoRec, quoteDate, partNo, rateUnit, price,
                    refNo, createUser, createDate, validFrom,validTo,supplier,supplierName,!string.IsNullOrEmpty(fixVendor),manufacturerName });
                }
                using (DBContextBOM context = new DBContextBOM())
                {
                    var StaffCodeParam = new SqlParameter("@Data", dataTable)
                    {
                        TypeName = "dbo.Udt_PUR_PART_PRICE",
                        SqlDbType = SqlDbType.Structured
                    };
                    var window = new SqlParameter("@windowUser", "System");

                    context.Database.ExecuteSqlCommand("exec PurPartPrice_Update @Data , @windowUser", StaffCodeParam, window);
                }
                // luu vao Import Info
                IMPORT_INFO info = new IMPORT_INFO();
                info.FileName = filepath;
                info.Func = "fPurPartPrice";
                info.Hostname = System.Windows.Forms.SystemInformation.ComputerName;
                info.UpdateTime = DateTime.Now;
                _importInfo.SaveImportInfo(info);
            }          
        }

        public List<ECOSchedule> GetdataECOSchedule(string filepath)
        {
            if (filepath != null)
            {
                // Create a workbook
                Workbook workbook = new Workbook();

                // Load the Excel file
                workbook.LoadFromFile(filepath);

                // Assume you are working with the first worksheet
                Worksheet sheet = workbook.Worksheets[0];

                if (!IsFormatECOSchedule(sheet))
                {
                    Common.CloseFormLoading();
                    MessageBox.Show("Sai định dạng cột!");
                    return null;
                }
                List<ECOSchedule> eCOSchedules = new List<ECOSchedule>();
                for (int row = 2; row <= sheet.LastRow; row++)
                {
                    if (IsNullRow(row, sheet)) continue;
                    ECOSchedule eCOSchedule = new ECOSchedule();
                    eCOSchedule.ECO_NO = sheet[row, 7].DisplayedText.ToUpper();
                    eCOSchedule.MODEL = sheet[row, 3].DisplayedText.ToUpper();
                    //if (string.IsNullOrEmpty(eCOSchedule.ECO_NO) || string.IsNullOrEmpty(eCOSchedule.MODEL)) continue;
                    eCOSchedule.RECEIVE_DOCUMENT_DATE = Common.ConvertDate(sheet[row, 1].DisplayedText);
                    eCOSchedule.IMPLEMENT_DATE = Common.ConvertDate(sheet[row, 2].DisplayedText);
                    eCOSchedule.CONTENT_CHANGE = sheet[row, 4].DisplayedText;
                    eCOSchedule.ECN_DCI_NO = sheet[row, 5].DisplayedText.ToUpper();
                    eCOSchedule.START_APPROVE_DATE = Common.ConvertDate(sheet[row, 6].DisplayedText);
                    eCOSchedule.REMARK = sheet[row, 8].DisplayedText;
                    eCOSchedules.Add(eCOSchedule);
                }
                return eCOSchedules;
            }
            return null;
        }

        private bool IsNullRow(int row, Worksheet sheet)
        {
            for(int i  = 1; i<sheet.LastColumn; i++)
            {
                if (!string.IsNullOrEmpty(sheet[row, i].DisplayedText)) return false;
            }
            return true;
        }

        private bool IsFormatECOSchedule(Worksheet sheet)
        {
            var rowHeader = sheet.Rows[0];
            if (rowHeader.CellList[0].DisplayedText != "Ngày nhận tài liệu" || rowHeader.CellList[1].DisplayedText != "Ngày triển khai" || rowHeader.CellList[2].DisplayedText != "Model"||
                rowHeader.CellList[3].DisplayedText != "Nội dung thay đổi" || rowHeader.CellList[4].DisplayedText != "ECN, DCI No." || rowHeader.CellList[5].DisplayedText != "Ngày bắt đầu áp dụng" || rowHeader.CellList[6].DisplayedText != "UMC ECO No." || rowHeader.CellList[7].DisplayedText != "REMARK")
            {
                return false;
            }
            return true;
        }

        private bool IsZMM70File(Worksheet sheet)
        {
            var rowHeader = sheet.Rows[0];
            if(rowHeader.CellList[0].DisplayedText != "Purchasing Info Rec." || rowHeader.CellList[1].DisplayedText != "Internal P/N" || rowHeader.CellList[2].DisplayedText != "Material Number")
            {
                return false;
            }
            return true;
        }

        private DateTime ConvertDate(string displayedText)
        {
            DateTime dateTime;
            if(DateTime.TryParse(displayedText, out dateTime))
            {
                return System.Convert.ToDateTime(dateTime.Date.ToString("yyyy-MM-dd"));
            }
            return dateTime;
        }

        public static void ExportData(DataTable dataResult, string originPath, string newPathName)
        {
            Workbook workbook = new Workbook();
            workbook.LoadFromFile(originPath);

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
            workbook.SaveToFile(newPathName, ExcelVersion.Version2013);
        }


        static Decimal? FindRowWithMaxTime(DataTable dataTable)
        {
            if (dataTable.Rows.Count == 0)
            {
                return null; // DataTable is empty
            }

            List<DataRow> rowListFixvender = new List<DataRow>();
            // lọc những hàng có fix vender
            foreach(DataRow row in dataTable.Rows)
            {
                if (!string.IsNullOrEmpty(row.Field<string>(16)))
                {
                    rowListFixvender.Add(row);
                }
            }
            DataRow maxTimeRow = rowListFixvender[0];
            string date = maxTimeRow.Field<string>(14);
            DateTime maxTime = DateTime.Parse(date);

            foreach (DataRow row in rowListFixvender)
            {
                DateTime currentTime = DateTime.Parse(row.Field<string>(14));

                if (currentTime > maxTime)
                {
                    maxTime = currentTime;
                    maxTimeRow = row;
                }
            }

            return decimal.Parse(maxTimeRow.Field<string>(10));
        }

        /// <summary>
        /// export data ecn finish
        /// </summary>
        /// <param name="listData"></param>
        /// <param name="fileName"></param>
        public static void ExportData(DataTable listData, string fileName)
        {
            try
            {
                Workbook workbook = new Workbook();
                // workbook.LoadFromFile(pathBase);

                // Get the first worksheet
                Worksheet sheet = workbook.Worksheets[0];
                //listData.Columns.RemoveAt(0);
                sheet.InsertDataTable(listData, true, 1, 1);
                // Get the header range
                Spire.Xls.CellRange headerRange = sheet.Rows[0];
                Spire.Xls.CellRange allRange = sheet.AllocatedRange;
                // Set the background color of the header row to lime
                headerRange.Style.Color = System.Drawing.Color.LimeGreen;
                headerRange.Style.HorizontalAlignment = HorizontalAlignType.Center;
                headerRange.Style.VerticalAlignment =  VerticalAlignType.Center;
                headerRange.AutoFitColumns();  
                headerRange.RowHeight = 40;
                headerRange.Style.Font.IsBold = true;
                headerRange.ColumnWidth = 14;
                allRange.Borders[BordersLineType.EdgeTop].LineStyle = LineStyleType.Thin;
                allRange.Borders[BordersLineType.EdgeBottom].LineStyle = LineStyleType.Thin;
                allRange.Borders[BordersLineType.EdgeLeft].LineStyle = LineStyleType.Thin;
                allRange.Borders[BordersLineType.EdgeRight].LineStyle = LineStyleType.Thin;
                workbook.SaveToFile(fileName, ExcelVersion.Version2013);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool CheckFormat(string filePath)
        {
            try
            {
                // check gì gì đó........
                return true;
            }
            catch (Exception)
            {

                throw;
            }         
        }

        public void ImportLocationModel(string filepath)
        {
            if (filepath != null)
            {
                //// Create a workbook
                //Workbook workbook = new Workbook();

                //// Load the Excel file
                //workbook.LoadFromFile(filepath);

                //// Assume you are working with the first worksheet
                //Worksheet sheet = workbook.Worksheets[0];

                // Create a DataTable
                dataTable = new DataTable();
                dataTable.Columns.Add("MODEL_ID", typeof(string));
                dataTable.Columns.Add("PART_NO", typeof(string));
                dataTable.Columns.Add("ASSEMBLY_NO", typeof(string));
                dataTable.Columns.Add("RATIO", typeof(decimal));
                dataTable.Columns.Add("UNIT_QTY", typeof(decimal));
                dataTable.Columns.Add("CREATE_DATE", typeof(DateTime));
                dataTable.Columns.Add("RUNNING_CHANGE", typeof(bool));
                dataTable.Columns.Add("FOLLOW_UP", typeof(string));
                dataTable.Columns.Add("ALT_GROUP", typeof(string));
                dataTable.Columns.Add("LOCATION", typeof(string));

                // Check if the file exists



                //if (!IsZMM70File(sheet))
                //{
                //    MessageBox.Show("ZMM70 file is not correct!");
                //    return;
                //}
                // Check if the file exists


                // Check if the file exists
                if (File.Exists(filepath))
                {
                    // Read data from the Excel file
                    using (var stream = File.Open(filepath, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            // Choose one of the available methods to read data

                            // Method 1: Reading data using a DataReader
                            do
                            {
                                while (reader.Read())
                                {
                                    // Read data row by row
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        Console.Write($"{reader.GetValue(i)} \t");
                                    }
                                    Console.WriteLine();
                                }
                            } while (reader.NextResult());

                            // Method 2: Reading data into a DataSet
                            var dataSet = reader.AsDataSet();
                            foreach (DataTable table in dataSet.Tables)
                            {
                                for(int row = 1; row < table.Rows.Count;row++)
                                {
                                    var modelId = table.Rows[row].ItemArray[0].ToString();
                                    var partNo = table.Rows[row].ItemArray[2].ToString();
                                    var assembly = table.Rows[row].ItemArray[1].ToString();
                                    decimal ratio = (decimal)0.01 * decimal.Parse(table.Rows[row].ItemArray[7].ToString(), NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint);
                                    if (ratio == 0)
                                    {
                                        ratio = 1;
                                    }
                                    var createDate = DateTime.Now;
                                    bool runingChange = !string.IsNullOrEmpty(table.Rows[row].ItemArray[9].ToString());
                                    var followUp = table.Rows[row].ItemArray[9].ToString();
                                    var altGroup = table.Rows[row].ItemArray[6].ToString();
                                    var location = table.Rows[row].ItemArray[10].ToString();
                                    var unitQty = decimal.Parse(table.Rows[row].ItemArray[4].ToString(), NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint);


                                    dataTable.Rows.Add(new object[] { modelId, partNo, assembly, ratio, unitQty,
                                        createDate, runingChange, followUp, altGroup,location });
                                }
                            }
                            using (DBContextBOM context = new DBContextBOM())
                            {
                                var StaffCodeParam = new SqlParameter("@Data", dataTable)
                                {
                                    TypeName = "dbo.Udt_BC_BOM_LIST1",
                                    SqlDbType = SqlDbType.Structured
                                };
                                var window = new SqlParameter("@windowUser", "System");

                                context.Database.ExecuteSqlCommand("exec BC_BOMLIST_Update @Data , @windowUser", StaffCodeParam, window);
                            }
                            // luu vao Import Info
                            //IMPORT_INFO info = new IMPORT_INFO();
                            //info.FileName = filepath;
                            //info.Func = "fBomList";
                            //info.Hostname = System.Windows.Forms.SystemInformation.ComputerName;
                            //info.UpdateTime = DateTime.Now;
                            //_importInfo.SaveImportInfo(info);
                        }
                    }
                }
                // Create a FileStream to read the Excel file

                //for (int row = 2; row <= sheet.LastRow; row++)
                //{
                //    var modelId = sheet[row, 1].DisplayedText;
                //    var partNo = sheet[row, 3].DisplayedText.Trim();
                //    if(partNo == "300-122-837")
                //    {
                //        Console.WriteLine("");
                //    }
                //    var assembly = sheet[row, 2].DisplayedText;
                //    decimal ratio = (decimal)0.01* decimal.Parse(sheet[row, 8].DisplayedText, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint);
                //    if((double)ratio != 0.00)
                //    {
                //        Console.WriteLine("");
                //    }
                //    var createDate = DateTime.Now;
                //    bool runingChange = !string.IsNullOrEmpty(sheet[row, 10].DisplayedText);
                //    var followUp = sheet[row, 10].DisplayedText;
                //    var altGroup = sheet[row, 7].DisplayedText;
                //    var location = sheet[row, 11].DisplayedText;
                //    var unitQty = decimal.Parse(sheet[row, 5].DisplayedText, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint);


                //    dataTable.Rows.Add(new object[] { modelId, partNo, assembly, ratio, unitQty,
                //    createDate, runingChange, followUp, altGroup,location });
                //}
                //using (DBContextBOM context = new DBContextBOM())
                //{
                //    var StaffCodeParam = new SqlParameter("@Data", dataTable)
                //    {
                //        TypeName = "dbo.Udt_BC_BOM_LIST1",
                //        SqlDbType = SqlDbType.Structured            
                //    };
                //    var window = new SqlParameter("@windowUser", "System");

                //    context.Database.ExecuteSqlCommand("exec BC_BOMLIST_Update @Data , @windowUser", StaffCodeParam, window);
                //}
                //// luu vao Import Info
                //IMPORT_INFO info = new IMPORT_INFO();
                //info.FileName = filepath;
                //info.Func = "fBomList";
                //info.Hostname = System.Windows.Forms.SystemInformation.ComputerName;
                //info.UpdateTime = DateTime.Now;
                //_importInfo.SaveImportInfo(info);
            }
        }
    }
}
