using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;
using Il2CppAssets.Scripts.Models.Towers.Weapons;
using static DarksTowers.Displays.Proj.ProjectileDisplays;

namespace DarksTowers.Upgrades.CyberMonkey.Middle
{
    internal class BetterBeam : ModUpgrade<DarksTowers.CyberMonkey>
    {
        public override int Path => MIDDLE;

        public override int Tier => 1;

        public override int Cost => 480;

        public override string Description => "More Pierce";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().projectile.pierce += 3;
            towerModel.GetWeapon().projectile.ApplyDisplay<BetterCyberLaser>();
        }
    }
    internal class EvenBetterBeam : ModUpgrade<DarksTowers.CyberMonkey>
    {
        public override int Path => MIDDLE;

        public override int Tier => 2;

        public override int Cost => 520;

        public override string Description => "Even More Pierce";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().projectile.pierce += 3;
            towerModel.GetWeapon().projectile.ApplyDisplay<EvenBetterCyberLaser>();

        }
    }
    internal class DualBlasters : ModUpgrade<DarksTowers.CyberMonkey>
    {
        public override int Path => MIDDLE;

        public override int Tier => 3;

        public override int Cost => 2545;

        public override string Description => "Now Shoots Two Projectiles";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().projectile.pierce += 3;
            towerModel.GetWeapon().emission = new RandomArcEmissionModel("RandomArchEmissionModel_", 2, 0, 0, 8, 1, null);
            towerModel.GetWeapon().rate *= 0.8f;
            towerModel.GetWeapon().projectile.GetDamageModel().damage += 8;
        }
    }
    internal class TripleBlasters : ModUpgrade<DarksTowers.CyberMonkey>
    {
        public override int Path => MIDDLE;

        public override int Tier => 4;

        public override int Cost => 6755;

        public override string Description => "Shoots three lasers";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().projectile.pierce += 3;
            towerModel.GetWeapon().emission = new RandomArcEmissionModel("RandomArchEmissionModel_", 3, 0, 0, 12, 2, null);
            towerModel.GetWeapon().rate *= 0.8f; 
            towerModel.GetWeapon().projectile.GetDamageModel().damage += 10;

        }
    }
    internal class QuadBlasters : ModUpgrade<DarksTowers.CyberMonkey>
    {
        public override int Path => MIDDLE;

        public override int Tier => 5;

        public override int Cost => 65780;

        public override string Description => "I heard that doing more damage and shooting lots is good :)";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().projectile.pierce += 3;
            towerModel.GetWeapon().emission = new RandomArcEmissionModel("RandomArchEmissionModel_", 4, 0, 0, 16, 3, null);
            towerModel.GetWeapon().rate *= 0.8f; 
            towerModel.GetWeapon().projectile.GetDamageModel().damage += 25;
        }
    }

}
