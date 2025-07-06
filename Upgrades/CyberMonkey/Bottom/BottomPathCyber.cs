using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2CppAssets.Scripts.Models.Towers.Filters;
using Il2CppAssets.Scripts.Models.Towers.Projectiles;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Weapons;
using Il2CppAssets.Scripts.Unity;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DarksTowers.Displays.Proj.ProjectileDisplays;

namespace DarksTowers.Upgrades.CyberMonkey.Bottom
{
    internal class BetterSensors : ModUpgrade<DarksTowers.CyberMonkey>
    {
        public override int Path => BOTTOM;

        public override int Tier => 1;

        public override int Cost => 435;

        public override string Description => "Increases range";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.range += 20;
            towerModel.GetAttackModel().range += 20;
        }
    }
    internal class CamoSensors : ModUpgrade<DarksTowers.CyberMonkey>
    {
        public override int Path => BOTTOM;

        public override int Tier => 2;

        public override int Cost => 615;

        public override string Description => "Can now see camo and slightly more range";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.range += 10;
            towerModel.GetAttackModel().range += 10;
            towerModel.GetDescendants<FilterInvisibleModel>().ForEach(model => model.isActive = false);
        }
    }
    internal class SharpBeams : ModUpgrade<DarksTowers.CyberMonkey>
    {
        public override int Path => BOTTOM;
        public override int Tier => 3;
        public override int Cost => 1545;
        public override string Description => "Pierces more bloons, slightly more damage + can pop leads";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().projectile.pierce += 3;
            towerModel.GetWeapon().projectile.GetDamageModel().immuneBloonProperties = Il2Cpp.BloonProperties.Purple;
            towerModel.GetWeapon().projectile.GetDamageModel().damage += 1;
        }
    }
    internal class ExplodingBeams : ModUpgrade<DarksTowers.CyberMonkey>
    {
        public override int Path => BOTTOM;

        public override int Tier => 4;

        public override int Cost => 6545;
        public override string Description => "Lasers now explode, does more damage + pierce";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetWeapon().rate *= 0.8f;
            towerModel.GetWeapon().projectile.AddBehavior(Game.instance.model.GetTowerFromId("BombShooter").GetWeapon().projectile.GetBehavior<CreateProjectileOnContactModel>().Duplicate());
            towerModel.GetWeapon().projectile.GetDamageModel().damage += 5;
            towerModel.GetWeapon().projectile.pierce = 15;
            towerModel.GetWeapon().projectile.GetDamageModel().immuneBloonProperties = Il2Cpp.BloonProperties.Black;
            towerModel.GetWeapon().projectile.ApplyDisplay<ExplodingCyberLaser>();
        }
    }
    internal class RocketLauncher : ModUpgrade<DarksTowers.CyberMonkey>
    {
        public override int Path => BOTTOM;

        public override int Tier => 5;

        public override int Cost => 31545;
        public override string Description => "I said a' boom chicka boom!";

        public override void ApplyUpgrade(TowerModel towerModel)
        {
            towerModel.GetAttackModel().AddWeapon(Game.instance.model.GetTowerFromId("BombShooter-003").GetWeapon().Duplicate());
            var Projectile = towerModel.GetWeapon(1).projectile;
            Projectile.pierce = towerModel.GetWeapon(0).projectile.pierce + 10;
            Projectile.AddBehavior(towerModel.GetWeapon().projectile.GetDamageModel().Duplicate());
            var DamageModel = towerModel.GetWeapon(1).projectile.GetDamageModel();
            Projectile.ApplyDisplay<CyberBomb>();
            DamageModel.damage += 50;
            DamageModel.immuneBloonProperties = Il2Cpp.BloonProperties.None;
        }
    }
}
