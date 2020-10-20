#include "Quick.h"



int* Quick::Sort(int size, int* array)
{
    int i = 0;
    int j = size - 1;
    int mid = array[size / 2];
    do 
    {
        while (array[i] < mid) 
        {
            i++;
        }
        while (array[j] > mid) 
        {
            j--;
        }
        if (i <= j) 
        {
            int tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;
    
            i++;
            j--;
        }
    } while (i <= j);
    
    if (j > 0)
    {
        Quick::Sort(j + 1,array);
    }
    if (i < size) 
    {
        Quick::Sort(size - i, &array[i]);
    }
    return array;
}
