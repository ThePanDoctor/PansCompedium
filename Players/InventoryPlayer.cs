using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using TheWallBusters.Items;
using TheWallBusters.Configs;


namespace PansCompedium.Players
{
	public class ChangesSpawnInventory : ModPlayer
	{
        public override bool IsLoadingEnabled(Mod mod) {
			return ModContent.GetInstance<PansCompediumConfig>().StarterBusterToggle;
		}

		public override IEnumerable<Item> AddStartingItems(bool mediumCoreDeath) {
			return new[] {
                new Item(ModContent.ItemType<WallBusterMk1>(), 1)
			};
		}
    }
}