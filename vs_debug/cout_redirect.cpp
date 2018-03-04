
#define _CRT_SECURE_NO_DEPRECATE

#include "stdafx.h"
#include <iostream>

using namespace std;

//class Fcout;
//class Fost : public std::ostream
//{
//public:
//
//	Fcout fcout;
//	
//	void set()
//	{
//		ostream ostream1(&fcout);
//		_Myios::init();
//		_Myios::move(std::move(ostream1));
//	}
//};

class Fcout : public std::streambuf
{
public:
	Fcout() 
	{
		//setp(m_buffer, m_buffer + BufferSize - 1);
	}

	~Fcout() {}

	//static const int BufferSize = 50;
	//char m_buffer[BufferSize];

protected:
	//friend class basic_ostream;
	friend class ostream;

	int sync() 
	{
		printf("sync \r\n");

		if (FlushBuffer() == EOF) {
			return -1;
		}

		return 0;
	}

	int FlushBuffer() 
	{
		int len = pptr() - pbase();

		//if (send(m_socket, m_buffer, len, 0) <= 0)
		//{
		//	return EOF;
		//}
		std::printf("FlushBuffer = %d \r\n", len);

		return len;
	}


	int_type overflow(int_type c) 
	{
		if (c != EOF) 
		{
			std::printf("overflow = %c \r\n", c);		
		}
		return c;
	}
   
	streamsize xsputn(const char_type *_Ptr, streamsize _Count)
	{
		std::printf("xsputn = %c \r\n", *_Ptr);

		return _Count;
	}

private:

};

#include<stdio.h>

void func1()
{

}

void func(FILE*p)
{
	char*str = "ddd";
	fputs(str, p);
}

void cout_redirect(void)
{
	std::ostream outStream(new Fcout);

	outStream << "ok--------------------------";

	//std::cout.rdbuf(outStream.rdbuf());

	int a = 100000;
	std::cout << a;

	std::cout << "2341" << endl;

	//FILE *file;

	std::cout << (int)stdout;

	if (freopen("printf.txt", "w", stdout) == NULL)
	{
		perror("freopen() failed");
	}

	std::cout << (int)stdout;
	//std::printf("stdout is redirected to a 1234"); // this is written to redir.txt

	while (true)
	{

	}
}