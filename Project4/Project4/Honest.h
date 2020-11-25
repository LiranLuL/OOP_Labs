#pragma once
#include "Human.h"
#include <iostream>

class Honest : public Human
{
	~Honest();
	bool My_hand_empty() override;
	void Discard_card() override;
	bool Beat(const std::string& trump_suit, Card* card) override;
	Card* Put() override;
	void Increase_hand(int how) override;
	void Take_card(Card* card) override;
private:
	int _how_i_have_cards = 4;
	int _which_index = -1;
};

