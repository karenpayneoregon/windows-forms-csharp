using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBoxFromFileList.Classes
{
    public class MockOperations
    {
        public static List<FileItem> List = new List<FileItem>()
        {
            new FileItem() {FullName = "C:\\Files\\Document1.docx"},
            new FileItem() {FullName = "C:\\Storage\\Pictures\\Image1.png"},
            new FileItem() {FullName = "C:\\Storage\\Pictures\\Image2.png"},
            new FileItem() {FullName = "C:\\Excel\\Customers.xlsx"}
        };
    }
}
