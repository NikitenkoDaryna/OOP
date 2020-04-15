#include "Shape.h"
#include <cmath>
Shape::Shape(Coordinate &c1, Coordinate &c2, Coordinate &c3, Coordinate &c4) {
	_c1 = c1;
	_c2 = c2;
	_c3 = c3;
	_c4 = c4;
}
double Shape::FindSideLength(Coordinate &a,Coordinate &b) {
	Coordinate c (b.getX() - a.getX(), b.getY() - a.getY());
	double res = sqrt(pow(c.getX(), 2) + pow(c.getY(), 2));
	return res;
}
