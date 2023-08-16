using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using DarksTowers.Displays.MoneyofLight;
using DarksTowers.Displays.Proj;
using Il2CppAssets.Scripts.Models.Towers;
using static DarksTowers.Displays.Proj.ProjectileDisplays;

namespace DarksTowers.Upgrades.LightMonkey.Bottom
{
    internal class PiercingLight : ModUpgrade<MonkeyofLight>
    {
        public override int Path => BOTTOM;

        public override int Tier => 1;

        public override int Cost => 345;

        public override string Description => "The Light Becomes Brighter And Can Pierce Through Three More Bloons";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.ApplyDisplay<MonkeyofLight001Display>();
            towerModel.GetWeapon().projectile.pierce += 3;
            towerModel.GetWeapon().projectile.GetDamageModel().damage += 3;
            towerModel.GetWeapon().projectile.ApplyDisplay<PiercingLightBlast>();
        }
    }
    internal class BrightestLight : ModUpgrade<MonkeyofLight>
    {
        public override int Path => BOTTOM;

        public override int Tier => 2;

        public override int Cost => 675;
        public override string Description => "The Light Becomes so Bright That it Can Pierce 4 More Bloons";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.ApplyDisplay<MonkeyofLight002Display>();
            towerModel.GetWeapon().projectile.pierce += 4;
            towerModel.GetWeapon().projectile.GetDamageModel().damage += 4;
            towerModel.GetWeapon().projectile.ApplyDisplay<BrightestLightBlast>();
        }
    }
    internal class StrongLight : ModUpgrade<MonkeyofLight> 
    {
        public override int Path => BOTTOM;
        public override int Tier => 3;
        public override int Cost => 1025;
        public override string Description => "Does Even More Damage But Takes Longer to Attack";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.ApplyDisplay<MonkeyofLight003Display>();
            towerModel.GetWeapon().projectile.GetDamageModel().damage += 6;
            towerModel.GetWeapon().rate *= 1.33f;
        }
    }
    internal class StrongerLight : ModUpgrade<MonkeyofLight>
    {
        public override int Path => BOTTOM;
        public override int Tier => 4;
        public override int Cost => 2350;
        public override string Description => "Stronger Light For Even More Damage.";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.ApplyDisplay<MonkeyofLight004Display>();
            towerModel.GetWeapon().projectile.GetDamageModel().damage += 7;
        }
    }
    internal class StrongestLight : ModUpgrade<MonkeyofLight>
    {
        public override int Path => BOTTOM;
        public override int Tier => 5;
        public override int Cost => 35545;
        public override string Description => "You Want Damage? We Got Damage!";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.ApplyDisplay<MonkeyofLight005Display>();
            towerModel.GetWeapon().projectile.GetDamageModel().damage += 55;
        }
    }
}