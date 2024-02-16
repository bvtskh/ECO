using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Xml;
using System.Reflection;
using System.Collections.Generic;

namespace ECO_DX_For_PUR.Utils
{
    public static class Common
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

        public static void SetHeaderColor(this DataGridView dgv)
        {
            var textColor = ContrastColor(dgv.ColumnHeadersDefaultCellStyle.BackColor);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = textColor;
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
        

        public static void CloseForm(string formName)
        {
            var formList = Application.OpenForms.Cast<Form>();
            var formInsert = formList.Where(w => w.Name == formName).ToList();
            foreach(var form in formInsert)
            {
                form.Close();
            }
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

        public static object GetType(int tYPE_ID)
        {
            switch (tYPE_ID)
            {
                case 0:
                    {
                        return "AI";
                    }
                case 1:
                    {
                        return "SMTA";
                    }
                case 2:
                    {
                        return "SMTB";
                    }
                case 3:
                    {
                        return "SMT";
                    }
                case 4:
                    {
                        return "FAT";
                    }
                default: return null;
            }
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

        public static string ConvertDate(DateTime? dateTime)
        {
            DateTime result;
            if (dateTime != null)
            {
                if (DateTime.TryParse(dateTime.ToString(), out result))
                {
                    return result.Date.ToString("MM/dd/yyyy");
                }
            }
            return null;
        }
        public static DateTime? ConvertDate(DateTime dateTime)
        {
            DateTime result;
            if (dateTime != null)
            {
                if (DateTime.TryParse(dateTime.ToString(), out result))
                {
                    return result;
                }
            }
            return null;
        }

        public static bool IsExitsForm(string formName)
        {
            if( Application.OpenForms.Cast<Form>().Where(w=>w.Name == formName).Count() > 0)
            {
                return true;
            }
            return false;
        }
        public static Form FindForm(string formName)
        {
            var form = Application.OpenForms.Cast<Form>().Where(w => w.Name == formName).FirstOrDefault();
            if (form != null) return form;
            return null;
        }
        public static void SetDoubleBuffering(this DataGridView dgv, bool value)
        {
            // Double buffering can make DGV slow in remote desktop
            if (!System.Windows.Forms.SystemInformation.TerminalServerSession)
            {
                Type dgvType = dgv.GetType();
                PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                        BindingFlags.Instance | BindingFlags.NonPublic);
                pi.SetValue(dgv, value, null);
            }
        }
        public static Color ContrastColor(Color color)
        {
            // Counting the perceptive luminance - human eye favors green color... 
            double a = 1 - (0.299 * color.R + 0.587 * color.G + 0.114 * color.B) / 255;

            // Return black for bright colors, white for dark colors
            return a < 0.5 ? Color.Black : Color.White;
        }
        public static List<KeyValuePair<string, string>> CreateCustomer()
        {
            return new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("CS001", "BIVN"),
                new KeyValuePair<string, string>("CS002", "TOYODENSO"),
                new KeyValuePair<string, string>("CS005", "CVN QV"),
                new KeyValuePair<string, string>("CS013", "YOKOWO"),
                new KeyValuePair<string, string>("CS016", "KYOCERA"),
                new KeyValuePair<string, string>("CS018", "NIDEC"),
                new KeyValuePair<string, string>("CS020", "YOKOWO"),
                new KeyValuePair<string, string>("CS022", "FUJI"),
                new KeyValuePair<string, string>("CS023", "MAS-V"),
                new KeyValuePair<string, string>("CS025", "CVN Electric"),
                new KeyValuePair<string, string>("CS029", "NICHICON"),
                new KeyValuePair<string, string>("CS030", "NICHICON"),
                new KeyValuePair<string, string>("CS034", "STANLEY"),
                new KeyValuePair<string, string>("CS038", "VALEO"),
                new KeyValuePair<string, string>("CS045", "YASKAWA"),
                new KeyValuePair<string, string>("CS048", "ICHIKOH"),
            };
        }
    }
}
