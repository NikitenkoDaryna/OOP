#pragma once
class _String
{
protected:
	char* str=nullptr;
	int size=0;
public :
	_String() ;
	_String(const char[]);
	virtual void Add( const char[]);
	virtual int getSize();
	 void PrintStr();
};

