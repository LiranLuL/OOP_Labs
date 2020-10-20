#include "Console_interactor.h"
#include "Choice.h"
#include "Quick.h"
#include <exception>
#include <algorithm>
#include <iostream>
#include <fstream>
#include <string>
#include <exception>


Console_interactor::~Console_interactor()
{
	if (_array != nullptr)
	{
		delete[] _array;
	}
}

void Console_interactor::Print_array(int* array)
{
	for (long long int i = 0; i < _quantity; i++)
	{
		std::cout << array[i] << '\n';
	}
}

void Console_interactor::File_reader(const std::string& path)
{
	std::ifstream file;
	file.open(path);
	long long int i;
	if (file.is_open())
	{
		file >> _quantity;
		_array = new int[_quantity];
		for (i=0; i < _quantity; i++)
		{
			file>>_array[i];
		}
	}
	else
	{
		file.close();
		throw std::exception("File not found.");
	}
}

void Console_interactor::File_writter(const std::string& path)
{
	std::ofstream output_file;
	output_file.open(path,std::ios::app);
	if (output_file.is_open())
	{
		std::cout << "File " << path << " created\n";
		for (long long int i = 0; i < _quantity; i++)
		{
			output_file << _array[i] << '\n';
		}
	}
	else
	{
		output_file.close();
		throw std::exception("File not created");
	}
	output_file.close();
}


void Console_interactor::Run()
{
	std::cout << "enter the number of items(10 or 100 or 1000 or 1000000):\n";
	std::string path;
	std::cin >> path;
	path += ".txt";
	try
	{
		File_reader(path);
	}
	catch (const std::exception& err)
	{
		std::cerr << "Error: " << err.what();
		exit(1);
	}
	int command = 1;
	std::cout << "1 - Choice sort\n2 - Qiuck sort\n3 - Create a file with a sorted array(the array will be sorted forcibly)\n4 - Print array\n5 - Shuffle array\n0 - Exit.\n";
	while (command)
	{
		std::cout << "Enter a command: ";
		std::cin >> command;
		switch (command)
		{
		case 0:
			break;
		case 1:
		{
			Choice obj;
			obj.Sort(_quantity, _array);
			std::cout << "Success\n";
		}
			break;
		case 2:
		{
			Quick obj;
			obj.Sort(_quantity, _array);
			std::cout << "Success\n";
		}	
			break;
		case 3:
		{
			Quick obj;
			obj.Sort(_quantity, _array);
			std::cout << "Enter a new file name:\n";
			std::cin >> path;
			path += ".txt";
			try
			{
				File_writter(path);
			}
			catch (const std::exception& err)
			{
				std::cerr << "Error: " << err.what();
				exit(1);
			}
		}
			break;
		case 4:
			Print_array(_array);
			break;
		case 5:
			std::random_shuffle(_array, _array + _quantity);
			break;
		default:
			std::cout << "Invalid command. Try again.\n";
			break;
		}
	}
}

