#define _CRT_SECURE_NO_WARNINGS 
#include <string>
#include "Card.h"

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