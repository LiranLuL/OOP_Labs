#include "Human.h"

Human::Human()
{
	_hand = new Card * [_how_cards_in_hands];
	for (int i = 0; i < _how_cards_in_hands; i++)
	{
		_hand[i] = nullptr;
	}
}

Human::~Human()
{
	if (_hand != nullptr)
	{
		for (int i = 0; i < _how_i_have_cards; i++)
		{
			if(_hand[i] != nullptr)
			delete _hand[i];
		}
		delete[] _hand;
	}
}
