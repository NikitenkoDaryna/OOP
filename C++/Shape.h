#pragma once
#include "Coordinate.h"

class Shape:public Coordinate
{
    //for quadrangle
public:
    Coordinate _c1;
    Coordinate _c2;
    Coordinate _c3;
    Coordinate _c4;
public:
    Shape(Coordinate& , Coordinate& , Coordinate& , Coordinate& );
    double FindSideLength(Coordinate&, Coordinate&);
    
};

