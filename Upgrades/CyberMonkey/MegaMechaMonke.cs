using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Models.Towers.Filters;
using Il2CppAssets.Scripts.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarksTowers.Displays.Proj.ProjectileDisplays;

namespace DarksTowers.Upgrades.CyberMonkey
{
    internal class MegaMechaMonke : ModParagonUpgrade<DarksTowers.CyberMonkey>
    {
        public override int Cost => 812560;

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            // Attack 1: Mini-Gun
            var WeaponModel_ = towerModel.GetWeapon();
            towerModel.GetWeapon().rate = 0.00002f;
            var Projectile_ = WeaponModel_.projectile;
            Projectile_.ApplyDisplay<MegaMiniCyberLaser>();
            Projectile_.GetDamageModel().damage = 1875;
            Projectile_.GetDamageModel().immuneBloonProperties = Il2Cpp.BloonProperties.None;
            towerModel.GetAttackModel().range = 40;
            WeaponModel_.emission = new ArcEmissionModel("ArcEmissionModel", 3, 0, 15, null, false, false);
            towerModel.range = 85;
            // Attack 2: Sniper
            towerModel.AddBehavior(Game.instance.model.GetTowerFromId("SniperMonkey").GetAttackModel());
            towerModel.GetAttackModel(1).range = 9999;
            var WeaponModel__ = towerModel.GetWeapon(1);
            WeaponModel_.rate = 0.2f;
            WeaponModel__.emission = new ArcEmissionModel("ArcEmissionModel", 3, 0, 15, null, false, false);
            var Projectile__ = WeaponModel__.projectile;
            Projectile__.GetDamageModel().damage = 75000;
            Projectile__.GetDamageModel().immuneBloonProperties = Il2Cpp.BloonProperties.None;
            Projectile__.pierce = 3;
            Projectile__.ApplyDisplay<MegaCyberLaserBullet>();
            // Attack 3: Blaster
            towerModel.AddBehavior(new AttackModel(null, null, 85, null, null, 0, 0, 0, false, false, 0, false, 0));
            towerModel.GetAttackModel(2).AddWeapon(WeaponModel_.Duplicate());
            var WeaponModel___ = towerModel.GetWeapon(2);
            var Projectile___ = WeaponModel__.projectile;
            WeaponModel___.rate = 0.07f;
            Projectile___.ApplyDisplay<MegaCyberLaser>();
            Projectile___.GetDamageModel().damage = 15000;
            Projectile___.pierce = 25;
            Projectile___.GetDamageModel().immuneBloonProperties = Il2Cpp.BloonProperties.None;
            WeaponModel___.emission = new ArcEmissionModel("ArcEmissionModel", 3, 0, 15, null, false, false);
            // Attack 4: RPG (Rocket Propelled Grenade)
            towerModel.AddBehavior(Game.instance.model.GetTowerFromId("BombShooter-004").GetAttackModel().Duplicate());
            towerModel.GetAttackModel().range = 85;
            var WeaponModel____ = towerModel.GetWeapon(3);
            var Projectile____ = WeaponModel____.projectile;
            WeaponModel____.emission = new ArcEmissionModel("ArcEmissionModel", 3, 0, 15, null, false, false);
            WeaponModel____.rate = 0.09f;
            Projectile____.pierce = 50;
            Projectile____.AddBehavior(Projectile___.GetDamageModel().Duplicate());
            Projectile____.GetDamageModel().damage = 12750;
            Projectile____.GetDamageModel().immuneBloonProperties = Il2Cpp.BloonProperties.None;
            Projectile____.ApplyDisplay<MegaCyberBomb>();
            // Misc.
            towerModel.GetDescendants<FilterInvisibleModel>().ForEach(model => model.isActive = false);
        }
    }
}
