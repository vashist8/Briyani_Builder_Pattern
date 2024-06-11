using SoftwareCraftmanship.DesignPattern.Builder.Library.Enum;
using System.Text.Json;

namespace SoftwareCraftmanship.DesignPattern.Builder.Library.Model
{
    public class Briyani
    {
        private decimal Rice;
        private string MainIngredient;
        private List<Spice> Spices;
        private List<Vegetable> Vegetables;

        public Briyani() { }

        public string ListIngredients()
        {
            return $"Biryani with {Rice} kg of rice, " +
                   $"{MainIngredient}, " +
                   $"with a spice mix of : {JsonSerializer.Serialize<List<Spice>>(Spices, JsonSerializerOptions.Default)} , " +
                   $"and {JsonSerializer.Serialize<List<Vegetable>>(Vegetables, JsonSerializerOptions.Default)}";
        }

        public void SetRice(decimal rice) => Rice = rice;

        public void SetMainIngredient(string mainIngredient) => MainIngredient = mainIngredient;

        public void SetSpices(List<Spice> spices) => Spices = spices;

        public void SetVegetables(List<Vegetable> vegetables) => Vegetables = vegetables;
    }
}
