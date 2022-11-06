#include <iostream>
#include <cstdlib>

int CompRandom() {
    srand(time(NULL));

    int compChoice;
    compChoice = rand() % 10 + 1;

    return compChoice;
}

int main()
{
    int compChoice;
    compChoice = CompRandom();

    int yourChoice;
    std::cin >> yourChoice;

    if (yourChoice == compChoice) {
        std::cout << "You win! Computer guessed the number " << compChoice;
    } else {
        std::cout << "You lose! Computer guessed the number " << compChoice;
    }
}