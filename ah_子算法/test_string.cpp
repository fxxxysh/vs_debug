
#include "stdafx.h"
#include <string>
#include <iostream>
#include <sstream>

using namespace std;

void int2str(const int &int_temp, string &string_temp)
{
	stringstream stream;
	stream << int_temp;
	stream >> string_temp;
}

void str2int(int &int_temp, const string &string_temp)
{
	stringstream stream(string_temp);
	stream >> int_temp;
}

void test_string()
{
	char name[] = "name112";

	int x = 0;
	std::string namex = "name";
	std::string name1 = name;
	std::string name2 = "name2";

	std::string name3 = name2.substr(4,10);
	int int_temp = atoi(name3.c_str());

	if (name2 > name1)
	{
		cout << name3 << "  " << int_temp << "  "<< name2 <<endl;
	}
	else
	{
		cout << name2 << "  " << name1 << endl;
	}
}