#pragma once
#include "Card.h"
class Table
{
public:
	~Table();
	Card* What_card_on_table();
	const void Put_card_on_table(Card* card);
private:
	Card* _card_on_table = nullptr;
};

