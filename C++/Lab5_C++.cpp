// Lab5_C++.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
using namespace std;
#include <iostream>
#include "Trapez.h"
#include "Coordinate.h"
#include "Shape.h"
#include "_String.h"
#include "Numbers.h"
#include "_Char.h"
int main()
{

    Coordinate t1 (-5, 0);
    Coordinate t2 (-4, 3);
    Coordinate t3 (-2, 3);
    Coordinate t4 (0, 0);
    Coordinate h (0, 3);
    Trapez trapez (t1, t2, t3, t4, h);
    trapez.PrintPerimeter();
    cout << endl;
    trapez.PrintSquare();
    _String str1= _String();
    cout << endl;
    str1.Add("hello");
    str1.Add("bybye");
    str1.PrintStr();
    cout << "size of str1:" << str1.getSize()<<endl;
    Numbers numbers = Numbers();
    numbers.Add("wow");
    numbers.Add("kekw");
    numbers.PrintStr();
    _Char _char = _Char();
    _char.Add("keeke");
    _char.PrintStr();
    cout << _char.getSize();
    system("pause");
}


