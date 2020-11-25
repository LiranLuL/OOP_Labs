#include "Card.h"

Card::Card(const std::string& suit, const std::string& rank, int value) :_suit(suit), _rank(rank), _value(value)
{}

int Card::Get_value() const
{
	return _value;
}

void Card::Set_value(int value)
{
	_value = value;
}

std::string Card::Get_suit() const
{
	return _suit;
}

std::string Card::Get_rank() const
{
	return _rank;
}

void Card::Set_suit(const std::string& suit)
{
	_suit = suit;
}

void Card::Set_rank(const std::string& rank)
{
	_rank = rank;
}

std::ostream& operator<<(std::ostream& out, const Card& card)
{
	out << card.Get_rank() << " " << card.Get_suit();
	return out;
}
