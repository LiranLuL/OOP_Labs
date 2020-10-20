#include "Choice.h"

int* Choice::Sort(int n, int* array)
{
    int i, j;
    int count, key;
    for (i = 0; i < n - 1; i++)
    {
        count = array[i]; key = i;
        for (j = i + 1; j < n; j++)
            if (array[j] < array[key]) key = j;
        if (key != i)
        {
            array[i] = array[key];
            array[key] = count;
        }
    }
    return array;
}
