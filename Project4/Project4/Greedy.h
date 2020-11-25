#pragma once
#include "Human.h"
#include <iostream>

class Greedy : public Human
{
public:
	~Greedy();
	bool My_hand_empty() override;
	bool Beat(const std::string& trump_suit, Card* card) override;
	void Discard_card() override;
	void Increase_hand(int how) override;
	void Take_card(Card* card) override;
	Card* Put() override;
private:
	int _how_i_have_cards = 4;
	int _which_index = -1;
};

