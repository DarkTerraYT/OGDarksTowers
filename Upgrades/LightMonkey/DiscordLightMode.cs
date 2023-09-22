using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using DarksTowers.Displays.Proj;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarksTowers.Upgrades.LightMonkey
{
    internal class DiscordLightMode : ModParagonUpgrade<MonkeyofLight>
    {
        public override int Cost => 615500;

        public override string DisplayName => "Discord Light Mode";

        public override string Description => "Well I guess it's just meant to be bright";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.range = 175;
            towerModel.GetAttackModel().range = 175;
            var WeaponModel = towerModel.GetWeapon();
            var ProjectileModel = WeaponModel.projectile;
            var DamageModel = ProjectileModel.GetDamageModel();
            WeaponModel.rate = 0.05f;
            WeaponModel.emission = new ArcEmissionModel("ArcEmissionModel_", 3, 0, 15, null, false, false);
            ProjectileModel.pierce = 50;
            DamageModel.immuneBloonProperties = Il2Cpp.BloonProperties.None;
            DamageModel.damage = 125;
            ProjectileModel.AddBehavior(new DamageModifierForTagModel("MOABDamageModifier_", "Moab", 1.75f, 0, false, false));
            ProjectileModel.ApplyDisplay<ProjectileDisplays.MegaLightBlast>();
        }
    }
}
