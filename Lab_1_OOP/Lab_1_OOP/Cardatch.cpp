#define _CRT_SECURE_NO_WARNINGS

#include "Cardatch.h"

Cardatch::~Cardatch()
{
	if (_deck != nullptr)
	{
		delete[] _deck;
	}
}

void Cardatch::Display_in_console(const Card &card)
{
	std::cout << card.Get_rank() << " " << card.Get_suit() << ' ' << '\n';
}

void Cardatch::Display_in_console(const Card &card, int number)
{
	std::cout<<number<<": "<< card.Get_rank() << " " << card.Get_suit() << ' ' << '\n';

}

void Cardatch::Console()
{
	srand(time(0));
	std::cout << "Enter the number of cards in the deck(32 or 52) or 104 but it's illegal:\n";
	std::string path;
	std::cin >> path;
	path += ".txt";
	try
	{
		Read_all(path);
	}
	catch (const std::exception &err)
	{
		std::cerr << "Error: " << err.what();
		exit(1);
	}
	int command = 1;
	std::cout << "1 - Shuffle\n2 - Comparison couple cards\n3 - Simulation game\n4 - Print all cards\n0 - Exit.\n";
	while (command)
	{
		std::cout << "Enter a command: ";
		std::cin >> command;
		switch (command)
		{
		case 0:
			break;
		case 1:
			Shuffle_deck();
			std::cout << "The deck is shuffled" << std::endl;
			break;
		case 2:
		{
			Card first = _deck[rand() % 32];
			Card second = _deck[rand() % 32];
			Display_in_console(first);
			Display_in_console(second);
			int res = Ñomparison_couple_cards(first,second);
			if (res == 1)
			{
				std::cout << "First win!\n";
			}
			if (res == 2)
			{
				std::cout << "Second win!\n";
			}
			if (res == 3)
			{
				std::cout << "Diffrent suits\n";
			}
		}
			break;
		case 3:
		{
			int num;
			std::cout << "How much cards per player?\n";
			std::cin >> num;
			if (num > 0 && num <= _deck_size / 4)
			{
				std::cout<<"Winning player: "<<Simulating_game(num)<<"\n";
			}
			else
			{
				std::cout << "Invalid number. Try again\n";
			}
		}
			break;
		case 4:
			for (int i = 0; i < _deck_size; i++)
			{
				Display_in_console(_deck[i]);
			}
			break;
		default:
			std::cout << "Invalid command. Try again.\n";
			break;
		}
	}
}

void Cardatch::Read_all(const std::string &path)
{
	std::ifstream file;
	file.open(path);
	std::string suit, rank;
	int value;
	if (file.is_open())
	{
		file >> _deck_size;
		_deck = new Card[_deck_size];
		for (int i = 0; i < _deck_size; i++)
		{
			file >> rank >> suit >> value;
			_deck[i].Set_rank(rank);
			_deck[i].Set_suit(suit);
			_deck[i].Set_value(value);
		}
	}
	else
	{
		file.close();
		throw std::exception("File not found.");
	}
}

void Cardatch::Shuffle_deck()
{
	int n = _deck_size;
	while (n > 1)
	{
		int ind = rand() % _deck_size;
		n--;
		Card temp = _deck[n];
		_deck[n] = _deck[ind];
		_deck[ind] = temp;
	}
}

int Cardatch::Ñomparison_couple_cards(const Card &first,const Card &second)
{
	if (first.Get_suit()==second.Get_suit())
	{
		if (first.Get_value()>second.Get_value())
		{
			return 1;
		}
		else
		{
			return 2;
		}
	}
	else
	{
		return 3;
	}
	
}

Card* Cardatch::Create_table(int how)
{
	Card* table = new Card[how * 4];
	int j = 0;
	for (int i = _deck_size - 1; i > _deck_size - 1 - how * 4; i--, j++)
	{
		table[j] = _deck[i];
	}
	return table;
}

Card Cardatch::Find_best(int first,int last,const Card* table)
{
	int max_value = table[first].Get_value();
	Card temp= table[first];
	for (int i = first; i <= last; i++)
	{
		if (table[i].Get_value() > max_value)
		{
			temp = table[i];
			max_value = temp.Get_value();
		}
	}
	return temp;
}

Card Cardatch::Find_best(int first, int last, Card* table,const std::string& suit)
{
	int max_value = table[first].Get_value();
	Card temp = table[first];
	for (int i = first; i <= last; i++)
	{
		if (table[i].Get_suit() == suit && table[i].Get_value() > max_value)
		{
			temp = table[i];
			max_value = temp.Get_value();
		}
	}
	return temp;
}

int Cardatch::Identify_winner(Card* table,int how)
{
	int winner = 1;
	Card *best_cards=new Card[4];
	best_cards[0] = Find_best(0, how-1,table);
	std::string suit = best_cards[0].Get_suit();
	for (int i = 1; i < 4; i++)
	{
		best_cards[i] = Find_best(i*how, (i+1) * how - 1, table, suit);
	}
	for (int i = 0; i < 4; i++)
	{
		Display_in_console(best_cards[i],i+1);
	}

	int max_value = -1;
	for (int i = 0; i < 4; i++)
	{
		if (best_cards[i].Get_suit() == suit && best_cards[i].Get_value() > max_value)
		{
			winner = i + 1;
			max_value = best_cards[i].Get_value();
		}
	}
	delete[] best_cards;
	return winner;
}

int Cardatch::Simulating_game(int how)
{
	Card* table=Create_table(how);
	int result = Identify_winner(table,how);
	delete[] table;
	return result;
}