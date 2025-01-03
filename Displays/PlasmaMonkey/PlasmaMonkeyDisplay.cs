using BTD_Mod_Helper.Api.Display;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.GenericBehaviors;
using Il2CppAssets.Scripts.Unity;
using Il2CppAssets.Scripts.Unity.Display;
using UnityEngine;

namespace DarksTowers.Displays.PlasmaMonkey
{
    public class PlasmaMonkeyDisplay : ModDisplay2D
    {
        protected override string TextureName => "PlasmaMonkeyDisplay";
    }
    public class PlasmaMonkey100Display : ModDisplay2D
    {
        protected override string TextureName => "PlasmaMonkey100Display";
    }
    public class PlasmaMonkey200Display : ModDisplay2D
    {
        protected override string TextureName => "PlasmaMonkey200Display";
    }
    public class PlasmaMonkey300Display : ModDisplay2D
    {
        protected override string TextureName => "PlasmaMonkey300Display";
    }
    public class PlasmaMonkey400Display : ModDisplay2D
    {
        protected override string TextureName => "PlasmaMonkey400Display";
    }
    public class PlasmaMonkey500Display : ModDisplay2D
    {
        protected override string TextureName => "PlasmaMonkey500Display";
    }
    public class PlasmaMonkey004Display : ModDisplay2D
    {
        protected override string TextureName => "PlasmaMonkey004Display";
    }
    public class PlasmaMonkey005Display : ModDisplay2D
    {
        protected override string TextureName => "PlasmaMonkey005Display";
    }
    public class PlasmaMonkey030Display : ModDisplay2D
    {
        protected override string TextureName => "PlasmaMonkey030Display";
    }
    public class PlasmaMonkey040Display : ModDisplay2D
    {
        protected override string TextureName => "PlasmaMonkey040Display";
    }
    public class PlasmaMonkey050Display : ModDisplay2D
    {
        protected override string TextureName => "PlasmaMonkey050Display";
    }
    public class PlasmaLordDisplay : ModTowerDisplay<DarksTowers.PlasmaMonkey>
    {
        public override string BaseDisplay => Game.instance.model.GetTowerFromId("SuperMonkey-500").GetAttackModel().GetBehavior<DisplayModel>().display.AssetGUID;

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
