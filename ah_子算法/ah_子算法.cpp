// ah_子算法.cpp: 定义控制台应用程序的入口点。
//

#include "stdafx.h"

void check_sensor();
void kfifo_test();
void test_string();
void class_test();

void test_static(int x)
{
	static int val = x;

	printf("%d\r\n", val);
}

int main()
{
	//check_sensor();
	//kfifo_test();
	//test_string();

	//class_test();

	test_static(2);
	test_static(3);
	while (true)
	{

	}
    return 0;
}

