// Cooking Chicken Briyani
using SoftwareCraftmanship.DesignPattern.Builder.Library.Builder;

var director = new BriyaniDirector();

Console.WriteLine("--- When using ChickenBriyaniBuilder ---");
var chickenBriyaniBuilder = new ChickenBriyaniBuilder();
director.ChangeBuilder(chickenBriyaniBuilder);
var briyani = director.CookBriani();
Console.WriteLine(briyani.ListIngredients());

Console.WriteLine("--- When using FishBriyaniBuilder ---");
var fishBriyaniBuilder = new FishBriyaniBuilder();
director.ChangeBuilder(fishBriyaniBuilder);
briyani = director.CookBrianiWithoutVegetables();
Console.WriteLine(briyani.ListIngredients());

Console.WriteLine("--- When using VegetarianBriyaniBuilder ---");
var vegBriyaniBuilder = new VegetarianBriyaniBuilder();
director.ChangeBuilder(vegBriyaniBuilder);
briyani = director.CookBriani();
Console.WriteLine(briyani.ListIngredients());


