#pragma once
#include "Shape.h"
#include "Coordinate.h"
class Trapez:public Shape
{
public:
    Coordinate s1;
    Coordinate s2;
    Coordinate s3;
    Coordinate s4;
    Coordinate s5;
    Trapez(Coordinate& c1, Coordinate& c2, Coordinate& c3, Coordinate& c4,Coordinate& h);
    double ReturnPerimeter();
    double ReturnSquare();
    void PrintSquare();
    void PrintPerimeter();

};

