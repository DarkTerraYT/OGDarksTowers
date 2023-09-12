using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using static DarksTowers.Displays.Proj.ProjectileDisplays;

namespace DarksTowers.Upgrades.CyberMonkey.Top
{
    internal class StongerBeam : ModUpgrade<DarksTowers.CyberMonkey>
    {
        public override int Path => TOP;

        public override int Tier => 1;

        public override int Cost => 625;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon(0).projectile.GetDamageModel().damage += 2;
            towerModel.GetWeapon().projectile.ApplyDisplay<StrongCyberLaser>();
        }
    }
    internal class PlasmaBeam : ModUpgrade<DarksTowers.CyberMonkey>
    {
        public override int Path => TOP;

        public override int Tier => 2;

        public override int Cost => 815;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon(0).projectile.GetDamageModel().damage += 3;
            towerModel.GetWeapon().projectile.ApplyDisplay<PlasmaCyberLaser>();
        }
    }
    internal class LightBeam : ModUpgrade<DarksTowers.CyberMonkey>
    {
        public override int Path => TOP;

        public override int Tier => 3;

        public override int Cost => 1165;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon(0).projectile.GetDamageModel().damage += 4;
            towerModel.GetWeapon().projectile.ApplyDisplay<LightCyberLaser>();
        }
    }
    internal class DarkBeam : ModUpgrade<DarksTowers.CyberMonkey>
    {
        public override int Path => TOP;

        public override int Tier => 4;

        public override int Cost => 5665;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon(0).projectile.GetDamageModel().damage += 14;
            towerModel.GetWeapon().projectile.ApplyDisplay<DarkCyberLaser>();
            towerModel.GetWeapon().projectile.AddBehavior(new DamageModifierForTagModel("MoabDamageModifier", "Moab", 2, 25, false, false));
            towerModel.GetWeapon().rate *= 0.8f;
            towerModel.GetWeapon().projectile.pierce += 1;

        }
    }
    internal class RainbowBeam : ModUpgrade<DarksTowers.CyberMonkey>
    {
        public override int Path => TOP;

        public override int Tier => 5;

        public override int Cost => 36485;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon(0).projectile.GetDamageModel().damage += 40;
            towerModel.GetWeapon().projectile.AddBehavior(new DamageModifierForTagModel("MoabDamageModifier", "Moab", 4, 200, false, false));
            towerModel.GetWeapon().projectile.ApplyDisplay<StrongCyberLaser>();
            towerModel.GetWeapon().rate *= 0.8f;
            towerModel.GetWeapon().projectile.pierce += 2;

        }
    }

}
