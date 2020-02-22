// OOPC++_LAB1.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include "pch.h"
#include <iostream>
using namespace std;
 bool EqualNumbers(int,int);
 void add(int &,int );


int main()
{
	int a = -3;
	int tmp = a;
	int b = 3;
	bool isEqual = EqualNumbers(a,b);
	cout << "is " << a << " equal to " << b << "? " << isEqual<<"\n";
	add(a,
		b);
	cout << "a=" << tmp << "\n" << "b=" << b << "\n" << "a+b=" << a << "\n";
}

static void add(int &a,int b) {
	int result = 0;
	int abit, bbit, cbit = 0, nbit;
	int last_bit = sizeof(int) * 8;
	for (int n = 0; n < last_bit; n++)
	{
		nbit = 1 << n;
		abit = a & nbit;
		bbit = b & nbit;
		if (abit ^ bbit)
		{
			result |= ~cbit & nbit;
		}
		else if (abit)
		{
			result |= cbit;
			cbit = nbit;
		}
		else
		{
			result |= cbit;
			cbit = 0;
		}
		cbit <<= 1;

	}
	a = result;
	
}
static bool EqualNumbers(int a, int b)
{
	int aa, bb, ii;
	int equal = 0;
	for (int i = sizeof(int) * 8; i > 0; i--)
	{
		ii = i >> 1;
		aa = a & i;
		bb = b & i;
		if (!(aa ^ bb))
		{
			equal = 1;
		}
		else
		{
			equal = 0;
		}
	}
	return equal;

}



// Запуск программы: CTRL+F5 или меню "Отладка" > "Запуск без отладки"
// Отладка программы: F5 или меню "Отладка" > "Запустить отладку"

// Советы по началу работы 
//   1. В окне обозревателя решений можно добавлять файлы и управлять ими.
//   2. В окне Team Explorer можно подключиться к системе управления версиями.
//   3. В окне "Выходные данные" можно просматривать выходные данные сборки и другие сообщения.
//   4. В окне "Список ошибок" можно просматривать ошибки.
//   5. Последовательно выберите пункты меню "Проект" > "Добавить новый элемент", чтобы создать файлы кода, или "Проект" > "Добавить существующий элемент", чтобы добавить в проект существующие файлы кода.
//   6. Чтобы снова открыть этот проект позже, выберите пункты меню "Файл" > "Открыть" > "Проект" и выберите SLN-файл.
