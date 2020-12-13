#include "Console_interactor.h"
#define new new( _NORMAL_BLOCK, __FILE__, __LINE__)


void Console_interactor::Run()
{
	int command = 1;
	try
	{
		std::string filename;
		std::cout << "Enter path to file:\n";
		std::cin >> filename;
		Parser parser;
		parser.Parse_file(filename, &train_table);
	}
	catch (std::exception& ex)
	{
		std::cout << ex.what();
		exit(1);
	}

	std::cout << "1 - Find by city and time\n2 - Find by city(today)\n3 - Add train\n4 - Print all trains\n0 - Exit.\n";
	while (command)
	{
		std::cout << "Enter a command: ";
		std::cin >> command;
		switch (command)
		{
		case 0:
		{
			break;
		}
		case 1:
		{
			std::cout << "Enter a town: \n";
			std::string town;
			std::cin >> town;
			std::cout << "Enter the time and date(hh:mm dd.mm.yyyy):\n";
			Time time;
			Date date;
			char symb;
			std::cin >> time.hour >> symb >> time.minutes >> date.day >> symb >> date.mounth >> symb >> date.year;
			Train_key key;
			key._date = date;
			key._point = town;

			auto ktown = train_table.equal_range(key);
			std::cout << "Search result:\n";
			for (auto it = ktown.first; it != ktown.second; it++)
			{
				if (time < (*it).second.Get_departure_date().first)
				{
					std::cout << (*it).second.Get_identifier() << " " << (*it).second.Get_departure_date().first.hour << ":" 
						<< (*it).second.Get_departure_date().first.minutes << "\n";
				}
			}
		}
		break;
		case 2:
		{
			std::cout << "Enter a town: \n";
			Train_key key;
			key._date = what_date_today;
			std::cin >> key._point;

			auto ktown = train_table.equal_range(key);
			std::cout << "Search result:\n";
			for (auto it = ktown.first; it != ktown.second; it++)
			{
				std::cout << (*it).second.Get_identifier() << " " << (*it).second.Get_departure_date().first.hour << ":"
					<< (*it).second.Get_departure_date().first.minutes << "\n";
			}
			break;
		}
		case 3:
		{
			std::cout << "Type point(string) identifier(int) departure time(hh:mm) departure date(dd.mm.yyyy) arrival time(hh:mm) arrival date(dd.mm.yyyy)\n";
			std::string point;
			int identifier;
			char symbol;
			std::pair<Time, Date> _departure;
			std::pair<Time, Date> _arrival;
			Train_key key;

			std::cin >> point >> identifier >> _departure.first.hour >> symbol >> _departure.first.minutes 
				>> _departure.second.day >> symbol >> _departure.second.mounth >> symbol >> _departure.second.year
				>> _arrival.first.hour >> symbol >> _arrival.first.minutes 
				>> _arrival.second.day >> symbol >> _arrival.second.mounth >> symbol >> _arrival.second.year;
			
			Train temp(point, identifier, _departure, _arrival);
			key._date = _departure.second;
			key._point = point;
			train_table.insert(std::pair<Train_key, Train>(key, temp));
			break;
		}
		case 4:
		{
			for (auto it = train_table.begin(); it != train_table.end(); it++)
			{
				std::cout << (*it).first._point<<" "<< (*it).second.Get_identifier()<<" " << (*it).second.Get_departure_date().first.hour << ":" << (*it).second.Get_departure_date().first.minutes << "\n";
			}
			break;
		}
		default:
			std::cout << "Invalid command. Try again.\n";
			break;
		}

	}
}
