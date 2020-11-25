#pragma once
#include "Human.h"
#include "Deck.h"

class Croupier : public Human
{
public:
	void Put_card(Card* card, Deck* deck, int remains);
};