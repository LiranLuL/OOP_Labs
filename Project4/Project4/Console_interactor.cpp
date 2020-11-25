#include "Console_interactor.h"
void Console_interactor::Run()
{
	int command = 1;
	Card_game* my_game = new Card_game;
	std::cout << "Enter the number of cards in the deck(32 or 52 or 104):\n";
	std::string path;
	std::cin >> path;
	path += ".txt";
	try
	{
		my_game->Deck_reader(path);
	}
	catch (const std::exception& err)
	{
		std::cerr << "Error: " << err.what();
		exit(1);
	}
	int how;
	srand((unsigned int)time(NULL) / 2);
	std::cout << "1 - Add players\n2 - Start game \n3 - Change deck\n4 - \n5 - \n0 - Exit.\n";
	std::cout << "Enter a command: ";
	while (command)
	{
		std::cout << "Enter a command: ";
		std::cin >> command;

		switch (command)
		{
		case 0:
		{
			delete my_game;
			break;
		}
		case 1:
		{
			std::cout << "How?\n";
			std::cin >> how;
			int* characters = new int[how];
			std::cout << "1-mad\n2-honest\n3-greedy\nEnter characters through a space\n";
			for (int i = 0; i < how; i++)
			{
				std::cin >> characters[i];
			}
			my_game->Add_players(how, characters);
			delete[] characters;
		}
		break;
		case 2:
		{
			//32
			//1
			//4
			//1 2 3 2
			//2
			{
				Human** winners = my_game->Start_game();
				std::cout << "\nWinners (first win,last lose): \n";
				for (int i = 0; i < how; i++)
				{
					if(winners[i]!=nullptr)
					std::cout << i + 1 << " " << typeid(*winners[i]).name() << "\n";
				}
				delete[] winners;
				std::cout << "\n";
				
			}
			break;
		}
		case 3:
		{
			std::cout << "Enter the number of cards in the deck(32 or 52 or 104):\n";
			std::string path;
			std::cin >> path;
			path += ".txt";
			try
			{
				my_game->Deck_reader(path);
			}
			catch (const std::exception& err)
			{
				std::cerr << "Error: " << err.what();
				exit(1);
			}
		}
		break;
		case 4:
		{
			//52
			//1
			//4
			//1 2 3 2
			//4

			{
				int n;
				std::cout << "Enter count of game\n";
				std::cin >> n;
				Human** winners;
				std::string* a = new std::string[n];
				for (int i = 0; i < n; i++)
				{
					winners = my_game->Start_game();
					a[i] = typeid(*winners[0]).name();
					std::cout << a[i] << "\n";
				}}
			break;
		}
		case 5:
			break;
		default:
			std::cout << "Invalid command. Try again.\n";
			break;
		}

	}
}
