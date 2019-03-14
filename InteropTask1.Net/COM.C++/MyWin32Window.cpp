#include "stdafx.h"



MyWin32Window::MyWin32Window()
{
    //TCHAR NPath[MAX_PATH];
    //GetCurrentDirectory(MAX_PATH, NPath);
}

void MyWin32Window::setHinst(HINSTANCE hInst)
{
    this->hInst = hInst;
}

void MyWin32Window :: setWindowName(LPCWSTR lpWindowName)
{
    this->windowName = lpWindowName;
}

void  MyWin32Window :: setClassName(LPCWSTR lpClassName)
{
    this->className = lpClassName;
}

void  MyWin32Window :: setHwnd(HWND hwnd)
{
    this->hwnd = hwnd;
}

HWND  MyWin32Window :: getHwnd()
{
    return this->hwnd;
}

LPCWSTR MyWin32Window ::getWindowName()
{
    return this->windowName;
}

LPCWSTR  MyWin32Window :: getClassName()
{
    return this->className;
}

HINSTANCE  MyWin32Window :: getHinst()
{
    return this->hInst;
}

bool  MyWin32Window :: setWCE()
{
    this->wce.cbSize = sizeof(WNDCLASSEX);
    wce.style = CS_HREDRAW | CS_VREDRAW;
    wce.hInstance = this->getHinst();
    wce.lpfnWndProc = Proc;
    wce.cbClsExtra = 0;
    wce.lpszClassName = this->getClassName();
    wce.hbrBackground = (HBRUSH)(COLOR_WINDOW + 1);
    wce.hIcon = LoadIcon(this->getHinst(), MAKEINTRESOURCE(IDI_APPLICATION));
    wce.hCursor = LoadCursor(NULL, IDC_ARROW);
    wce.cbWndExtra = 0;
    wce.hIconSm = LoadIcon(wce.hInstance, MAKEINTRESOURCE(IDI_APPLICATION));
    wce.lpszMenuName = NULL;

    if (!RegisterClassEx(&wce))
        return false;
    else
        return true;
}
bool  MyWin32Window :: createWindow()
{
    this->setHwnd(CreateWindow(this->getClassName(), this->getWindowName(), WS_OVERLAPPEDWINDOW,
        CW_USEDEFAULT, CW_USEDEFAULT, 500, 500, NULL, NULL, this->getHinst(), NULL));

    if (!this->getHinst())
        return false;
    else
        return true;
}

void  MyWin32Window :: show (int iCmdShow)
{
    ShowWindow(this->getHwnd(), iCmdShow);
    UpdateWindow(this->getHwnd());
}

int  MyWin32Window :: messages()
{
    while (GetMessage(&this->msg, NULL, 0, 0))
    {
        TranslateMessage(&this->msg);
        DispatchMessage(&this->msg);
    }

    return (int)this->msg.wParam;
}
