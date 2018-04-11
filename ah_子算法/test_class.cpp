#include "stdafx.h"
#include <string>
#include <iostream>
#include <sstream>


class a1
{
public:
	a1() {}
	~a1() {}

	virtual void test() = 0;
};

class A
{
public:
	A() {}
	~A() {}

	virtual void test()
	{

	};

	static void init(a1* a)
	{
		_a = a;
	};

	static a1 *_a;
	static int *x;
};

class A1:public a1
{
public:
	A1() {}
	~A1() {}

	virtual void test()
	{

	};
};

int tt[100];
a1* A::_a = nullptr;

void class_test()
{
	a1 *a = new A1();
	//A::_a = a;
	A::init(a);
	//A::x = tt;

}