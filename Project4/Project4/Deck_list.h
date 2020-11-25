#pragma once
#include "Deck.h"
class Deck_list
{
public:
	Deck_list() = default;
	~Deck_list();
	void Add_deck(const std::string& path);
	void Add_deck(const Deck& deck);
	const Deck& Get_deck(int which);
	const int& Get_number();
private:
	void Increase();
	Deck** _all_decks;
	int _how_decks = 0;
};

