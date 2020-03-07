#pragma once
#include <iostream>
using namespace std;
class Str
{
private:
	char* str = {};//zero initialization
	int size;
	void init(char*);
public:
	Str();
	Str(char* str);
	Str(const Str& str);
	int quantity_of_consonants();
	int quantity_of_symbols();
	void delete_first_and_last();
	void deleteSpace();
	Str& operator =(const Str&);
	friend ostream& operator <<(ostream& os, const Str& str); //overload the << operator for my class.
	//Inserts the sequence of characters that conforms value of str into os(ostream object).
	friend class Text;
	int get_size() const;
	~Str();
};

