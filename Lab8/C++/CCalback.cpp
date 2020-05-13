#include "List.h"
List::List(std::string str ) {
   this->str = str;
}
int  List::ReturnNumberOfSymbs(std::string str) {
    int counter = 0;
    for (int i = 0; i < str.size;i++) {
        if (isupper(str[i]))counter++;
    }
    return counter;
}

