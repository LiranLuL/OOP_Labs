#include "Honest.h"
#include <ctime>

Honest::~Honest()
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

bool Honest::My_hand_empty()
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

void Honest::Discard_card()
{
	_hand[_which_index] = nullptr;
}

bool Honest::Beat(const std::string& trump_suit, Card* card)
{
	bool can = false;
	for (int i = 0; i < _how_i_have_cards; i++)
	{
		if (_hand[i] != nullptr)
		{
			if (_hand[i]->Get_suit() == card->Get_suit() && _hand[i]->Get_value() >= card->Get_value())
			{
				if (_hand[i]->Get_suit() == card->Get_suit() && _hand[i]->Get_value() >= card->Get_value())
				{
					can = true;
					std::cout << "Next player beat it with: " << *_hand[i] << "\n";

					_hand[i] = nullptr;
					break;
				}
			}
		}
	}
	return can;
}

Card* Honest::Put()
{
	Card* max=NULL;
	for (int i = 0; i < _how_i_have_cards; i++)
	{
		if (_hand[i] != nullptr)
		{
			max = _hand[i];
			break;
		}
	}
	if (max != NULL)
	{
		for (int i = _how_i_have_cards - 1; i > -1; i--)
		{
			if (_hand[i] != NULL && _hand[i]->Get_value() > max->Get_value())
			{
				_which_index = i;
				max = _hand[i];
			}
		}
	}
	return max;
}


void Honest::Increase_hand(int how)
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
	_hand = temp;
	_how_i_have_cards += how;
}

void Honest::Take_card(Card* card)
{
	bool flag = false;
	for (int i = 0; i < _how_i_have_cards; i++)
	{
		if (_hand[i] == nullptr)
		{
			_hand[i] = card;
			break;
			flag = true;
		}
	}
	if (!flag)
	{
		Increase_hand(1);
		_hand[_how_i_have_cards - 1] = card;
	}
}
