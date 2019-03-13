#pragma once
class Button
{
private:
    HWND btn;
public:

    Button(LPSTR lpValue,
        int sizeX, int sizeY, int posX, int posY,
        HINSTANCE hInst, HWND hwnd);
    Button();
    void setHwnd(HWND btn);
    HWND getHwnd();
    bool createButton(LPSTR lpValue,
        int sizeX, int sizeY, int posX, int posY,
        HINSTANCE hInst, HWND hwnd);
};

