using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;

namespace PansCompedium.Items
{
    internal class WallBusterMk2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.useTime = 1;
            Item.useAnimation = 5;
            Item.autoReuse = true;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.tileBoost = 10;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 1;
            Item.knockBack = 1f;

            Item.rare = ItemRarityID.Blue;

            Item.hammer = 110;

            Item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Pwnhammer, 1)
                .AddIngredient(ItemID.PearlstoneBlock, 1)
                .AddIngredient(ItemID.EbonstoneBlock, 1)
                .Register();

             CreateRecipe()
                .AddIngredient(ItemID.Pwnhammer, 1)
                .AddIngredient(ItemID.PearlstoneBlock, 1)
                .AddIngredient(ItemID.CrimstoneBlock, 1)
                .Register();

        }
    }
}