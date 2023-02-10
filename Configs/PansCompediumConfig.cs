using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace PansCompedium.Configs
{
	public class PansCompediumConfig : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ServerSide;

		[Label("Enable Wall Buster Mk.I as starting item")]
		[Tooltip("Allows for the Wall buster Mk.I to be one of the items given in character creation.")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool StarterBusterToggle;
	}
}
