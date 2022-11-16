bool quitProgram = false;
int selectionCounter = 0;

ConsoleKeyInfo keyPressed;

Dictionary <ConsoleKey, int> keyToNum =
new Dictionary<ConsoleKey, int>
{
    {ConsoleKey.D1, 1},
    {ConsoleKey.D2, 2},
    {ConsoleKey.D3, 3},
    {ConsoleKey.D4, 4},
    {ConsoleKey.D5, 5},
    {ConsoleKey.D6, 6},
    {ConsoleKey.D7, 7}
};

do
{
    int tea = 10;
    int sugar = 10;
    int milk = 10;
    int coffee = 10;
    int cups = 10;
    int selection;
    ConsoleDisplay.DrinkSelection();
    do
    {
        keyPressed = Console.ReadKey(true); //The true means it won't print the pressed key onto the console
        if (keyToNum.ContainsKey(keyPressed.Key))
        {
            selection = keyToNum[keyPressed.Key];
            break;
        }
    }
    while (true);
    if (selection == 7)
    {
        quitProgram = true;
    }
    else
    {
        selectionCounter++;
        ConsoleDisplay.ProcessingDrink(selection);
    }
}
while (quitProgram == false);