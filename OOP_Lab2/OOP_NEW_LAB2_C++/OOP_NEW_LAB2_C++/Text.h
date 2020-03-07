#pragma once
#include "Str.h"
#include <iostream>
class Text
{
private:
	Str* text;
	int quantity;
	void resize(int);
public:
	Text();
	void print();
	void add(char* arr);
	void erase(int index);
	void clear();
	int quantity_of_consonants();
	int quantity_of_symbols();
	double percent_of_consonants();
	void delete_first_and_last();
	void deleteExtraSpace();
	Str min_row();
	~Text();
};

