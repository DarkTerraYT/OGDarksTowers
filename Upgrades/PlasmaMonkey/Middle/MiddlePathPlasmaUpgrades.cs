using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2Cpp;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Simulation.Towers.Behaviors.Abilities;
using Il2CppAssets.Scripts.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
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
                sproj.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Moab", "Moab",
                    1, 15, false, false));
            }
        }
    }

    internal class MoabIncineration : ModUpgrade<DarksTowers.PlasmaMonkey>
    {
        public override int Path => MIDDLE;

        public override int Tier => 4;

        public override int Cost => 21350;

        public override string Description => "Ability: The Plasma Monkey Gets New Darts Designed to Incinitgrate MOABS. Also adds increases damage and MOAB damage";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var proj = attackModel.weapons[0].projectile;
            var dmgModel = proj.GetDamageModel();
            dmgModel.damage += 3;

            foreach (var sPorj in towerModel.GetWeapons().Select(weaponModel => weaponModel.projectile))
            {
                sPorj.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Moab", "Moab", 1, 5, false, false));
            }
            var abilityModel = new AbilityModel("moab-incineration-ability", "Moab Incineration", "Increases Moab Greatly Effectively Incinerating Them.", 1, 0, GetSpriteReference(Icon),
                52f, null, false, false, null, 0, 0, 999999, false, false);
            var abilityAttackModel = new ActivateAttackModel("moab-incineration-avtivate-attack-model", 1f, true, new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<AttackModel>(1), false, true, false, false, false);
            abilityModel.AddBehavior(abilityAttackModel);

            var attackModleAbility = abilityAttackModel.attacks[0];
            var weaponModel = attackModleAbility.weapons[0];
            var projectileModel = weaponModel.projectile;

            attackModleAbility.range = towerModel.range;
            projectileModel.ApplyDisplay<MoabIncinerationDart>();
            var abilityDamageModel = projectileModel.GetDamageModel();
            abilityDamageModel.damage = dmgModel.damage;
            abilityDamageModel.immuneBloonProperties = dmgModel.immuneBloonProperties;
            projectileModel.pierce = proj.pierce;
            projectileModel.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Moab", "Moab", 1, 40, false, false));
        }
    }

    internal class MoabDiscintergration : ModUpgrade<DarksTowers.PlasmaMonkey>
    {
        public override int Path => MIDDLE;

        public override int Tier => 5;

        public override int Cost => 82650;

        public override string Description => "Ability: The Plasma Monkey Uses Most of His Energy to Create The Most Powerful Darts of All Time.";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var attackModel = towerModel.GetAttackModel();
            var proj = attackModel.weapons[0].projectile;
            var dmgModel = proj.GetDamageModel();

            foreach (var sProj in towerModel.GetWeapons().Select(weaponModel => weaponModel.projectile))
            {
                sProj.AddBehavior(new DamageModifierForTagModel("DamageModifierForTagModel_Moab", "Moab", 1, 9, false, false));
            }
        }
    }
}
