#define _CRTDBG_MAP_ALLOC

#include <stdlib.h>
#include <crtdbg.h>
#include <iostream>
#include "Console_interactor.h"

int main()
{
	Console_interactor console;
	console.Run();
	_CrtDumpMemoryLeaks();
}