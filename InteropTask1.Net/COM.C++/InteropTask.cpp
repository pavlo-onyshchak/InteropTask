// InteropTask.cpp : Implementation of CInteropTask

#include "stdafx.h"
#include "InteropTask.h"
#include "MyWin32Window.h"
#include "Button.h"


using namespace std;

// CInteropTask



STDMETHODIMP CInteropTask::Call()
{
    MyWin32Window* myWin = new MyWin32Window();
    HINSTANCE hInstance = (HINSTANCE)GetModuleHandle(NULL);
    myWin->setHinst(hInstance);

    if (!myWin->setWCE())
    {
        return 1;
    }

    if (!myWin->createWindow())
    {
        return 1;
    }

    myWin->show(10);

    return S_OK;
}
