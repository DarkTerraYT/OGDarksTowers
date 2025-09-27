using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using OGDarksTowers.Displays.PlasmaMonkey;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;

namespace OGDarksTowers.Upgrades.PlasmaMonkey.Bottom
{
    public class FasterCreation : ModUpgrade<OGDarksTowers.PlasmaMonkey>
    {
        public override int Path => BOTTOM;

        public override int Tier => 1;

        public override int Cost => 1320;

        public override string Description => "Increases Attack Speed";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            foreach (var projAttack in towerModel.GetWeapons())
            {
                projAttack.rate *= 0.5f;
            }
        }

        public class EvenFasterCreation : ModUpgrade<OGDarksTowers.PlasmaMonkey>
        {
            public override int Path => BOTTOM;

            public override int Tier => 2;

            public override int Cost => 3450;

            public override string Description => "Greatly Increases Attack Speed";

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                foreach (var projAttack in towerModel.GetWeapons())
                {
                    projAttack.rate *= 0.2f;
                }
            }
        }

        public class HypersonicCreation : ModUpgrade<OGDarksTowers.PlasmaMonkey>
        {
            public override int Path => BOTTOM;
            public override int Tier => 3;
            public override int Cost => 21000;

            public override string Description => "Using New Technology it Creates Plasma Instantly, Shooting Hypersonicaly";

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                foreach(var proj in towerModel.GetWeapons())
                {
                    proj.rate *= 0.05f;
                }
            }
        }

        public class PlasmaBlasters : ModUpgrade<OGDarksTowers.PlasmaMonkey>
        {
            public override int Path => BOTTOM;
            public override int Tier => 4;
            public override int Cost => 7125;
            public override string Description => "Puts a Blaster Onto his arm Allowing the Plasma to go Further and Pierce More Bloons.";


            public override void ApplyUpgrade(TowerModel towerModel)
            {
                towerModel.ApplyDisplay<PlasmaMonkey004Display>();
                towerModel.range += 50;
                towerModel.GetAttackModel().range += 50;
                var proj = towerModel.GetAttackModel().weapons[0].projectile;
                proj.pierce += 10;
            }
        }

        public class SuperBlasters : ModUpgrade<OGDarksTowers.PlasmaMonkey>
        {
            public override int Path => BOTTOM;
            public override int Tier => 5;
            public override int Cost => 43505;
            public override string Description => "Improves the Blasters to the State of the art Blasters Allowing Gloable Range, INSANE Peirce and Increasing Damage";

            public override void ApplyUpgrade(TowerModel towerModel)
            {
                towerModel.ApplyDisplay<PlasmaMonkey005Display>();
                towerModel.range *= 15;
                towerModel.GetAttackModel().range *= 5;
                towerModel.isGlobalRange = true;
                var proj = towerModel.GetAttackModel().weapons[0].projectile;
                proj.pierce += 50;
                proj.GetDamageModel().damage += 15;

                foreach (var weaponModel in towerModel.GetWeapons())
                {
                    weaponModel.projectile.GetBehavior<TravelStraitModel>().lifespan = 1;
                    weaponModel.projectile.GetBehavior<TravelStraitModel>().Lifespan = 1;
                }
            }
        }
    }
}
