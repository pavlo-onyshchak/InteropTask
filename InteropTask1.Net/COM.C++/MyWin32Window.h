#pragma once
#include<Windows.h>
LRESULT CALLBACK Proc(HWND, UINT, WPARAM, LPARAM);
class MyWin32Window
{
private:
    HINSTANCE hInst;
    MSG msg;
    LPCWSTR windowName = L"Main Form.C++";
    LPCWSTR className = L"class";
    WNDCLASSEX wce;
    HWND hwnd;
public:
    MyWin32Window();
    void setHinst(HINSTANCE hInst);
    void setWindowName(LPCWSTR lpWindowName);
    void setClassName(LPCWSTR lpClassName);
    void show(int iCmdShow);
    void setHwnd(HWND hwnd);
    HWND getHwnd();
    LPCWSTR getWindowName();
    LPCWSTR getClassName();
    HINSTANCE getHinst();
    bool setWCE();
    bool createWindow();
    int messages();

};



