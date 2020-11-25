#pragma once
#include "Card.h"
class Human
{
public:
	virtual Card* Put() = 0;
	virtual bool Beat(const std::string& trump_suit, Card* card) = 0;
	virtual void Discard_card() = 0;
	virtual void Increase_hand(int) = 0;
	virtual bool My_hand_empty() = 0;
	static const int _how_cards_in_hands = 4;
	int _how_i_have_cards = 4;
	Card** _hand = nullptr;
	virtual void Take_card(Card* card)=0;
	Human();
	virtual ~Human();
};

