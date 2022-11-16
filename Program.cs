using System.Diagnostics;

bool quitProgram = false;
int selectionCounter = 0;

int tea = 10;
int sugar = 10;
int milk = 10;
int coffee = 10;
int cups = 10;

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
    Debug.WriteLine("Tea " + tea + "\nSugar " + sugar + "\nMilk " + milk + "\nCoffee " + coffee + "\nCups " + cups);
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
        List<bool> ingredientsReady = new List<bool>();
        if (selection >= 1 && selection <= 3)
        {
            if (tea > 0)
            {
                ingredientsReady.Add(true);
            }
            else
            {
                ingredientsReady.Add(false);
            }
        }
        else
        {
            if (coffee > 0)
            {
                ingredientsReady.Add(true);
            }
            else
            {
                ingredientsReady.Add(false);
            }
            if (cups > 0)
            {
                ingredientsReady.Add(true);
            }
            else
            {
                ingredientsReady.Add(false);
            }
        }
        if (selection == 1 || selection == 2 || selection == 4 || selection == 5)
        {
            if (milk > 0)
            {
                ingredientsReady.Add(true);
            }
            else
            {
                ingredientsReady.Add(false);
            }
        }
        if (selection == 1 || selection == 3 || selection == 4 || selection == 6)
        {
            if (sugar > 0)
            {
                ingredientsReady.Add(true);
            }
            else
            {
                ingredientsReady.Add(false);
            }
        }
        bool drinkCanBeMade = true;
        foreach(bool i in ingredientsReady)
        {
            if (i == false)
            {
                drinkCanBeMade = false;
                break;
            }
        }
        if (drinkCanBeMade)
        {
            if (selection >= 1 && selection <= 3)
            {
                tea--;
            }
            else
            {
                coffee--;
                cups--;
            }
            if (selection == 1 || selection == 2 || selection == 4 || selection == 5)
            {
                milk--;
            }
            if (selection == 1 || selection == 3 || selection == 4 || selection == 6)
            {
                sugar--;
            }
            Debug.WriteLine("Tea " + tea + "\nSugar " + sugar + "\nMilk " + milk + "\nCoffee " + coffee + "\nCups " + cups);
            ConsoleDisplay.ProcessingDrink(selection);
        }
        else
        {
            Debug.WriteLine("Tea " + tea + "\nSugar " + sugar + "\nMilk " + milk + "\nCoffee " + coffee + "\nCups " + cups);
            ConsoleDisplay.OutOfIngredients();
        }
    }
}
while (quitProgram == false);