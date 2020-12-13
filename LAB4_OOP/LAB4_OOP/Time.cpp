#include "Time.h"

bool operator<(const Time& first, const Time& second)
{
    return (first.hour*60+first.minutes) <= (second.hour * 60 + second.minutes);
}
