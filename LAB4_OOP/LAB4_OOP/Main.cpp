#define __CRTDBG_MAP_ALLOC
#include <crtdbg.h>
#define DEBUG_NEW new(_NORMAL_BLOCK, __FILE__, __LINE__)
#define new DEBUG_NEW
#include "Console_interactor.h"

int main()
{
	_CrtMemState _ms;
	_CrtMemCheckpoint(&_ms);
	Console_interactor console;
	console.Run();
	_CrtMemDumpAllObjectsSince(&_ms);
	_CrtSetReportMode(_CRT_WARN, _CRTDBG_MODE_FILE);
	_CrtSetReportFile(_CRT_WARN, _CRTDBG_FILE_STDOUT);
	_CrtDumpMemoryLeaks();
}