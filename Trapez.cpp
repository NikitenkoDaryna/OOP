#include <iostream>
#include "Trapez.h"
#include <cmath>
using namespace std;
Trapez::Trapez(Coordinate &c1,Coordinate &c2, Coordinate& c3, Coordinate& c4,Coordinate& h):Shape(c1,c2,c3,c4)
{
    s1 = c1;
    s2 = c2;
    s3 = c3;
    s4 = c4;
    s5 = h;
}
double Trapez::ReturnPerimeter() {
    double a = FindSideLength(s1, s2);
    double b = FindSideLength(s2, s3);
    double c = FindSideLength(s3, s4);
    double d = FindSideLength(s4, s1);
    double res = a + b + c + d;
    return res;
}
double Trapez::ReturnSquare() {
    double h = sqrt(pow(s5.getX(), 2) + pow(s5.getY(), 2));
    double b = FindSideLength(s2, s3);
    double d = FindSideLength(s4, s1);
    double m = (b + d) / 2;
    return m * h;
}
void Trapez::PrintPerimeter()
{
   cout<<"Trapez perimeter:"<< ReturnPerimeter();
}
void Trapez::PrintSquare() {
    cout<<"Trapez square:"<< ReturnSquare();
}
