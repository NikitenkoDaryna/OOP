#include "Numbers.h"
#include <cstring>
#include <iostream>
#include "stdlib.h"
using namespace std;
Numbers::Numbers(const char s[]) {
	size = strlen(s);
	 str= new char[size];
	for (int i = 0; i < size; i++)
	{
		str[i] = s[i];
	}
}
Numbers::Numbers() :_String(){}

void Numbers::Add(const char s[])  {
	
	if (str == nullptr){
		Numbers();
	}
	else {
		
		for (int i = size; i < size + strlen(s) * 2;i+=2) {
			str[i] = s[(i-size)/2];
			str[i+1] = s[(i-size)/2];
			
		}
		size += strlen(s) * 2;
	}
}
int Numbers::getSize() {
	cout << "Class Numbers"<<endl;
	return size;
}