#pragma once
class Card
{
public:
	Card() = default;
	std::string Get_suit() const;
	std::string Get_rank() const;
	int Get_value() const;
	void Set_suit(const std::string &suit);
	void Set_rank(const std::string& suit);
	void Set_value(int value);
private:
	std::string _suit;
	std::string _rank;
	int _value=0;
};