// OOP_Lab2C++.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>

using namespace std;

#include "Str.h"
#include "Text.h"
    int main() {
        Str a("bbbbb");
        //a.Add("byebye ");
        //Str c(" abdcss ");
       // a.print();
        //a.DeleteFirstAndLast();
        //a.print();
        //a.Clear();
        //a.print();
        Str a2("t  tt");
        Str a3("  tfef");
       // myText.DeleteFirstAndLastSpace(a2);
        a.print();
        //cout<<a2.CalcConsonants();
        Text text(a2);
        text.Add(a3);
        cout << endl;
       // cout<<text.ConsonantsPercentage()<<"%";
       //text.Clear();
       // text.PrintText();
       // a2.Spaces();
        //a2.print();
        text.Spaces();
        text.PrintText();
        //cout<<text.Smallest();
        //cout<<myText.ConsonantsPercentage();
    }
  
// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
