using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace PansCompedium.Items
{
	[AutoloadEquip(EquipType.Legs)]
	public class FlinxFurGreaves : ModItem
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 18;
			Item.height = 18;

			Item.value = Item.buyPrice(gold: 2);
			Item.rare = ItemRarityID.Green;

			Item.defense = 2;
		}

		public override void UpdateEquip(Player player)
		{
			// Increases move speed by 10%
			player.moveSpeed += 0.1f;

			// Increase summon damage by 10%
			player.GetDamage(DamageClass.Summon) += 0.1f;
		}

		public override void AddRecipes()
		{
			// Recipe with gold
			CreateRecipe() 
				.AddIngredient(ItemID.GoldBar, 6)
				.AddIngredient(ItemID.Silk, 5)
				.AddIngredient(ItemID.FlinxFur, 2)
				.AddTile(TileID.Anvils)
				.Register();

			// Same but with platinum
			CreateRecipe()
				.AddIngredient(ItemID.PlatinumBar, 6)
				.AddIngredient(ItemID.Silk, 5)
				.AddIngredient(ItemID.FlinxFur, 2)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}