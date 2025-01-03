
using BTD_Mod_Helper.Api.Display;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Unity.Display;

namespace DarksTowers.Displays.MoneyofLight
{
    public class MonkeyofLightDisplay : ModDisplay2D
    {
        protected override string TextureName => "MonkeyofLightDisplay";
    }
    public class MonkeyofDarknessDisplay : ModDisplay2D
    {
        protected override string TextureName => "MonkeyofLight500Display";
    }
    public class MonkeyofLight400Display : ModDisplay2D 
    {
        protected override string TextureName => "MonkeyofLight400Display";
    }
    public class MonkeyofLight300Display : ModDisplay2D
    {
        protected override string TextureName => "MonkeyofLight300Display";
    }
    public class MonkeyofLight050Display : ModDisplay2D
    {
        protected override string TextureName => "MonkeyofLight050Display";
    }
    public class MonkeyofLight040Display : ModDisplay2D
    {
        protected override string TextureName => "MonkeyofLight040Display";
    }
    public class MonkeyofLight030Display : ModDisplay2D
    {
        protected override string TextureName => "MonkeyofLight030Display";
    }
    public class MonkeyofLight001Display : ModDisplay2D
    {
        protected override string TextureName => "MonkeyofLight001Display";
    }
    public class MonkeyofLight002Display : ModDisplay2D
    {
        protected override string TextureName => "MonkeyofLight002Display";
    }
    public class MonkeyofLight003Display : ModDisplay2D
    {
        protected override string TextureName => "MonkeyofLight003Display";
    }
    public class MonkeyofLight004Display : ModDisplay2D
    {
        protected override string TextureName => "MonkeyofLight004Display";
    }
    public class MonkeyofLight005Display : ModDisplay2D
    {
        protected override string TextureName => "MonkeyofLight005Display";
    }
    public class DiscordLightModeDisplay : ModTowerDisplay<MonkeyofLight>
    {
        public override string BaseDisplay => Game.instance.model.GetTowerFromId("WizardMonkey-500").display.AssetGUID;

        public override bool UseForTower(int[] tiers)
        {
            return IsParagon(tiers);
        }

        public override void ModifyDisplayNode(UnityDisplayNode node)
        {
            SetMeshTexture(node, Name);
        }
    }
}
