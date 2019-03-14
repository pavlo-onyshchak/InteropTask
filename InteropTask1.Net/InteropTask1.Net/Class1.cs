using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace InteropTask1.Net
{
   [Guid("1B807B25-E9B6-4BD4-9F05-7634668F49BC"), ComVisible(true)]
    public enum WinForm
    {
        Main = 1,
        frmAdd = 2,
        frmRemove = 3,
        frmShow = 4,
        frmSearch = 5
    }

    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [System.Runtime.InteropServices.ComVisible(true)]
    [Guid("8520FC41-B0B2-4473-A7CB-FDC0721DFB3F")]
    public interface Class
    {
        void func(WinForm value);
    }

    [ClassInterface(ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComVisible(true)]
    [ProgId("Class1")]
    [Guid("E69DE4D9-2A65-43F9-8EDC-E7416626BFFF")]
    public class Class1 : Class
    {
        public void func(WinForm value)
        {
            switch (value)
            {
                case WinForm.Main:
                    frmMain frmMain = new frmMain();
                    frmMain.Show();
                    break;
                case WinForm.frmAdd :
                    frmAddStudent frmAddStudent = new frmAddStudent();
                    frmAddStudent.Show();
                    break;
                case WinForm.frmRemove:
                    frmRemoveStudent frmRemoveStudent = new frmRemoveStudent();
                    frmRemoveStudent.Show();
                    break;
                case WinForm.frmShow:
                    frmShowStudents frmShowStudent= new frmShowStudents();
                    frmShowStudent.Show();
                    break;
                case WinForm.frmSearch:
                    frmStudentSearch frmStudentSearch = new frmStudentSearch();
                    frmStudentSearch.Show();
                    break;
            }
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            // frmMain form = new frmMain();"C:\\Users\\ponys\\Desktop\\visual basic"

            //form.Show();
        }
    }
}
