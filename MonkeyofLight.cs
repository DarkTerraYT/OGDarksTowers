using MelonLoader;
using BTD_Mod_Helper;
using DarksTowers;
using BTD_Mod_Helper.Api.Towers;
using Il2CppAssets.Scripts.Models.TowerSets;
using Il2CppAssets.Scripts.Models.Towers;
using BTD_Mod_Helper.Extensions;
using static DarksTowers.Displays.Proj.ProjectileDisplays;
using Il2CppAssets.Scripts.Models;
using Il2Cpp;

namespace DarksTowers
{
    internal class MonkeyofLight : ModTower
    {

        public override TowerSet TowerSet => TowerSet.Magic;

        public override string BaseTower => TowerType.WizardMonkey;

        public override int Cost => 1065;

        public override int TopPathUpgrades => 5;

        public override int MiddlePathUpgrades => 5;

        public override int BottomPathUpgrades => 0;

        public override string Description => "This Monkey learned how to capture light and used it to their advantage. One day though, this monkey had an accident and turned into a monkey made purely of light.";

        public override string Icon => "MonkeyofLight-Portrait";


        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            towerModel.range += 10;
            var attackModle = towerModel.GetAttackModel();
            attackModle.range += 10;
            towerModel.ApplyDisplay<Displays.MoneyofLight.MonkeyofLightDisplay>();
            var projectile = attackModle.weapons[0].projectile;
            projectile.ApplyDisplay<LightBlast>();
            projectile.GetDamageModel().damage += 2;
            foreach (var weaponModel in towerModel.GetWeapons())
            {
                weaponModel.rate *= 0.65f;
                weaponModel.projectile.GetDamageModel().immuneBloonProperties = BloonProperties.Lead;
            }
        }

        public override bool IsValidCrosspath(int[] tiers) =>
          ModHelper.HasMod("UltimateCrosspathing") ? true : base.IsValidCrosspath(tiers);
    }
}
