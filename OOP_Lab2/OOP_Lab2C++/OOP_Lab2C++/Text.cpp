#include "Text.h"
#include "Str.h"


Text::Text(Str a)
{
    size++;
    text = new Str[size];
    text[0] = a;
}
void Text::Spaces() {
    for (int i = 0; i < size;i++) {
        text[i].Spaces();
    }
}

void Text::Add(Str a)
{
    size++;
    text[size - 1] = a;
}
void Text::PrintText() {
    for (int i = 0; i < size;i++) {
        text[i].print();
    }
}

//void MyText::Del()
//{
//    delete[size-1]text;
//    size--;
//}

void Text::Clear()
{
    *text = nullptr;
    size = 0;
}

int Text::Smallest()
{
    int min = text[0].getSize(), index = 0;
    for (int i = 0; i < size; i++)
    {
        if (text[i].getSize() < min)
        {
            min = text[i].getSize();
            //index = i;
        }
    }
    //return text[index];
    return min;
}
void Text::DeleteFirstAndLastSpace(Str string) {
    string.DeleteFirstAndLast();
}

int Text::Elements()const
{
    int e = 0;
    for (int i = 0; i < size; i++)
    {
        e += text[i].getSize();
    }
    return e;
}
//int MyText::CalcConsonants() const {
//
//}
double Text::ConsonantsPercentage() const
{
    int e = Elements();
    int n = 0;
    for (int i = 0; i < size; i++)
    {
        n += text[i].CalcConsonants();
    }
    return 100.0 * n / e;
}
void Text::Del(Str string) {
    for (int i = 0; i < size;i++) {

    }
}
