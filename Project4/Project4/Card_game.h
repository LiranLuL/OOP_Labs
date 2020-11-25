#pragma once
#define _CRTDBG_MAP_ALLOC
#include <stdlib.h>
#include <crtdbg.h>
#include "Deck.h"
#include "Human.h"
#include "Mad.h"
#include "Honest.h"
#include "Greedy.h"
#include "Table.h"

class Card_game
{
public:
	Card_game() = default;
	~Card_game();
	void Deck_reader(const std::string& path);
	static Human* Human_factory(int which);
	void Add_players(int how, int* characters);
	Human** Start_game();
private:
	bool Check_hands(Human** _players, int how);
	int First_turn(Human** _players, int which, Table* table,int how);
	bool Second_turn(Human** _players, int which, Table* table, const std::string& trump_suit);
	void Define_winners(Card* card, Human** _players, int how, Human** winners);
	Table* table = nullptr;
	void Fill_hands();
	static const int _how_cards_in_hands=4;
	void Clean_players();
	int _how_players = -1;
	Human** _players = nullptr;
	Deck* _deck = nullptr;
	std::string _trump_suit;
};