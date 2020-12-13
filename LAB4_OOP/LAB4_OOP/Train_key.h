#pragma once
#include <string>
#include "Date.h"
struct Train_key
{
	std::string _point = "";
	Date _date;
	friend bool operator<(const Train_key& a, const Train_key& b)
	{
		return a._point < b._point;
	}
};

