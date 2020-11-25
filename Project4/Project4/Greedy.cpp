#include "Greedy.h"

Greedy::~Greedy()
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

bool Greedy::My_hand_empty()
{
	bool flag = true;
	for (int i = 0; i < _how_i_have_cards; i++)
	{
		if (_hand[i] != nullptr)
		{
			flag = false;
		}
	}
	return flag;
}

bool Greedy::Beat(const std::string& trump_suit, Card* card)
{
	bool can = false;
	for (int i = 0; i < _how_i_have_cards; i++)
	{
		if (_hand[i] != nullptr)
		{
			if (_hand[i]->Get_suit() == card->Get_suit() && _hand[i]->Get_value() > card->Get_value())
			{
				if (card->Get_suit() == trump_suit)
				{
					return false;
				}
				else
				{
					can = true;
					_hand[i] = nullptr;
					break;
				}
			}
		}
	}
	return can;
}

void Greedy::Discard_card()
{
	_hand[_which_index] = nullptr;
}

void Greedy::Increase_hand(int how)
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

void Greedy::Take_card(Card* card)
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
		_hand[_how_i_have_cards - 1] = card;
	}
}

Card* Greedy::Put()
{
	for (int i = _how_i_have_cards - 1; i > -1; i--)
	{
		if (_hand[i] != nullptr)
		{
			_which_index = i;
			return _hand[i];
		}
	}
	return nullptr;
}

