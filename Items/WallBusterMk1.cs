using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;

namespace PansCompedium.Items
{
    internal class WallBusterMk1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.useTime = 2;
            Item.useAnimation = 15;
            Item.autoReuse = true;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
			Item.tileBoost = 5;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 1;
            Item.knockBack = 1f;

            Item.rare = ItemRarityID.Blue;

            Item.hammer = 70;

            Item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddRecipeGroup(RecipeGroupID.Wood, 10)
                .AddIngredient(ItemID.StoneBlock, 10)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}