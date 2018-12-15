using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDna.Integration;
using System.Windows.Forms;

namespace ExcelExport
{
    public class Export
    {
        [ExcelFunction(Description = "Echo function.")]
        public static String Echo(String str)
        {
            return str;
        }

        [ExcelFunction(Description = "Show Message")]
        public static void ShowMsg(String str)
        {
            MessageBox.Show(str);
        }

        [ExcelFunction(Description = "Select filePath")]
        public static String SelectFilePath()
        {
            IsOpenExp();
            var filePath = string.Empty;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "xml files (*.xml)|*.xml";
                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    filePath = ofd.FileName;
                }
            }
            return filePath;
        }

        public static bool IsOpenExp()
        {
            string message = "You have to select a file path. Do you want to open file explorer?";
            string caption = "Error!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);

            return result == DialogResult.Yes ?
                true : false;
        }
    }
}
