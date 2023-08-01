using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarksTowers.Displays.Proj.Displays;

namespace CustomTowerMaybe.Upgrades.PlasmaMonkey.Middle
{
    internal class StrongerThrowing : ModUpgrade<DarksTowers.PlasmaMonkey>
    {
        public override int Path => MIDDLE;

        public override int Tier => 1;

        public override int Cost => 1250;

        public override string Description => "Increases Range";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.range += 15;
        }
    }

    internal class SuperStrongThrowing : ModUpgrade<DarksTowers.PlasmaMonkey>
    {
        public override int Path => MIDDLE;

        public override int Tier => 2;

        public override int Cost => 4075;

        public override string Description => "Super Long Range Darts That do Extra Damage and Even More to Moabs, Ceramics and Fortified Bloons ";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            foreach (var proj in towerModel.GetWeapons().Select(weaponModel => weaponModel.projectile))
            {
                proj.GetDamageModel().damage += 4;
                proj.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Moab", "Moab",
                    1, 6, false, false));
                proj.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModle_Ceramic", "Ceramic", 1, 4, false, false));
                proj.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Fortified", "Fortified",
                    1, 2, false, false));
            }

            towerModel.range += 20;

        }
    }


    internal class MoabMeltingDarts : ModUpgrade<DarksTowers.PlasmaMonkey>
    {
        public override int Path => MIDDLE;

        public override int Tier => 3;

        public override int Cost => 12000;

        public override string Description => "Does Even More Damage to Moabs, Melting Them";

        public override void ApplyUpgrade(TowerModel towerModel)
        {

            var proj = towerModel.GetAttackModel().weapons[0].projectile;
            proj.GetDamageModel().damage += 5;

            foreach (var sproj in towerModel.GetWeapons().Select(weaponModel => weaponModel.projectile))
            {
                sproj.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Moab1", "Moab",
                    1, 15, false, false));
            }
        }
    }

    internal class FieryPlasmaBalls2 : ModUpgrade<DarksTowers.PlasmaMonkey>
    {
        public override int Path => MIDDLE;

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

    internal class GodlyPlasmaBalls2 : ModUpgrade<DarksTowers.PlasmaMonkey>
    {
        public override int Path => MIDDLE;

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
