#include "Parser.h"

void Parser::Parse_file(const std::string &path, std::multimap<Train_key, Train> *train_table) const
{
		std::fstream input(path);
		if (!input.is_open())
		{
			throw std::exception("File doesn`t exist!");
		}
		int how_trains;
		std::string point;
		int identifier;
		char symbol;
		std::pair<Time, Date> _departure;
		std::pair<Time, Date> _arrival;
		Train_key key;
		input >> how_trains;
		for (auto i = 0; i < how_trains; i++)
		{
			input >> point >> identifier >> _departure.first.hour >> symbol >> _departure.first.minutes >> _departure.second.day >> symbol >> _departure.second.mounth >> symbol >> _departure.second.year
				>> _arrival.first.hour >> symbol >> _arrival.first.minutes >> _arrival.second.day >> symbol >> _arrival.second.mounth >> symbol >> _arrival.second.year;
			Train temp(point, identifier, _departure, _arrival);
			key._date = _departure.second;
			key._point = point;
			train_table->emplace(key, temp);
		}
}
