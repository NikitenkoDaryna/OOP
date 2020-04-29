#pragma once
class Problem
{
	double a=0, b=0, c=0, d=0;
public:
	Problem(double, double, double);
	Problem();
	void setA(double);
	void setB(double);
	void setC(double);
	void setD(double);
	double getA();
	double getB();
	double getC();
	double getD();
private:
	double ReturnLog10();
	double Multiply();
public:
	friend double  operator/(Problem&,double);
	friend double  operator*(Problem&,double);
	double Division(double,double);
	bool CheckArgument(double);
};

