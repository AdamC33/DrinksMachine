static class ConsoleDisplay
{
    private static Dictionary <int, string> selectionToDrink =
    new Dictionary<int, string>
    {
        {1, "tea with sugar and milk"},
        {2, "tea with milk"},
        {3, "tea with sugar"},
        {4, "coffee with sugar and milk"},
        {5, "coffee with milk"},
        {6, "coffee with sugar"}
    };
    public static void DrinkSelection()
    {
        Console.Clear();
        Console.WriteLine("Welcome. Please choose a drink:\n[1] Tea with sugar and milk\n[2] Tea with milk\n[3] Tea with sugar\n[4] Coffee with sugar and milk\n[5] Coffee with milk\n[6] Coffee with sugar\n[7] Quit");
    }
    public static void ProcessingDrink(int selection)
    {
        Console.Clear();
        Console.WriteLine("Preparing " + selectionToDrink[selection] + ". Please wait...");
        Thread.Sleep(5000);
    }
}