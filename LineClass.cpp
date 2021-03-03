#include <iostream>
#include<math.h>

using namespace std;

class Line {
private:
	class Point {
	private:
	public:
		double _x;
		double _y;
		Point (): _x(0), _y(0){}
		Point(double x, double y) : _x(x), _y(y)	{}

	};
	Point _a;
	Point _b;
public:
	Line(double x1, double y1, double x2, double y2)  {
	_a._x = x1;
	_a._y = y1;
	_b._x = x2;
	_b._y = y2;
	
	}
	void printPointA() {
		cout << "X1 : "<< _a._x<<endl;
		cout << "Y1 : "<< _a._y << endl;
	}
	void printPointB() {
		cout << "X2 : " << _b._x << endl;
		cout << "Y2 : " << _b._y << endl;
	}
	void printCoordinates() {
		printPointA();
		printPointB();
	}
	double calculateDistance(){
		double distance;
		distance = (_b._x - _a._x) * (_b._x - _a._x) + (_b._y - _a._y) * (_b._y - _a._y);
		return distance = sqrt(distance);
	}
};

int main() {
	Line ln(2, 5, 4, 8);
	ln.printCoordinates();
	cout << ln.calculateDistance();

}