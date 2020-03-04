#include "Str.h"
#include <cstring>
#include <iostream>

using namespace std;



Str::Str(const char s[]) {
    size = strlen(s);
    str = new char[size];
    for (int i = 0; i < size; i++) {
        str[i] = s[i];
    }
}

void Str::print() {
    for (int i = 0; i < size; i++) {
        cout << str[i];
    }
    cout << endl;
}
void Str::Spaces() {
    int k = 0;
    for (int i = 0; i < size; i++)
    {
        if (str[i] == ' ' && str[i + 1] == ' ') {
            k = i + 1;
            for (int i = k; i < size - 1; i++)
            {
                str[i] = str[i + 1];
            }
            delete[size]str;
            size--;
        }
    }
}

//------------------------------------------------------------------------
int Str::Find(const char s[]) {
    int k = 0;
    int index = -1;

    for (int i = 0; i < size; i++) {
        if (str[i] == s[0]) {
            for (int j = 0; j < strlen(s) + 1; j++) {
                if (str[i] == s[j])
                    k++;
            }
        }
        if (k == strlen(s)) {
            index = i;
            return index;
        }
    }
    return index;
}

//------------------------------------------------------------------------
void Str::Add(const char s[]) {
    int j = size;
    size += strlen(s);
    for (int i = j; i < size; i++) {
        str[i] = s[i - j];
    }
}
void Str::Del(const char s[]) {
    for (int i = Find(s); i < (size - strlen(s)); i++)
    {
        str[i] = str[i + strlen(s)];
    }
    size -= (strlen(s));
}
void Str::Clear() {
    memset(str, 0, size);
}
void Str::DeleteFirstAndLast() {
    long start, end = -1;
    if (HasFirstAndLastSpace()) {
        start = 0;
        end = strlen(str) - 1;
        for (start; start < size; ++start) {
            str[start] = str[start + 1];
        }
        size--;
        for (end + 1; end < size; end++)
        {
            str[end - 1] = str[end];
        }
        size--;
    }
}
bool Str::HasFirstAndLastSpace() {
    bool flag = 0;
    int count = 0;
    for (int i = 0; i < size; i++) {
        if (str[i] == ' ' && (i == 0 || i == size - 1)) {
            flag = 1;
            count++;
        }
    }
    if (count == 2 && flag == 1)return 1;
    return 0;
}

int Str::getSize() const {
    return size;
}

//--------------------------------------------------
int Str::CalcConsonants() const {
    int n;
    char vowels[] = { 'a', 'e', 'i', 'o', 'u' };
    for (int i = 0; i < sizeof(vowels) / sizeof(char); i++) {
        n = 0;
        for (int j = 0; j < size; j++) {
            if ((vowels[i] == str[j]) && str[j] != ' ')continue;
            n++;
        }
    }
    return n;
}