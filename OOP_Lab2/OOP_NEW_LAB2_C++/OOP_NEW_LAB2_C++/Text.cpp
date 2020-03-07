#include "Text.h"
#include "Text.h"
#include "Str.h"

Text::Text() : quantity{ 0 } {
	text = new Str[quantity + 2];
	for (int i = 0; i < quantity + 2; ++i)
		text[i] = Str();
}

void Text::print() {
	for (int i = 0; i < quantity; i++) {
		cout << text[i] << endl;
	}
}
Text::~Text() {
	delete[] text;
}
void Text::delete_first_and_last() {
	for (int i = 0; i < quantity; ++i)
	{
		text[i].delete_first_and_last();
	}
}
void Text::resize(int value) {
	Str* tmp = new Str[value + 2];
	for (int i = 0; i < value; i++) {
		tmp[i] = i < quantity ? Str(text[i]) : Str();
	}
	delete[] text;
	text = tmp;
}
void Text::deleteExtraSpace() {
	for (int i = 0; i < quantity; ++i)
	{
		text[i].deleteSpace();
	}
}
void Text::add(char* arr) {
	resize(quantity + 1);
	text[quantity] = Str(arr);
	quantity++;
}

void Text::erase(int index) {
	for (int i = index; i < quantity; i++) {
		text[i] = text[i + 1];
	}
	quantity--;
}
void Text::clear() {
	for (int i = 0; i < quantity; i++) {
		text[i] = Str();
	}
	quantity = 0;
}
int Text::quantity_of_consonants() {
	int counter = 0;
	for (int i = 0; i < quantity; i++) {
		counter += text[i].quantity_of_consonants();
	}
	return counter;
}
int Text::quantity_of_symbols() {
	int counter = 0;
	for (int i = 0; i < quantity; i++) {
		counter += text[i].quantity_of_symbols();
	}
	return counter;
}
double Text::percent_of_consonants() {
	double percent;
	percent = (double(quantity_of_consonants()) * 100.0) / double(quantity_of_symbols());
	return percent;
}
//void Text::delete_first_and_last(Str str) {
//	 str.delete_first_and_last();
//}
Str Text::min_row() {
	int length = text[0].quantity_of_symbols();
	int min = 0;
	for (int i = 1; i < quantity; i++) {
		if (text[i].quantity_of_symbols() < min) {
			min = i;
		}
	}
	return text[min];
}
