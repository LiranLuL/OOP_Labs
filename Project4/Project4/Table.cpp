#include "Table.h"



Table::~Table()
{
	
}

Card* Table::What_card_on_table()
{
	return _card_on_table;
}



const void Table::Put_card_on_table(Card* card)
{
	_card_on_table = card;
}

