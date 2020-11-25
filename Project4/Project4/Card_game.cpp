#include "Card_game.h"
#include <sstream>

Card_game::~Card_game()
{
	if (_deck != nullptr)
	{
		delete _deck;
	}
	Clean_players();
	delete table;
}

void Card_game::Deck_reader(const std::string& path)
{
	_deck = new Deck(path);
}

Human* Card_game::Human_factory(int which)
{
	Human* player;
	switch (which)
	{
	case 1:
		player = new Mad;
		break;
	case 2:
		player = new Honest;
		break;
	case 3:
		player = new Greedy;
		break;
	default:
		throw std::exception("Err");
	}
	return player;
}

void Card_game::Add_players(int how, int* characters)
{
	Clean_players();
	_how_players = how;
	_players = new Human * [how];
	for (int i = 0; i < how; i++)
	{
		_players[i] = Human_factory(characters[i]);
	}
}

bool Card_game::Check_hands(Human** _players, int how)
{
	int answer = 0, res = 0;

	for (int i = 0; i < how; i++)
	{
		for (int j = 0; j < _players[i]->_how_i_have_cards; j++)
		{
			if (_players[i]->_hand[j] == nullptr)
			{
				res++;
			}
		}
		if (res == _players[i]->_how_i_have_cards)
		{
			answer++;
		}
		res = 0;
	}
	if (answer >= how - 1)
	{
		return false;
	}
	else
	{
		return true;
	}
}

int Card_game::First_turn(Human** _players, int which, Table* table,int how)
{
	auto temp = _players[which]->Put();
	if (temp != nullptr && !_players[which+1 % how]->My_hand_empty())
	{
		table->Put_card_on_table(temp);
		std::cout << "Player " << which << " put: " << *table->What_card_on_table() << "\n";
		return 1;
	}
	else if (temp != nullptr && !_players[which + 2 % how]->My_hand_empty())
	{
		table->Put_card_on_table(temp);
		std::cout << "Player " << which << " put: " << *table->What_card_on_table() << "\n";
		return 2;
	}
	else
	{
		return 3;
	}
}

bool Card_game::Second_turn(Human** _players, int which, Table* table, const std::string& trump_suit)
{
	return _players[which]->Beat(trump_suit, table->What_card_on_table());

}

void Card_game::Define_winners(Card* card, Human** _players, int how_players, Human** winners)
{
	int res = 0;
	int how_without_cards=0;
	if (card == nullptr)
	{
		for (int i = 0; i < how_players; i++)
		{
			for (int j = 0; j < _players[i]->_how_i_have_cards; j++)
			{
				if (_players[i]->_hand[j] == nullptr)
				{
					res++;
				}
			}

			if (res == _players[i]->_how_i_have_cards)
			{
				how_without_cards++;
			
				for (int k = 0; k < how_players; k++)
				{
					if (winners[k] == _players[i])
					{
						break;
					}
					if (winners[k] == nullptr)
					{
						winners[k] = _players[i];
						break;
					}
				}
			}
			res = 0;
		}
		if (how_without_cards >= _how_players-1)
		{
			for (int i = 0; i < how_players; i++)
			{
				for (int k = 0; k < how_players; k++)
				{
					if (winners[k] == _players[i])
					{
						break;
					}
					if (winners[k] == nullptr)
					{
						winners[k] = _players[i];
						break;
					}
				}
			}
		}
	}
}

Human** Card_game::Start_game()
{
	if (_players != nullptr)
	{
		_trump_suit = _deck->Get_random_suit();
		for (int i = 0; i < 15; i++)
		{
			_deck->Deck_shuffler();
		}
		Fill_hands();
		table = new Table;
		int result,tmp;
		int index = 0;
		Human** winners = new Human * [_how_players];
		for (int i = 0; i < _how_players; i++)
		{
			winners[i] = nullptr;
		}
		while (Check_hands(_players, _how_players))
		{
			Fill_hands();
			//if(something win)
			tmp = First_turn(_players, index % _how_players, table, _how_players);
			index += tmp;
			result = Second_turn(_players, (index) % _how_players, table, _trump_suit);

			if (!result)
			{
				std::cout << "Player " << index << " grab card\n";
				_players[(index) % _how_players]->Take_card(table->What_card_on_table());
				_players[(index - tmp) % _how_players]->Discard_card();
				index++;
			}
			else
			{
				_players[(index - tmp) % _how_players]->Discard_card();
			}
			Define_winners(_deck->Get_top_card(), _players, _how_players, winners);
		}
		//1 ходит на 2
		//если забирает то пропускает
		//игра продолжается пока
		//у 3 человек не кончатся карты
		return winners;
	}
}

void Card_game::Fill_hands()
{
	for (int i = 0; i < _how_players; i++)
	{
		for (int j = 0; j < _how_cards_in_hands; j++)
		{
			if (_players[i]->_hand[j] == nullptr)
			{
				_players[i]->_hand[j] = _deck->Get_top_card();
			}
		}
	}
}

void Card_game::Clean_players()
{
	if (_players != nullptr)
	{
		for (int i = 0; i < _how_players; i++)
		{
			if (_players[i] != nullptr)
			{
				delete _players[i];
			}
		}
		delete[] _players;
	}
}
