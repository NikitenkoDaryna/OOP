#include <iostream>;
using namespace std;
#include <cstring>;
#include <exception>
/*int Foo1(int a) {
	return a - 1;
}
int Foo2(int a) {
	return a * 2;
}
*/  
double DivideByZeroExp(int , int );
struct DelegateList1 {
	int CalcUpperCaseLetters(string str) {
		int counter = 0;
		for (int i = 0; i < str.size(); i++) {
			if (isupper(str[i]))
				counter++;
		}
		cout << "non-static method()" << endl;
		return counter;
	};
};
struct DelegateList2 {
	double Divide(int x,int y) {
		double res = 0;
		try {
			res = DivideByZeroExp(x, y);
		}
		catch (std::exception err) {
			std::cout << err.what() << std::endl;
		}
		return res;
	}
	double Add(int x, int y) {
		return x + y;
	}
	double Multiply(int x, int y) {
		return x * y;
	}

};
typedef int (DelegateList1::* DelegateType1)(string s);
typedef double (DelegateList2::* DelegateType2)(int x,int y);

	double DivideByZeroExp(int a, int b)
	{
		if (b == 0)
			throw std::exception("Division by zero!");
		return a / b;
	}

 int main() {

	//int(*fooPointer)(int a);
	//fooPointer = Foo1;
	//cout<<fooPointer(5)<<endl;
	 DelegateType1 d1 = &DelegateList1::CalcUpperCaseLetters;
	 DelegateType2 d2 = &DelegateList2::Divide;
	 DelegateList1 list1;
	 DelegateList2 list2;
	 string s = "HIIsws";
	 int calc = (list1.*d1)(s);
	 double d = (list2.*d2)(5,0);
	 cout << calc<<endl;
	 cout << d << endl;
	
 };

 
