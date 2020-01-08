#include <iostream>

int main()
{
	//Print welcom messages to the terminal 
	std::cout << "You are a secret agent breaking a secure server room...";
	std::cout << std::endl;
	std::cout << "Enter the code to continue...";

	// Declere 3 number code 
	const int a = 4;
	const int b = 3;
	const int c = 2;

	const int sum = a + b + c;
	const int product = a * b * c;

	// Print sum and product to the terminal 
	std::cout << std::endl;
	std::cout << "+ There are 3 numbers in teh code" << std::endl;
	std::cout << "+ The codes add-up to: " << std::endl;
	std::cout << "+ The codes multiply to givae: " << product << std::endl;

	int GuessA, GuessB, GuessC;
	std::cin >> GuessA;
	std::cin >> GuessB;
	std::cin >> GuessC;
	std::cout << "You entered" << GuessA << GuessB << GuessC;
	
	return 0;
}