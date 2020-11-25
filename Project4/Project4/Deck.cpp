#include "Deck.h"

Deck::Deck(const std::string& path)
{
	std::ifstream file;
	file.open(path);
	std::string suit, rank;
	int value;
	if (file.is_open())
	{
		file >> _deck_size;
		_remains = _deck_size - 1;
		_all_cards = new Card[_deck_size];
		for (int i = 0; i < _deck_size; i++)
		{
			file >> rank >> suit >> value;
			_all_cards[i] = Card(suit, rank, value);
		}
		file.close();
	}
	else
	{
		file.close();
		throw std::exception("File not found.");
	}
}

Deck::~Deck()
{
	if (_all_cards != nullptr)
	{
		delete[] _all_cards;
		_all_cards = nullptr;
	}
}

void Deck::Deck_shuffler()
{
	int n = _deck_size;
	while (n > 1)
	{
		int ind = rand() % n;
		n--;
		Card temp = _all_cards[n];
		_all_cards[n] = _all_cards[ind];
		_all_cards[ind] = temp;
	}
}

Card* Deck::Get_top_card()
{
	if(_remains>=0)
		return &_all_cards[_remains--];
	else
		return nullptr;
}

const std::string Deck::Get_random_suit()
{
	return _all_cards[rand() % _deck_size].Get_suit();
}

std::ostream& operator<<(std::ostream& out, const Deck& deck)
{
	out << "Deck have " << deck._deck_size << " cards";
	return out;
}
