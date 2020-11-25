#pragma once
#include "Card.h"
#include <iostream>
#include <ostream>
#include <fstream>

class Deck
{
public:
	Deck(const std::string& path);
	~Deck();
	void Deck_shuffler();
	friend std::ostream& operator<<(std::ostream& out, const Deck& deck);
	int Get_size() { return _deck_size; }
	Card* Get_top_card();
	int Get_remains() { return _remains; }
	const std::string Get_random_suit();
private:
	Card* _all_cards = nullptr;
	int _remains;
	int _deck_size;
};

