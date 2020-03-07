// OOP_NEW_LAB2_C++.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include "Str.h"
#include "Text.h"
using namespace std;

int main()
{
	char arr1[] = { ' ', 'r', 'a', '\0' };
	char arr2[] = { ' ', 'a', 'a', 'a', 'a', ' ', '\0' };
	char arr3[] = { '3', '-', 'r', 'd', ' ', 'e', 'o', 'o', '\0' };
	char arr4[] = { 'r', ' ', ' ', ' ', 'a', 'c', 'e', '\0' };
	Text txt;
	txt.add(arr1);
	txt.add(arr2);
	txt.delete_first_and_last();
	txt.add(arr4);
	txt.deleteExtraSpace();
	cout << txt.percent_of_consonants();

	txt.print();
	
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
