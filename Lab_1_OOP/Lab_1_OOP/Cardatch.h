#pragma once
#include <iostream>
#include <ctime> 
#include <exception>
#include <fstream>
#include "Card.h"

class Cardatch
{
public:
	Cardatch()=default;
	~Cardatch();
	void Console();
private:
	Card* _deck=nullptr;
	int _deck_size=0;
	void Display_in_console(const Card &card);
	void Display_in_console(const Card &card,int number);
	void Read_all(const std::string& path);
	void Shuffle_deck();
	int Ñomparison_couple_cards(const Card &first, const Card &second);
	Card* Create_table(int how);
	Card Find_best(int first, int last,const Card* table);
	Card Find_best(int first, int last, Card* table, const std::string& suit);
	int Identify_winner(Card* table, int how);
	int Simulating_game(int n);
};