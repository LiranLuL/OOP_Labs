#pragma once
#include "Train.h"
#include <map>
#include "Train_key.h"

class Train_storage
{
public:
	std::multimap<Train_key, Train> train_table;
};

