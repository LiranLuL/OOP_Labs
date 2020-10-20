#pragma once
#include <string>
#include <iostream>
#include <exception>
#include <fstream>

class Console_interactor
{
public:
	~Console_interactor();
	void Print_array(int* array);
	void Run();
	void File_reader(const std::string& path);
	void File_writter(const std::string& path);
private:
	long long int _quantity;
	int* _array=nullptr;
};

