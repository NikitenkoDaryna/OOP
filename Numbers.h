#pragma once
#include "_String.h"
class Numbers:public _String
{

public:
	Numbers(const char[]);
	Numbers();
	void Add(const char[]) override;
	int getSize() override;	
};

