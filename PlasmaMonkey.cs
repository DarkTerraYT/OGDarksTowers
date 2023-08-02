using MelonLoader;
using BTD_Mod_Helper;
using DarksTowers;
using BTD_Mod_Helper.Api.Towers;
using Il2CppAssets.Scripts.Models.TowerSets;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Extensions;
using static DarksTowers.Displays.Proj.Displays;
using Il2CppAssets.Scripts.Models;
using Il2Cpp;

namespace DarksTowers
{
    internal class PlasmaMonkey : ModTower
    {

        public override TowerSet TowerSet => TowerSet.Magic;

        public override string BaseTower => TowerType.DartMonkey;

        public override int Cost => 4250;

        public override int TopPathUpgrades => 5;

        public override int MiddlePathUpgrades => 5;

        public override int BottomPathUpgrades => 5;

        public override string Description => "It's a Monkey but Plasma, Shoots Plasma Darts";

        public override string Icon => "PlasmaMonkey-Portrait";

        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            towerModel.range += 15;
            var attackModle = towerModel.GetAttackModel();
            attackModle.range += 15;

            var projectile = attackModle.weapons[0].projectile;
            projectile.ApplyDisplay<PlasmaDart>();
            projectile.pierce += 7;
            projectile.GetDamageModel().damage += 2;
            foreach (var weaponModel in towerModel.GetWeapons())
            {
                weaponModel.projectile.GetDamageModel().immuneBloonProperties = BloonProperties.None;
                weaponModel.projectile.GetDamageModel().immuneBloonProperties = BloonProperties.Purple;
            }
            projectile.CanHitCamo();
        }

        public override bool IsValidCrosspath(int[] tiers) =>
          ModHelper.HasMod("UltimateCrosspathing") ? true : base.IsValidCrosspath(tiers);
    }
}
