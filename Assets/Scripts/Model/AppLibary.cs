using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AppLibary{

    public static Dictionary<string, Feat> featDictionary = new Dictionary<string, Feat>();

    public static Dictionary<string, Item> itemDictionary = new Dictionary<string, Item>();

    #region FeatKeys
    public const string Acrobatic = "Acrobatic";
    public const string Alertness = "Alertness";
    public const string AlignmentChannel = "Alignment Channel";
    public const string AnimalAffinity = "Animal Affinity";
    public const string ArcaneArmorTraining = "Arcane Armor Training";
    public const string ArcaneArmorMastery = "Arcane Armor Mastery";
    public const string ArcaneStrike = "Arcane Strike";
    public const string ArmorProficiencyLight = "Armor Proficiency, Light";
    public const string ArmorProficiencyMedium = "Armor Proficiency, Medium";
    public const string ArmorProficiencyHeavy = "Armor Proficiency, Heavy";
    public const string Athletic = "Athletic";
    public const string AugmentSummoning = "Augment Summoning";
    public const string BlindFight = "Blind-Fight";
    public const string CatchOffGuard = "Catch-Off-Guard";
    public const string ChannelSmite = "Channel Smite";
    public const string CombatCasting = "Combat Casting";
    public const string CombatExpertise = "Combat Expertise";
    public const string ImprovedDisarm = "Improved Disarm";
    public const string GreaterDisarm = "Greater Disarm";
    public const string ImprovedFeint = "Improved Feint";
    public const string GreaterFeint = "Greater Feint";
    public const string ImprovedTrip = "Improved Trip";
    public const string GreaterTrip = "Greater Trip";
    public const string WhirlwindAttack = "Whirlwind Attack";
    public const string CombatReflexes = "Combat Reflexes";
    public const string StandStill = "Stand Still";
    public const string CommandUndead = "Command Undead";
    public const string CriticalFocus = "Critical Focus";
    public const string BleedingCritical = "Bleeding Critical";
    public const string BlindingCritical = "Blinding Critical";
    public const string CriticalMastery = "Critical Mastery";
    public const string DeafeningCritical = "Deafening Critical";
    public const string SickeningCritical = "Sickening Critical";
    public const string StaggeringCritical = "Staggering Critical";
    public const string StunningCritical = "Stunning Critical";
    public const string TiringCritical = "Tiring Critical";
    public const string DeadlyAim = "Deadly Aim";
    public const string Deceitful = "Deceitful";
    public const string DefensiveCombatTraining = "Defensive Combat Training";
    public const string DeftHands = "Deft Hands";
    public const string Disruptive = "Disruptive";
    public const string Spellbreaker = "Spellbreaker";
    public const string Dodge = "Dodge";
    public const string Mobility = "Mobility";
    public const string SpringAttack = "Spring Attack";
    public const string WindStance = "Wind Stance";
    public const string LightningStance = "Lighting Stance";
    public const string ElementalChannel = "Elemental Channel";
    public const string Endurance = "Endurance";
    public const string Diehard = "Diehard";
    public const string EschewMaterials = "Eschew Materials";
    public const string ExhaustingCritical = "Exhausting Critical";
    public const string ExoticWeaponProficiency = "Exotic Weapon Proficiency";
    public const string ExtraChannel = "Extra Channel";
    public const string ExtraKi = "Extra Ki";
    public const string ExtraLayOnHands = "Extra Lay On Hands";
    public const string ExtraMercy = "Extra Mercy";
    public const string ExtraPerformance = "Extra Performance";
    public const string ExtraRage = "Extra Rage";
    public const string Fleet = "Fleet";
    public const string GreatFortitude = "Great Fortitude";
    public const string ImprovedGreatFortitude = "Improved Great Fortitude";
    public const string ImprovedChannel = "Improved Channel";
    public const string ImprovedCounterspell = "Improved Counterspell";
    public const string ImprovedCritical = "Improved Critical";
    public const string ImprovedFamiliar = "Improved Familiar";
    public const string ImprovedInitiative = "Improved Initiative";
    public const string ImprovedUnarmedStrike = "Improved Unarmed Strike";
    public const string DeflectArrows = "Deflect Arrows";
    public const string SnatchArrows = "Snatch Arrows";
    public const string ImprovedGrapple = "Improved Grapple";
    public const string GreaterGrapple = "Greater Grapple";
    public const string ScorpionStyle = "Scorpion Style";
    public const string GorgonsFist = "Gorgon's Fist";
    public const string MedusasWrath = "Medusa's Wrath";
    public const string StunningFist = "Stunning Fist";
    public const string ImprovisedWeaponMastery = "Improvised Weapon Mastery";
    public const string IntimidatingProwess = "Intimidating Prowess";
    public const string IronWill = "Iron Will";
    public const string ImprovedIronWill = "Improved Iron Will";
    public const string Leadership = "Leadership";
    public const string LightningReflexes = "Lightning Reflexes";
    public const string ImprovedLightningReflexes = "Improved Lightning Reflexes";
    public const string Lunge = "Lunge";
    public const string MagicalAptitude = "Magical Aptitude";
    public const string MartialWeaponProficiency = "Martial Weapon Proficiency";
    public const string MasterCraftsman = "Master Craftsman";
    public const string MountedCombat = "Mounted Combat";
    public const string MountedArchery = "Mounted Archery";
    public const string RideByAttack = "Ride-By-Attack";
    public const string SpiritedCharge = "Spirited Charge";
    public const string Trample = "Trample";
    public const string Unseat = "Unseat";
    public const string NaturalSpell = "Natural Spell";
    public const string NimbleMoves = "Nimble Moves";
    public const string AcrobaticSteps = "Acrobatic Steps";
    public const string Persuasive = "Persuasive";
    public const string PointBlankShot = "Point-Blank-Shot";
    public const string FarShot = "Far-Shot";
    public const string PreciseShot = "Precise-Shot";
    public const string ImprovedPreciseShot = "Improved-Precise-Shot";
    public const string PinpointTargeting = "Pinpoint Targeting";
    public const string ShotOnTheRun = "Shot On The Run";
    public const string RapidShot = "Rapid Shot";
    public const string Manyshot = "Manyshot";
    public const string PowerAttack = "Power Attack";
    public const string Cleave = "Cleave";
    public const string GreatCleave = "Great Cleave";
    public const string ImprovedBullRush = "Improved Bull Rush";
    public const string GreaterBullRush = "Greater Bull Rush";
    public const string ImprovedOverrun = "ImprovedOverrun";
    public const string GreaterOverrun = "Greater Overrun";
    public const string ImprovedSunder = "Improved Sunder";
    public const string GreaterSunder = "Greater Sunder";
    public const string QuickDraw = "Quick-Draw";
    public const string RapidReload = "Rapid-Reload";
    public const string Run = "Run";
    public const string SelectiveChanneling = "Selective Channeling";
    public const string SelfSufficient = "Self-Sufficient";
    public const string ShieldProficiency = "Sheild Proficency";
    public const string ImprovedShieldBash = "Improved Shield Bash";
    public const string ShieldSlam = "Shield-Slam";
    public const string ShieldMaster = "Shield Master";
    public const string ShieldFocus = "Shield Focus";
    public const string GreaterSheildFocus = "Greater Shield Focus";
    public const string TowerSheildProficiency = "Tower Shield Proficiency";
    public const string SimpleWeaponProficiency = "Simple Weapon Proficiency";
    public const string SkillFocus = "Skill Focus";
    public const string SpellFocus = "Spell Focus";
    public const string GreaterSpellFocus = "Greater Spell Focus";
    public const string SpellMastery = "Spell Mastery";
    public const string SpellPenetration = "Spell Penetration";
    public const string GreaterSpellPenetration = "Greater Spell Penetration";
    public const string Stealthy = "Stealthy";
    public const string StepUp = "Step Up";
    public const string StrikeBack = "Strike Back";
    public const string ThrowAnything = "Throw Anything";
    public const string Toughness = "Toughness";
    public const string TurnUndead = "Turn Undead";
    public const string TwoWeaponFighting = "Two-Weapon Fighting";
    public const string DoubleSlice = "Double Slice";
    public const string TwoWeaponRend = "Two-Weapon Rend";
    public const string ImprovedTwoWeaponFighting = "Improved Two-Weapon Fighting";
    public const string GreaterTwoWeaponFighting = "Greater Two-WeaponFighting";
    public const string TwoWeaponDefense = "Two-Weapon Defense";
    public const string VitalStrike = "Vital Strike";
    public const string ImprovedVitalStrike = "Improved Vital Strike";
    public const string GreaterVitalStrike = "Greater Vital Strike";
    public const string WeaponFinesse = "Weapon Finesse";
    public const string WeaponFocus = "Weapon Focus";
    public const string DazzlingDisplay = "Dazzling Display";
    public const string ShatterDefenses = "Shatter Defenses";
    public const string DeadlyStroke = "DeadlyStroke";
    public const string GreaterWeaponFocus = "Greater Weapon Focus";
    public const string PenetratingStrike = "Penetrating Strike";
    public const string GreaterPenetratingStrike = "Greater Penetrating Strike";
    public const string WeaponSpecialization = "Weapon Specialization";
    public const string GreaterWeaponSpecialization = "Greater Weapon Specialization";
    public const string BrewPotion = "Brew Potion";
    public const string CraftMagicArmsAndArmor = "Craft Magic Arms and Armor";
    public const string CraftRod = "Craft Rod";
    public const string CraftStaff = "Craft Staff";
    public const string CraftWand = "CraftWand";
    public const string CraftWondrousItem = "Craft Wondrous Item";
    public const string ForgeRing = "Forge Ring";
    public const string ScribeScroll = "Scribe Scroll";
    public const string EmpowerSpell = "Empower Spell";
    public const string EnlargeSpell = "Enlarge Spell";
    public const string ExtendSpell = "Extend Spell";
    public const string HeightenSpell = "Heighten Spell";
    public const string MaximizeSpell = "Maximize Spell";
    public const string QuickenSpell = "Quicken Spell";
    public const string SilentSpell = "Silent Spell";
    public const string StillSpell = "Still Spell";
    public const string WidenSpell = "Widen Spell";
    #endregion FeatKeys

    #region SkillKeys
    //do last
    #endregion SkillKeys

    #region ItemKeys
    //simple weapons
    public const string Gauntlet = "Gauntlet";
    public const string UnarmedStrike = "Unarmed, Strike";
    public const string Dagger = "Dagger";
    public const string DaggerPunching = "Dagger, Punching";
    public const string GauntletSpiked = "Gauntlet, Spiked";
    public const string MaceLight = "Mace, Light";
    public const string Sickle = "Sickle";
    public const string Club = "Club";
    public const string MaceHeavy = "Mace, Heavy";
    public const string Morningstar = "Morningstar";
    public const string Shortspear = "Shortspear";
    public const string Longspear = "Longspear";
    public const string Quaterstaff = "Quaterstaff";
    public const string Spear = "Spear";
    public const string Blowgun = "Blowgun";
    public const string BlowgunDarts = "Darts, Blowgun";
    public const string CrossbowHeavy = "Crossbow, Heavy";
    public const string CrossbowBolts = "Bolts, Crossbow";
    public const string CrossbowLight = "Crossbow, Light";
    public const string Darts = "Dart";
    public const string Javelin = "Javelin";
    public const string Sling = "Sling";
    public const string BulletsSling = "Bullets, Sling";

    //Martial Weapons

    public const string AxeThrowing = "Axe, Throwing";
    public const string HammerLight = "Hammer, Light";
    public const string Handaxe = "Handaxe";
    public const string Kukri = "Kukri";
    public const string PickLight = "Pick, Light";
    public const string Sap = "Sap";
    public const string SheildLight = "Shield, Light";
    public const string SpikedArmor = "Spiked Armor";
    public const string SpikedShieldlight = "Spiked Shield, Light";
    public const string Starknife = "Starknife";
    public const string SwordShort = "Sword Short";
    public const string Battleaxe = "Battleaxe";
    public const string Flail = "Flail";
    public const string Longsword = "Longsword";
    public const string PickHeavy = "Pick, Heavy";
    public const string Rapier = "Rapier";
    public const string Scimitar = "Scimitar";
    public const string SheildHeavy = "Sheild, Heavy";
    public const string SpikedShieldHeavy = "Spiked Shield, Heavy";
    public const string Trident = "Trident";
    public const string Warhammer = "Warhammer";
    public const string Falchion = "Falchion";
    public const string Glaive = "Glaive";
    public const string Greataxe = "Greataxe";
    public const string Greatclub = "Greatclub";
    public const string FlailHeavy = "Flail, Heavy";
    public const string Greatsword = "Greatsword";
    public const string Guisarme = "Guisarme";
    public const string Halberd = "Halberd";
    public const string Lance = "Lance";
    public const string Ranseur = "Ranseur";
    public const string Scythe = "Scythe";
    public const string Longbow = "Longbow";
    public const string BowArrow = "Arrow, Bows";
    public const string LongbowComposite = "Longbow, Composite";
    public const string Shortbow = "Shortbow";
    public const string ShortbowComposite = "Shortbow, Composite";

    //Exotic Weapons

    public const string Kama = "Kama";
    public const string Nunchaku = "Nunchaku";
    public const string Sai = "Sai";
    public const string Siangham = "Siangham";
    public const string SwordBastard = "Sword, Bastard";
    public const string WaraxeDwarven = "Waraxe, Dwarven";
    public const string Whip = "Whip";
    public const string AxeOrcDouble = "Axe, Orc Double";
    public const string ChainSpiked = "Chain, Spiked";
    public const string CurveBladeElven = "Curve blade, Elven";
    public const string FlailDire = "Flail, Dire";
    public const string HammerGnomeHooked = "Hammer, Gnome Hooked";
    public const string SwordTwoBladed = "Sword, Two-bladed";
    public const string UrgroshDwarven = "Urgrosh, Dwarven";
    public const string Bolas = "Bolas";
    public const string CrossbowHand = "Crossbow, Hand";
    public const string CrossbowRepeatingLight = "Crossbow, Repeating Light";
    public const string CrossbowRepeatingHeavy = "Crossbow, Repeating Heavy";
    public const string Net = "Net";
    public const string Shuriken = "Shuriken";
    public const string SlingStaffHalfling = "Sling staff, Halfling";

    //Armor

    public const string Padded = "Padded";
    public const string Leather = "Leather";
    public const string StuddedLeather = "Studded Leather";
    public const string ChainShirt = "Chain Shirt";
    public const string Hide = "Hide";
    public const string ScaleMail = "Scale Mail";
    public const string Chainmail = "Chainmail";
    public const string Breastplate = "Breastplate";
    public const string SplintMail = "SplintMail";
    public const string BandedMail = "BandedMail";
    public const string HalfPlate = "HalfPlate";
    public const string FullPlate = "FullPlate";
    public const string Buckler = "Buckler";
    public const string ShieldLightWooden = "Shield, Light Wooden";
    public const string ShieldLightSteel = "Shield, Light Steel";
    public const string ShieldHeavyWooden = "Shield, Heavy Wooden";
    public const string ShieldHeavySteel = "Shield, Heavy Steel";
    public const string ShieldTower = "Shield, Tower";
    public const string ArmorSpikes = "Armor spikes";
    public const string GauntletLocked = "Gauntlet, Locked";
    public const string ShieldSpikes = "Shield, Spikes";

    //Equipment
    //adventuring gear
    public const string Backpack = "Backpack";
    public const string Barrel = "Barrel";
    public const string Basket = "Basket";
    public const string Bedroll = "Bedroll";
    public const string Bell = "Bell";
    public const string BlanketWinter = "Blanket, Winter";
    public const string BlockAndTackle = "Block, and Tackle";
    public const string BottleGlass = "Bottle, Glass";
    public const string Bucket = "Bucket";
    public const string Caltrops = "Caltrops";
    public const string Candle = "Candle";
    public const string Canvas = "Canvas";
    public const string CaseMapOrScroll = "Case, Map or Scroll";
    public const string Chain10ft = "Chain, 10ft";
    public const string ChalkOne = "Chalk, 1 piece";
    public const string Chest = "Chest";
    public const string Crowbar = "Crowbar";
    public const string Firewood = "Firewood";
    public const string Fishhook = "Fishhook";
    public const string FishingNet25 = "Fishing net, 25 sq ft";
    public const string Flask = "Flask";
    public const string FlintAndSteel = "Flint and Steel";
    public const string GrappelingHook = "Grappeling Hook";
    public const string Hammer = "Hammer";
    public const string Hourglass = "Hourglass";
    public const string Ink = "Ink (1 oz, vial)";
    public const string Inkpen = "Inkpen";
    public const string JugClay = "Jug, Clay";
    public const string Ladder10ft = "Ladder, 10-ft";
    public const string LampCommon = "Ladder, Common";
    public const string LanternBullseye = "Latern, Bullseye";
    public const string LanternHodded = "Latern, Hooded";
    public const string LockSimple = "Lock, Simple";
    public const string LockAverage = "Lock, Average";
    public const string LockGood = "Lock, Good";
    public const string LockSuperior = "Lock, Superior";
    public const string Manacles = "Manacles";
    public const string ManaclesMasterwork = "Manacles, Masterwork";
    public const string MirrorSmallSteel = "Mirror, Small Steel";
    public const string MugClay = "Mug/Tankard, clay";
    public const string Oil = "Oil";
    public const string Paper = "Paper";
    public const string Parchment = "Parchment";
    public const string PickMiner = "Pick, Miner's";
    public const string PitcherClay = "Pitcher, Clay";
    public const string Piton = "Piton";
    public const string Pole10Foot = "Pole, 10-foot";
    public const string PotIron = "Pot, Iron";
    public const string PouchBelt = "Pouch, Belt";
    public const string RamPortable = "Ram, portable";
    public const string RationsTrail = "Rations, Trail (per day)";
    public const string RopeHemp = "Rope, hemp";
    public const string RopeSilk = "Rope, silk";
    public const string Sack = "Sack";
    public const string SealingWax = "Sealing, Wax";
    public const string SewingNeedle = "Sewing, Needle";
    public const string ShovelOrSpade = "Shovel or Spade";
    public const string SignalWhistle = "Signal Whistle";
    public const string SignetRing = "Signet Ring";
    public const string Sledge = "Sledge";
    public const string Soap = "Soap";
    public const string Spyglass = "Spyglass";
    public const string Tent = "Tent";
    public const string Torch = "Torch";
    public const string VialInkOrPotion = "Vial, ink or potion";
    public const string WaterClock = "Water, Clock";
    public const string Waterskin = "Waterskin";
    public const string Whetstone = "Whetstone";

    //Special Substance

    public const string AcidFlask = "Acid (Flask)";
    public const string AlchemistFire = "Alchemist's Fire";
    public const string Antitoxin = "Antitoxin";
    public const string EverburningTorch = "Everburning Torch";
    public const string HolyWaterFlask = "Holy water (Flask)";
    public const string Smokestick = "Smokestick";
    public const string Sunrod = "Sunrod";
    public const string TanglefootBag = "Tanglefoot bag";
    public const string Thunderstone = "Thunderstone";
    public const string Tinderwig = "Tinderwig";

    //Tools and Skill Kits

    public const string AlchemistLab = "Alchemist's Lab";
    public const string ArtisansTools = "Artisan's Tools";
    public const string ArtisansToolsMasterwork = "Artisan's Tools, masterwork";
    public const string ClimbersKit = "Climber's Kit";
    public const string DisguiseKit = "Disguise Kit";
    public const string HealersKit = "Healer's Kit";
    public const string HollyAndMistletoe = "Holly and Mistletoe";
    public const string HolySymbolWooden = "Holy Symbol, wooden";
    public const string HolySymbolSilver = "Holy Symbol, silver";
    public const string MagnifyingGlass = "Magnifying Glass";
    public const string MusicalInstrimentCommon = "Musical Instrument, common";
    public const string MusicalInstrumentMasterwork = "Musical Instrument, masterwork";
    public const string ScaleMerchants = "Scale, Merchant's";
    public const string SpellComponentPouch = "Spell component pouch";
    public const string SpellbookBlank = "Spellbook (wizards), blank";
    public const string ThievesTools = "Thieve's Tools";
    public const string ThievesToolsMasterwork = "Thieve's Tools, Masterwork";
    public const string ToolMasterwork = "Tool, Masterwork";

    //Cloathing

    public const string ArtisansOutfit = "Artisan's Outfit";
    public const string ClericsVestments = "Cleric's vestments";
    public const string ColdWeatherOutfit = "Cold-Weather Outfit";
    public const string CourtiersOutfit = "Courtier's Outfit";
    public const string EntertainersOutfit = "Entertainer's Outfit";
    public const string ExplorersOutfit = "Explorer's Outfit";
    public const string MonksOutfit = "Monk's Outfit";
    public const string NoblesOutfit = "Noble's Outfit";
    public const string PesantsOutfit = "Pesent's Outfit";
    public const string RoyalOutfit = "Royal Outfit";
    public const string ScholarsOutift = "Scholar's Outfit";
    public const string TravlersOutfit = "Traveler's Outfit";

    //Food Drink Lodging

    public const string AleGallon = "Ale, Gallon";
    public const string AleMug = "Ale, Mug";
    public const string Banquet = "Banquet";
    public const string BreadLoaf = "Bread, Loaf";
    public const string CheeseHunk = "Cheese, Hunk";
    public const string InnStayGood = "Inn Stay (per day), Good";
    public const string InnStayCommon = "Inn Stay (per day), Common";
    public const string InnStayPoor = "Inn Stay (per day), Poor";
    public const string MealsGood = "Meals (per day), Good";
    public const string MealsCommon = "Meals (per day), Common";
    public const string MealsPoor = "Meals (per day), Poor";
    public const string MeatChunk = "Chunk of Meat";
    public const string WineCommon = "Wine (pitcher) , Common";
    public const string WineFine = "Wine (bottle) , Fine";

    //Mounts and Related Gear

    public const string BardingMedium = "Barding, Medium";
    public const string BardingLarge = "Barding, Large";
    public const string BitAndBridle = "Bit and Bridle";
    public const string DogGaurd = "Dog, Guard";
    public const string DogRiding = "Dog, Riding";
    public const string DonkeyMule = "Donkey or Mule";
    public const string Feed = "Feed (per day)";
    public const string HorseHeavy = "Horse, Heavy";
    public const string HorseHeavyCombat = "Horse, Heavy (Combat Trained)";
    public const string HorseLight = "Horse, Light";
    public const string HorseLightCombat = "Horse, Light (Combat Trained)";
    public const string Pony = "Pony";
    public const string PonyCombat = "Pony (Combat Trained)";
    public const string SaddleMilitary = "Saddle, Military";
    public const string SaddlePack = "Saddle, Pack";
    public const string SaddleRiding = "Saddle, Riding";
    public const string SaddleExoticMilitary = "Exotic Saddle, Military";
    public const string SaddleExoticPack = "Exotic Saddle, Pack";
    public const string SaddleExoticRiding = "Exotic Saddle, Riding";
    public const string Saddlebags = "Saddlebags";
    public const string Stabling = "Stabling (per day)";

    //Transport

    public const string Carriage = "Carriage";
    public const string Cart = "Cart";
    public const string Galley = "Galley";
    public const string Keelboat = "Keelboat";
    public const string Longship = "Longship";
    public const string Rowboat = "Rowboat";
    public const string Oar = "Oar";
    public const string SalingShip = "Saling Ship";
    public const string Sled = "Sled";
    public const string Wagon = "Wagon";
    public const string Warship = "Warship";

    //Service 

    public const string CoachCab = "CoachCab";
    public const string HirelingTrained = "Hireling, Trianed";
    public const string HirelingUntrained = "Hireling, Untrianed";
    public const string Messenger = "Messenger";
    public const string RoadOrGateToll = "Road or Gate Toll";
    public const string ShipsPassage = "Ship's Passage";
    public const string Spellcasting = "Spellcasting";
    #endregion ItemKeys
}
