#pragma once
class Str
{
    int size = 0;
    char* str = nullptr;
public:
    Str() = default;
    Str(const char s[]);
    void print();
    int Find(const char s[]);
    void Add(const char s[]);
    void Del(const char s[]);
    void DeleteFirstAndLast();
    void Clear();
    int CalcConsonants()const;
    bool HasFirstAndLastSpace();
    int getSize()const;
    void Spaces();

};

