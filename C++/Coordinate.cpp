#include "Coordinate.h"
void Coordinate::setX(double x) {
	this->x = x;
}
double Coordinate::getX() {
	return x;
}
void Coordinate::setY(double y) {
	this->y = y;
}
double Coordinate::getY() {
	return y;
}
Coordinate::Coordinate() {

}
Coordinate::Coordinate(double x,double y) {
	this->x = x;
	this->y = y;
}
