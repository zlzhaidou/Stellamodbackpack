
using Stellamod;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace VeilChinesePack.Translations
{
    public class ItemGlobalTrans : GlobalItem
    {

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {

            if (item.type == ModContent.ItemType < HikersBackpack >)
            {
                tooltips.ReplaceText("%", "sssss");
            }
        }
    }
}
