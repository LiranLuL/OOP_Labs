#include "Croupier.h"
#include "Card.h"

void Croupier::Put_card(Card* card, Deck* deck,int remains)
{
	card = &deck->_all_cards[remains];
	remains--;
}
