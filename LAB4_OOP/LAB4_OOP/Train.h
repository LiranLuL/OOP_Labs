#pragma once
#include <string>
#include "Time.h"
#include "Date.h"

class Train
{
public:
	Train() = default;
	Train(std::string destination_point, int train_identifier, std::pair<Time, Date> _departure, std::pair<Time, Date> _arrival);
	~Train() = default;
	std::string Get_destination_point() const;

	friend bool operator<(const Train& first, const Train& second);
	friend bool operator>(const Train& first, const Train& second);

	int Get_identifier() const;
	std::pair<Time, Date> Get_departure_date() const;
	std::pair<Time, Date> Get_arrival_date() const;
private:
	std::string _destination_point = "";
	int _train_identifier = -1;
	std::pair<Time, Date> _departure;
	std::pair<Time, Date> _arrival;
};