#pragma once
#include "Str.h"
class Text {
    int size = 0;
    Str* text = nullptr;
public:
    Text() = default;
    Text(Str a);
    void Add(Str a);
    void Del(Str string);
    void Clear();
    int Smallest();
    int Elements()const;
    int CalcConsonants()const;
    double ConsonantsPercentage()const;
    void DeleteFirstAndLastSpace(Str string);
    void Spaces();
    void PrintText();
    
    

};
