#pragma once
#include <string>
#include <iostream>

class Card
{
public:
	Card() = default;
	~Card() = default;
	Card(const std::string &suit, const std::string& rank,int value);
	std::string Get_suit() const;
	std::string Get_rank() const;
	int Get_value() const;
	void Set_suit(const std::string& suit);
	void Set_rank(const std::string& suit);
	void Set_value(int value);
	friend std::ostream& operator<< (std::ostream& out, const Card& point);

private:
	std::string _suit;
	std::string _rank;
	int _value = 0;
};

