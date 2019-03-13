#include "stdafx.h"
#include "Button.h"

Button::Button()
{

}

Button::Button(LPSTR lpValue,
    int sizeX, int sizeY, int posX, int posY,
    HINSTANCE hInst, HWND hwnd)
{
    this->createButton(lpValue,
        sizeX, sizeY, posX, posY,
        hInst, hwnd);
}

HWND Button::getHwnd()
{
    return this->btn;
}

void Button::setHwnd(HWND btn)
{
   this->btn = btn;
}
bool Button::createButton(LPSTR lpValue,
    int sizeX, int sizeY, int posX, int posY,
    HINSTANCE hInst, HWND hwnd)
{
    this->setHwnd(CreateWindowA("BUTTON", lpValue, WS_CHILD | WS_VISIBLE | BS_DEFPUSHBUTTON,
        posX, posY, sizeX, sizeY, hwnd, NULL, hInst, NULL));

    if (!this->getHwnd())
        return false;

    return true;
}

