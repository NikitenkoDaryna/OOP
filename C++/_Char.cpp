#include "_Char.h"
#include "_String.h"
#include <cstring>
#include <iostream>
using namespace std;
_Char::_Char(const char s[]) :_String(s) {}
void _Char::Add(const char s[]) {
    if (str == nullptr) { _Char(); }
    int count_k = 0;
    for (int i = 0; i < strlen(s); i++)
    {
        if (s[i] == 'k')
            count_k++;
    }
    int k = 0;
    for (int i = size; i < size + strlen(s) + count_k; i++)
    {
        str[i] = s[i - size - k];
        if (s[i - size - k] == 'k')
        {
            str[i + 1] = s[i - size - k];
            i++;
            k++;
        }
    }
    size += strlen(s) + count_k;
}
int _Char::getSize() {
    cout << "_Char class"<<endl;
    return size;
}
