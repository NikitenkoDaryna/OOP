#include "_String.h"
#include <cstring>
#include <iostream>
using namespace std;
_String::_String() {

	size = 0;
	str = new char[size];
}
_String::_String(const char val[]){
	size = strlen(val);
	str = new char[size];
	for (int i = 0; i < size; i++)
	{
		str[i] = val[i];
	}
}
void _String::Add( const char s[]) {
	if (str == nullptr)
	{
		_String();
	}
	else {

		for (int i = size; i < size + strlen(s); i++)
		{
			str[i] = s[i - size];
		}
		size += strlen(s);

	}
}
int _String::getSize() {
	return size;
}

void _String::PrintStr() {
	
	for (int i = 0; i < size; i++)
	{
		cout << str[i];
	}
	cout << endl;
	
}

