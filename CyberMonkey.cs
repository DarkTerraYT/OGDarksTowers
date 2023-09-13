using BTD_Mod_Helper;
using BTD_Mod_Helper.Api.Enums;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using DarksTowers.Displays.CyberMonkey;
using Il2CppAssets.Scripts;
using Il2CppAssets.Scripts.Models.Bloons.Behaviors;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Models.TowerSets;
using Il2CppAssets.Scripts.Unity;
using System.Runtime.Serialization;
using static DarksTowers.Displays.Proj.ProjectileDisplays;

namespace DarksTowers
{
    internal class CyberMonkey : ModTower
    {
        public override TowerSet TowerSet => TowerSet.Military;

        public override string BaseTower => TowerType.DartMonkey;

        public override int Cost => 615;

        public override int TopPathUpgrades => 5;

        public override int MiddlePathUpgrades => 5;

        public override int BottomPathUpgrades => 5;

        public override string Icon => "CyberMonkey-Portrait";

        public override ParagonMode ParagonMode => ParagonMode.Base000;

        public static float _004Damage = 0;

        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            var WeaponModel = towerModel.GetWeapon();
            var ProjectileModel = WeaponModel.projectile;
            ProjectileModel.GetDamageModel().damage = 3;
            ProjectileModel.ApplyDisplay<CyberLaser>();
            ProjectileModel.pierce = 5;
            towerModel.ApplyDisplay<CyberMonkeyDisplay>();
            towerModel.range += 20;
            towerModel.GetAttackModel().range += 20;
            WeaponModel.rate *= 0.8f;
            ProjectileModel.GetDamageModel().immuneBloonProperties = Il2Cpp.BloonProperties.Lead | Il2Cpp.BloonProperties.Purple;
        }

        public override bool IsValidCrosspath(int[] tiers) => ModHelper.HasMod("UltimateCrosspathing") ? true : base.IsValidCrosspath(tiers);
    }
}
