#include "Str.h"
Str::Str() : size{ 0 } {
	str = new char[0];
}
Str::Str(char* str) {
	init(str);
}
Str::Str(const Str& str) {
	init(str.str);
}
Str::~Str() {
	delete[] str;
}
ostream& operator<<(ostream& os, const Str& str) {
	os << str.str;
	return os;
}

void Str::delete_first_and_last() {
	int count1(0);
	int count2(0);
	for (int i = 0; str[i] == ' '; ++i, count1++);
	for (int j = size - 1; str[j] == ' '; --j, count2++);
	char* temp = new char[size + 1 - count1 - count2];

	for (int j = count1, k = 0; k != size - count1 - count2; ++j) {
		temp[k] = str[j];
		k++;
	}
	temp[size - count1 - count2] = '\0';
	delete[] str;
	str = temp;
}
void Str::init(char* arr) {
	size = strlen(arr);
	this->str = new char[size + 1];
	for (int i = 0; i < size; ++i) {
		this->str[i] = arr[i];
	}
	this->str[size] = '\0';
}
void Str::deleteSpace() {
	int countSpace = 0;
	for (int i = 0; i < size; ++i) {
		if (str[i] == ' ' and str[i + 1] == ' ')
		{
			countSpace++;
		}
	}
	char* temp = new char[size + 1 - countSpace];

	for (int j = 0, k = 0; j < size; ++j) {
		if (str[j] == ' ' and str[j + 1] == ' ')
		{
			continue;
		}
		temp[k] = str[j];
		k++;
	}

	temp[size - countSpace] = '\0';
	delete[] str;
	str = temp;

}

int Str::quantity_of_consonants() {
	int counter = 0;
	for (int i = 0; i < size; i++) {

		char ch = str[i];

		if ((ch >= 'a' && ch <= 'z') ||
			(ch >= 'A' && ch <= 'Z')) {

			// To handle upper case letters 
			ch = tolower(ch);

			if (!(ch == 'a' || ch == 'e' || ch == 'i' ||
				ch == 'o' || ch == 'u'))
				counter++;
		}

		return counter;
	}
}
int Str::quantity_of_symbols() {
	return size;
}

Str& Str::operator=(const Str& arr) {
	this->size = arr.get_size();
	if (this->str != nullptr)
		delete[] this->str;
	this->str = new char[size + 1];
	for (int i = 0; i < size + 1; ++i) {
		this->str[i] = arr.str[i];
	}
	return *this;
}
int Str::get_size() const {
	return size;
}
