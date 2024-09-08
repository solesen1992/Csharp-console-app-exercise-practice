using Exercise_JavaToCsharp2.Db;

Employee employee = new Employee("Hans Hansen");
employee.AddFavouriteWord("Git");
employee.AddFavouriteWord("Gut");
employee.AddFavouriteWord("Got");

List<string> favouriteWords = employee.FavouriteWords;

Console.WriteLine($"The favourite words of {employee.EmployeeName}:");
foreach (string favW in favouriteWords)
{
    Console.WriteLine(favW);
}