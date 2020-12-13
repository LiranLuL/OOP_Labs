#pragma once
#include <fstream>
#include <map>
#include "Train_key.h"
#include "Train.h"
class Parser
{
public:
	void Parse_file(const std::string& path, std::multimap<Train_key, Train>* train_table) const;
};

