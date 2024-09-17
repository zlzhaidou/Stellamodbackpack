﻿
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Stellamod.Assets.Biomes
{
    public class CatacombFlames : ModBiome
    {

        public override int Music => MusicLoader.GetMusicSlot(Mod, "Assets/Music/Catacombs");
        public override SceneEffectPriority Priority => SceneEffectPriority.BossLow;
        public override string BestiaryIcon => base.BestiaryIcon;
        public override string BackgroundPath => MapBackground;
        public override Color? BackgroundColor => base.BackgroundColor;


        public override bool IsBiomeActive(Player player) => BiomeTileCounts.InCatafire;
        public override void OnEnter(Player player) => player.GetModPlayer<MyPlayer>().ZoneCatacombsFire = true;
        public override void OnLeave(Player player) => player.GetModPlayer<MyPlayer>().ZoneCatacombsFire = false;
    }
}