#pragma once
struct Time
{
	int minutes = 0;
	int hour = 0;
	friend bool operator<(const Time& first, const Time& second);
};

