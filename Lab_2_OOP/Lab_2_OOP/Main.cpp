#define _CRTDBG_MAP_ALLOC
#define _CRT_SECURE_NO_WARNINGS

#include <stdlib.h>
#include <crtdbg.h>
#include <iostream>
#include "Console_interactor.h"
#include <time.h>

//15. Создать класс Sorting(сортировка), и на его основе
//классы Choice(сортировка выбором) и Quick(быстрая сортировка).Размер сортируемых массивов задается при их создании,
//а элементы считываются из файла
int main()
{
    _CrtSetDbgFlag(_CRTDBG_ALLOC_MEM_DF | _CRTDBG_LEAK_CHECK_DF);
    Console_interactor console;
    console.Run();
}