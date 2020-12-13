#pragma once
#include <iostream>
#include <ctime>
#include <typeinfo>
#include <fstream>
#include <map>
#include "Parser.h"
#include "Train.h"


class Console_interactor
{
public:
	void Run();
private:
	Date what_date_today = { 12, 12, 2020 };
	std::multimap<Train_key, Train> train_table;

};
