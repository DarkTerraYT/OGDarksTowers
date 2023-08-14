using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using System.Linq;
using static DarksTowers.Displays.Proj.ProjectileDisplays;

namespace CustomTowerMaybe.Upgrades.PlasmaMonkey.Top
{
    internal class HotterPlasmaDarts : ModUpgrade<DarksTowers.PlasmaMonkey>
    {
        public override int Path => TOP;

        public override int Tier => 1;

        public override int Cost => 2250;

        public override string Description => "Increases Pierce by 4 and Damage by 5";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var proj = attackModel.weapons[0].projectile;
            proj.ApplyDisplay<HotterPlasmaDart>();
            proj.pierce = 4;
            var dmgModel = proj.GetDamageModel();
            dmgModel.damage += 5;
        }
    }

    internal class FieryPlasmaDarts : ModUpgrade<DarksTowers.PlasmaMonkey>
    {
        public override int Path => TOP;

        public override int Tier => 2;

        public override int Cost => 2750;

        public override string Description => "Increases Pierce by 8 and Damage by 4";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var proj = attackModel.weapons[0].projectile;
            proj.ApplyDisplay<FieryPlasmaDart>();
            proj.pierce = 8;
            var dmgModel = proj.GetDamageModel();
            dmgModel.damage += 4;
        }
    }

    internal class PlasmaBalls : ModUpgrade<DarksTowers.PlasmaMonkey>
    {
        public override int Path => TOP;

        public override int Tier => 3;

        public override int Cost => 4670;

        public override string Description => "Increases Damage by 12";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var proj = attackModel.weapons[0].projectile;
            proj.ApplyDisplay<PlasmaBall>();
            var dmgModel = proj.GetDamageModel();
            dmgModel.damage += 12;
        }
    }

    internal class FieryPlasmaBalls : ModUpgrade<DarksTowers.PlasmaMonkey>
    {
        public override int Path => TOP;

        public override int Tier => 4;

        public override int Cost => 7560;

        public override string Description => "Increases Damage by 18. Increases Moab Damage";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var proj = attackModel.weapons[0].projectile;
            proj.ApplyDisplay<FieryPlasmaBall>();
            var dmgModel = proj.GetDamageModel();
            dmgModel.damage += 18;

            foreach (var sPorj in towerModel.GetWeapons().Select(weaponModel => weaponModel.projectile))
            {
                sPorj.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Moab", "Moab", 1, 5, false, false));
            }
        }
    }

    internal class GodlyPlasmaBalls : ModUpgrade<DarksTowers.PlasmaMonkey>
    {
        public override int Path => TOP;

        public override int Tier => 5;

        public override int Cost => 18750;

        public override string Description => "Increases Damage by 22. Also Increases Moab Damage Even More.";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var proj = attackModel.weapons[0].projectile;
            proj.ApplyDisplay<GodlyPlasmaBall>();
            var dmgModel = proj.GetDamageModel();
            dmgModel.damage += 22;

            foreach (var sProj in towerModel.GetWeapons().Select(weaponModel => weaponModel.projectile))
            {
                sProj.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Moab", "Moab", 1, 9, false, false));
            }
        }
    }
}
