#include "Train.h"

Train::Train(std::string destination_point, int train_identifier, std::pair<Time, Date> departure, std::pair<Time, Date> arrival)
	:
	_destination_point(destination_point),
	_train_identifier(train_identifier),
	_departure(departure),
	_arrival(arrival)
{}

std::string Train::Get_destination_point() const
{
	return _destination_point;
}

int Train::Get_identifier() const
{
	return _train_identifier;
}

std::pair<Time, Date> Train::Get_departure_date() const
{
	return _departure;
}

std::pair<Time, Date> Train::Get_arrival_date() const
{
	return _arrival;
}

bool operator<(const Train& first, const Train& second)
{
	return (first._departure.first.hour * 60 + first._departure.first.minutes)
		< (second._departure.first.hour * 60 + second._departure.first.minutes);
}

bool operator>(const Train& first, const Train& second)
{
	return (first._departure.first.hour * 60 + first._departure.first.minutes)
> (second._departure.first.hour * 60 + second._departure.first.minutes);
}
