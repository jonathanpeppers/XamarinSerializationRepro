using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattlePillars.XNA
{
    public enum Facing
    {
        Right,
        Left,
    };

    public enum Team
    {
        Player1,
        Player2,
        Garden,
        Robot,
        Junk,
        Jungle,
        Spooky,
        Endless,
    }

    public enum SegmentType
    {
        BasicHead,
        DevHead,
        Cannon,
        Armor,
        Feet,
        Gun,
        Grenade,
        Medic,
        Carapace,
        Spikes,
        Grub,
        Honey,
        Bellows,
        Mines,
        FlameThrower,
        Missile,
    }

    public enum SegmentCategory
    {
        Upgrade,
        Head,
        Weapon,
        ZoneWeapon,
        Special,
        PassiveOngoing,
    }

    public enum SegmentRole
    {
        Defense,
        Attack,
        Support,
    }

    public enum DamageType
    {
        Normal,
        Fire,
        Poison,
        Blast,
        Poop,
        Lightning,
        ToxicHoney,
        Mandatory,
    }

    public enum EnvironmentType
    {
        Garden = 0,
        Jungle = 1,
        Spooky = 2,
        Junk = 3,
        Robot = 4,
        Glitch = 5,
    }

    [Flags]
    public enum Weather
    {
        None = 0,
        Rain = 1,
        Lightning = 2,
    }

    public enum ZoneType
    {
        Napalm,
        Honey,
        Raygun,
        Mines,
        Swarm_LV1,
        Swarm_LV2,
        Swarm_LV3,
        Flames_LV1,
        Flames_LV2,
        Flames_LV3,
        Air_LV1,
        Air_LV2,
        Air_LV3,
        Poop,
        ToxicHoney,
        Lightning,
        Beam,
        FinalBeam
    }

    public enum EffectType
    {
        Heal,
        Damage,
        Slow,
        Explode,
        Blow,
    }

    public enum ExpendableType
    {
        Squirrel,
        Bird,
        Turtle,
    }

    public enum ExplosionType
    {
        None,
        Cannon,
        MachineGun,
        Grenade,
        Napalm,
        Heal,
        Magma,
    }

    public enum ProjectileType
    {
        None,
        Grenades_LV1,
        Grenades_LV2,
        Grenades_LV3,
        Spikes_LV1,
        Honey,
        Missile_LV1,
        Missile_LV2,
        Missile_LV3,
        Poop,
        Cannonball,
        ToxicHoney,
        Boss_Spikes,
        Boss_MagmaBall,
        Boss_Missile,
    }

    public enum PillarAction
    {
        Moving,
        Stopped,
        Dying,
        Attacking,
    }

    public enum BossAction
    {
        Moving,
        Stopped,
        Dying,
        Biting,
        Roar,
        Hit,
        Attacking,
        Honey,
        Spiders,
        Magma,
        Missiles,
        Flying,
        Rising,
    }

    public enum PurchaseResult
    {
        Unlocked,
        Success,
        MaxedOut,
        NotEnoughApples,
        Error,
    }

    public enum LevelState
    {
        Locked,
        JustUnlocked,
        Unlocked,
        Completed,
        JustCompleted,
    }

    public enum UpgradeMenuTabType
    {
        Segments,
        Base,
        Expendables,
        Skins,
        Apples
    }

    public enum BaseUpgradeType
    {
        Defense = 0,
        Gun = 1,
        Production = 2,
    }

    public enum Tips
    {
        Tutorial = 1,
        FirstBaseUpgrade = 2,
        SegmentSelect = 5,
        Store = 6,
        Slots = 7,
        Allies = 8,
        ProductionButton = 9,
        BonusChallenges = 10,
        TestZone = 11,
        Endless = 12,
        GoldSkin = 13,
    }

    public enum CollectibleType
    {
        Leaf,
        Apple,
    }

    [Flags]
    public enum AITraits
    {
        //Builds at * 1.25 hesitation when player base at 1/2 health
        //Builds at * 2 hesitation when player base at 1/4 health
        Merciful = 0,

        //Builds at * 0.75f hesitation when their own base is at 1/2 health
        Comeback = 1,

        //Builds at * 0.05 hesition if their own base is at 1/4 health
        LastStand = 2,

        //always has a 1/4 chance to build from the derp list
        Dumb = 4,

        //Builds at * 0.5f hesitiation on their opening list
        ComeOutSwinging = 8,

        //Builds at * 1.25 hesitation time when they (segment) outnumber their opponent
        //Builds at * 2 hesitation time when they (segment) outnumber their opponent 2 to 1
        Arrogant = 16,

        //Never builds Derp Pillar
        Smart = 32,

        //Will save up enough leaves to execute entire rush list at once when set to strategy rush
        SaveForRush = 64,

        //Builds at *0.5 hesitation when their base is mobbed
        Defensive = 128,

        //Won't send Battlepillars while their opponent has none on the field
        Pacifist = 256,
    }

    public enum AIStrategies
    {
        None,

        //Pillars that define the boss's/level's personality
        Preferred,
    
        //Awful pillars
        Derp,

        //Lots of lil' pillars
        Rush,

        //One big ole pillar and lots of lil' pillars
        TankRush,

        //Largish, many segmented pillars
        BigPillars,

        //Battlepillars intended to clear mobs
        CrowdControl,

        //Battlepillars intended to defend base
        BaseDefense,

        //Battlepillars that go fast
        FastPillars,
    }

    public enum CameraDistance
    {
        Sky,
        Far,
        Normal,
        Near,
    }

    public enum BattlefieldMode
    {
        Normal,
        LeafChallenge,
    }

    public enum Skin
    {
        Green = 0,
        Red = 1,
        Jungle = 2,
        Spooky = 3,
        Junk = 4,
        EvilRobot = 5,
        Mummy = 6,
        CoolRobot = 7,
        FuzzyStripes = 8,
        Freedom = 9,
        Purple = 10,
        Scales = 11,
        SpiderWeb = 12,
        Spotty = 13,
        Ninja = 14,
        TieDye = 15,
        Stripey = 16,
        TribalBlue = 17,
        Gold = 18,
    }

    public enum ApplePurchase
    {
        TapJoyApp,
        TapJoyVid,
        Apples1,
        Apples2,
        Apples3,
        Apples4,
        Apples5,
        Apples6,
    }

    public enum CameraMode
    {
        Free,
        FollowPlayer,
        FollowAI
    }

    public enum ChallengeType
    {
        Time,
        Segment,
        Size,
        Leaf,
        Production,
        Collect,
    }

    public enum GameMode
    {
        Campaign,
        Endless,
        Multiplayer,
        TestZone,
        Title,
    }

    public enum DailyReward
    {
        ApplesX5,
        ApplesX10,
        ApplesX15,
        ApplesX20,
        ApplesX25,
        ApplesX30,
        ApplesX35,
        ApplesX40,
        ApplesX45,
        ApplesX50,
        Turtle,
        Squirrel,
        Bird,
    }

    public enum AllowedUpgrades
    {
        Personal,
        Minimum,
        Maximum,
    }

    public enum TreeTopColor
    {
        Default,
        Alternate1,
        Alternate2
    }

    public enum BossType
    {
        None = 0,
        Garden = 1,
        Jungle = 2,
        Spooky = 3,
        Junk = 4,
        Robot1 = 5,
        Robot2Beam = 6,
        Robot2Missle = 7,
        Robot3 = 8,
    }

    public enum Developers
    {
        None = 0,
        Andrew = 1,
        Annie = 2,
        Brian = 3,
        Chris = 4,
        Clinton = 5,
        Craig = 6,
        Ed = 7,
        Jeff = 8,
        Jon = 9,
        Joy = 10,
        Matt = 11,
        Mitch = 12,
        Nick = 13,
        Phil = 14,
        Stuart = 15,
    }
}
