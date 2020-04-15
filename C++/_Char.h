#pragma once
#include "_String.h"
class _Char:public _String
{
public:
	_Char() :_String() {}
	_Char(const char[]);
	void Add(const char[])override;
	int getSize()override;
};

