#include "Mad.h"
#include <ctime>



Mad::~Mad()
{
	if (_hand != nullptr)
	{
		for (int i = 0; i < _how_i_have_cards; i++)
		{
			if (_hand[i] != nullptr)
			{
				_hand[i] = nullptr;
				delete _hand[i];
			}
		}
		delete[] _hand;
		_hand = nullptr;
	}
}

bool Mad::Beat(const std::string& trump_suit, Card* card)
{
	bool can = false;
	for (int i = 0; i < _how_i_have_cards; i++)
	{
		if (_hand[i] != nullptr)
		{
			if (_hand[i]->Get_suit() == card->Get_suit() && _hand[i]->Get_value() >= card->Get_value())
			{
				if (rand() % 2)
				{
					can = true;
					std::cout << "Next player beat it with: " << *_hand[i]<<"\n";
					_hand[i] = nullptr;
					break;
				}
			}
		}
	}
	return can;
}

Card* Mad::Put()
{
	for (int i = _how_i_have_cards-1; i > -1; i--)
	{
		if (_hand[i] != nullptr)
		{
			_which_index = i;
			return _hand[i];
		}
	}
	return nullptr;
}

void Mad::Discard_card()
{
	_hand[_which_index] = nullptr;
}

bool Mad::My_hand_empty()
{
	bool flag = false;
	for (int i = 0; i < _how_i_have_cards; i++)
	{
		if (_hand[i] != nullptr)
		{
			flag = true;
		}
	}
	return flag;
}

void Mad::Increase_hand(int how)
{
	Card** temp = new Card * [_how_i_have_cards + how];
	for (int i = 0; i < _how_i_have_cards; i++)
	{
		temp[i] = _hand[i];
	}
	for (int i = 0; i < how; i++)
	{
		temp[_how_i_have_cards + i] = nullptr;
	}
	delete[] _hand;
	_hand = nullptr;
	_hand = temp;
	_how_i_have_cards += how;
}

void Mad::Take_card(Card* card)
{
	bool flag = 0;
	for (int i = 0; i < _how_i_have_cards; i++)
	{
		if (_hand[i] == nullptr)
		{
			_hand[i] = card;
			break;
			flag = 1;
		}
	}
	if (!flag)
	{
		Increase_hand(1);
		_hand[_how_i_have_cards-1] = card;
	}
}
