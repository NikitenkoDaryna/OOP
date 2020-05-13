#pragma once
#include <string>
#include <iostream>
 class List
{
private:std::string str ;
public:
	List(std::string str);
	static int ReturnNumberOfSymbs(std::string str) {
		int counter = 0;
		for (int i = 0; i < str.size; i++) {
			if (isupper(str[i]))counter++;
		}
		return counter;
	};
	int ReturnNumberOfSymbs(std::string str);

};

