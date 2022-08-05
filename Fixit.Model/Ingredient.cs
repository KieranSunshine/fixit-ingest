namespace Fixit.Model
{
	public class Ingredient
	{
		public Item Item { get; set; }
		public int Amount { get; set; }

		public Ingredient(Item item, int amount)
		{
			Item = item;
			Amount = amount;
		}
	}
}