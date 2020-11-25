#include "Deck_list.h"	 

Deck_list::~Deck_list()
{
	delete _all_decks;
}

void Deck_list::Add_deck(const std::string& path)
{
	Deck_list::Increase();
	auto deck = new Deck(path);
	_all_decks[_how_decks] = deck;
	_how_decks++;
}

void Deck_list::Add_deck(const Deck& deck)
{
	Deck_list::Increase();
	*_all_decks[_how_decks] = deck;
	_how_decks++;
}

const Deck& Deck_list::Get_deck(int which)
{
	if (which < _how_decks)
		return *_all_decks[which];
}

const int& Deck_list::Get_number()
{
	return _how_decks;
}

void Deck_list::Increase()
{
	if (_how_decks != NULL)
	{
		auto temp = _all_decks;
		*_all_decks = new Deck[_how_decks + 1];
		for (int i = 0; i < _how_decks; i++)
		{
			_all_decks[i] = temp[i];
		}
	}
	else
	{
		_all_decks = new Deck*;
	}
}
