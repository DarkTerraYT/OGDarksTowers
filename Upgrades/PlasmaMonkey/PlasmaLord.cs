using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using DarksTowers.Displays.Proj;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Models.Towers.Filters;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Unity;

namespace DarksTowers.Upgrades.PlasmaMonkey
{
    internal class PlasmaLord : ModParagonUpgrade<DarksTowers.PlasmaMonkey>
    {
        public override int Cost => 999999;

        public override string DisplayName => "Plasma Lord";

        public override string Description => "Plasma is what the sun is made of along with hydrogen and helium.";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            var AttackModel = towerModel.GetAttackModel();
            AttackModel.range = 250;

            // Attack 1: Deadly Plasma Ball
            var WeaponModel = AttackModel.weapons[0];
            WeaponModel.rate = 0.05f;
            WeaponModel.projectile.pierce = 500;
            WeaponModel.projectile.GetDamageModel().damage = 500;
            WeaponModel.projectile.GetDamageModel().immuneBloonProperties = Il2Cpp.BloonProperties.None;
            WeaponModel.projectile.ApplyDisplay<ProjectileDisplays.DeadlyPlasmaBall>();

            // Attack 2: Deadly Plasma Beam
            AttackModel.AddWeapon(Game.instance.model.GetTowerFromId("DartMonkey").GetWeapon().Duplicate());
            var WeaponModel_ = AttackModel.weapons[1];
            WeaponModel_.rate = 0.01f;
            WeaponModel_.emission = new ArcEmissionModel("ArcEmissionModel", 3, 0, 15, null, false, false);
            WeaponModel_.projectile.pierce = 500;
            WeaponModel_.projectile.GetDamageModel().damage = 200;
            WeaponModel_.projectile.GetDamageModel().immuneBloonProperties = Il2Cpp.BloonProperties.None;
            WeaponModel_.projectile.ApplyDisplay<ProjectileDisplays.DeadlyPlasmaBeam>();


            // Other Things
            towerModel.range = 250;
            towerModel.GetDescendants<FilterInvisibleModel>().ForEach(i => i.isActive = false);
            foreach(var weaponModel in towerModel.GetWeapons())
            {
                weaponModel.projectile.GetBehavior<TravelStraitModel>().lifespan = 1;
                weaponModel.projectile.GetBehavior<TravelStraitModel>().Lifespan = 1;
            }
        }
    }
}
