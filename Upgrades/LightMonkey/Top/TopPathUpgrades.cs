using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using DarksTowers.Displays.MoneyofLight;
using Il2CppAssets.Scripts.Models.Towers;
using static DarksTowers.Displays.Proj.Displays;

namespace DarksTowers.Upgrades.LightMonkey.Top
{
    internal class FurtherBlasts : ModUpgrade<MonkeyofLight>
    {
        public override int Path => TOP;

        public override int Tier => 1;

        public override int Cost => 855;
        public override string DisplayName => "Further Blasts";
        public override string Description => "Increases Range";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.range += 10;
            var attackModel = towerModel.GetAttackModel();
            attackModel.range += 10;
        }
    }
    internal class EvenFurtherBlasts : ModUpgrade<MonkeyofLight>
    {
        public override int Path => TOP;

        public override int Tier => 2;

        public override int Cost => 1050;
        public override string DisplayName => "Even Further Blasts";
        public override string Description => "Increases Range Further";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.range += 20;
            var attackModel = towerModel.GetAttackModel();
            attackModel.range += 20;
        }
    }
    internal class TheDarkness : ModUpgrade<MonkeyofLight>
    {
        public override int Path => TOP;

        public override int Tier => 3;

        public override int Cost => 2050;
        public override string DisplayName => "The Darkness";
        public override string Description => "Monkey of Light Finds a Way to Use The Darkness to Attack.";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.range += 10;
            var attackModel = towerModel.GetAttackModel();
            attackModel.range += 10;
            var proj = attackModel.weapons[0].projectile;
            proj.ApplyDisplay<VoidBlastExtraLight>();
            var dmgModel = proj.GetDamageModel();
            dmgModel.damage += 3;
        }
    }
    internal class MoreDarkness : ModUpgrade<MonkeyofLight>
    {
        public override int Path => TOP;

        public override int Tier => 4;

        public override int Cost => 3425;
        public override string DisplayName => "More Darkness";
        public override string Description => "The Monkey of Light Collects More Darkness Allowing For More Damage and Range";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.range += 10;
            var attackModel = towerModel.GetAttackModel();
            attackModel.range += 10;
            var proj = attackModel.weapons[0].projectile;
            proj.ApplyDisplay<VoidBlastLight>();
            var dmgModel = proj.GetDamageModel();
            dmgModel.damage += 6;
        }
    }
    internal class MonkeyofDarkness : ModUpgrade<MonkeyofLight>
    {
        public override int Path => TOP;

        public override int Tier => 5;

        public override int Cost => 15430;
        public override string DisplayName => "Monkey of Darkness";
        public override string Description => "The Monkey of Light is Now Corrupted With The Darkness";
        public override string Portrait => "MonkeyofDarkness-Portrait";
        public override string Icon => "MonkeyofDarkness-Portriat";
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.range += 10;
            towerModel.ApplyDisplay<MonkeyofDarknessDisplay>();
            var attackModel = towerModel.GetAttackModel();
            attackModel.range += 10;
            var proj = attackModel.weapons[0].projectile;
            proj.ApplyDisplay<VoidBlast>();
            var dmgModel = proj.GetDamageModel();
            dmgModel.damage += 12;
        }
    }
    
}
