#include "Button.h"
#include "MyWin32Window.h"
#include<string>
#include "stdafx.h"
#include <sqltypes.h>
#include <sql.h>
#include <sqlext.h>

#import "C:\Users\ponys\Documents\visual studio 2015\Projects\InteropTask1.Net\InteropTask1.Net\bin\Debug\InteropTask1.Net.tlb"



using namespace std;
using namespace InteropTask1_Net;

struct Controls {
    HWND btnAddStudent;
    HWND btnRemoveStudent;
    HWND btnShowStudent;
    HWND btnStudenhtSearch;
    HWND btnCancel;
};

Controls controls;

MyWin32Window* myWin = new MyWin32Window();

LRESULT CALLBACK windowprocessforwindow1(HWND handleforwindow1, UINT message, WPARAM wParam, LPARAM lParam);
LRESULT CALLBACK Proc(HWND hwnd, UINT message, WPARAM wParam, LPARAM lParam) {
    switch (message) {

    case WM_CREATE:
    {
        Button btnAddStudent("Add Student", 120, 34, 200, 100, myWin->getHinst(), hwnd);
        Button btnRemoveStudent("Remove Student", 120, 34, 200, 150, myWin->getHinst(), hwnd);
        Button btnShowStudent("Show Student", 120, 34, 200, 200, myWin->getHinst(), hwnd);
        Button btnStudentSearch("Student Search", 120, 34, 200, 250, myWin->getHinst(), hwnd);
        Button btnCancel("Cancel", 70, 34, 220, 350, myWin->getHinst(), hwnd);
        controls.btnAddStudent = btnAddStudent.getHwnd();
        controls.btnRemoveStudent = btnRemoveStudent.getHwnd();
        controls.btnShowStudent = btnShowStudent.getHwnd();
        controls.btnStudenhtSearch = btnStudentSearch.getHwnd();
        controls.btnCancel = btnCancel.getHwnd();
    }break;

    case WM_CLOSE:
    {
        DestroyWindow(hwnd);
    }break;

    case WM_DESTROY:
    {
        //delete myWin;
        PostQuitMessage(0);
    }break;

    case WM_COMMAND:
    {
        //string con = "Data Source = localhost; Initial Catalog = InteropTasks; Integrated Security = True";
        switch (HIWORD(wParam)) {
        case BN_CLICKED:
            if ((HWND)lParam == controls.btnAddStudent)
            {

                CoInitialize(NULL);
                ClassPtr obj;
                obj.CreateInstance(__uuidof(Class1));
                obj->func(InteropTask1_Net::WinForm_frmAdd);
                CoUninitialize();
            }
            if ((HWND)lParam == controls.btnRemoveStudent)
            {
                CoInitialize(NULL);
                ClassPtr obj;
                obj.CreateInstance(__uuidof(Class1));
                obj->func(InteropTask1_Net::WinForm_frmRemove);
                CoUninitialize();
            }
            if ((HWND)lParam == controls.btnShowStudent)
            {
                CoInitialize(NULL);
                ClassPtr obj;
                obj.CreateInstance(__uuidof(Class1));
                obj->func(WinForm_frmShow);
                CoUninitialize();
            }
            if ((HWND)lParam == controls.btnStudenhtSearch)
            {
                CoInitialize(NULL);
                ClassPtr obj;
                obj.CreateInstance(__uuidof(Class1));
                obj->func(WinForm_frmSearch);
                CoUninitialize();
            }
            if ((HWND)lParam == controls.btnCancel)
            {
                PostMessage(hwnd, WM_CLOSE, 0, 0);
                //DestroyWindow(hwnd);
            }

        }break;
    }break;

    default:
        return DefWindowProc(hwnd, message, wParam, lParam);
        break;
    }

    return 0;
}
LRESULT CALLBACK windowprocessforwindow1(HWND handleforwindow, UINT msg, WPARAM wParam, LPARAM lParam)
{
    switch (msg)
    {
    case WM_CREATE:
    {

    }break;
    case WM_DESTROY: {
        MessageBox(NULL,
            L"Window 1 closed",
            L"Message",
            MB_ICONINFORMATION);


        return 0;
    }
                     break;
    }

    return DefWindowProc(handleforwindow, msg, wParam, lParam);
}

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nCmdShow) {

    myWin->setHinst(hInstance);

    if (!myWin->setWCE())
        return 1;

    if (!myWin->createWindow())
        return 1;

    myWin->show(nCmdShow);

    return myWin->messages();
}