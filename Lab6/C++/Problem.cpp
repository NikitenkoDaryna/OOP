#include "Problem.h"
#include <math.h>
#include <iostream>
#include <stdexcept>
using namespace std;
Problem::Problem(double a,double b,double c ) {
	this->a = a;
	this->b = b;
	this->c = c;
}
Problem::Problem() {

}
void Problem::setA(double a) {
	this->a = a;
}
void Problem::setB(double b) {
	this->b = b;
}
void Problem::setC(double c) {
	this->c = c;
}
void Problem::setD(double d) {
	this->d = d;
}
double Problem::getA() {
	return this->a;
}
double Problem::getB() {
	return this->b;
}
double Problem::getC() {
	return this->c;
}
double Problem::getD() {
	return this->d;
}
double operator/(Problem& p, double d) {
	double res = 0;
	try {
		res = p.Division(p.c,d);
	}
	catch (runtime_error& e) {
		cout << "Exception occurred" << endl
			<< e.what();
	}
	return res;
}
double Problem::ReturnLog10() {
	double res = 0;
	try {
		res = CheckArgument(4 * b - c);
	}
	catch (runtime_error & e) {
		cout<< "Exception occurred" << endl
			<< e.what();
	}
	return log10(4 * b - c);
}
double Problem::Multiply() {
	double res= ReturnLog10() * a;
	return res;
}
double operator*(Problem& p,double d) {
	double res = 0;
	try {
		res = p.Multiply() * p.Division(1 ,( (p.b + p.Division(p.c,d) - 1)));
	}
	catch (runtime_error& e) {
		cout << "Exception occurred" << endl
			<< e.what();
	}
	return res;
}
double Problem::Division(double c,double d) {
	//using stdexcept
	if(d==0)throw runtime_error("Math error: Attempted to divide by Zero\n");
	return c / d;
}
class Exception :public runtime_error {
public:
	Exception() :runtime_error("Math error: Log10 must be positive\n") {}
};

bool Problem::CheckArgument(double arg) {
	//using class exception
	if (arg <= 0) throw Exception();
	return true;
	
}




