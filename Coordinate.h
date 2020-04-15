#pragma once
class Coordinate
{
private:
	double x=0.0;
	double y=0.0;
public:
	void setX(double);
	void setY(double);
	double getX();
	double getY();
	Coordinate();
	Coordinate(double,double);
};

