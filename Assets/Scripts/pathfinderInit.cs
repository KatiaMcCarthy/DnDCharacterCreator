using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// *HasPrereq = look at later, skill has prereq 


public class pathfinderInit : MonoBehaviour {

    //For feats
    string tempName = "";
    string tempFeature = "";
    string tempDescription = "";
    string tempSpecial = "";
    string tempNormal = "";
    Image tempTable = null;

    //For Items

    string tempType = "";
    string tempitemName = "";
    int tempCost = 0;
    string tempDamageS = "";
    string tempDamageM = "";
    string tempCritical = "";
    float tempRange = 0.0f;
    float tempWeight = 0.0f;
    string tempDamageType = "";
    string tempSpecialAbility = "";
    string tempOther = "";
    int tempArmorBonus = 0;
    int tempMaxDexBonus = 0;
    int tempArmorCheckPenality = 0;
    int tempArcaneSpellFailure = 0;
    int tempSpeed20 = 0;
    int tempSpeed30 = 0;
    //temp description already initialized

    


	// Use this for initialization
	void Start () {


        InitalizeFeats();

    }

    void InitalizeFeats()
    {
        #region FeatInitalization
        //creates a feat called Acrobatic and adds it to the libary

        tempName = AppLibary.Acrobatic;
        tempFeature = "You get a +2 bonus on all Arcobatics and Fly checks. if you have 10 or more ranks in one of these skills it increases to +4 for that skill.";
        tempDescription = "You are skilled at leaping, jumping, and flying.";


        Feat acrobatic = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.Acrobatic))
        {
            AppLibary.featDictionary.Add(AppLibary.Acrobatic, acrobatic);
        }

        // end add Acrobatic

        //Acrobatic Steps
        //*HasPrereq
        tempName = AppLibary.AcrobaticSteps;
        tempFeature = "Whenever you move you may mmove through up to 15 feet of difficult terrain each round as if it was normal terrain. This effect stacks with those provided by Nimble Moves.";
        tempDescription = "You can easily move over and through obsticles.";

        Feat acrobaticSteps = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if(!AppLibary.featDictionary.ContainsKey(AppLibary.AcrobaticSteps))
        {
            AppLibary.featDictionary.Add(AppLibary.AcrobaticSteps, acrobaticSteps);
        }

        // end Acrobatic Steps

        //Alertness

        tempName = AppLibary.Alertness;
        tempFeature = "You get a +2 bonus on Perception and Sense Motive skill checks. If you have 10 or more ranks in one of these skills, the bonus increases to +4 for that skill.";
        tempDescription = "You often notice things that others may miss.";

        Feat alertness = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if(!AppLibary.featDictionary.ContainsKey(AppLibary.Alertness))
        {
            AppLibary.featDictionary.Add(AppLibary.Alertness, alertness);
        }

        //end Alertness

        //Alignment Channel

        tempName = AppLibary.AlignmentChannel;
        tempFeature = "Instead of its normal effect, you can choose to have your ability to channel energy, heal or harm outsiders of the chosen alignment subtype. You must make this choice each time you channel energy. If you choose to heal or harm creatures of the chosen alignment subtype, your channel energy has no effect on other creatures. The ammount of damage healed or dealt and the DC to halve the damge are uneffected.";
        tempDescription = "Chose Chaos, evil, good, or law. You can channel divine energy to affect outsiders that possess this subtype";
        tempSpecial = "You can gain this feat multipule times. Its effects do not stack, each time you take this feat, it applies to a new alignment subtype. Whenever you channel energy, you must choose what type to effect.";

        Feat alignmentChannel = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if(!AppLibary.featDictionary.ContainsKey(AppLibary.AlignmentChannel))
        {
            AppLibary.featDictionary.Add(AppLibary.AlignmentChannel, alignmentChannel);
        }

        tempSpecial = "";

        //End alignment channel

        //Animal affinity

        tempName = AppLibary.AnimalAffinity;
        tempFeature = "You geta a +2 bonus on all Handle Animal and Ride skill checks. If you have 10 or more ranks in one of these skills, the bonus increases to +4 for that skill.";
        tempDescription = "You are skilled at working with animals and mounts";

        Feat animalAffinity = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.AnimalAffinity))
        {
            AppLibary.featDictionary.Add(AppLibary.AnimalAffinity, animalAffinity);
        }

        //End animal affinity

        //Arcane Armor Mastery

        tempName = AppLibary.ArcaneArmorMastery;
        tempFeature = "As a swift action, reduce the arcane spell failure chance due to the armor you are wearing by 20% for any spells you cast this round. This bonus replaces, adn doesn not stack with, the bonus granted by Arcane Armor Training.";
        tempDescription = "You have mastered the ability to cast spells while wearing armor.";

        Feat arcaneArmorMastery = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if(!AppLibary.featDictionary.ContainsKey(AppLibary.ArcaneArmorMastery))
        {
            AppLibary.featDictionary.Add(AppLibary.ArcaneArmorMastery, arcaneArmorMastery);
        }

        //End Arcane Armor Mastery

        //Arcane Armor Training

        tempName = AppLibary.ArcaneArmorTraining;
        tempFeature = "As a swift action, reduce the arcane spell failure chance due to the armor you are wearing by 10$ for any spells you cast this round.";
        tempDescription = "You have learned how to cast spells while wearing armor.";

        Feat arcaneArmrorTraining = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if(!AppLibary.featDictionary.ContainsKey(AppLibary.ArcaneArmorTraining))
        {
            AppLibary.featDictionary.Add(AppLibary.ArcaneArmorTraining, arcaneArmrorTraining);
        }

        //End Arcane Armor Training

        //Arcane Strike

        tempName = AppLibary.ArcaneStrike;
        tempFeature = "As a swift action, you can imbune your weapons with a fraction of your power. For 1 round, your weapons deal +1 damages and are treated as magic for the purpose of overcoming damage reduction. For every five caster levels you possess, this bonus is increased by +1, to a maximum of +5 at 20th level.";
        tempDescription = "You draw upon your arcane power to enhance your weapons with magical energy.";

        Feat arcaneStrike = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if(!AppLibary.featDictionary.ContainsKey(AppLibary.ArcaneStrike))
        {
            AppLibary.featDictionary.Add(AppLibary.ArcaneStrike, arcaneStrike);
        }

        //End Arcane Strike

        //Armor Proficiency, Heavy

        tempName = AppLibary.ArmorProficiencyHeavy;
        tempFeature = "When you wear Heavy Armor, the armor check penalty applies only to Strength and Dexterity baised skill checks.";
        tempDescription = "You are skilled at wearing Heavy Armors.";
        tempSpecial = "A character who is wearing armor with which he is not proficient applies its armor check penalty to attack rolls and to all skill checks that involve moving.";

        Feat armorProficiencyHeavy = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if(!AppLibary.featDictionary.ContainsKey(AppLibary.ArmorProficiencyHeavy))
        {
            AppLibary.featDictionary.Add(AppLibary.ArmorProficiencyHeavy, armorProficiencyHeavy);
        }

        //End Armor Proficiency, Heavy

        //Armor Proficiency, Medium

        tempName = AppLibary.ArmorProficiencyMedium;
        tempFeature = "When you wear Medium Armor, the armor check penalty applies only to Strength and Dexterity baised skill checks.";
        tempDescription = "You are skilled at wearing Medium Armors";
        tempSpecial = "A character who is wearing armor with which he is not proficient applies its armor check penalty to attack rolls and to all skill checks that involve moving.";

        Feat armorProficiencyMedium = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if(!AppLibary.featDictionary.ContainsKey(AppLibary.ArmorProficiencyMedium))
        {
            AppLibary.featDictionary.Add(AppLibary.ArmorProficiencyMedium, armorProficiencyMedium);
        }

        //End Armor Proficency Medium

        //Armor Proficiency Light

        tempName = AppLibary.ArmorProficiencyLight;
        tempFeature = "When you wear Light Armor, the armor check penalty applies only to Strength and Dexterity baised skill checks.";
        tempDescription = "You are skilled at wearing Light Armor.";
        tempSpecial = "A character who is wearing armor with which he is not proficient applies its armor check penalty to attack rolls and to all skill checks that involve moving.";

        Feat armorProficiencyLight = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if(!AppLibary.featDictionary.ContainsKey(AppLibary.ArmorProficiencyLight))
        {
            AppLibary.featDictionary.Add(AppLibary.ArmorProficiencyLight, armorProficiencyLight);
        }

        tempSpecial = "";
        //End Armor Proficiency Light

        //Athletic

        tempName = AppLibary.Athletic;
        tempFeature = "You get a +2 bonus on Climb and Swim skill checks. If you have 10 or more ranks in one of these skills, the bonus increases to +4 for that skill.";
        tempDescription = "You possess inherent physical prowess.";

        Feat athletic = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if(!AppLibary.featDictionary.ContainsKey(AppLibary.Athletic))
        {
            AppLibary.featDictionary.Add(AppLibary.Athletic, athletic);
        }

        //End Athletic

        //Augment Summoning

        tempName = AppLibary.AugmentSummoning;
        tempFeature = "Each creature you conjure with any summon spell gains a +4 enhancement bonust to Strength and Constitution for the duration fo the spell that summoned it.";
        tempDescription = "Your summoned creatures are more powerful and robust.";

        Feat augmentSummoning = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.AugmentSummoning))
        {
            AppLibary.featDictionary.Add(AppLibary.AugmentSummoning, augmentSummoning);
        }

        //End Augment Summoning

        //Bleeding Critical

        tempName = AppLibary.BleedingCritical;
        tempFeature = "Whenever you score a critical hit with a slashing or piercing weapon, you opponent takes 2d6 points of bleed damage each round on his turn, in addition to the damage dealt by the critical hit. Bleed damage can be stopped by a DC 15 Heal skill check or through any magical healing. The effects of this feat stack.";
        tempDescription = "Your critical hits cause opponets to bleed profusely.";
        tempSpecial = "You can only apply the effects of one critical feat to a given critical hit unless you possess Critical Mastery.";

        Feat bleedingCritical = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.BleedingCritical))
        {
            AppLibary.featDictionary.Add(AppLibary.BleedingCritical, bleedingCritical);
        }

        tempSpecial = "";
        //End Bleeding Critical

        //Blind-Fight

        tempName = AppLibary.BlindFight;
        tempFeature = "In melle, every time you miss because of concealment, you can reroll you miss chance percentile roll one time to see if you actually hit. An invisible attacker gets no advantages related to hitting you in melee. That is you don't lose your Dexterity bonus to Armor Class, and the attacker doesn't get the usual +2 bonus for being invisible. The invisible attacker's bonuses still apply for ranged attacks, However. You do not need to make Acrobatics skill checks to move at full speed when blinded.";
        tempDescription = "You possess inherent physical prowess.";
        tempSpecial = "The Blind-Fight feat is of no use against a character who is the subject of a blink spell.";

        Feat blindFight = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.BlindFight))
        {
            AppLibary.featDictionary.Add(AppLibary.BlindFight, blindFight);
        }

        tempSpecial = "";

        //End Blind-Fight

        //Blinding Critical

        tempName = AppLibary.BlindingCritical;
        tempFeature = "Whenever you score a critial, your opponent is permanently blinded. A successful Fortitude save reduces this to dazzled for 1d4 rounds. The DC of this Fortitude save is equal to 10 + your base attack bonus. This feat has no effect on creatures that do not rely on eyes for sight or creatures with more than two eyes (although multipule critical hits might cause bliness, at the GM's discretion). Blindness can be cured by heal, regeneration, remove blindess, or similar ablities";
        tempDescription = "Your critical hits blind your opponents.";
        tempSpecial = "You can only apply the effects of one critical feat to a given critical hit unless you possess Critical Mastery.";

        Feat blindingCritical = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if(!AppLibary.featDictionary.ContainsKey(AppLibary.BlindingCritical))
        {
            AppLibary.featDictionary.Add(AppLibary.BlindingCritical, blindingCritical);
        }
        tempSpecial = "";

        //End Blinding Critical

        //Brew Potion

        tempName = AppLibary.BrewPotion;
        tempFeature = "You can create a potion of any 3rd-level or lower spell that you know and that targets one or more creatrues or objects. Brewing a potion takes 2 hours if its base price is 250gp or less, otherwize brewing a potion takes 1 day for each 1000gp in its base price. When you create a potion, you set the caster level, which must be sufficient to cast the spell in question and no higher than your own level. To brew a potion, you must use up raw materials costing one half this base price. See themagic item creation rules for more information. When you create a potion, you make any choices that you would normally make when casting the spell. Whoever drinks the potion is the target of the spell.";
        tempDescription = "You can create magic potions.";
        
        Feat brewPotion = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.BrewPotion))
        {
            AppLibary.featDictionary.Add(AppLibary.BrewPotion, brewPotion);
        }

        tempSpecial = "";

        //End Brew Potion

        //Catch Off-Guard

        tempName = AppLibary.CatchOffGuard;
        tempFeature = "You do not suffer any penalties for using an improvised melee weapon. Unarmed opponents are flat-footed against any attacks you make iwth an improvised melee weapon.";
        tempDescription = "Foes are surprised by your skilled use of unorthodox and improvised weapons.";

        Feat catchOffGuard = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if(!AppLibary.featDictionary.ContainsKey(AppLibary.CatchOffGuard))
        {
            AppLibary.featDictionary.Add(AppLibary.CatchOffGuard, catchOffGuard);
        }

        //End Catch off Guard

        //Channel Smite

        tempName = AppLibary.ChannelSmite;
        tempFeature = "Before you make an melee attack roll, you can choose to spend one use of your channel energy ability as a swift action. If you channel positive energy and you hit an undead creature, that creature takes an amount of additional damage equal to the damage dealt by you channel positive energy ability. If you channel negative energy and you hit a living creature, that creature takes an amount of additional damage equal to the damage dealt by your channel negative energy ability. Your target can make a Will save, as normal, to halve this additional damage. If your attack misses, the channel energy ability is sstill expended with no effect.";
        tempDescription = "You can channel your divine energy through a melee weapon you wield.";

        Feat channelSmite = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ChannelSmite))
        {
            AppLibary.featDictionary.Add(AppLibary.ChannelSmite, channelSmite);
        }

        //End Channel Smite

        //Cleave

        tempName = AppLibary.Cleave;
        tempFeature = "As a standard action, you can make a single attack at your full base attack bonus against a foe within reach. If you hit, you deal damage normally and can make an additional attack (using your full base attack bonus) that is adjacent to the first and also within reach. You can only make one additional attack per round with this feat. When you use this feat, you take a -2 penalty to your Armor Class until your next turn.";
        tempDescription = "You can strike two adjacent foes with a single swing.";

        Feat cleave = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.Cleave))
        {
            AppLibary.featDictionary.Add(AppLibary.Cleave, cleave);
        }

        //End Cleave

        //Combat Casting

        tempName = AppLibary.CombatCasting;
        tempFeature = "You get a +4 bonus on concentration checks made to cast a spell or use a spell-like-ability when casting on the defensive or while grappled.";
        tempDescription = "You are adept at spellcasting when threatened or distracted.";

        Feat combatCasting = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.CombatCasting))
        {
            AppLibary.featDictionary.Add(AppLibary.CombatCasting, combatCasting);
        }

        //End combat casting

        //Combat Expertise

        tempName = AppLibary.CombatExpertise;
        tempFeature = "You can choose to take a -1 penalty on melee attack rolls and combat maneuver checks to gain a +1 dodge bonus to your Armor Class. When your base attack bonus reaches +4, and every +4 thereafter, the penalty increases by -1 and the dodge bonus increases by +1. You can only choose to use this feat when you declare that you are making an attack or a full-attack action wiht a melee weapon. The effects of this feat last until your next turn.";
        tempDescription = "You can increase your defense at the expense of your accuracy.";

        Feat combatExpertise = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.CombatExpertise))
        {
            AppLibary.featDictionary.Add(AppLibary.CombatExpertise, combatExpertise);
        }

        //End Combat Expertise

        //Combat Reflexes

        tempName = AppLibary.CombatReflexes;
        tempFeature = "You may make a number of additional attacks of opportunity per round equal to your dexterity bonus. With this feat, you may also make attacks of opportunity while flat-footed.";
        tempDescription = "You can make additional attacks of opportunity.";
        tempSpecial = "The Combat Reflexes feat does not allow a rougue to use her opportunist ability more than once a round.";

        Feat combatReflexes = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.CombatReflexes))
        {
            AppLibary.featDictionary.Add(AppLibary.CombatReflexes, combatReflexes);
        }

        tempSpecial = "";

        //End Combat Reflexes

        //Command Undead

        tempName = AppLibary.CommandUndead;
        tempFeature = "As a standard action, you can use one of your uses of channel negative energy to enslave undead within 30 feet. Undead recive a Will save to negate this effect. The DC for this Will save is equal to 10 + 1/2 your cleric level + your Charisma modifier. Undead that fail their saves fall under your control, obeying your commands to the best of their ability, as if under the effects of control undead. Intelligent undead receive an new saving throw each day to resist your command. You can control any number of undead, so long as their total Hit Dice do not exceed your cleric level. If you use channel energy in this way, it has no other effect(it does not heal or harm nearby creatures). If an undead creature is under the control of another creature, you must make an opposed Charisma check whenever your orders conflict.";
        tempDescription = "Using foul powers of necromancy, you can command undead creatures, making them into your servants.";

        Feat commandUndead = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.CommandUndead))
        {
            AppLibary.featDictionary.Add(AppLibary.CommandUndead, commandUndead);
        }

        //End Command Undead

        //Craft Magic Arms and Armor

        tempName = AppLibary.CraftMagicArmsAndArmor;
        tempFeature = "You can create magic weapons, armor, or shields. Enhancing a weapon, suit of armor, or shield takes one day for each 1,000gp in the price of its magical features. To enhance a weapon, suit of armor, or shield, you must use up raw materials costing half of this total price. See the magic item creation rules for more information. The weapon, armor, or shield to be enhanced must be a masterwork item that you provide. Its cost is not included in the above cost. You can also mend a broken or destroyed magic weapon, suit of armor, or shield if it is one that you could make. Doing so costs half the raw materials and half of the time it would take to craft that item in the first place.";
        tempDescription = "You can create magic armor, shields, and weapons.";

        Feat craftMagicArmsAndArmor = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.CraftMagicArmsAndArmor))
        {
            AppLibary.featDictionary.Add(AppLibary.CraftMagicArmsAndArmor, craftMagicArmsAndArmor);
        }

        //End Craft Magic Arms and Armor

        //Craft Rod

        tempName = AppLibary.CraftRod;
        tempFeature = "You can create magic rods. Crafting a rod takes 1 day for each 1,000gp in its base price. To craft a rod, you must use up raw materials consting half of its base price. See the magic item creation rules for more information.";
        tempDescription = "You can create magic rods.";

        Feat craftRod = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.CraftRod))
        {
            AppLibary.featDictionary.Add(AppLibary.CraftRod, craftRod);
        }

        //End Craft Rod

        //Craft Staff

        tempName = AppLibary.CraftStaff;
        tempFeature = "You can create any staff whose prerequisites you meet. Crafting a staff takes 1 day for each 1,000gp in its base price. To craft a staff, you must use up raw materials costing half of its base price. A newly created staff has 10 charges. See the magic item creation rules for more information.";
        tempDescription = "You can create magic Staffs.";

        Feat craftStaff = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.CraftStaff))
        {
            AppLibary.featDictionary.Add(AppLibary.CraftStaff, craftStaff);
        }

        //End Craft Staff

        //Craft Wand

        tempName = AppLibary.CraftWand;
        tempFeature = "You can create a wand of any 4th-level or lower spellthat you know. Crafting a staff takes 1 day for each 1,000gp in its base price. To craft a staff, you must use up raw materials costing half of its base price. A newly created staff has 50 charges. See the magic item creation rules for more information.";
        tempDescription = "You can create magic Wands.";

        Feat craftWand = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.CraftWand))
        {
            AppLibary.featDictionary.Add(AppLibary.CraftWand, craftWand);
        }

        //End Craft Wand

        //Craft Wondrous Item

        tempName = AppLibary.CraftWondrousItem;
        tempFeature = "You can crate a wide-variety o fmagic wondrous items. Crafting a staff takes 1 day for each 1,000gp in its base price. To craft a staff, you must use up raw materials costing half of its base price. See the magic item creation rules for more information. You can also mend a broken or destroyed wondrous item if it is one that you could make. Doing so conts half the raw materials and half the timie it would take to craft that item.";
        tempDescription = "You can create wondrous items, a type of magic item.";

        Feat craftWondrousItem = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.CraftWondrousItem))
        {
            AppLibary.featDictionary.Add(AppLibary.CraftWondrousItem, craftWondrousItem);
        }

        //End Craft Wondrous Item

        //Critical Focus

        tempName = AppLibary.CriticalFocus;
        tempFeature = "You receive a +4 circumstance bonus on attack rolls made to confim critical hits.";
        tempDescription = "You are trained in the art of causing pain.";

        Feat criticalFocus = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.CriticalFocus))
        {
            AppLibary.featDictionary.Add(AppLibary.CriticalFocus, criticalFocus);
        }

        //End Critical Focus

        //Critical Mastery

        tempName = AppLibary.CriticalMastery;
        tempFeature = "When you score a critical hit, you can apply the effects of two crtical feats in addition to the damage dealt.";
        tempDescription = "Your critical hits cause two additional effects.";

        Feat criticalMastery = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.CriticalMastery))
        {
            AppLibary.featDictionary.Add(AppLibary.CriticalMastery, criticalMastery);
        }

        //End Critical Mastery

        //Dazzling Display

        tempName = AppLibary.DazzlingDisplay;
        tempFeature = "While wielding the weapon in which you have Weapon Focus, you can preform an bewildering show of prowess as a full-round action. Make an Intimidate check to demoralize all foes within 30 feet who can see your display.";
        tempDescription = "Your skill with your favored weapoin can frighten enemies.";

        Feat dazzlingDisplay = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.DazzlingDisplay))
        {
            AppLibary.featDictionary.Add(AppLibary.DazzlingDisplay, dazzlingDisplay);
        }

        //End Dazzling Display

        //Deadly Aim

        tempName = AppLibary.DeadlyAim;
        tempFeature = "You can choose to take a -1 penalty on all ranged attack rolls to gain a +2 bonus on all ranged damage rolls. When your base attack bonus reaches a +4, and every +4 thereafter, the penalty increases by -1 and the bonuse to damage increases by +2. You must choose to use this feat before making an attack roll and its effects last unitl your next turn. The bonus damage does not apply to touch attacks or effects that do not deal hit point damage.";
        tempDescription = "With a well-placed strike, you can bring a swift and painful end to most foes.";

        Feat deadlyAim = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.DeadlyAim))
        {
            AppLibary.featDictionary.Add(AppLibary.DeadlyAim, deadlyAim);
        }

        //End Deadly Aim

        //Deadly Stroke

        tempName = AppLibary.DeadlyStroke;
        tempFeature = "As a standard action, make a single attack with the weapon for which you have Greater Weapon Focus against a stunned or flat-footed opponent. If you hit, you deal double the normal damage and the target takes 1 point of Consitution bleed. The additional damage and bleed is not multiplied on a critical hit.";
        tempDescription = "With a well-placed strike, you can bring a swift and painful end to most foes.";

        Feat deadlyStroke = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.DeadlyStroke))
        {
            AppLibary.featDictionary.Add(AppLibary.DeadlyStroke, deadlyStroke);
        }

        //End Deadly Stroke

        //Deafening Critical

        tempName = AppLibary.DeafeningCritical;
        tempFeature = "Whenever you score a critical hit against an opponent, the victim is permanently deafened. A successful Fortitude save deduceds the deafness to 1 round. The DC of this Fortitude save is equal to 10+ your base attack bonus. This feat has no effect on deaf creatures. This deafness can be cured by heal, regeneration, remove deafness , or a simular ability.";
        tempDescription = "Your critical hits cause enemeis to lose their hearing.";
        tempSpecial = "you can only aply the effects of one critical feat to a given critical hit unless you possess Critical Mastery.";

        Feat deafeningCritical = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.DeafeningCritical))
        {
            AppLibary.featDictionary.Add(AppLibary.DeafeningCritical, deafeningCritical);
        }

        tempSpecial = "";

        //End Deafening Critical

        //Deceitful
        tempName = AppLibary.Deceitful;
        tempFeature = "You get a +2 bonus on all Bluff and Disguise skill checks. If you have 10 or more ranks in one of these kills, the bonus increases to +4 for that skill.";
        tempDescription = "You arre skilled at deceiving others, both with the spoken word and with physical disguises.";

        Feat deceitful = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.Deceitful))
        {
            AppLibary.featDictionary.Add(AppLibary.Deceitful, deceitful);
        }

        //End Deceitful

        //Defensive Combat Training

        tempName = AppLibary.DefensiveCombatTraining;
        tempFeature = "You treat your total Hit Dice as your base attack bonus when calculating your Combat Maneuver Defense.";
        tempDescription = "You excel at defending yourself from all manner of combat maneuvers.";

        Feat defensiveCombatTraining = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.DefensiveCombatTraining))
        {
            AppLibary.featDictionary.Add(AppLibary.DefensiveCombatTraining, defensiveCombatTraining);
        }

        //End Defensive Combat Training

        //Deflect Arrows

        tempName = AppLibary.DeflectArrows;
        tempFeature = "You must have at least one hand free (holding nothing) to use this feat. Once per round when you would normaly be hit with an attack from a ranged weapon, you may deflect it so that you take no damage from it. You must be aware of the attack and not flat-footed. Attempting to deflect a ranged attack doesn't count as an action. Unusually massive ranged wapons (such as boulders or ballista bolts) and ranged attacks generated by natural attacks or spell effects cant's be deflect.";
        tempDescription = "You can knock arrows and other projectiles off course, preventing them from hitting you.";

        Feat deflectArrows = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.DeflectArrows))
        {
            AppLibary.featDictionary.Add(AppLibary.DeflectArrows, deflectArrows);
        }

        //End Deflect Arrows

        //Deft Hands

        tempName = AppLibary.DeftHands;
        tempFeature = "You get a +2 bonus on Disable Device and Sleight of Hand skill checks. If you have 10 or more ranks in one of these skills, the bonus increases to +4 for that skill.";
        tempDescription = "You have exceptional manual dexterity.";

        Feat deftHands = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.DeftHands))
        {
            AppLibary.featDictionary.Add(AppLibary.DeftHands, deftHands);
        }

        //End Deft Hands

        //Diehard

        tempName = AppLibary.Diehard;
        tempFeature = "When your hit point total is below 0, but you are not dead, you automatically stablize. You do not need to make a Constitution check each round to avoid losing additional hit points. You may choose to act as if you were disabled rather than dying. You must make this decision as soon as you are reduced to negitive hit points (even if its not your turn) If you do not choose to act as if  you were disabled, you immediately fall unconscious. When using this feat, you are staggered. You can take a move action without further injuring yourself, but if you preform any standard action (or any other action deamed as strenuous, including some swift actions, such as casting a quickened spell) you take 1 point of damage after compleating the act. If you negative hit points are equal to or creater than your Constitution score, you immediately die.";
        tempDescription = "You are especially hard to kill. Not only do your wounds automatically stabilize when grievously injured, but you can remain conscious and continue to act even at death's door.";

        Feat diehard = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.Diehard))
        {
            AppLibary.featDictionary.Add(AppLibary.Diehard, diehard);
        }

        //End Diehard

        //Disruptive

        tempName = AppLibary.Disruptive;
        tempFeature = "The DC to cast spells defensivly increases by +4 for all enemies that are within your threatened area. This increase to casting spells defensivly only applies if you are aware of the enemy's location and are capable of taking an attack of opportunity. If you can only take one attack of opportunity per round and have already used that attack, this increase does not apply.";
        tempDescription = "Your training makes it difficult for enemy spellcasters to safely cast spells near you.";

        Feat disruptive = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.Disruptive))
        {
            AppLibary.featDictionary.Add(AppLibary.Disruptive, disruptive);
        }

        //End Disruptive

        //Dodge

        tempName = AppLibary.Dodge;
        tempFeature = "You gain a +1 dodge bonus to your AC. A condition that makes you lose your Dex bonus to AC also makes you lose the benefits of this feat.";
        tempDescription = "Your training makes it difficult for enemy spellcasters to safely cast spells near you.";

        Feat dodge = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.Dodge))
        {
            AppLibary.featDictionary.Add(AppLibary.Dodge, dodge);
        }

        //End Dodge

        //Double Slice

        tempName = AppLibary.DoubleSlice;
        tempFeature = "Add your Strength bonus to damage rolls made with your off-hand weapon.";
        tempDescription = "Your off-hand weapon while daul-wielding strikes with greater power.";

        Feat doubleSlice = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.DoubleSlice))
        {
            AppLibary.featDictionary.Add(AppLibary.DoubleSlice, doubleSlice);
        }

        //End Double Slice

        //Elemental Channel

        tempName = AppLibary.ElementalChannel;
        tempFeature = "Instead of its normal effect, you can choose to have your ability to channel energy heal or harm outsiders of your chosen elemental subtype. You must make this choice each time your channel energy. If you choose to heal or harm creatrues of your elemental subtype, your channel energy has no affect on other creatures. The amount of damage healed or dealt the DC to halve the damage is otherwise unchanged.";
        tempDescription = "Choose one elemental subtype, such as air, earth, fire, or water. You can channel your divine energy to harm or hael outsiders that possess your chosen elemental subtype.";

        Feat elementalChannel = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ElementalChannel))
        {
            AppLibary.featDictionary.Add(AppLibary.ElementalChannel, elementalChannel);
        }

        //End Elemental Channel

        //Empower Spell

        tempName = AppLibary.EmpowerSpell;
        tempFeature = "All variable, numeric effects of an empowered spell are increased by half, including bonuses to thoese dice rolls. Saving throws and opposed rolls are not affected, nor are spells without random variables. An empowered spell uses up a spell slot two levels higher than the spell's actual level.";
        tempDescription = "You can increase the power of your spells, causing them to deal more damage.";

        Feat empowerSpell = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.EmpowerSpell))
        {
            AppLibary.featDictionary.Add(AppLibary.EmpowerSpell, empowerSpell);
        }

        //End Empower Spell

        //Endurance

        tempName = AppLibary.Endurance;
        tempFeature = "You gain a +4 bonus on the following checks and saves: Swim checks made to resist nonleathal damage from exhaustion; Constitution checks made to continue running; Constitution checks made to advoid nonleathal damage from a forced march; Constitution checks made to hold your breath; Constitution checks made to avoid nonleathal damage from starvation or thirst; Fortitude saves made to avoid nonleathal damage from hod or cold environments; and Fortitude saves made to resist damage from suffocation. You may sleep in light or medium armor without becoming fatiugued.";
        tempDescription = "Harsh conditions or long exertions do not easily tire you.";

        Feat endurance = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.Endurance))
        {
            AppLibary.featDictionary.Add(AppLibary.Endurance, endurance);
        }

        //End Endurance

        //Enlarge Spell

        tempName = AppLibary.EnlargeSpell;
        tempFeature = "You can alter a spell with a range of close, medium, or long to increase its range by 100%. An enlarged spell with a range of close now has a range for 50ft + 5ft/level, while medium-range spells have a range of 200ft + 20ft/level and long-range spells have a range of 800ft + 80ft/level. An enlarged spell uses up a spell slot one level higher than the spell's actual level. Spells whoes ranges are not defined by distance, as well as spells whose ranges are not close, medium, or long, do not benefint from this feat.";
        tempDescription = "You can increase the range of your spells.";

        Feat enlargeSpell = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.EnlargeSpell))
        {
            AppLibary.featDictionary.Add(AppLibary.EnlargeSpell, enlargeSpell);
        }

        //End Enlarge Spell

        //Eschew Materials

        tempName = AppLibary.EschewMaterials;
        tempFeature = "You can cast any spell with a material component costing 1 gp or less without needing that component. The casting of the spell still provokes attacks of opportunity as normal. If the spell requires a material component that costs more that 1 gp, you must have the material component on hand to cast the spell, as normal.";
        tempDescription = "You can cast many spells without needing to utilize minor material components.";

        Feat eschewMaterials = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.EschewMaterials))
        {
            AppLibary.featDictionary.Add(AppLibary.EschewMaterials, eschewMaterials);
        }

        //End Eschew Materials

        //Exhausting Critical

        tempName = AppLibary.ExhaustingCritical;
        tempFeature = "When you score a critical hit on a foe, your target immediately becomes exhausted. This feat has no effect on exhausted creatures.";
        tempDescription = "Your critical hits cause opponents to become exhausted.";
        tempSpecial = "You can only apply the effects of one critical feat to a given critical hit unless your possess the Critical Mastery feat.";
     
        Feat exhaustingCritical = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ExhaustingCritical))
        {
            AppLibary.featDictionary.Add(AppLibary.ExhaustingCritical, exhaustingCritical);
        }

        tempSpecial = "";

        //End Exhausting Critical

        //Exotic Weapon Proficiency

        tempName = AppLibary.ExoticWeaponProficiency;
        tempFeature = "Choose one type of exotic weapon, such as the spiked chain or whip. You make attack rolls with the chosen weapon normally.";
        tempDescription = "You understand how to use a chosen type of exotic weapon in combat, and can utilize any special tricks or qualities that exotic weapon might allow.";
        tempSpecial = "You can gain Exotic Weapon Proficiency multiple times. Each time you take the feat, it applies to a new type of exotic weapon.";

        Feat exoticWeaponProficiency = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ExoticWeaponProficiency))
        {
            AppLibary.featDictionary.Add(AppLibary.ExoticWeaponProficiency, exoticWeaponProficiency);
        }

        tempSpecial = "";

        //End Exotic Weapon Proficiency

        //Extend Spell

        tempName = AppLibary.ExtendSpell;
        tempFeature = "An extended spell lasts twice as long as normal. A spell with a duration of concentration, instantaneous, or permanent is not affected by this feat. An extended spell uses up a spell slot one level higher than the spell's actual level.";
        tempDescription = "You canmake your spells last twice as long.";

        Feat extendSpell = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ExtendSpell))
        {
            AppLibary.featDictionary.Add(AppLibary.ExtendSpell, extendSpell);
        }

        //End Extend Spell

        //Extra Channel

        tempName = AppLibary.ExtraChannel;
        tempFeature = "You can channel energy two additional times per day.";
        tempDescription = "You can channel divine energy more often.";
        tempSpecial = "If a paladin with the ability to channel positive energy takes this feat, she can use lay on hands four additional times a day, but only to channel positive energy.";

        Feat extraChannel = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ExtraChannel))
        {
            AppLibary.featDictionary.Add(AppLibary.ExtraChannel, extraChannel);
        }

        tempSpecial = "";

        //End Extra Channel

        //Extra Ki

        tempName = AppLibary.ExtraKi;
        tempFeature = "Your Ki pool increases by 2.";
        tempDescription = "You can use your ki pool more times per day than most.";
        tempSpecial = "You can gain Extra Ki multipule times. Its effects stack.";

        Feat extraKi = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ExtraKi))
        {
            AppLibary.featDictionary.Add(AppLibary.ExtraKi, extraKi);
        }

        tempSpecial = "";

        //End Extra Ki

        //Extra Lay On Hands

        tempName = AppLibary.ExtraLayOnHands;
        tempFeature = "You can use your lay on hands ability two additional times per day.";
        tempDescription = "You can use your Lay On Hands ability more often.";
        tempSpecial = "You can gain Extra Lay On Hands multiple times. Its effects stack.";

        Feat extraLayOnHands = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ExtraLayOnHands))
        {
            AppLibary.featDictionary.Add(AppLibary.ExtraLayOnHands, extraLayOnHands);
        }

        tempSpecial = "";

        //End Extra Lay on Hands

        //Extra Mercy

        tempName = AppLibary.ExtraMercy;
        tempFeature = "Select one additional mercy for which you qualify. When you use lay on hands to heal damage to one target, it also receives the additional effects of this mercy.";
        tempDescription = "Your lay on hands ability adds an additional mercy.";
        tempSpecial = "You can gain this feat multiple times. Its effects do not stack. Each time you take this feat, select a new mercy.";

        Feat extraMercy = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ExtraMercy))
        {
            AppLibary.featDictionary.Add(AppLibary.ExtraMercy, extraMercy);
        }

        tempSpecial = "";

        //Extra Mercy

        //Extra Performance

        tempName = AppLibary.ExtraPerformance;
        tempFeature = "You can use your bardic performance ability for 6 additional rounds per day.";
        tempDescription = "You can use your bardic performance ability more often.";
        tempSpecial = "You can gain Extra Performance multiple times. Its effects stack.";

        Feat extraPreformance = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ExtraPerformance))
        {
            AppLibary.featDictionary.Add(AppLibary.ExtraPerformance, extraPreformance);
        }

        tempSpecial = "";

        //End Extra Performance

        //Extra Rage

        tempName = AppLibary.ExtraRage;
        tempFeature = "You can rage for 6 additional rounds per day.";
        tempDescription = "You can use your rage ability more than normal.";
        tempSpecial = "You can gain Extra Rage multiple times. Its effects stack.";

        Feat extraRage = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ExtraRage))
        {
            AppLibary.featDictionary.Add(AppLibary.ExtraRage, extraRage);
        }

        tempSpecial = "";

        //End Extra Rage

        //Far Shot

        tempName = AppLibary.FarShot;
        tempFeature = "You only suffer a -1 penalty per full range increment between you and your target when using a ranged weapon.";
        tempDescription = "You are more accurate at longer ranges.";
        tempNormal = " (Normaly this is a -2 penalty).";

        Feat farShot = new Feat(tempName, tempFeature, tempDescription, tempSpecial, tempNormal);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.FarShot))
        {
            AppLibary.featDictionary.Add(AppLibary.FarShot, farShot);
        }

        //End Far Shot

        //Fleet

        tempName = AppLibary.Fleet;
        tempFeature = "While you are wearing light or no armor, your base speed increases by 5 feet. You lose the benefits of this feat if you carry a medium or heavy load.";
        tempDescription = "You are faster than most.";

        Feat fleet = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.Fleet))
        {
            AppLibary.featDictionary.Add(AppLibary.Fleet, fleet);
        }

        //End Fleet

        //Forge Ring

        tempName = AppLibary.ForgeRing;
        tempFeature = "You can create magic rings. Crafting a ring takes 1 day for each 1000gp in its base price. To craft a ring, you must use up raw materials costing half of the base price. See the magic item creation rules for more information. You can also mend a broken ring if it is one that you could make. Doing so costs half the raw materials and half the time it would take to forge that ring in the first place.";
        tempDescription = "You can create magic rings.";

        Feat forgeRing = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ForgeRing))
        {
            AppLibary.featDictionary.Add(AppLibary.ForgeRing, forgeRing);
        }

        //End Forge Ring

        //Gorgon's Fist

        tempName = AppLibary.GorgonsFist;
        tempFeature = "As a standard action, make a single unarmed melee attack against a foe whoes speed is reduced (such as from Scorpion Style). If the attack hits, you deal damage normally and the target is staggered until the end of your next turn unless it makes a Fortitude saving throw (DC 10 + 1/2 your chracter levvel + your Wis modifier). This feat has no effect on targets that are staggered.";
        tempDescription = "With one well-placed blow, you leave your target reeling.";

        Feat gorgonsFist = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.GorgonsFist))
        {
            AppLibary.featDictionary.Add(AppLibary.GorgonsFist, gorgonsFist);
        }

        //End Gorgon's Fist

        //Great Cleave

        tempName = AppLibary.GreatCleave;
        tempFeature = "As a standard action, you can make a single attack at your full base attack bonus against a foe within reach. If you hit, you deal damage normally and can make an additional attack ( using your full base attack bonus) against a foe that is adjacent to the previous foe and also within reach. If you hit, you can continue to make attacks against foes adjacent to the previous foe, so long as they are within your reach. You cannot attack and individual foe more than once during this attack action. When you use this feat, you take a -2 penalty to your Armor Class until your next turn.";
        tempDescription = "You can strike many adjacent foes with a single blow.";

        Feat greatCleave = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.GreatCleave))
        {
            AppLibary.featDictionary.Add(AppLibary.GreatCleave, greatCleave);
        }

        //End Great Cleave

        //Great Fortitude

        tempName = AppLibary.GreatFortitude;
        tempFeature = "You gain a +2 bonus on all Fortitude saving throws.";
        tempDescription = "You are resistant to poisons, diseases, and other maladies.";

        Feat greatFortitude = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.GreatFortitude))
        {
            AppLibary.featDictionary.Add(AppLibary.GreatFortitude, greatFortitude);
        }

        //End Great Fortitude

        //Greater Bull Rush

        tempName = AppLibary.GreaterBullRush;
        tempFeature = "You receive a +2 bonus on checks made to bull rush a foe. this bonus stacks with the bonus granted by Improved Bull Rush. Whenever you bull rush an opponent, his movement provokes attacks of oppertunity from all of your allies (but not you). Normaly they dont provoke attacks of opportunity";
        tempDescription = "Your bull rush attacks throw enemies off balance.";

        Feat greaterBullRush = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.GreaterBullRush))
        {
            AppLibary.featDictionary.Add(AppLibary.GreaterBullRush, greaterBullRush);
        }

        //End Greater Bull Rush

        //Greater Disarm

        tempName = AppLibary.GreaterDisarm;
        tempFeature = "You receive a +2 bonus on checks made to disarm a foe. This bonus stacks with the bonus granted by Improved Disarm. Whenever you successfully disarm an opponent, the weapon lands 15 feet away from its previous wielder, in a random direction.";
        tempDescription = "You can knock weapons far from an enemy's grasp.";
        tempNormal = "Normaly disarmed weapons land at the opponents feet.";

        Feat greaterDisarm = new Feat(tempName, tempFeature, tempDescription, tempSpecial, tempNormal);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.GreaterDisarm))
        {
            AppLibary.featDictionary.Add(AppLibary.GreaterDisarm, greaterDisarm);
        }

        //End Greater Disarm

        //Greater Grapple

        tempName = AppLibary.GreaterGrapple;
        tempFeature = "You receive a +2 bonus on checks made to grapple a foe. This bonus stacks with the bonus granted by Improved Grapple. Once you have grappled a creature, maintaining the grapple is a move action. This feat allows you to make two grapple checks each round (to move, harm, or pin your opponent), but you are not required to make two checks. You only need to succeed at one of these checks to maintian the grapple.";
        tempDescription = "Maintaining a grapple is second nature to you.";
        tempNormal = "Maintaining the grapple is a standard action).";

        Feat greaterGrapple = new Feat(tempName, tempFeature, tempDescription, tempSpecial, tempNormal);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.GreaterGrapple))
        {
            AppLibary.featDictionary.Add(AppLibary.GreaterGrapple, greaterGrapple);
        }

        //End Greater Grapple

        //Greater Overrun

        tempName = AppLibary.GreaterOverrun;
        tempFeature = "You receive a +2 bonus on checks made to overrun a foe. This bonus stacks with the bonus granted by Improved Overrun. Whnever you overrun opponents, they provoke attacks of opportunity if they are knocked prone by your overrun.";
        tempDescription = "Enemies must dive to avoid your dangerous move.";
        tempNormal = "Normaly when knocked prone by your overrun they do not provoke attacks of opportunity.";

        Feat greaterOverrun = new Feat(tempName, tempFeature, tempDescription, tempSpecial, tempNormal);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.GreaterOverrun))
        {
            AppLibary.featDictionary.Add(AppLibary.GreaterOverrun, greaterOverrun);
        }

        //End Greater Overrun

        //Greater Penetrating Strike

        tempName = AppLibary.GreaterPenetratingStrike;
        tempFeature = "Your attacks made with weapons selected with Weapon Focus ignore up to 10 points of damage reduction. this ammount is reduced to 5 points for damage reduciton with out a type (such as DR 10/-).";
        tempDescription = "Your attacks penetrate the defenses of most foes.";

        Feat greaterPenetratingStrike = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.GreaterPenetratingStrike))
        {
            AppLibary.featDictionary.Add(AppLibary.GreaterPenetratingStrike, greaterPenetratingStrike);
        }

        //End Greater Penetrating Strike

        //Greater Shield Focus

        tempName = AppLibary.GreaterSheildFocus;
        tempFeature = "Increase the AC bonus grated by any shield you are using by 1. This bonus stacks with the bonus granted by Shield Focus.";
        tempDescription = "You are skilled at deflecting blows with your shield.";

        Feat greaterShieldFocus = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.GreaterSheildFocus))
        {
            AppLibary.featDictionary.Add(AppLibary.GreaterSheildFocus, greaterShieldFocus);
        }

        //End Greater Shield Focus

        //Greater Spell Focus

        tempName = AppLibary.GreaterSpellFocus;
        tempFeature = "Add +1 to the Difficulty Class for all saving throws against spells from the school of magic you select This bonus stacks with the bonus from Spell Focus.";
        tempDescription = "Choose a school of magic to which you have already applied to the Spell Focus feat. Any spells you cast of this school are very hard to resist.";
        tempSpecial = "You can gain this feat multiple times. Its effects do not stack. Each time you take this feat, it applies to a new school to which you already have applied the Spell Focus feat.";

        Feat greaterSpellFocus = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.GreaterSpellFocus))
        {
            AppLibary.featDictionary.Add(AppLibary.GreaterSpellFocus, greaterSpellFocus);
        }

        tempSpecial = "";

        //End Greater Spell Focus

        //Greater Spell Penetration

        tempName = AppLibary.GreaterSpellPenetration;
        tempFeature = "You get a +2 bonus on caster level checks (1d20 + caster level) made to overcome a creature's spell resistance. This bonus stacks with the one from Spell Penetration.";
        tempDescription = "Your spells break through spell resistance much more easily than most.";

        Feat greaterSpellPenetration = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.GreaterSpellPenetration))
        {
            AppLibary.featDictionary.Add(AppLibary.GreaterSpellPenetration, greaterSpellPenetration);
        }

        //End Greater Spell Penetration

        //Greater Sunder

        tempName = AppLibary.GreaterSunder;
        tempFeature = "You receive a +2 bonus on checks made to sunder an item. This bonus stacks with the bonus granted by Improved Sunder. Whenever you sunder to destroy a weapon, shield or suit of armor, any excess dmage is applied to the item's wielder. No damage is transferred if you decide to leave the item with 1 hit point.";
        tempDescription = "Your devastating strikes cleave through weapons and armor and into their wielders, damaging both item and wielder alike in a single terrific strike.";

        Feat greaterSunder = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.GreaterSunder))
        {
            AppLibary.featDictionary.Add(AppLibary.GreaterSunder, greaterSunder);
        }

        //End Greater Sunder

        //Greater Trip

        tempName = AppLibary.GreaterTrip;
        tempFeature = "You receive a +2 bonus on checks made to trip a foe. This bonus stacks with the bonus granted by Improved Trip. Whenever you sucessfully trip an opponent, that opponent provokes attacks of opportunity.";
        tempDescription = "You can make free attacks on foes that you knock down.";
        tempNormal = "Normaly if tripped an opponet does not provoke attacks of opportunity.";

        Feat greaterTrip = new Feat(tempName, tempFeature, tempDescription, tempSpecial, tempNormal);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.GreaterTrip))
        {
            AppLibary.featDictionary.Add(AppLibary.GreaterTrip, greaterTrip);
        }

        //End Greater Trip

        //Greater Two-Weapon Fighting

        tempName = AppLibary.GreaterTwoWeaponFighting;
        tempFeature = "You get a third attack with your off-hand weapon, abit at a -10 penalty.";
        tempDescription = "You are incedibly skilled at fighting with two weapons at the same time.";

        Feat greaterTwoWeaponFighting = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.GreaterTwoWeaponFighting))
        {
            AppLibary.featDictionary.Add(AppLibary.GreaterTwoWeaponFighting, greaterTwoWeaponFighting);
        }

        //End Greater Two-Weapon Fighting

        //Greater Vital Strike

        tempName = AppLibary.GreaterVitalStrike;
        tempFeature = "When you use the attack acton, you can make one attack at your highest base attack bonus that deals additional damage. Roll the weapon's damage dice for the attack four times and add the rustlts togeather before adding bonuses for Strength, weapon abilities (such as flaming), percision-based damgage (such as sneak attack), and other damage bonuses. These extra deapon damage dice are not multiplied on a critical hit, but are added to the total.";
        tempDescription = "You can make a single attack that deals incredible damage.";

        Feat greaterVitalStrike = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.GreaterVitalStrike))
        {
            AppLibary.featDictionary.Add(AppLibary.GreaterVitalStrike, greaterVitalStrike);
        }

        //End Greater Vital Strike

        //Greater Weapon Focus

        tempName = AppLibary.GreaterWeaponFocus;
        tempFeature = "You gain a +1 bonus on attack rolls you make using the selected weapon. This bonus stacks with other bonuses on attack rolls, including those form Weapon Focus.";
        tempDescription = "Choose one type of weapon (including unarmed strike or grapple) for which you have already selected Weapon Focus. You are a master at your chosen weapon.";
        tempSpecial = "You can gain Greater Weapon Focus multipule times. Its effects do not stack. Each time you take the feat, it applies to a new type of weapon.";

        Feat greaterWeaponFocus = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.GreaterWeaponFocus))
        {
            AppLibary.featDictionary.Add(AppLibary.GreaterWeaponFocus, greaterWeaponFocus);
        }

        tempSpecial = "";

        //End Greater Weapon Focus

        //Greater Weapon Specilization

        tempName = AppLibary.GreaterWeaponSpecialization;
        tempFeature = "You gain a +2 bonus on all damage rolls you make using the selected weapon. This bonus to damage stacks with other damage roll bonuses, including any you gain form Weapon Specilization.";
        tempDescription = "Choose one type of weapon (including Unarmed Strike and Grapple) for which you posses the Weapon Specialization feat. Your attacks with the chosen weapon are more devastating than normal.";
        tempSpecial = "You can gain Greater Weapon Specialization multipule times. Its effects do not stack. Each time you take the feat, it applies to a new type of weapon.";

        Feat greaterWeaponSpecilization = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.GreaterWeaponSpecialization))
        {
            AppLibary.featDictionary.Add(AppLibary.GreaterWeaponSpecialization, greaterWeaponSpecilization);
        }

        tempSpecial = "";

        //End Greater Weapon Specilization

        //Heighten Spell

        tempName = AppLibary.HeightenSpell;
        tempFeature = "A heightened spell has a higher spell level than normal (up to a maximum of 9th level). Unlike other metamaginc feats, Heighten Spell actually increases the effective lvevl of the spell that it modifies. All effects dependent on spell level ( such as saving throw DC's and the ability to penetrate a lesser globe of invulnerability) are calculated according to the heightened level. The heightend spell is as diffiuclt to prepare and cast as a spell of its effective level.";
        tempDescription = "You can cast spells as if they were a heigher level.";

        Feat heightenSpell = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.HeightenSpell))
        {
            AppLibary.featDictionary.Add(AppLibary.HeightenSpell, heightenSpell);
        }

        //End Heighten Spell

        //Improved Bull Rush

        tempName = AppLibary.ImprovedBullRush;
        tempFeature = "You do not provoke an attack of opportunity when performing a bull rush combat maneuver. In addition, you receive a +2 bonus on checks made to bull rush a foe. You also receive a +2 bonus to your Combat Maneuver Defence whenever an opponent tries to bull rush you.";
        tempDescription = "You are skilled at pushing your foes around.";
        tempNormal = "Normally you provoke an Attack of Opportunity when you bull rush).";

        Feat improvedBullRush = new Feat(tempName, tempFeature, tempDescription, tempSpecial, tempNormal);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ImprovedBullRush))
        {
            AppLibary.featDictionary.Add(AppLibary.ImprovedBullRush, improvedBullRush);
        }
        //End Improved Bull Rush

        //Improved Channel

        tempName = AppLibary.ImprovedChannel;
        tempFeature = "Add 2 to the DC of saving throws made to resist the effects of your channel energy ability.";
        tempDescription = "Your channeled energy is harder to resist.";

        Feat improvedChannel = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ImprovedChannel))
        {
            AppLibary.featDictionary.Add(AppLibary.ImprovedChannel, greaterVitalStrike);
        }

        //End Improved Channel

        //Improved Counterspell

        tempName = AppLibary.ImprovedCounterspell;
        tempFeature = "When counterspelling, you may use a spell of the same school that is one or more spell levels higher than the target spell.";
        tempDescription = "You are  skilled at countering the spell of others using similar spells.";
        tempNormal = "Normaly you have to cast the same spell as being countered to counter it.";

        Feat improvedCounterspell = new Feat(tempName, tempFeature, tempDescription, tempSpecial, tempNormal);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ImprovedCounterspell))
        {
            AppLibary.featDictionary.Add(AppLibary.ImprovedCounterspell, improvedCounterspell);
        }

        //End Improved Counterspell

        //Improved Critical

        tempName = AppLibary.ImprovedCritical;
        tempFeature = "When using the wapon you selected, your threata range is doubled.";
        tempDescription = "Attacks made with your chosen weapon are quite deadly.";
        tempSpecial = "You can gain Improved Critical multiple times. The effects do not stack. Ecah time you take this feat, it applies to a new type of weapon. The effect doesn't stack with any other effect than expands the threat range of a weapon.";

        Feat improvedCritical = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ImprovedCritical))
        {
            AppLibary.featDictionary.Add(AppLibary.ImprovedCritical, improvedCritical);
        }

        tempSpecial = "";

        //End Improved Critical

        //Improved Disarm

        tempName = AppLibary.ImprovedDisarm;
        tempFeature = "You do not provoke an attack of opportunity when performing a disarm combat maneuver. In addition, you receive a +2 bonus on checks made to disarm a foe. Yoou alos receive a +2 bonus to your Combat Maneuver Defense whenever an opponent tries to disarm you.";
        tempDescription = "You are skilled at knocking weapons from a foe's grasp.";

        Feat improvedDisarm = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ImprovedDisarm))
        {
            AppLibary.featDictionary.Add(AppLibary.ImprovedDisarm, improvedDisarm);
        }

        //End Improved Disarm 

        //Improved Familiar

        tempName = AppLibary.ImprovedFamiliar;
        tempFeature = "When choosing a familiar, these additional creatrues are alos available to you. You may choose a familiar with an alignment up to one step away on each alignment axis (lawful through chatotic, good through evil). Improved familiars otherwize use the rules for regular familiars, with thewo exceptions: if the creature's type is somthing other than animal, its type does not change; and improved familiars do not gain the ability to speak with other creatures of their kind (although many of them already have the ability to communicate).";
        tempDescription = "This feat allows you to acquire a powerful familiar, but only when you could normally acquire a new familiar.";
        tempNormal = "";
        tempTable = null;  //*lookat

        Feat improvedFamiliar = new Feat(tempName, tempFeature, tempDescription, tempSpecial, tempNormal, tempTable);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ImprovedFamiliar))
        {
            AppLibary.featDictionary.Add(AppLibary.ImprovedFamiliar, improvedFamiliar);
        }

        tempTable = null;

        //End Improved Familiar

        //Improved Feint

        tempName = AppLibary.ImprovedFeint;
        tempFeature = "You can make a BLuff check to feint in combat as a move action.";
        tempDescription = "You are skilled at fooling your opponents in combat.";
        tempNormal = "Feinting in combat is a standard action.";

        Feat improvedFeint = new Feat(tempName, tempFeature, tempDescription, tempSpecial, tempNormal);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ImprovedFeint))
        {
            AppLibary.featDictionary.Add(AppLibary.ImprovedFeint, improvedFeint);
        }

        //End Improved Feint

        //Improved Grapple

        tempName = AppLibary.ImprovedGrapple;
        tempFeature = "You do not provoke an attack of opportunity when performing an grapple combat maneuver. In addition, you receive a +2 bonus on checks made to grapple a foe. You also receive a +2 bonus to your Combat Maneuver Defense whenever an opponent tries to grapple you.";
        tempDescription = "You are skilled at grappling opponents.";
        tempNormal = "You provoke an attakc of opportunity when performing an grapple combat maneuver.";

        Feat improvedGrapple = new Feat(tempName, tempFeature, tempDescription, tempSpecial, tempNormal);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ImprovedGrapple))
        {
            AppLibary.featDictionary.Add(AppLibary.ImprovedGrapple, improvedGrapple);
        }

        //End Improved Grapple

        //Improved Great Fortitude

        tempName = AppLibary.ImprovedGreatFortitude;
        tempFeature = "Once per day, you may reroll a Fortitude save. You must decide to use this ability before the results are revealed. You must take the second roll, even if it is worse.";
        tempDescription = "You can draw upon an inner reserve to resist diseases, poisons, and other grievous harm.";

        Feat improvedGreatFortitude = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ImprovedGreatFortitude))
        {
            AppLibary.featDictionary.Add(AppLibary.ImprovedGreatFortitude, improvedGreatFortitude);
        }

        //End Improved Great Fortitude

        //Improved Initiative

        tempName = AppLibary.ImprovedInitiative;
        tempFeature = "You get a +4 bonus on initiative checks.";
        tempDescription = "Your quick reflexes allow you to ract rapidly to danger.";

        Feat improvedInitiative = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ImprovedInitiative))
        {
            AppLibary.featDictionary.Add(AppLibary.ImprovedInitiative, improvedInitiative);
        }

        //End Improved Initiative

        //Improved Iron Will

        tempName = AppLibary.ImprovedIronWill;
        tempFeature = "Once per day, you may reroll a Reflex save. You must decide to use this ability before the results are revealed. You must take the second roll, even if it is worse.";
        tempDescription = "Your clarity of thought allows you to resist mental attacks.";

        Feat improvedIronWill = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ImprovedIronWill))
        {
            AppLibary.featDictionary.Add(AppLibary.ImprovedIronWill, improvedIronWill);
        }

        //End Improved Iron Will

        //Improved Lightning Reflexes

        tempName = AppLibary.ImprovedLightningReflexes;
        tempFeature = "Once per day, you may reroll a Reflex save. You must decide to use this ability before the results are revealed. You must take the second roll, even if it is worse.";
        tempDescription = "you have a knack for avoiding danger all around  you.";

        Feat improvedLightningReflexes = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ImprovedLightningReflexes))
        {
            AppLibary.featDictionary.Add(AppLibary.ImprovedLightningReflexes, improvedLightningReflexes);
        }

        //End Improved Lightning Reflexes

        //Improved Overrun

        tempName = AppLibary.ImprovedOverrun;
        tempFeature = "You do not provoke an attack of opportunity when performing an overrun combat maneuver. In addition, you receive a +2 bonus on checks made to overrun a foe. You also receive a +2 bonus to your Combat Maneuver Defense whenever an opponent tries to overrun  you. Targets of your overrun attempt may not choose to avoid you.";
        tempDescription = "You are skilled at running down your foes.";
        tempNormal = "You provoke an attack of opportunity when performing an overrun combat maneuver.";

        Feat improvedOverrun = new Feat(tempName, tempFeature, tempDescription, tempSpecial, tempNormal);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ImprovedOverrun))
        {
            AppLibary.featDictionary.Add(AppLibary.ImprovedOverrun, improvedOverrun);
        }

        //End Improved Overrun

        //Improved Precise Shot

        tempName = AppLibary.ImprovedPreciseShot;
        tempFeature = "Your ranged attacks ignore the AC bonus granted to targets by anyting less than total cover, and the miss chance grated to targets by anyting less than total concealment. Total cover and total concealment provide their normal benefirts against your ranged attacks.";
        tempDescription = "Your ranged attacks ignore anything but total concealment and cover.";
        tempNormal = ""; //*lookat

        Feat improvedPreciseShot = new Feat(tempName, tempFeature, tempDescription, tempSpecial, tempNormal);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ImprovedPreciseShot))
        {
            AppLibary.featDictionary.Add(AppLibary.ImprovedPreciseShot, improvedPreciseShot);
        }

        //End Improved Precise Shot

        //Improved Shield Bash

        tempName = AppLibary.ImprovedShieldBash;
        tempFeature = "When you perform a shield bash, you may still apply the shield's shield bonus to your AC.";
        tempDescription = "You can protect yourself with your shield, even if you use it to attack.";
        tempNormal = "Without this feat, a character that performs a shield bash loses the sheild's shield bonus to AC until his next turn.";

        Feat improvedShieldBash = new Feat(tempName, tempFeature, tempDescription, tempSpecial, tempNormal);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ImprovedShieldBash))
        {
            AppLibary.featDictionary.Add(AppLibary.ImprovedShieldBash, improvedShieldBash);
        }

        //End Improved Shield Bash

        //Improved Sunder 

        tempName = AppLibary.ImprovedSunder;
        tempFeature = "You do not provoke an attack of opportunity when performing a sunder combat maneuver. In addition, you recieve a +2 bonus on checks made to sunder an item. You also receive a +2 bonus to your Combat Maneuver Defense whenever an opponent tries to sunder you.";
        tempDescription = "You are skilled at damaging your foes' weapons and armor.";
        tempNormal = "You provoke an attack of opportunity when performing a sunder combat maneuver.";

        Feat improvedSunder = new Feat(tempName, tempFeature, tempDescription, tempSpecial, tempNormal);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ImprovedSunder))
        {
            AppLibary.featDictionary.Add(AppLibary.ImprovedSunder, improvedSunder);
        }

        //End Improved Sunder

        //Improved Trip

        tempName = AppLibary.ImprovedTrip;
        tempFeature = "You do not provoke an attack of opportunity when performing a trip combat maneuver. In addition, you receive a +2 bonus on checks made to a trip a foe. You also receive a +2 bonus to your Combat Maneuver Defense whenever an opponent tries to trip you.";
        tempDescription = "You are skilled at sending your opponents to the ground.";
        tempNormal = "You provoke an attack of opportunity when performing a trip combat maneuver.";

        Feat improvedTrip = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ImprovedTrip))
        {
            AppLibary.featDictionary.Add(AppLibary.ImprovedTrip, improvedTrip);
        }

        //End Improved Trip

        //Improved Two-Weapon Fighting

        tempName = AppLibary.ImprovedTwoWeaponFighting;
        tempFeature = "In addition to the standard single extra attack you get with an off-hand weapon, you get a second atttack wiht it, albeit at a -5 penalty.";
        tempDescription = "You are skilled at fighting with two weapons.";
        tempNormal = "Without this feat, you can only get a single extra attack wiht an off-hand weapon.";

        Feat improvedTwoWeaponFighting = new Feat(tempName, tempFeature, tempDescription, tempSpecial, tempNormal);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ImprovedTwoWeaponFighting))
        {
            AppLibary.featDictionary.Add(AppLibary.ImprovedTwoWeaponFighting, improvedTwoWeaponFighting);
        }

        //End Improved Two-Weapon Fighting

        //Improved Unarmed Strike

        tempName = AppLibary.ImprovedUnarmedStrike;
        tempFeature = "You are considered to be armed even when unarmed - you do not provoke attacks of opportunity when you attack foes while unarmed. Your unarmed strikes can deal lethal or nonleathal damage, at your choice.";
        tempDescription = "You are skilled at fighting while unarmed.";
        tempNormal = "Without this feat, you are considered unarmed when attacking iwth an unarmed strike, and you can deal only nonleathal damage with such an attack.";

        Feat improvedUnarmedStrike = new Feat(tempName, tempFeature, tempDescription, tempSpecial, tempNormal);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ImprovedUnarmedStrike))
        {
            AppLibary.featDictionary.Add(AppLibary.ImprovedUnarmedStrike, improvedUnarmedStrike);
        }

        //End Improved Unarmed Strike

        //Improved Vital Strike

        tempName = AppLibary.ImprovedVitalStrike;
        tempFeature = "When you use the attack action, you can make one attack at your highest base attack bonus that deals additional damage. Roll the weapon's damage dice fro the attack three times and add the results togeather before addding bonuses from Strength, weapon abilities (such as flaming), precision-based damage, and other damage bonuses. These extra weapon damage dice are not multiplied on a critical hit, but are added to the total.";
        tempDescription = "You can make a single attack that deals a large ammount of damage.";

        Feat improvedVitalStrike = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ImprovedVitalStrike))
        {
            AppLibary.featDictionary.Add(AppLibary.ImprovedVitalStrike, improvedVitalStrike);
        }

        //End Improved Vital Strike

        //Improved Weapon Mastery

        tempName = AppLibary.ImprovisedWeaponMastery;
        tempFeature = "You do not suffer any penalties for using an improvised weapon. Increase the amount of damage dealt by the improvised weapon by one step (for example 1d4 becomes 1d6) to a maximum of 1d8 (2d6 if the weapon is two-handed). The improvised weapon has a critical threat range of 19-20, wiht a critical multiplier of x2.";
        tempDescription = "You can turn nearly any object into a dealdy weapon, from a razor-sharp chair leg to a sack of flour.";

        Feat improvisedWeaponMastery = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ImprovisedWeaponMastery))
        {
            AppLibary.featDictionary.Add(AppLibary.ImprovisedWeaponMastery, improvisedWeaponMastery);
        }

        //End Improved Weapon Mastery

        //Intimidating Prowess

        tempName = AppLibary.IntimidatingProwess;
        tempFeature = "Add your Strength modifier to Intimidate skill checks in addition to your Charisma modifier.";
        tempDescription = "Your physical might is intimidating to others.";

        Feat intimidatingProwess = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.IntimidatingProwess))
        {
            AppLibary.featDictionary.Add(AppLibary.IntimidatingProwess, intimidatingProwess);
        }

        //End Intimidating Prowess

        //Iron Will

        tempName = AppLibary.IronWill;
        tempFeature = "You get a +2 bonus on all Will saving throws.";
        tempDescription = "You are more resistant ot mental effects.";

        Feat ironWill = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.IronWill))
        {
            AppLibary.featDictionary.Add(AppLibary.IronWill, ironWill);
        }

        //End Iron Will

        //Leadership

        //*Lookat *Unknown pg130

        //End Leadership

        //Lightning Reflexes

        tempName = AppLibary.LightningReflexes;
        tempFeature = "You get a +2 bonus on all Reflex saving throws.";
        tempDescription = "You have faster reflexes than normal.";

        Feat lightningReflexes = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.LightningReflexes))
        {
            AppLibary.featDictionary.Add(AppLibary.LightningReflexes, lightningReflexes);
        }

        //End Lightning Reflexes

        //Lightning Stance

        tempName = AppLibary.LightningStance;
        tempFeature = "If you take tow actions to move or a withdraw action in a turn, you gain a 50% concealment for 1 round.";
        tempDescription = "The speed at which you move makes it nearly impossible for opponents to strike you.";

        Feat lightningStance = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.LightningStance))
        {
            AppLibary.featDictionary.Add(AppLibary.LightningStance, lightningStance);
        }

        //End Lighning Stance

        //Lunge

        tempName = AppLibary.Lunge;
        tempFeature = "You can increase the reach of your melee attacks by 5 feet until the end of your turn by taking a -2 penalty to your AC until your next turn. You must decide to use this ability before nay attacks are made.";
        tempDescription = "You can strike foes that would normaly be out of your reach.";

        Feat lunge = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.Lunge))
        {
            AppLibary.featDictionary.Add(AppLibary.Lunge, lunge);
        }

        //End Lunge

        //Magical Aptitude

        tempName = AppLibary.MagicalAptitude;
        tempFeature = "You get a +2 bonus on all Spellcraft checks and Use magic Devise checks. If you have 10 or more ranks in one of these skills, the bonus increases to +4 for that skill.";
        tempDescription = "You are skilled at knocking weapons from a foe's grasp.";

        Feat magicalAptitude = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.MagicalAptitude))
        {
            AppLibary.featDictionary.Add(AppLibary.MagicalAptitude, magicalAptitude);
        }

        //End Magical Aptitude

        //Manyshot

        tempName = AppLibary.Manyshot;
        tempFeature = "When making a full-attack action with a bow, your first attack fires two arrows. If the attack hits, both arrows hit. Apply percision-baised damage (Such as sneak attacks) and critical hit damage only once for this attack. Damage bonuses from using a composite bow with a high Strength bonus apply to each arrow, as do other damage bonuses, such as a ranger's favored enemy bonus. Damage reduction and resistances apply separately to each arrow.";
        tempDescription = "You can fire multiple arrows at a single target.";

        Feat manyshot = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.Manyshot))
        {
            AppLibary.featDictionary.Add(AppLibary.Manyshot, manyshot);
        }

        //End Manyshot

        //Martial Weapon Proficiency

        tempName = AppLibary.MartialWeaponProficiency;
        tempFeature = "You make attack rolls with  the selected weapon mormally (without the non-proficient penalty).";
        tempDescription = "Choose a type of martial weapon. You understand how to use that type of martial weapon in combat.";
        tempNormal = "When using a weapon wiht which you are not proficien , you take a -4 penalty on attack rolls.";
        tempSpecial = "Barbarians, fighters, paladins, and rangers are proficient with all martial weapons. The need not select this feat. You can gain Martial Weapon Proficiency multiple times. Each time you take the feat, it applies to a new type of weapon.";

        Feat martialWeaponProficiency = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.MartialWeaponProficiency))
        {
            AppLibary.featDictionary.Add(AppLibary.MartialWeaponProficiency, martialWeaponProficiency);
        }

        tempSpecial = "";

        //End Martial Weapon Proficiency

        //Master Craftsman

        tempName = AppLibary.MasterCraftsman;
        tempFeature = "Choose one Craft or Profession skill in which you possess at least 5 ranks. Ranks in your chosen skill count as your caster level for the purposes of qualifying for the Craft Magic Arms and Armor and Craft Wondrous Item feats. You can create magic itmes using these feats, substituting your ranks in the chosen skill for your total caster level. You must use the chosen skill for the check to create the item. The DC to create the item still increases for any necessary spell requirements (see the magic creation rules). You cannont use the feat to create any splee-trigger or spell-activatoin item.";
        tempDescription = "Your superior crafting skills allow you to make simple magic items.";
        tempNormal = "Only spellcasters can qualify for the Craft Magic Arms and Armor and Craft Wondrous Item feats.";

        Feat masterCraftsman = new Feat(tempName, tempFeature, tempDescription, tempSpecial, tempNormal);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.MasterCraftsman))
        {
            AppLibary.featDictionary.Add(AppLibary.MasterCraftsman, masterCraftsman);
        }

        //End Master Craftsman

        //Maximize Spell

        tempName = AppLibary.MaximizeSpell;
        tempFeature = "All variable, numeric effects of a spell modified by the feats are maximized. Saving throws and opposed rolls are not affected, nor are spells without random variables. A maximezed spell uses up a spell slot three levels higher than the spell's actual levelAn empowered, maximized spell gains the separate benefits of each feat: the maximum result plus half the normally rolled result.";
        tempDescription = "Your spells have the maximum possible effect.";

        Feat maximizeSpell = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.MaximizeSpell))
        {
            AppLibary.featDictionary.Add(AppLibary.MaximizeSpell, maximizeSpell);
        }

        //End Maximize Spell

        //Medusa's Wrath

        tempName = AppLibary.MedusasWrath;
        tempFeature = "Whenever you use the full-attack action and make at least one unarmed strike, you can make two additional unarmed strikes at your highest base attack bonus. These bonus attacks must be made against a dazed, flat-footed, paralyzed, staggered, stunneded, or unconscious foe.";
        tempDescription = "You can take advantage of your opponent's confusion, delivering multiple blows.";

        Feat medusasWrath = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.MedusasWrath))
        {
            AppLibary.featDictionary.Add(AppLibary.MedusasWrath, medusasWrath);
        }

        //End Medusa's Wrath

        //Mobility

        tempName = AppLibary.Mobility;
        tempFeature = "You get a +4 dodge bonus to your Armor Class against attacks of opportunity caused when you move out of or wihtin a threatened area. A condition that makeas yoou lose your Dexterity bonus to Armor Class(if any) also makes you lose dodge bonuses.";
        tempDescription = "You can easily move through a dangerous melee.";

        Feat mobility = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.Mobility))
        {
            AppLibary.featDictionary.Add(AppLibary.Mobility, mobility);
        }

        //End Mobility

        //Mounted Archery

        tempName = AppLibary.MountedArchery;
        tempFeature = "The penalty you take when using a ranged weapon while mounted is halved: -2 instead of -4 if your mount is taking a double move, and -4 instead of -8 if your mount is running.";
        tempDescription = "You are skilled at making ranged attacks while mounted.";

        Feat mountedArchery = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.MountedArchery))
        {
            AppLibary.featDictionary.Add(AppLibary.MountedArchery, mountedArchery);
        }

        //End Mounted Archery

        //Mounted Combat

        tempName = AppLibary.MountedCombat;
        tempFeature = "Once per round when your mount is hit in combat, you may attempt a Ride check (as an immediant action) to negate the hit. The hit is negated if your Ride check result is greater than the opponent's attack roll.";
        tempDescription = "You are adept at guiding  your mount through combat.";

        Feat mountedCombat = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.MountedCombat))
        {
            AppLibary.featDictionary.Add(AppLibary.MountedCombat, mountedCombat);
        }

        //End Mounted Combat

        //Natural Spell

        tempName = AppLibary.NaturalSpell;
        tempFeature = "You can complete the verbal and somatic components of spells while using wild shape. You substitute various noises and gestures for the normal verbal and somatic components of a spell. You can also use any material components or focuses you possess, even if such items are melded within your current form. This feat does not permit the use of magic items while you are in a form that could not ordinarily use that, and you do not gain the ability to speak while using wild shape.";
        tempDescription = "You can cast spells even while in a form that cannot normally cast spells.";

        Feat naturalSpell = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.NaturalSpell))
        {
            AppLibary.featDictionary.Add(AppLibary.NaturalSpell, naturalSpell);
        }

        //End Natural Spell

        //Nimble Moves

        tempName = AppLibary.NimbleMoves;
        tempFeature = "Whenever you move, you may move through 5 feet of difficult terrain each round as if it were normal terrain. This feat allows you to take a 5-foot step into a difficult terrain.";
        tempDescription = "You can move across a single obstacle with ease.";

        Feat nimbleMoves = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.NimbleMoves))
        {
            AppLibary.featDictionary.Add(AppLibary.NimbleMoves, nimbleMoves);
        }

        //End Nimble Moves

        //Penetrating Strike

        tempName = AppLibary.PenetratingStrike;
        tempFeature = "Your attacks made with weapons selected with Weapon Focus ignore up to 5 points of damage reduction. This feat does not apply to damge reduction without a type (such as DR 10/-).";
        tempDescription = "Your attacks are capable of penetrating the defenses of some creatures.";

        Feat penetratingStrike = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.PenetratingStrike))
        {
            AppLibary.featDictionary.Add(AppLibary.PenetratingStrike, penetratingStrike);
        }

        //End Penetrating Strike

        //Persuasive

        tempName = AppLibary.Persuasive;
        tempFeature = "You get a +2 bonus on Diplomacy and Intimidate skill checks. If you have 10 or more ranks in one of these skills, the bonus increases to +4 for that skill.";
        tempDescription = "You are skilled at swaying attitudes and intimidating others into your way of thinking.";

        Feat persuasive = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.Persuasive))
        {
            AppLibary.featDictionary.Add(AppLibary.Persuasive, persuasive);
        }

        //End Persuasive

        //Pinpoint Targeting

        tempName = AppLibary.PinpointTargeting;
        tempFeature = "As a standared action, make any single ranged attack. The target does not gain any armor, natural armor, or shield bonuses to its Armor Class. You do not gain the benefit of this feat if you move this round.";
        tempDescription = "You can target the weak points in your opponents armor.";

        Feat pinpointTargeting = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.Manyshot))
        {
            AppLibary.featDictionary.Add(AppLibary.PinpointTargeting, pinpointTargeting);
        }

        //End Pinpoint Targeting

        //Point-Blank Shot

        tempName = AppLibary.PointBlankShot;
        tempFeature = "You get a +1 bonus on attack and damage rolls with ranged weapons at ranges of up to 30ft.";
        tempDescription = "You are especially accurate when making ranged attacks against close targets.";

        Feat pointBlankShot = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.PointBlankShot))
        {
            AppLibary.featDictionary.Add(AppLibary.PointBlankShot, pointBlankShot);
        }

        //End Point-Blank Shot

        //Power Attack

        tempName = AppLibary.PowerAttack;
        tempFeature = "You can choose to take a -1 penalty on all melee attack rolls and combat maneuver checks to gain a +2 on all melee damage rolls. This bonus to damage is increased by half (+50%) if you are making an attack with a two-handed weapon, a on-handed weapon using two hands, or a primary natural weapon that adds 1-1/2 times your Strength modifier on damage rolls. This bonus to damage is halved (-50%) if you are making an attack iwth an off-hand weapon or secondary natural weapon. When your base attackc bonus reaches +4, and every 4 points thereafter, the penalty increases by -1 and the bonus to damage increases by +2. You must choose to use this feat before making an attack roll, and its effects last until your next turn. The bonus damage does not apply to touch attacks or effects that do not deal hit point damage.";
        tempDescription = "You can make exceptionally deadly melee attacks by sacrificing accuracy for strength.";

        Feat powerAttack = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.PowerAttack))
        {
            AppLibary.featDictionary.Add(AppLibary.PowerAttack, powerAttack);
        }

        //End Power Attack

        //Precise Shot

        tempName = AppLibary.PreciseShot;
        tempFeature = "You can shoot or throw ranged weapons at an opponent engaged in melee without taking the standard -4 penalty on your attack roll.";
        tempDescription = "You are adept at firing ranged attacks into melee.";

        Feat preciseShot = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.PreciseShot))
        {
            AppLibary.featDictionary.Add(AppLibary.PreciseShot, preciseShot);
        }

        //End Precise Shot

        //Quick Draw

        tempName = AppLibary.QuickDraw;
        tempFeature = "You can draw a weapon as a free action instead of as a move action. You can draw a hidden weapon as a move action. A character who has selected this feat my throw weapons at his full normal rate of attacks. Alchemical items, potions, scrolls, and wands cannot be drawn quickly using this feat.";
        tempDescription = "You can draw weapons faster than most.";
        tempNormal = "Without this feat, you may draw a weapon as a move action, of (if our base attack bonus is +1 or higher) as a free action as part of that movement. Without this feat, you can draw a hidden weapon as a standard action.";

        Feat quickDraw = new Feat(tempName, tempFeature, tempDescription, tempSpecial, tempNormal);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.QuickDraw))
        {
            AppLibary.featDictionary.Add(AppLibary.QuickDraw, quickDraw);
        }

        //End Quick Draw

        //Quicken Spell

        tempName = AppLibary.QuickenSpell;
        tempFeature = "Casting a quickened spell is a swift action. You can perform another action, even casting another spell. A spell whoes casting time is more than 1 round or 1 full-round action cannot be quickened. A quickend spell uses up a spell slot four levels higher than the spell's actual level. Casting a quickend spell doesn't provoke an attack of opportunity.";
        tempDescription = "You can cast spells in a fraction of the normal time.";
        tempSpecial = "You can apply the effects of this feat to a spell cast spontaneously, so long as it has a casting time that is not more than a full round action, without increasing the spells casting time.";

        Feat quickenSpell = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.QuickenSpell))
        {
            AppLibary.featDictionary.Add(AppLibary.QuickenSpell, quickenSpell);
        }

        tempSpecial = "";

        //End Quicken Spell

        //Rapid Reload

        tempName = AppLibary.RapidReload;
        tempFeature = "The time required for you to reload your chosen type of crossbow is reduced to a free action (for a hand or light crossbow) or a move aciton (for a heavy crossbow). Reloading a crossbow still provokes an attack of opportunity. If you have selected this feat for hand crossbow or a light crossbow, you may fire that weapon as many times in a full-attack action as you could attack if you were using a bow.";
        tempDescription = "Choose a type of crossbow (hand, light, or heavy). You can reload such weapons quickly.";
        tempSpecial = "You can gain Rapid Reload multiple times. Each time you take the feat, it applies to a new type of crossbow.";
        tempNormal = "A character without this feat needs a move action to reload a hand or light crossbow, or a full-round action to reload a heavy crossbow.";

        Feat rapidReload = new Feat(tempName, tempFeature, tempDescription, tempSpecial, tempNormal);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.RapidReload))
        {
            AppLibary.featDictionary.Add(AppLibary.RapidReload, rapidReload);
        }

        tempSpecial = "";

        //End Rapid Reload

        //Rapid Shot

        tempName = AppLibary.RapidShot;
        tempFeature = "When making a full-attack action wiht a ranged weapon, you can fire one additional time this round at your highest bonus. All of your attakc rolls take a -2 penalty when using Rapid Shot.";
        tempDescription = "You can make an additional ranged attack.";

        Feat rapidShot = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.RapidShot))
        {
            AppLibary.featDictionary.Add(AppLibary.RapidShot,  rapidShot);
        }

        //End Rapid Shot

        //Ride-By Attack

        tempName = AppLibary.RideByAttack;
        tempFeature = "When you are mounted and use the charge action, you may move and attack as if wiht standard charge and then move again (continuing the streight line of the charge). Your total movement for the round can't exceed double your mounted speed. You and your mount do not provoke an attack of opportunity form the opponent that you attack.";
        tempDescription = "While mounted and charging, you can move, strike at a foe, and then continue moving.";

        Feat rideByAttack = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.RideByAttack))
        {
            AppLibary.featDictionary.Add(AppLibary.RideByAttack, rideByAttack);
        }

        //End Ride-By Attack

        //Run

        tempName = AppLibary.Run;
        tempFeature = "When running, you move five times your normal speed (if wearing medium, light, or no armor and carrying no more than a medium load) or four times your speed (if you are wearing heavy armor or carrying an heavy load). If you make a jump after a running start, you gain a +4 bonus on your Acrobatics check. While running, you retain yoru Dexterity bonus to your Armor Class.";
        tempDescription = "You are swift of foot.";
        tempNormal = "You move four times your speed while running (in light, medium, or no armor and carrying no more than a medium load) or three times your speed (if wearing heavy armor or carrying a heavy load), and you lose your Dexterity bonus to AC.";

        Feat run = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.Run))
        {
            AppLibary.featDictionary.Add(AppLibary.Run, run);
        }

        //End Run

        //Scorpion Style

        tempName = AppLibary.ScorpionStyle;
        tempFeature = "To use this feat, you must make a single unarmed attack as standard action. If this unarmed attack hits,  you deal damage normaly, and the target'sbase land speed is reduced to 5 feet for a number of rounds equal to your Wisdom modifier unless it makes a Fortitude saving throw (DC 10 + 1/2 your character level + your Wis modifier).";
        tempDescription = "You can perform an unarmed striek that greatly hampers your targets movemnt speed.";

        Feat scorpionStyle = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ScorpionStyle))
        {
            AppLibary.featDictionary.Add(AppLibary.ScorpionStyle, scorpionStyle);
        }

        //End Scorpion Style

        //Scribe Scroll

        tempName = AppLibary.ScribeScroll;
        tempFeature = "You can create a scroll of any spell that you know. Scribing a scroll takes 2 hours if its base price is 250gp or less, otherwise scribing a scroll takes 1 day for each 1,000gp in its base. To scribe a scroll, hyou must use up raw materials costing half of this base price. See the magic item creation rules for more information.";
        tempDescription = "You can create magic scrolls.";

        Feat scribeScroll = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ScribeScroll))
        {
            AppLibary.featDictionary.Add(AppLibary.ScribeScroll, scribeScroll);
        }

        //End Scribe Scroll

        //Selective Channeling

        tempName = AppLibary.SelectiveChanneling;
        tempFeature = "When you channel energy, you can choose a number of targets in the area up your Charisma modifier. These targets are not affected byyour channeled energy.";
        tempDescription = "You can choose whom to affect when you channel energy.";
        tempNormal = "All targets in a 30-foot burst are affected when you channel energy. You can only choose whether or not you are affected.";

        Feat selectiveChanneling = new Feat(tempName, tempFeature, tempDescription, tempSpecial, tempNormal);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.SelectiveChanneling))
        {
            AppLibary.featDictionary.Add(AppLibary.SelectiveChanneling, selectiveChanneling);
        }

        //End Selective Channeling

        //Self-Sufficient

        tempName = AppLibary.SelfSufficient;
        tempFeature = "You get a +2 bonus on all Heal checks and Survival checks. If you have 10 or mor ranks in one of these skills, the bonus increases to +4 for that skill.";
        tempDescription = "You know how to get along in the wild and how to effectively treat wounds.";

        Feat selfSufficient = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.SelfSufficient))
        {
            AppLibary.featDictionary.Add(AppLibary.SelfSufficient, selfSufficient);
        }

        //End Self-Sufficient

        //Shatter Defenses

        tempName = AppLibary.ShatterDefenses;
        tempFeature = "Any shaken, frightened, or panicked opponet hit by you this round is flat-footed to your attacks until the end of your next turn. This includes any additional attacks you make this round.";
        tempDescription = "Your skill with your chosen weapon leaves opponents unable to defend themselves if you strike them when their defenses are already compromised.";

        Feat shatterDefenses = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ShatterDefenses))
        {
            AppLibary.featDictionary.Add(AppLibary.ShatterDefenses, shatterDefenses);
        }

        //End Shatter Defenses

        //Shield Focus

        tempName = AppLibary.ShieldFocus;
        tempFeature = "Increase the AC bonus granted by any shield you are using by 1.";
        tempDescription = "You are skilled at deflecting blows with your shield.";

        Feat shieldFocus = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ShieldFocus))
        {
            AppLibary.featDictionary.Add(AppLibary.ShieldFocus, shieldFocus);
        }

        //End Shield Focus

        //Shield Master

        tempName = AppLibary.ShieldMaster;
        tempFeature = "You do not suffer any penalties on attack rolls made with a shield while you are wielding another weapon. Add your shield's enhancement bonus to attacks and damage rolls made with the shield as if it was a weapon enhancement bonus.";
        tempDescription = "Your mastery of the shield allows you ti fight with it without hinderance.";

        Feat shieldMaster = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ShieldMaster))
        {
            AppLibary.featDictionary.Add(AppLibary.ShieldMaster, shieldMaster);
        }

        //End Shield Master

        //Shield Proficiency

        tempName = AppLibary.ShieldProficiency;
        tempFeature = "When you use a shield (except a tower shield), the shield's armor check penalty only applies to Strength and Dexterity baised skills.";
        tempDescription = "You are trained how to properly use shields.";
        tempSpecial = "Barbarians, bards, clerics, druids, fighters, paladins, and ragners all automatically have Shield Proficiency as a bonus feat. They need not select it.";
        tempNormal = "When you are using a shield with which you are proficient, you take the shield's armor check penalty on attack rolls and on all skill checks that involve moving.";

        Feat shieldProficiency = new Feat(tempName, tempFeature, tempDescription, tempSpecial, tempNormal);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.Manyshot))
        {
            AppLibary.featDictionary.Add(AppLibary.Manyshot, manyshot);
        }

        //End Shield Proficiency

        //Shield Slam

        tempName = AppLibary.ShieldSlam;
        tempFeature = "Any opponents hit by your shield bash are also hit with a free bull rush attack, substituting your attack roll for the combat maneuver check. This bull rush does not provoke an attack of opportunity. Opponents who cannot move back due to a wall or other surface are knocked prone after moving the maximum possible distance. You may choose to move with your target if you are able ot take a 5-foot step or to spend an action to move this turn.";
        tempDescription = "In the right position, your shield can be used to send opponents flying.";

        Feat shieldSlam = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ShieldSlam))
        {
            AppLibary.featDictionary.Add(AppLibary.ShieldSlam, shieldSlam);
        }

        //End Sheild Slam

        //Shot on the Run

        tempName = AppLibary.ShotOnTheRun;
        tempFeature = "As a full-round action, you can move up to your speed and make a single ranged attack at any point during your movement.";
        tempDescription = "You can move, fire a ranged weapon, and move again before your foes can react.";
        tempSpecial = "You cannot move before and after an attack with a ranged weapon.";
           
        Feat shotOnTheRun = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.Manyshot))
        {
            AppLibary.featDictionary.Add(AppLibary.Manyshot, manyshot);
        }

        tempSpecial = "";

        //End Shot on the Run

        //Sickening Critial

        tempName = AppLibary.SickeningCritical;
        tempFeature = "Whenever you score a critical hit, your opponent becomes sickened for 1 minute. The effects of this feat do not stack. Additional hits instead add to the effect's duration.";
        tempDescription = "Your critical hits cause opponents to become sokened.";
        tempSpecial = "You can only apply the efects of one critical feat to a given critical hit unless you possess Critical Mastery.";

        Feat sickeningCritical = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.SickeningCritical))
        {
            AppLibary.featDictionary.Add(AppLibary.SickeningCritical, sickeningCritical);
        }

        tempSpecial = "";

        //End Sickening Critical

        //Silent Spell

        tempName = AppLibary.SilentSpell;
        tempFeature = "A silent spell can be cast with no verbal components. Spells without verbal components are not affected. A silent spell uses up a spell slot one level higher than the spell's actual level.";
        tempDescription = "You can cast your spells without making any sound.";

        Feat silentSpell = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.SilentSpell))
        {
            AppLibary.featDictionary.Add(AppLibary.SilentSpell, silentSpell);
        }

        //End Silent Spell

        //Simple Weapon Proficiency

        tempName = AppLibary.SimpleWeaponProficiency;
        tempFeature = "You make attack rolls with simple weapons wihtout penalty.";
        tempDescription = "You are trained in the use of basic weapons.";
        tempSpecial = "All characters except for druids, monks, and wizards are automatically proficient with all simple wapons. They need not select this feat.";
        tempNormal = "When using a weapon with which you are not proficient, you take a -4 penalty on attack rolls.";

        Feat simpleWeaponProficiency = new Feat(tempName, tempFeature, tempDescription, tempSpecial, tempNormal);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.SimpleWeaponProficiency))
        {
            AppLibary.featDictionary.Add(AppLibary.SimpleWeaponProficiency, simpleWeaponProficiency);
        }

        tempSpecial = "";

        //End Simple Weapon Proficiency

        //Skill Focus

        tempName = AppLibary.SkillFocus;
        tempFeature = "You get a +3 bonus on all checks involving the chosen skill. If you have 10 or more ranks in that skill the bonus increases to +6.";
        tempDescription = "Choose a skill. You are particularly adept at that skill.";
        tempSpecial = "You can gain this feat multiple times. Its effecs do not stack. Each time you take the feat, it applies to a new skill.";

        Feat skillFocus = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.SkillFocus))
        {
            AppLibary.featDictionary.Add(AppLibary.SkillFocus, skillFocus);
        }

        //End Skill Focus

        //Snatch Arrows

        tempName = AppLibary.SnatchArrows;
        tempFeature = "Wehn using the Deft Arrows feat you may choose to catch the weapon instead of just deflecting it. Thrown weapons can immediately be thrwon back as an attack against the origninal attacker (even if it is not your turn) or kept for later use. You must have at least one hand free (holding nothing) to use this feat.";
        tempDescription = "Instead of knocking an arrow or ranged attack aside, you can catch it in mid-flight.";

        Feat snatchArrows = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.SnatchArrows))
        {
            AppLibary.featDictionary.Add(AppLibary.SnatchArrows, snatchArrows);
        }

        //End Snatch Arrows

        //Spell Focus

        tempName = AppLibary.SpellFocus;
        tempFeature = "Add +1 to the Difficulty Class for all saving throws against spells from the school of magic you select.";
        tempDescription = "Choose a school of magic. Any spells you cast of that school are more difficult to resist.";
        tempNormal = "You can gain this feat multiple times. Its effects do not stack. Each time you gain this feat, it applies to a new school of magic.";

        Feat spellFocus = new Feat(tempName, tempFeature, tempDescription, tempSpecial, tempNormal);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.SpellFocus))
        {
            AppLibary.featDictionary.Add(AppLibary.SpellFocus, spellFocus);
        }

        //End Spell Focus

        //Spell Mastery

        tempName = AppLibary.SpellMastery;
        tempFeature = "Each time you take this feat, choose a number of spells that you already know equal to your Intellligence modifier. From that point on, you can prepare these spells without reffering to a spellbook.";
        tempDescription = "You have mastered a spell handful of spells, and can prepare these spells without referencing your spellbook at all.";

        Feat spellMastery = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.SpellMastery))
        {
            AppLibary.featDictionary.Add(AppLibary.SpellMastery, spellMastery);
        }

        //End Spell Mastery

        //Spell Penetration

        tempName = AppLibary.SpellPenetration;
        tempFeature = "You get a +2 bonus on caster level checks (1d20 + caster level) made to overcome a creature's spell resistance.";
        tempDescription = "Your spells break through spell rsistance more easily than most.";

        Feat spellPenetration = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.SilentSpell))
        {
            AppLibary.featDictionary.Add(AppLibary.SpellPenetration, spellPenetration);
        }

        //End Spell Penetration

        //Spellbreaker

        tempName = AppLibary.Spellbreaker;
        tempFeature = "Enemies in your threatened area that fail their checks to cast spells defensively provoke attacks of opportunity from you.";
        tempDescription = "You can strike at enemy spellcasters who fail to cast defensivley when you threaten them.";
        tempNormal = "Enemies that fail their checks to cast spells defensively do not provoke attacks of opportunity from you.";

        Feat spellbreaker = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.Spellbreaker))
        {
            AppLibary.featDictionary.Add(AppLibary.Spellbreaker, spellbreaker);
        }

        //End Spellbreaker

        //Spirited Charge

        tempName = AppLibary.SilentSpell;
        tempFeature = "When mounted and using the charge action, you deal double damage with a melee weapon (or triple damage with a lance).";
        tempDescription = "Your mounted charge attacks deal a tremendous amount of damage.";

        Feat silenSpell = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.SilentSpell))
        {
            AppLibary.featDictionary.Add(AppLibary.SilentSpell, silenSpell);
        }

        //End Spirted Charge

        //Spring Attack

        tempName = AppLibary.SpringAttack;
        tempFeature = "As a full-round action, you can move up to your speed and make a single melee attack without provoking any attacks of opportunity from the target of your attack. You can move both before and after the attack and the total distance that you move cannot be greater than your speed. You cannot use this ability to attack a foe that is adjacent to you at the start of your turn.";
        tempDescription = "You can deftly move up to a foe, and withdraw before he can react.";

        Feat springAttack = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.SpringAttack))
        {
            AppLibary.featDictionary.Add(AppLibary.SpringAttack, springAttack);
        }

        //End Spring Attack

        //Staggering Critical

        tempName = AppLibary.StaggeringCritical;
        tempFeature = "Whenever you score a critical hit, your opponent becomes staggered for 1d4+1 rounds. A sucessfull Fortitude save reduces the duration to 1 round. The DC of this Fortitude save is equal to 10 + your base attack bonus. The effects of this feat do not stack. Additional hits instead add to the duration.";
        tempDescription = "Your critical hits cause opponents to slow down.";
        tempSpecial = "You can only apply the effects of one critical feat to a given critical hit unless you possess Critcal Mastery.";

        Feat staggeringCritical = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.StaggeringCritical))
        {
            AppLibary.featDictionary.Add(AppLibary.StaggeringCritical, staggeringCritical);
        }

        tempSpecial = "";

        //End Staggering Critical

        //Stand Still

        tempName = AppLibary.StandStill;
        tempFeature = "When a foe provokes an attack of opportunity due to moving through your adjacent squares, you can make a combat maneuver check as your attack of opportunity. If successful, the enemy cannot move for the rest of his turn. An enemy can still take the rest of his action, but cannot move. This feat also applies to any creature that attempts to move from a square that is adjacent to your if such movement provokes an attack of opportunity.";
        tempDescription = "You can stop foes that try to move past you.";

        Feat standStill = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.StandStill))
        {
            AppLibary.featDictionary.Add(AppLibary.StandStill, standStill);
        }

        //End Stand Still

        //Stealty
        
        tempName = AppLibary.Stealthy;
        tempFeature = "You get a +2 bonus on all Escape Artist and Stealth checks. If you have 10 or more ranks in one of these skills, the bonus increases to +4 for that skill.";
        tempDescription = "You are good at avoiding unwanted attention and slipping out of bounds.";

        Feat stealthy = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.Stealthy))
        {
            AppLibary.featDictionary.Add(AppLibary.Stealthy, stealthy);
        }

        //End Stealthy

        //Step Up

        tempName = AppLibary.StepUp;
        tempFeature = "Whenever an adjacent foe attempts to take a 5-foot step away from you, you may also make a 5-foot step as an immediant acton so long as you end up adjacent to the foe that triggered this ability. If you take this step, you cannot take a 5-foot step during your next turn. If you take an action to move during your next turn, subtract 5 feet from your total movemenet.";
        tempDescription = "You can close the distance when a foe tries to move away.";

        Feat stepUp = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.StepUp))
        {
            AppLibary.featDictionary.Add(AppLibary.StepUp, stepUp);
        }

        //End Step Up

        //Still Spell

        tempName = AppLibary.StillSpell;
        tempFeature = "A stilled spell can be cast with no somatic components. Spells without somatic components are not affected. A stilled spell uses up a spell slot one level higher than the spell's actual level.";
        tempDescription = "You can cast spells without moving.";

        Feat stillSpell = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.StillSpell))
        {
            AppLibary.featDictionary.Add(AppLibary.StillSpell, stillSpell);
        }

        //End Still Spell

        //Strike Back

        tempName = AppLibary.StrikeBack;
        tempFeature = "You can ready an action to make an melee attack against any foe that attacks you in melee, even if that foe is outside of your reach.";
        tempDescription = "You can strike at foes that attack you using their superior reach, by targeting their limbs or weapons as they come at you.";

        Feat strikeBack = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.StrikeBack))
        {
            AppLibary.featDictionary.Add(AppLibary.StrikeBack, strikeBack);
        }

        //End Strike Back

        //Stunning Critical

        tempName = AppLibary.StunningCritical;
        tempFeature = "Whenever you score a critical hit, your opponent becomes stunned for 1d4 rounds. A successful Fortitude save reduces thsi to staggred for 1d4 rounds. The DC of this Fortitude save is equal to 10 + your base attack bonus. The effects of this feat do not stack. Attitional hits instead add to the duration.";
        tempDescription = "Your critical hits cause opponents to become stunned.";
        tempSpecial = "You can only apply the effects of one critical feat to a given critical hit unless you possess Critical Mastery.";

        Feat stunningCritical = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.StunningCritical))
        {
            AppLibary.featDictionary.Add(AppLibary.StunningCritical, stunningCritical);
        }

        tempSpecial = "";

        //End Stunning Critical

        //Stunning Fist

        tempName = AppLibary.StunningFist;
        tempFeature = "You must declare that you are using this feat before you make your attack roll (thus, a failed attack roll ruins the attempt). Stunning Fist forces a foe damaged by your unarmed attack to make a Fortitude saving throw (DC 10 + 1/2 your character level + your Wis modifier), in addition to dealing damage normally. A defender who fails this saving throw is stunned for 1 round (until just before your next turn). A stunned character dropps everythign held, can't take actions, loses any Dexterity bonus to AC, and takes a -2 penalty to AC. You may attempt a stunning attack once per day for every four levels you have attained (but see below), and no more than once per round. Constructs, oozes, plants, undead, incorporeal creatures, and creatures immune to critical hits cannot be stunned.";
        tempDescription = "You know just when to strike to temporarily stun a foe.";
        tempSpecial = "A monk receives Stunning Fist as a bonus feat at 1st level, even if he does not meet the prerequisites. A monk may attempt a stunning attack a number of times per day equal to his monk level, plus one more time per day for every four levels he has in classes other than monk.";

        Feat stunningFist = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.StunningFist))
        {
            AppLibary.featDictionary.Add(AppLibary.StunningFist, stunningFist);
        }

        tempSpecial = "";

        //End Stunning Fist

        //Throw Anything

        tempName = AppLibary.ThrowAnything;
        tempFeature = "You do not suffer any penalties for using an improvised ranged weapon. You receive a +1 circumstance bonus on attack rolls made with thrown splash weapons.";
        tempDescription = "You are used to throwing things you have on hand.";
        tempNormal = "You take a -4 penalty on attack rolls made with an improvised weapon.";

        Feat throwAnything = new Feat(tempName, tempFeature, tempDescription, tempSpecial, tempNormal);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.ThrowAnything))
        {
            AppLibary.featDictionary.Add(AppLibary.ThrowAnything, throwAnything);
        }

        //End Throw Anything

        //Tiring Critical

        tempName = AppLibary.TiringCritical;
        tempFeature = "Whenever you score a critical hit, your opponent becomes fatigued. This feat has no additional effect on a fatigued and exhausted creature.";
        tempDescription = "Your critical hits cause opponenets to become fatigued.";
        tempSpecial = "You can only apply the effects of one critical feat to a given critical hit unless you possess Critical Mastery.";

        Feat tiringCritical = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.TiringCritical))
        {
            AppLibary.featDictionary.Add(AppLibary.TiringCritical, tiringCritical);
        }

        tempSpecial = "";

        //End Tiring Critical

        //Toughness

        tempName = AppLibary.Toughness;
        tempFeature = "You gain +3 hit ppoints. For every Hit Die you possess beyond 3, you gain an additional +1 hit points. If you have more than 3 Hit Dice, you gain +1 hit points whenever you gain a Hit Die (such as when you gain a level).";
        tempDescription = "You have enhanced physical stamina.";

        Feat toughness = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.Toughness))
        {
            AppLibary.featDictionary.Add(AppLibary.Toughness, toughness);
        }

        //End Toughness

        //Tower Shield Proficiency

        tempName = AppLibary.TowerSheildProficiency;
        tempFeature = "When you use a tower shield, the shield's armor check penalty only applies to Strength and Dexterity-based skills.";
        tempDescription = "You are trained in how to properly use a tower shield.";
        tempNormal = "A character using a shield with which he is not proficient takes the shield's armor check penalty on attack rolls and on all skill checks that involve moving, including Ride.";
        tempSpecial = "Fighers automatically have Tower Shield Proficiency as a bonus feat, they need not select it.";

        Feat towerShieldProficiency = new Feat(tempName, tempFeature, tempDescription, tempSpecial, tempNormal);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.TowerSheildProficiency))
        {
            AppLibary.featDictionary.Add(AppLibary.TowerSheildProficiency, towerShieldProficiency);
        }

        //End Tower Shield Proficiency

        //Trample

        tempName = AppLibary.Trample;
        tempFeature = "When you attempt to overrun an opponent while mounted, your target may not choose to avoid you. Your mount make make one hoof attack against any target you knock down, gaining the standard +4 bonus on attack rolls against prone targets.";
        tempDescription = "While mounted, you can ride down opponents and trample them under your mount.";

        Feat trample = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.Trample))
        {
            AppLibary.featDictionary.Add(AppLibary.Trample, trample);
        }

        //End Trample

        //Tun Undead

        tempName = AppLibary.TurnUndead;
        tempFeature = "You can, as a standard action, use one of your uses of channel positive energy to cause all undead within 30 feet of you to flee, as if panicked. Undead receive a Will save to negate this effect. The DC for this Will save is equal to 10 + 1/2 your cleric level + your Charisma modifier. Undead that fail their saving throw flee for 1 minuite. Intelligent undead receive a new saving throw each round to end th effect. If you use channel energy in this way, it has no other effect (it does not heal or harm nearby creatures).";
        tempDescription = "Calling upon higher powers, you cause undead to fell from the might of your unleased divine energy.";

        Feat turnUndead = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.TurnUndead))
        {
            AppLibary.featDictionary.Add(AppLibary.TurnUndead, turnUndead);
        }

        //End Turn Undead

        //Two-Weapon Defense

        tempName = AppLibary.TwoWeaponDefense;
        tempFeature = "When wielding a double weapon or two weapons (not including natural weapons or unarmed strikes), you gain a +1 shield bonus to your AC. When you are fighting defensively or using the total defense action, this sheild bonus icreases to +2.";
        tempDescription = "You are skilled at defending yourself while dual-wielding.";

        Feat twoWeaponDefense = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.TwoWeaponDefense))
        {
            AppLibary.featDictionary.Add(AppLibary.TwoWeaponDefense, twoWeaponDefense);
        }

        //End Two-Weapon Defense

        //Two-Weapon Fighting

        tempName = AppLibary.TwoWeaponFighting;
        tempFeature = "Your penalties on attack rolls for fighting with two weapons are reduced. The penalty for your primary hand lessens by 2 and the one for your off-hand lessens by 6.";
        tempDescription = "You can fight with a weapon wielded in each of your hands. You can make one extra attack each round with the secondary weapon.";
        tempNormal = "If you wield a second weapon in your off hand, you can get one extra attack per round with that weapon. When fighting in this way you suffer a -6 penalty with your regular attack or attacks with your primary hand and a -10 penalty to the attack with your off hand. If your off-hand weapon is light, the penalties are reduced by 2 each. An unarmed strike is always considered light.";

        Feat twoWeaponFighting = new Feat(tempName, tempFeature, tempDescription, tempSpecial, tempNormal);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.TwoWeaponFighting))
        {
            AppLibary.featDictionary.Add(AppLibary.TwoWeaponFighting, twoWeaponFighting);
        }

        //End Two-Weapon Fighting

        //Two-Weapon Rend

        tempName = AppLibary.TwoWeaponRend;
        tempFeature = "If you hit an opponent with both your primary hand and your off-hand weapon, you deal an additional 1d10 points of damage pulus 1-1/2 times your Strength modifier. You can only deal this damage onece each round.";
        tempDescription = "Striking with both of your weapons simultaneously, you can use them to deliver devastinging wounds.";

        Feat twoWeaponRend = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.TwoWeaponRend))
        {
            AppLibary.featDictionary.Add(AppLibary.TwoWeaponRend, twoWeaponRend);
        }

        //End Two-Weapon Rend

        //Unseat

        tempName = AppLibary.Unseat;
        tempFeature = "When charging an opponent while mounted and wielding a lance, resolve the attack as normal. If it hits, you may immediantely make a free bull rush attempt in addition to the normal damage. If successful, the target is knocked off his horse and lands prone in a space adjacent ot his mount that is directly away from you.";
        tempDescription = "You are skilled at unseating your mounted opponents.";

        Feat unseat = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.Unseat))
        {
            AppLibary.featDictionary.Add(AppLibary.Unseat, unseat);
        }

        //End Unseat

        //Vital Strike

        tempName = AppLibary.VitalStrike;
        tempFeature = "When you use the attack action, you can make one attack at your highest base attack bonus that deals additional damage. Roll the weapon's damage dice for the attack twice and add the results togeather before adding bonuses from Strength, weapon abilities (such as flaming), precision-based damage, and other damage bonuses. These extra weapon damage dice are not multiplied on a critical hit, but are added to the total.";
        tempDescription = "You make a single attack that deals significantly more damage than normal.";

        Feat vitalStrike = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.VitalStrike))
        {
            AppLibary.featDictionary.Add(AppLibary.VitalStrike, vitalStrike);
        }

        //End Vital Strike

        //Weapon Finesse

        tempName = AppLibary.WeaponFinesse;
        tempFeature = "With a light weapon, elven curve blade, rapier, whip, or spiked chain made for a creature of yoru size category, you may use your Dexterity modifier instead of your Strength modifier on attack rolls. If you carry a shield, its armor check penalty applies to your attack rolls.";
        tempDescription = "You can cast your spells without making any sound.";
        tempSpecial = "Natural weapons are considered light weapons.";

        Feat weaponFinesse = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.WeaponFinesse))
        {
            AppLibary.featDictionary.Add(AppLibary.WeaponFinesse, weaponFinesse);
        }

        tempSpecial = "";

        //End Weapon Finesse

        //Weapon Focus

        tempName = AppLibary.WeaponFocus;
        tempFeature = "You gain a +1 bonus on all attack rolls you make using the selected wepaon.";
        tempDescription = "Choose one type of weapon. You can also choose unarmed strike or grapple (or ray, if you are a spellcaster) as your weapon for the purposes of this feat.";

        Feat weaponFocus = new Feat(tempName, tempFeature, tempDescription, tempSpecial);
        if (!AppLibary.featDictionary.ContainsKey(AppLibary.WeaponFocus))
        {
            AppLibary.featDictionary.Add(AppLibary.WeaponFocus, weaponFocus);
        }

        //End Weapon Focus
        #endregion FeatInitalization 
    }

    void InitalizeItems()
    {
        #region ItemInitalization
        
        #region Weapons
        #region SimpleWeapons

        //Gauntlet
        tempType = "Weapon, Unarmed Attacks";
        tempitemName = "Gauntlet";
        tempCost = 2;
        tempDamageS = "1d2";
        tempDamageM = "1d3";
        tempCritical = "x2";
        tempRange = 0;
        tempWeight = 1;
        tempDamageType = "B";
        tempDescription = "This metal glove lets you deal lethal damage rather than nonleathal damage. The cost and weight is for a single gauntlet. Medium and heavy-armors (except for breastplate) come with gauntlets. your opponent cannot use a disarm action to disarm you of gauntlets.";

        Item gauntlet = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Gauntlet))
        {
            AppLibary.itemDictionary.Add(AppLibary.Gauntlet, gauntlet);
        }

        //End Gauntlet

        //Unarmed Strike
        tempType = "Weapon, Unarmed Attack";
        tempitemName = "Unarmed Strike";
        tempCost = 0;
        tempDamageS = "1d2";
        tempDamageM = "1d3";
        tempCritical = "x2";
        tempRange = 0;
        tempWeight = 0;
        tempDamageType = "B";
        tempDescription = "Unarmed strikes are always considered light weapons.";

        Item unarmedStrike = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.UnarmedStrike))
        {
            AppLibary.itemDictionary.Add(AppLibary.UnarmedStrike, unarmedStrike);
        }

        //End Unarmed Strike

        //Dagger
        tempType = "Weapon, , Light";
        tempitemName = "Dagger";
        tempCost = 2;
        tempDamageS = "1d3";
        tempDamageM = "1d3";
        tempCritical = "19-20/x2";
        tempRange = 10;
        tempWeight = 1;
        tempDamageType = "P or S";
        tempSpecialAbility = "You get a +2 bonus on slight of hand skill checks made to conceal a dagger on your body.";
        tempDescription = "A dagger has a blade that is about 1 food in length.";

        Item dagger = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Dagger))
        {
            AppLibary.itemDictionary.Add(AppLibary.Dagger, dagger);
        }

        tempSpecialAbility = "";
        //End Dagger

        //Dagger, Punching
        tempType = "Weapon , Light";
        tempitemName = "Dagger, Punching";
        tempCost = 2;
        tempDamageS = "1d3";
        tempDamageM = "1d4";
        tempCritical = "x3";
        tempRange = 0;
        tempWeight = 1;
        tempDamageType = "P";
        tempDescription = "A punching dagger's blade is attached to a horizontal handle that projects out from the fist when held.";

        Item daggerPunching = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.DaggerPunching))
        {
            AppLibary.itemDictionary.Add(AppLibary.DaggerPunching, daggerPunching);
        }

        //End Dagger, Punching

        //Gauntlet, Spiked
        tempType = "Weapon, Light";
        tempitemName = "Gauntlet, Spiked";
        tempCost = 2;
        tempDamageS = "1d3";
        tempDamageM = "1d4";
        tempCritical = "x2";
        tempRange = 0;
        tempWeight = 1;
        tempDamageType = "P";
        tempSpecialAbility = "Your opponent cannot use a disarm action to disarm you of spiked gauntlets.";
        tempDescription = "The cost and weight given are for a single gauntlet.";

        Item spikedGauntlet = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.GauntletSpiked))
        {
            AppLibary.itemDictionary.Add(AppLibary.GauntletSpiked, spikedGauntlet);
        }

        tempSpecialAbility = "";
        //End Gauntlet, Spiked

        //Mace, light
        tempType = "Weapon, Light";
        tempitemName = "Mace, Light";
        tempCost = 5;
        tempDamageS = "1d4";
        tempDamageM = "1d6";
        tempCritical = "x2";
        tempRange = 0;
        tempWeight = 4;
        tempDamageType = "B";
        tempDescription = "A mace is made up of an ornate metal head attached to a simple wooden or metal shaft.";

        Item maceLight = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.MaceLight))
        {
            AppLibary.itemDictionary.Add(AppLibary.MaceLight, maceLight);
        }
        //End Mace, light

        //Sickle
        tempType = "Weapon, Light";
        tempitemName = "Sickle";
        tempCost = 6;
        tempDamageS = "1d4";
        tempDamageM = "1d6";
        tempCritical = "x2";
        tempRange = 0;
        tempWeight = 2;
        tempDamageType = "S";
        tempSpecialAbility = "You may make trip attacks with this weapon.";
        tempDescription = "A simple farming impliment, consisting of a curved blade attaching to a short wooden or metal handle.";

        Item sickle = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Sickle))
        {
            AppLibary.itemDictionary.Add(AppLibary.Sickle, sickle);
        }

        tempSpecialAbility = "";
        //End Sickle

        //Club
        tempType = "Weapon, One Handed Melee";
        tempitemName = "Club";
        tempCost = 0;
        tempDamageS = "1d4";
        tempDamageM = "1d6";
        tempCritical = "x2";
        tempRange = 10;
        tempWeight = 3;
        tempDamageType = "B";
        tempDescription = "A large wooden piece of wood, used for clobbering.";

        Item club = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Club))
        {
            AppLibary.itemDictionary.Add(AppLibary.Club, club);
        }
        //End Club

        //Mace, Heavy
        tempType = "Weapon, One Handed Melee";
        tempitemName = "Mace, Heavy";
        tempCost = 12;
        tempDamageS = "1d6";
        tempDamageM = "1d8";
        tempCritical = "x2";
        tempRange = 0;
        tempWeight = 8;
        tempDamageType = "B";
        tempDescription = "A heavy mace has a larger head and a longer shaft than a normal mace.";

        Item maceHeavy = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.MaceHeavy))
        {
            AppLibary.itemDictionary.Add(AppLibary.MaceHeavy, maceHeavy);
        }

        //End Mace, Heavy

        //Morningstar
        tempType = "Weapon, One Handed Melee";
        tempitemName = "Morningstar";
        tempCost = 8;
        tempDamageS = "1d6";
        tempDamageM = "1d8";
        tempCritical = "x2";
        tempRange = 0;
        tempWeight = 6;
        tempDamageType = "B and P";
        tempDescription = "A morningstar is a spiked metal ball, affixed to the top of a long handle.";

        Item morningstar = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Morningstar))
        {
            AppLibary.itemDictionary.Add(AppLibary.Morningstar, morningstar);
        }

        //End Morningstar

        //Shortspear
        tempType = "Weapon, One Handed Melee";
        tempitemName = "Shortspear";
        tempCost = 1;
        tempDamageS = "1d4";
        tempDamageM = "1d6";
        tempCritical = "x2";
        tempRange = 20;
        tempWeight = 3;
        tempDamageType = "P";
        tempDescription = "A shortspear is about 3 feet in length, making it a suitable thrown weapon.";

        Item shortspear = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Shortspear))
        {
            AppLibary.itemDictionary.Add(AppLibary.Shortspear, shortspear);
        }

        //End Shortspear

        //Longspear
        tempType = "Weapon, Two Handed Melee";
        tempitemName = "Longspear";
        tempCost = 0;
        tempDamageS = "1d6";
        tempDamageM = "1d8";
        tempCritical = "x3";
        tempRange = 10;
        tempWeight = 9;
        tempSpecial = "Brace (If you use a readied action to set a brace weapon against a charge, you deal double damage on a successful hit against a charging creature), Reach (can only attack 10 feet away)";
        tempDamageType = "P";
        tempDescription = "A longspear is about 8 feet in length.";

        Item longspear = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Longspear))
        {
            AppLibary.itemDictionary.Add(AppLibary.Longspear, longspear);
        }

        tempSpecial = "";
        //End Longspear

        //Quarterstaff
        tempType = "Weapon, Two Handed Melee";
        tempitemName = "Quaterstaff";
        tempCost = 0;
        tempDamageS = "1d4/1d4";
        tempDamageM = "1d6/1d6";
        tempCritical = "x2";
        tempRange = 0;
        tempWeight = 4;
        tempDamageType = "B";
        tempSpecial = "Double (can be either used as a 2 handed with 1 attack, or dual wielding with all the normal penalities for a single handed and a light weapon), Monk (this weapon can be used by a monk for flurry of blows).";
        tempDescription = "A quaterstaff is a simple piece of wood about 5 feet in length.";

        Item quaterstaff = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Quaterstaff))
        {
            AppLibary.itemDictionary.Add(AppLibary.Quaterstaff, quaterstaff);
        }

        tempSpecial = "";
        //End Quarterstaff

        //Spear
        tempType = "Weapon, Two Handed Melee";
        tempitemName = "Spear";
        tempCost = 1;
        tempDamageS = "1d6";
        tempDamageM = "1d8";
        tempCritical = "x3";
        tempRange = 20;
        tempWeight = 6;
        tempDamageType = "P";
        tempSpecial = "Brace (If you use a readied action to set a brace weapon against a charge, you deal double damage on a successful hit against a charging creature).";
        tempDescription = "A spear is 5ft in length and can be thrown.";

        Item spear = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Spear))
        {
            AppLibary.itemDictionary.Add(AppLibary.Spear, spear);
        }

        tempSpecial = "";
        //End, Spear

        //Blowgun
        tempType = "Weapon, Ranged";
        tempitemName = "Blowgun";
        tempCost = 2;
        tempDamageS = "1";
        tempDamageM = "1d2";
        tempCritical = "x2";
        tempRange = 20;
        tempWeight = 1;
        tempDamageType = "P";
        tempDescription = "Blowguns are generally used to deliver debilitating poisons from a distance. They are nearly silent when fired.";

        Item blowgun = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Blowgun))
        {
            AppLibary.itemDictionary.Add(AppLibary.Blowgun, blowgun);
        }

        //End Blowgun

        //Darts, Blowgun
        tempType = "Weapon, Ranged";
        tempitemName = "Darts, Blowgun";
        tempCost = 1;
        tempDamageS = "see blowgun";
        tempDamageM = "see blowgun";
        tempCritical = "see blowgun";
        tempRange = 0;
        tempWeight = 0.1f;
        tempDamageType = "P";
        tempDescription = "Darts for a blowgun.";

        Item dartsBlowgun = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.BlowgunDarts))
        {
            AppLibary.itemDictionary.Add(AppLibary.BlowgunDarts, dartsBlowgun);
        }

        //End Darts, Blowgun

        //Crossbow, Heavy
        tempType = "Weapon, Ranged";
        tempitemName = "Crossbow, Heavy";
        tempCost = 50;
        tempDamageS = "1d8";
        tempDamageM = "1d10";
        tempCritical = "19-20/x2";
        tempRange = 120;
        tempWeight = 8;
        tempDamageType = "P";
        tempDescription = "You load a heavy crossbow back by turning a small winch. Loading a heavy crossbow is a full-round action that provokes attacks of opportunity. Normally, operating a heavy crossbow requires two hands. However, you can shoot, but not load, a heavy crossbow with one hand at a -4 penalty on attack rolls. You can shoot a heavy crossbow with each hand, but you take a penalty on attack rolls as if attacking with two one-handed weapons. This penalty is cummulative with the penalty for one-handed fireing.";

        Item crossbowHeavy = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.CrossbowHeavy))
        {
            AppLibary.itemDictionary.Add(AppLibary.CrossbowHeavy, crossbowHeavy);
        }

        //End Crossbow, Heavy

        //Crossbow, Light
        tempType = "Weapon, Ranged";
        tempitemName = "Crossbow, Light";
        tempCost = 35;
        tempDamageS = "1d6";
        tempDamageM = "1d8";
        tempCritical = "19-20/x2";
        tempRange = 80;
        tempWeight = 4;
        tempDamageType = "P";
        tempDescription = "You draw a light crossbow back by pulling a lever. This is a move action that provokes attacks of opportunity. Normaly, operating a light crossbow requries two hands. You can shoot, but not load, with one hand at a -2 penalty. You can fire with two light crossbows in each hand, but you take a penalty on attack rolls as if attacking with two light weapons. This penalty is cumulative with the penalty for one-hand firing. ";

        Item crossbowLight = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.CrossbowLight))
        {
            AppLibary.itemDictionary.Add(AppLibary.CrossbowLight, crossbowLight);
        }

        //End Crossbow, Light

        //Dart
        tempType = "Weapon, Ranged";
        tempitemName = "Dart";
        tempCost = 0;
        tempDamageS = "1d3";
        tempDamageM = "1d4";
        tempCritical = "x2";
        tempRange = 20;
        tempWeight = 0.5f;
        tempDamageType = "P";
        tempDescription = "A small weighted dart. ";

        Item dart = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Darts))
        {
            AppLibary.itemDictionary.Add(AppLibary.Darts, dart);
        }

        //End Dart

        //Javelin
        tempType = "Weapon, Ranged";
        tempitemName = "Javilin";
        tempCost = 1;
        tempDamageS = "1d4";
        tempDamageM = "1d6";
        tempCritical = "x2";
        tempRange = 30;
        tempWeight = 2;
        tempDamageType = "P";
        tempDescription = "A javelin is a thin throwing spear. Since it is not designed for melee, you are treated as nonproficient iwth it and take a -4 penalty on attack rolls if you use a javelin as a melee weapon.";

        Item javilin = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Javelin))
        {
            AppLibary.itemDictionary.Add(AppLibary.Javelin, javilin);
        }

        //End Javelin

        //Sling
        tempType = "Weapon, Ranged";
        tempitemName = "Sling";
        tempCost = 0;
        tempDamageS = "1d3";
        tempDamageM = "1d4";
        tempCritical = "x2";
        tempRange = 50;
        tempWeight = 0;
        tempDamageType = "B";
        tempDescription = "A sling is little more than a leather cup attached to a pair of strings. Your Strength modifier applies to damage rolls when you use a sling, just as it does for thrown weapons. You can fire but not load a sling with one hand. You can use normal stones but they take a -1 penalty to attack rolls and such an attack deals damage one size catagory smaller.";

        Item sling = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Sling))
        {
            AppLibary.itemDictionary.Add(AppLibary.Sling, sling);
        }
        //End Sling

        //Bolts, Crossbow
        tempType = "Weapon, Ranged";
        tempitemName = "Bolts, Crossbow";
        tempCost = 1;
        tempDamageS = "N/A";
        tempDamageM = "N/A";
        tempCritical = "N/A";
        tempRange = 0;
        tempWeight = 0;
        tempDamageType = "P";
        tempDescription = "A crossbow bolt used as a melee weapon is treated as a light improvised weapon (-4 penalty on attack rolls) and deals damage as a dagger of its size (crit x2). Bolts come in a case or quiver that holds 10 bolts (or 5, for a repeating crossbow).";

        Item boltsCrossbow = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.CrossbowBolts))
        {
            AppLibary.itemDictionary.Add(AppLibary.CrossbowBolts, boltsCrossbow);
        }
        //End Bolts, Crossbow

        //Bullet, Sling
        tempType = "Weapon, Ranged";
        tempitemName = "Bullet, Sling";
        tempCost = 1;
        tempDamageS = "N/A";
        tempDamageM = "N/A";
        tempCritical = "N/A";
        tempRange = 0;
        tempWeight = 0;
        tempDamageType = "B";
        tempDescription = "Bullet, Sling";

        Item bulletSling = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.BulletsSling))
        {
            AppLibary.itemDictionary.Add(AppLibary.BulletsSling, bulletSling);
        }
        //End Bullet, Sling
        #endregion SimpleWeapons
        #region Martial Weapons

        //Axe, Throwing
        tempType = "Weapon, Light";
        tempitemName = "Axe, Throwing";
        tempCost = 8;
        tempDamageS = "1d4";
        tempDamageM = "1d6";
        tempCritical = "x2";
        tempRange = 10;
        tempWeight = 2;
        tempDamageType = "S";
        tempDescription = "A small weighted axe, weighted for throwing.";

        Item axeThrowing = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.AxeThrowing))
        {
            AppLibary.itemDictionary.Add(AppLibary.AxeThrowing, axeThrowing);
        }
        //End Axe, Throwing

        //Hammer, light
        tempType = "Weapon, Light";
        tempitemName = "Hammer, Light";
        tempCost = 1;
        tempDamageS = "1d3";
        tempDamageM = "1d4";
        tempCritical = "x2";
        tempRange = 20;
        tempWeight = 2;
        tempDamageType = "B";
        tempDescription = "A short weighted hammer, great for cracking skulls.";

        Item hammerLight = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.HammerLight))
        {
            AppLibary.itemDictionary.Add(AppLibary.HammerLight, hammerLight);
        }

        //End Hammer, light

        //Handaxe
        tempType = "Weapon, Light";
        tempitemName = "Handaxe";
        tempCost = 6;
        tempDamageS = "1d4";
        tempDamageM = "1d6";
        tempCritical = "x3";
        tempRange = 0;
        tempWeight = 3;
        tempDamageType = "S";
        tempDescription = "A simple axe.";

        Item handaxe = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Handaxe))
        {
            AppLibary.itemDictionary.Add(AppLibary.Handaxe, handaxe);
        }

        //End Handaxe

        //Kurki
        tempType = "Weapon, Light";
        tempitemName = "Kukri";
        tempCost = 8;
        tempDamageS = "1d3";
        tempDamageM = "1d4";
        tempCritical = "18-20/x2";
        tempRange = 0;
        tempWeight = 2;
        tempDamageType = "S";
        tempDescription = "A curved blade about 1 foot in length.";

        Item kukri = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Kukri))
        {
            AppLibary.itemDictionary.Add(AppLibary.Kukri, kukri);
        }

        //End Kurki

        //Pick, Light
        tempType = "Weapon, Light";
        tempitemName = "Pick, Light";
        tempCost = 4;
        tempDamageS = "1d3";
        tempDamageM = "1d4";
        tempCritical = "x4";
        tempRange = 0;
        tempWeight = 3;
        tempDamageType = "P";
        tempDescription = "A small sharp pick.";

        Item pickLight = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.PickLight))
        {
            AppLibary.itemDictionary.Add(AppLibary.PickLight, pickLight);
        }

        //End Pick, Light

        //Sap
        tempType = "Weapon, Light";
        tempitemName = "Sap";
        tempCost = 1;
        tempDamageS = "1d4";
        tempDamageM = "1d6";
        tempCritical = "x2";
        tempRange = 0;
        tempWeight = 2;
        tempSpecial = "nonleathal (This weapon does nonlethal damage.";
        tempDamageType = "P";
        tempDescription = "A small sharp pick.";

        Item sap = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Sap))
        {
            AppLibary.itemDictionary.Add(AppLibary.Sap, sap);
        }

        //End Sap

        //Shield, Light
        tempType = "Weapon, Light";
        tempitemName = "Shield, Light (As weapon)";
        tempCost = 5;
        tempDamageS = "1d2";
        tempDamageM = "1d3";
        tempCritical = "x2";
        tempRange = 0;
        tempWeight = 2;
        tempSpecial = "Cost and weight vary depending on what the shield is made of.";
        tempDamageType = "B";
        tempDescription = "You can bash with a shield rather than using it for defense..";

        Item shieldLight = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.SheildLight))
        {
            AppLibary.itemDictionary.Add(AppLibary.SheildHeavy, shieldLight);
        }
        //End Shield, Light

        //Spiked Armor
        tempType = "Weapon, Light";
        tempitemName = "Spiked Armor";
        tempCost = 5;
        tempDamageS = "1d4";
        tempDamageM = "1d6";
        tempCritical = "x2";
        tempRange = 0;
        tempWeight = 2;
        tempSpecial = "Cost and weight vary depending on what the armor is made of.";
        tempDamageType = "P";
        tempDescription = "Your spikes on your armor can be used as weapons.";

        Item spikedArmor = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.SpikedArmor))
        {
            AppLibary.itemDictionary.Add(AppLibary.SpikedArmor, spikedArmor);
        }
        //End Spiked Armor

        //Spiked Shield, Light
        tempType = "Weapon, Light";
        tempitemName = "Spiked Shield, Light";
        tempCost = 5;
        tempDamageS = "1d3";
        tempDamageM = "1d4";
        tempCritical = "x2";
        tempRange = 0;
        tempWeight = 2;
        tempSpecial = "Cost and weight vary depending on what the shield is made of.";
        tempDamageType = "P";
        tempDescription = "You can bash with a shield rather than using it for defense.";

        Item spikedShieldLight = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.SpikedShieldlight))
        {
            AppLibary.itemDictionary.Add(AppLibary.SpikedShieldlight, spikedShieldLight);
        }

        tempSpecial = "";
        //End Spiked Shield, Light

        //Starkinfe
        tempType = "Weapon, Light";
        tempitemName = "Starknife";
        tempCost = 24;
        tempDamageS = "1d3";
        tempDamageM = "1d4";
        tempCritical = "x3";
        tempRange = 20;
        tempWeight = 3;
        tempDamageType = "P";
        tempDescription = "From a central metal ring, four tapering metal blades extend like points on a compass rose. A wielder can stab with the starknife or throw it.";

        Item starknife = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Starknife))
        {
            AppLibary.itemDictionary.Add(AppLibary.Starknife, starknife);
        }

        //End Starknife

        //Sword, Short
        tempType = "Weapon, Light";
        tempitemName = "Sword, Short";
        tempCost = 10;
        tempDamageS = "1d4";
        tempDamageM = "1d6";
        tempCritical = "19-20/x2";
        tempRange = 0;
        tempWeight = 2;
        tempDamageType = "S/P";
        tempDescription = "A simple short sword.";

        Item swordShort = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.SwordShort))
        {
            AppLibary.itemDictionary.Add(AppLibary.SwordShort, swordShort);
        }
        //End Sword, Short

        //Battleaxe
        tempType = "Weapon, One Handed Melee";
        tempitemName = "Battleaxe";
        tempCost = 10;
        tempDamageS = "1d6";
        tempDamageM = "1d8";
        tempCritical = "x3";
        tempRange = 0;
        tempWeight = 6;
        tempDamageType = "S";
        tempDescription = "A simple battleaxe.";

        Item battleaxe = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Battleaxe))
        {
            AppLibary.itemDictionary.Add(AppLibary.Battleaxe, battleaxe);
        }
        //End Battleaxe.

        //Flail
        tempType = "Weapon, One Handed Melee";
        tempitemName = "Flail";
        tempCost = 8;
        tempDamageS = "1d6";
        tempDamageM = "1d8";
        tempCritical = "x2";
        tempRange = 0;
        tempWeight = 5;
        tempDamageType = "S";
        tempDescription = "A weighted length of metal attached to a stick.";

        Item flail = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Flail))
        {
            AppLibary.itemDictionary.Add(AppLibary.Flail, flail);
        }
        //End Flail

        //Longsword
        tempType = "Weapon, One Handed Melee";
        tempitemName = "Longsword";
        tempCost = 15;
        tempDamageS = "1d6";
        tempDamageM = "1d8";
        tempCritical = "19-20/x2";
        tempRange = 0;
        tempWeight = 4;
        tempDamageType = "S";
        tempDescription = "A simple longsword.";

        Item longsword = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Longsword))
        {
            AppLibary.itemDictionary.Add(AppLibary.Longsword, longsword);
        }
        //End longsword

        //Pick, Heavy
        tempType = "Weapon, One Handed Melee";
        tempitemName = "Pick, Heavy";
        tempCost = 8;
        tempDamageS = "1d4";
        tempDamageM = "1d6";
        tempCritical = "x4";
        tempRange = 0;
        tempWeight = 6;
        tempDamageType = "P";
        tempDescription = "A reinforced battle pick.";

        Item pickHeavy = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.PickHeavy))
        {
            AppLibary.itemDictionary.Add(AppLibary.PickHeavy, pickHeavy);
        }
        //End Pick, Heavy

        //Rapier
        tempType = "Weapon, One Handed Melee";
        tempitemName = "Rapier";
        tempCost = 20;
        tempDamageS = "1d4";
        tempDamageM = "1d6";
        tempCritical = "18-20/x2";
        tempRange = 0;
        tempWeight = 2;
        tempDamageType = "P";
        tempDescription = "You can use the Weapon Finesse feat to apply your Dexterity modifier instead of your Strength modifier to attack rolls with a rapier size for you, even though it isn't a light weapon. You can't wield a rapier in two hands in order to apply 1-1/2 times your Strength to damage.";

        Item rapier = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Rapier))
        {
            AppLibary.itemDictionary.Add(AppLibary.Rapier, rapier);
        }
        //End Rapier

        //Scimitar
        tempType = "Weapon, One Handed Melee";
        tempitemName = "Scimitar";
        tempCost = 15;
        tempDamageS = "1d4";
        tempDamageM = "1d6";
        tempCritical = "18-20/x2";
        tempRange = 0;
        tempWeight = 4;
        tempDamageType = "S";
        tempDescription = "A wicked curved blade.";

        Item scimitar = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Scimitar))
        {
            AppLibary.itemDictionary.Add(AppLibary.Scimitar, scimitar);
        }
        //End Scimitar

        //Shield, Heavy
        tempType = "Weapon, One Handed Melee";
        tempitemName = "Shield, Heavy";
        tempCost = 10;
        tempDamageS = "1d3";
        tempDamageM = "1d4";
        tempCritical = "x2";
        tempRange = 0;
        tempWeight = 6;
        tempSpecial = "Cost and weight depent on the type of shield.";
        tempDamageType = "S";
        tempDescription = "You can attack with your shield instead of using it defensivly.";

        Item shieldHeavy = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.SheildHeavy))
        {
            AppLibary.itemDictionary.Add(AppLibary.SheildHeavy, shieldHeavy);
        }
        //End Shield, Heavy

        //Spiked Shield, Heavy
        tempType = "Weapon, One Handed Melee";
        tempitemName = "Spiked Shield, Heavy";
        tempCost = 10;
        tempDamageS = "1d4";
        tempDamageM = "1d6";
        tempCritical = "x2";
        tempRange = 0;
        tempWeight = 6;
        tempSpecial = "Cost and weight depent on the type of shield.";
        tempDamageType = "S";
        tempDescription = "You can attack with your shield instead of using it defensivly.";

        Item spikedShieldHeavy = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.SpikedShieldHeavy))
        {
            AppLibary.itemDictionary.Add(AppLibary.SpikedShieldHeavy, spikedShieldHeavy);
        }
        tempSpecial = "";
        //End Spiked Shield, Heavy

        //Trident
        tempType = "Weapon, One Handed Melee";
        tempitemName = "Trident";
        tempCost = 15;
        tempDamageS = "1d6";
        tempDamageM = "1d8";
        tempCritical = "x2";
        tempRange = 10;
        tempWeight = 4;
        tempDamageType = "S";
        tempDescription = "A trident has three metal prongs at the end of a 4-foot-long shaft. This weapon can be thrown.";

        Item trident = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Trident))
        {
            AppLibary.itemDictionary.Add(AppLibary.Trident, trident);
        }
        //End Trident

        //Warhammer
        tempType = "Weapon, One Handed Melee";
        tempitemName = "Warhammer";
        tempCost = 12;
        tempDamageS = "1d6";
        tempDamageM = "1d8";
        tempCritical = "x2";
        tempRange = 0;
        tempWeight = 5;
        tempDamageType = "B";
        tempDescription = "A Warhammer has a heavy metal head on a short shaft.";

        Item warhammer = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Warhammer))
        {
            AppLibary.itemDictionary.Add(AppLibary.Warhammer, warhammer);
        }
        //End Warhammer

        //Falchion
        tempType = "Weapon, Two Handed Melee";
        tempitemName = "Falchion";
        tempCost = 75;
        tempDamageS = "1d6";
        tempDamageM = "2d4";
        tempCritical = "18-20/x2";
        tempRange = 0;
        tempWeight = 8;
        tempDamageType = "S";
        tempDescription = "A large two-handed curved blade.";

        Item falchion = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Falchion))
        {
            AppLibary.itemDictionary.Add(AppLibary.Falchion, falchion);
        }
        //End Falchion

        //Glaive
        tempType = "Weapon, Two Handed Melee";
        tempitemName = "Glaive";
        tempCost = 8;
        tempDamageS = "1d8";
        tempDamageM = "1d10";
        tempCritical = "18-20/x2";
        tempRange = 0;
        tempWeight = 10;
        tempSpecial = "Reach (You can attack 10 feet away from you but you cannot attack adjacent to you).";
        tempDamageType = "S";
        tempDescription = "A Glaive consists of a streight or curved blade on the end of a long stick.";

        Item glaive = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Glaive))
        {
            AppLibary.itemDictionary.Add(AppLibary.Glaive, glaive);
        }

        tempSpecial = "";
        //End Glaive

        //Greataxe
        tempType = "Weapon, Two Handed Melee";
        tempitemName = "Greataxe";
        tempCost = 20;
        tempDamageS = "1d10";
        tempDamageM = "1d12";
        tempCritical = "x3";
        tempRange = 0;
        tempWeight = 12;
        tempDamageType = "S";
        tempDescription = "A large two-handed axe.";

        Item greataxe = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Greataxe))
        {
            AppLibary.itemDictionary.Add(AppLibary.Greataxe, greataxe);
        }
        //End Greataxe

        //Greatclub
        tempType = "Weapon, Two Handed Melee";
        tempitemName = "Greatclub";
        tempCost = 5;
        tempDamageS = "1d8";
        tempDamageM = "1d10";
        tempCritical = "x2";
        tempRange = 0;
        tempWeight = 8;
        tempDamageType = "B";
        tempDescription = "A large club.";

        Item greatclub = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Greatclub))
        {
            AppLibary.itemDictionary.Add(AppLibary.Greatclub, greatclub);
        }
        //End Greatclub

        //Flail, Heavy
        tempType = "Weapon, Two Handed Melee";
        tempitemName = "Flail, Heavy";
        tempCost = 15;
        tempDamageS = "1d8";
        tempDamageM = "1d10";
        tempCritical = "19-20/x2";
        tempRange = 0;
        tempWeight = 10;
        tempSpecial = "Disarm (you may made disarm attacks with this weapon), trip (You may make a trip attemp with this weapon).";
        tempDamageType = "S";
        tempDescription = "Similar to a flail, a heavy flail hs a larger metal ball and a longer handle.";

        Item flailHeavy = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.FlailHeavy))
        {
            AppLibary.itemDictionary.Add(AppLibary.FlailHeavy, flailHeavy);
        }
        tempSpecial = "";
        //End Flail, Heavy

        //Greatsword
        tempType = "Weapon, Two Handed Melee";
        tempitemName = "Greatsword";
        tempCost = 50;
        tempDamageS = "1d10";
        tempDamageM = "2d16";
        tempCritical = "19-20/x2";
        tempRange = 0;
        tempWeight = 8;
        tempDamageType = "S";
        tempDescription = "This immense two-handed sword is about 5 feet in length.";

        Item greatsword = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Greatsword))
        {
            AppLibary.itemDictionary.Add(AppLibary.Greatsword, greatsword);
        }
        //End Greatsword

        //Guisarme
        tempType = "Weapon, Two Handed Melee";
        tempitemName = "Guisarme";
        tempCost = 9;
        tempDamageS = "1d6";
        tempDamageM = "2d4";
        tempCritical = "x3";
        tempRange = 0;
        tempWeight = 12;
        tempSpecial = "Reach (You can attack 10 feet away from you but you cannot attack adjacent to you), Trip (You may make trip attacks with this weapon).";
        tempDamageType = "S";
        tempDescription = "A guisarme is an 8-foot-long shaft with a blade and hook mounted at the top.";

        Item guisarme = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Guisarme))
        {
            AppLibary.itemDictionary.Add(AppLibary.Guisarme, guisarme);
        }
        //End Guisarme

        //Halberd
        tempType = "Weapon, Two Handed Melee";
        tempitemName = "Halberd";
        tempCost = 10;
        tempDamageS = "1d8";
        tempDamageM = "1d10";
        tempCritical = "x3";
        tempRange = 0;
        tempWeight = 12;
        tempSpecial = "Brace (When you use a readied action to set a brace weapon against a charge, you deal double damage on a successful hit against a charging creature), Trip (You may make trip attacks with this weapon).";
        tempDamageType = "P or S";
        tempDescription = "A halberd is similar to a 5-foot-long spear, but it also has a small, axe-like head mounted near the tip.";

        Item halberd = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Halberd))
        {
            AppLibary.itemDictionary.Add(AppLibary.Halberd, halberd);
        }
        //End Halberd

        //Lance
        tempType = "Weapon, Two Handed Melee";
        tempitemName = "Lance";
        tempCost = 10;
        tempDamageS = "1d6";
        tempDamageM = "1d8";
        tempCritical = "x3";
        tempRange = 0;
        tempWeight = 12;
        tempSpecial = "Reach (You can attack 10 feet away from you but you cannot attack adjacent to you).";
        tempDamageType = "P";
        tempDescription = "A long stick with a metal tip, ment to be used from horseback. A lance deals double damge when used from the back of a charging mount. WHile mounted, you can wield a lance with one hand.";

        Item lance = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Lance))
        {
            AppLibary.itemDictionary.Add(AppLibary.Lance, lance);
        }
        //End Lance

        //Ranseur
        tempType = "Weapon, Two Handed Melee";
        tempitemName = "Ranseur";
        tempCost = 10;
        tempDamageS = "1d6";
        tempDamageM = "2d4";
        tempCritical = "x3";
        tempRange = 0;
        tempWeight = 12;
        tempSpecial = "Reach (You can attack 10 feet away from you but you cannot attack adjacent to you), Disarm (When you use a disarm weapon, you gain a +2 bonus on Combat Maneuver checks to disarm an enemy).";
        tempDamageType = "P";
        tempDescription = "Similar in apperance ot a trident, a ranseur has a single spear at its tip, flanked bya a pair of short, curving blades.";

        Item ranseur = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Ranseur))
        {
            AppLibary.itemDictionary.Add(AppLibary.Ranseur, ranseur);
        }
        //Ranseur

        //Scythe
        tempType = "Weapon, Two Handed Melee";
        tempitemName = "Scythe";
        tempCost = 18;
        tempDamageS = "1d6";
        tempDamageM = "2d4";
        tempCritical = "x4";
        tempRange = 0;
        tempWeight = 10;
        tempSpecial = "Trip (You can use a trip weapon to make trip attacks. If you are tripped during your own trip attemp, you can drop the weapon to avoid being tripped).";
        tempDamageType = "P";
        tempDescription = "A scythe is a long curved blade attacked to the top of a long shaft.";

        Item scythe = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Scythe))
        {
            AppLibary.itemDictionary.Add(AppLibary.Scythe, scythe);
        }
        tempSpecial = "";
        //End Scythe

        //Longbow
        tempType = "Weapon, Ranged";
        tempitemName = "Longbow";
        tempCost = 75;
        tempDamageS = "1d6";
        tempDamageM = "1d8";
        tempCritical = "x3";
        tempRange = 100;
        tempWeight = 2;
        tempDamageType = "P";
        tempDescription = "At almost 5 feet in height, a longbow is made up of one solid piece of carefully curved wood. You need two hands to use a bow, regardless of its size. A longbow is too unwieldy to use while you are mounted. If you have a penalty for low Strength, apply it to damage rolls when you use a longbow. If you have a Strength bonus, you can apply it to damage rolls when you use a composite longbow, but not when you use a regular longbow.";

        Item longbow = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Longbow))
        {
            AppLibary.itemDictionary.Add(AppLibary.Longbow, longbow);
        }
        //End Longbow

        //Longbow, Composite
        tempType = "Weapon, Ranged";
        tempitemName = "Longbow, Composite";
        tempCost = 100;
        tempDamageS = "1d6";
        tempDamageM = "1d8";
        tempCritical = "x3";
        tempRange = 110;
        tempWeight = 3;
        tempDamageType = "P";
        tempDescription = "You need at least two hands to use a bow, regaurdless of size. You can use a composite longbow while mounted. All composite bows are mae with a particular strength rating. If your Strength bonus is less than the strength rating of the composite bow, you can't effectivly use it, so you take a -2 penalty on attacks with it. The default composite longbow requires a Strength modifier of +0 or higher to use with proficiency. A composite longbow can be made with a high strength rating to take advantage of an above-average Strength score; this feature allows you to add your Strength bonus to damge, up to the maximum bonus indicated for the bow. Each point of Strength bonus granted by the bow adds 100gp to the cost. If you have a penalty for low Strength, apply it to damge rolls when you use a composite longbow. For purposes of Weapon Proficiency and similar feats, a composite longbow is treated as a normal longbow.";

        Item longbowComposite = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.LongbowComposite))
        {
            AppLibary.itemDictionary.Add(AppLibary.LongbowComposite, longbowComposite);
        }
        //End Longbow, Composite

        //Shortbow
        tempType = "Weapon, Ranged";
        tempitemName = "Shortbow";
        tempCost = 30;
        tempDamageS = "1d4";
        tempDamageM = "1d6";
        tempCritical = "x3";
        tempRange = 60;
        tempWeight = 2;
        tempDamageType = "P";
        tempDescription = "A shortbow is made out of one piece of wood about 3 feet in length. You need two hands to use a bow regardless of length. You can use a shortbow while mounted. If you have a penalty for low Strength, apply it to damage rolls when you use a shortbow. If you have a bonus for high Strength, you can apply it to damage rolls when youuse a composite shortbow, but not a regualar shortbow.";

        Item shortbow = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Shortbow))
        {
            AppLibary.itemDictionary.Add(AppLibary.Shortbow, shortbow);
        }
        //End Shortbow

        //Composite Shortbow
        tempType = "Weapon, Ranged";
        tempitemName = "Longbow, Composite";
        tempCost = 100;
        tempDamageS = "1d6";
        tempDamageM = "1d8";
        tempCritical = "x3";
        tempRange = 110;
        tempWeight = 3;
        tempDamageType = "P";
        tempDescription = "You need at least two hands to use a bow, regaurdless of size. You can use a composite shortbow while mounted. All composite bows are mae with a particular strength rating. If your Strength bonus is less than the strength rating of the composite bow, you can't effectivly use it, so you take a -2 penalty on attacks with it. The default composite shortbow requires a Strength modifier of +0 or higher to use with proficiency. A composite shortbow can be made with a high strength rating to take advantage of an above-average Strength score; this feature allows you to add your Strength bonus to damge, up to the maximum bonus indicated for the bow. Each point of Strength bonus granted by the bow adds 100gp to the cost. If you have a penalty for low Strength, apply it to damge rolls when you use a composite shortbow. For purposes of Weapon Proficiency and similar feats, a composite shortbow is treated as a normal shortbow.";

        Item shortbowComposite = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.ShortbowComposite))
        {
            AppLibary.itemDictionary.Add(AppLibary.ShortbowComposite, shortbowComposite);
        }
        //End Composite Shortbow

        //Arrows, Bow
        tempType = "Weapon, Ranged";
        tempitemName = "Arrows, Bow";
        tempCost = 1;
        tempDamageS = "-";
        tempDamageM = "-";
        tempCritical = "-";
        tempRange = 0;
        tempWeight = 3;
        tempDamageType = "P";
        tempDescription = "An arrow used as a melee weapon is treated as a light improvised weapon (-4 penalty on attack rolls) and deals damage as a dagger of its size (crit x2). Arrows come in a leather quiver that holds 20 arrows.";

        Item arrowsBow = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.BowArrow))
        {
            AppLibary.itemDictionary.Add(AppLibary.BowArrow, arrowsBow);
        }
        //Arrows, Bow


        #endregion Martial Weapons
        #region Exotic Weapons

        //Light Melee Weapons
        tempType = "Weapon, Light";
        tempitemName = "Kama";
        tempCost = 2;
        tempDamageS = "1d4";
        tempDamageM = "1d6";
        tempCritical = "x2";
        tempRange = 0;
        tempWeight = 2;
        tempSpecial = "Monk (A monk weapon can be used by a monk to perform a flurry of blows). Trip (You can make a trip attack with this weapon, if you are tripped during your tripp attempt you can drop this weapon to advoid being tripped.";
        tempDamageType = "S";
        tempDescription = "A heavy curved short blade.";

        Item kama = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Kama))
        {
            AppLibary.itemDictionary.Add(AppLibary.Kama, kama);
        }
        //End Light Melee Weapons

        //Nunchaku
        tempType = "Weapon, Light";
        tempitemName = "Nunchaku";
        tempCost = 2;
        tempDamageS = "1d4";
        tempDamageM = "1d6";
        tempCritical = "x2";
        tempRange = 0;
        tempWeight = 2;
        tempSpecial = "Disarm (When you use a disarm weapon, you get a +2 bonus on Combat Maneuver Checks to disarm an enemy). Monk (A monk weapon can be used by a monk to perform a flurry of blows). ";
        tempDamageType = "B";
        tempDescription = "Two wooden or metal lengths of wood attached by a chain.";

        Item nunchaku = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Nunchaku))
        {
            AppLibary.itemDictionary.Add(AppLibary.Nunchaku, nunchaku);
        }
        //End Nunchaku

        //Sai
        tempType = "Weapon, Light";
        tempitemName = "Sai";
        tempCost = 1;
        tempDamageS = "1d3";
        tempDamageM = "1d4";
        tempCritical = "x2";
        tempRange = 0;
        tempWeight = 1;
        tempSpecial = "Disarm (When you use a disarm weapon, you get a +2 bonus on Combat Maneuver Checks to disarm an enemy). Monk (A monk weapon can be used by a monk to perform a flurry of blows). ";
        tempDamageType = "B";
        tempDescription = "A sai is a metal spike flanked by a pair of prongs used to trap an enemy's weapon. With a sai, you get a +2 bonus on Combat Maneuver Checks to sunder an enemy's weapon. Though pointed, a sai is used primarily to bludgeon foes and to diarm weapons.";

        Item sai = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Sai))
        {
            AppLibary.itemDictionary.Add(AppLibary.Sai, sai);
        }
        //End Sai

        //Siangham
        tempType = "Weapon, Light";
        tempitemName = "Nunchaku";
        tempCost = 2;
        tempDamageS = "1d4";
        tempDamageM = "1d6";
        tempCritical = "x2";
        tempRange = 0;
        tempWeight = 2;
        tempSpecial = "Monk (A monk weapon can be used by a monk to perform a flurry of blows). ";
        tempDamageType = "P";
        tempDescription = "This weapon is a handheld shaft fitted with a pointed tip for stabbing foes.";

        Item siangham = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Siangham))
        {
            AppLibary.itemDictionary.Add(AppLibary.Siangham, siangham);
        }
        //End Siangham

        //Sword, Bastard
        tempType = "Weapon, One-Handed Melee Wapon";
        tempitemName = "Sword, Bastard";
        tempCost = 35;
        tempDamageS = "1d8";
        tempDamageM = "1d10";
        tempCritical = "19-20/x2";
        tempRange = 0;
        tempWeight = 6;
        tempDamageType = "S";
        tempDescription = "A bastard sword is about 4 feet in length, making it too large to use in one hand without special trrianing; thus, it is an  exotic weapon. A character can ust a bastard sword as a two-handed weapon as a martial weapon.";

        Item bastardSword = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.SwordBastard))
        {
            AppLibary.itemDictionary.Add(AppLibary.SwordBastard, bastardSword);
        }
        //End Sword, Bastard

        //Waraxe, Dwarven
        tempType = "Weapon, One-Handed Melee Wapon";
        tempitemName = "Waraxe, Dwarven";
        tempCost = 30;
        tempDamageS = "1d8";
        tempDamageM = "1d10";
        tempCritical = "x3";
        tempRange = 0;
        tempWeight = 8;
        tempDamageType = "S";
        tempDescription = "A dwarven waraxe has a large, ornate head mounted to a thick handle, making it to large too use in one hand without special training; thus, it is an exotic weapon. A Medium chracter can use a dwarven waraxe tow-handed as a martial weapon, or a Large creature can use it one-handed in the same way. A dwarf treats a dwarven waraxe as a martial weapon even when using it in one hand.";

        Item dwarvenWaraxe = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.WaraxeDwarven))
        {
            AppLibary.itemDictionary.Add(AppLibary.WaraxeDwarven, dwarvenWaraxe);
        }
        //End Waraxe, Dwarven

        //Whip
        tempType = "Weapon, One-Handed Melee Wapon";
        tempitemName = "Whip";
        tempCost = 1;
        tempDamageS = "1d2";
        tempDamageM = "1d3";
        tempCritical = "x2";
        tempRange = 0;
        tempWeight = 2;
        tempSpecial = "Disarm (When you use a disarm weapon, you get a +2 bonus on Combat Maneuver Checks to disarm an enemy), Nonleathal (These weapons deal nonlethal damage), Trip (You can use a trip weapon to make trip attacks. If you are tripped during your own trip attempt, you can drop the weapon to avoid being tripped), Reach(You use a reach weapon to strike opponents 15 feet away).";
        tempDamageType = "S";
        tempDescription = "A whip deals no damage to any creature with an armor bonus of +1 or higher or a natural armor bonus of +3 or higher. The whip is treated as a melee weapon with a 15-ft reach, though you don't threaten the area into which you can make an attack. In addition, unlike most other wapons with reach, you may use it against foes anywhere within your reach (including adjacent foes). Using a whip provokes an attack of opportunity, just as if you used a ranged weapon. You can use the Weapon Finesse feat to apply you Dexterity modifier instead of your Strength modifier to attack rolls with a whip sized for you, even though it isn't a light weapon.";

        Item whip = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Whip))
        {
            AppLibary.itemDictionary.Add(AppLibary.Whip, whip);
        }
        //End Whip

        //Axe, orc double
        tempType = "Weapon, Two-Handed Melee Wapon";
        tempitemName = "Axe, Orc Double";
        tempCost = 60;
        tempDamageS = "1d6/1d6";
        tempDamageM = "1d8/1d8";
        tempCritical = "x3";
        tempRange = 0;
        tempWeight = 15;
        tempSpecial = "Double (You can use a double weapon to fight as if fighting with two weapons, but if you do, you incur all the normal attack penalties associated with fighting with two weapons, just as if you were using a one-handed weapon and a light weapon. You can choose to wield one end of a double weapon two-handed, but it cannot be used as a double weapon when wielded in this way—only one end of the weapon can be used in any given round).";
        tempDamageType = "S";
        tempDescription = "A cruel weapon with blades placed at opposite ends of a long haft, an orc double axe is a double weapon.";

        Item axeOrcDouble = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.AxeOrcDouble))
        {
            AppLibary.itemDictionary.Add(AppLibary.AxeOrcDouble, axeOrcDouble);
        }
        //End Axe, orc double

        //Chain, spiked
        tempType = "Weapon, Two-Handed Melee Wapon";
        tempitemName = "Chain, Spiked";
        tempCost = 25;
        tempDamageS = "1d6";
        tempDamageM = "2d4";
        tempCritical = "x2";
        tempRange = 0;
        tempWeight = 10;
        tempSpecial = "Disarm (When you use a disarm weapon, you get a +2 bonus on Combat Maneuver Checks to disarm an enemy), Trip (You can use a trip weapon to make trip attacks. If you are tripped during your own trip attempt, you can drop the weapon to avoid being tripped).";
        tempDamageType = "P";
        tempDescription = "A spiked chain is about 4 feet in length, covered in wicked barbs. You can use the Weapon Finesse feat to apply your Dexterity modifier instead of your Strength modifier to attack rolls with a spiked chain sized for you, even though it isn't a light weapon.";

        Item chainSpiked = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.ChainSpiked))
        {
            AppLibary.itemDictionary.Add(AppLibary.ChainSpiked, chainSpiked);
        }
        tempSpecial = "";
        //End Chain, spiked

        //Curve blade, elven
        tempType = "Weapon, Two-Handed Melee Wapon";
        tempitemName = "Curve blade, elven";
        tempCost = 80;
        tempDamageS = "1d8";
        tempDamageM = "1d10";
        tempCritical = "18-20/x2";
        tempRange = 0;
        tempWeight = 7;
        tempDamageType = "S";
        tempDescription = "Essentially a longer version of a scimitar, but with a thinner blade, the elven curve blade is exceptionally rare. You receive a +2 circumstance bonus to your Combat Maneuver Defense whenever a foe attempts to sunder your elven curve blade due to its flexible metal. You can use the Weapon Finesse feat to apply your Dexterity modifier instead of your Stength modifier to attack rolls with an elven curve blade sized for you, even though it isnt a light weapon.";

        Item curveBladeElven = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.CurveBladeElven))
        {
            AppLibary.itemDictionary.Add(AppLibary.CurveBladeElven, curveBladeElven);
        }
        //End curve blade elven

        //Dire flail
        tempType = "Weapon, Two-Handed Melee Wapon";
        tempitemName = "Flail, Dire";
        tempCost = 90;
        tempDamageS = "1d6/1d6";
        tempDamageM = "1d8/1d8";
        tempCritical = "x2";
        tempRange = 0;
        tempWeight = 10;
        tempSpecial = "Double (You can use a double weapon to fight as if fighting with two weapons, but if you do, you incur all the normal attack penalties associated with fighting with two weapons, just as if you were using a one-handed weapon and a light weapon. You can choose to wield one end of a double weapon two-handed, but it cannot be used as a double weapon when wielded in this way—only one end of the weapon can be used in any given round), Disarm (When you use a disarm weapon, you get a +2 bonus on Combat Maneuver Checks to disarm an enemy), Trip (You can use a trip weapon to make trip attacks. If you are tripped during your own trip attempt, you can drop the weapon to avoid being tripped).";
        tempDamageType = "S";
        tempDescription = "A dire flail consists of two spheres of spiked iron dangling form chains at opposite ends of a long haft.";

        Item flailDire = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.FlailDire))
        {
            AppLibary.itemDictionary.Add(AppLibary.FlailDire, flailDire);
        }
        //End Dire flail

        //Hammer, gnome spiked
        tempType = "Weapon, Two-Handed Melee Wapon";
        tempitemName = "Hammer, Gnome Spiked";
        tempCost = 20;
        tempDamageS = "1d6/1d4";
        tempDamageM = "1d8/1d6";
        tempCritical = "x3/x4";
        tempRange = 0;
        tempWeight = 6;
        tempSpecial = "Double (You can use a double weapon to fight as if fighting with two weapons, but if you do, you incur all the normal attack penalties associated with fighting with two weapons, just as if you were using a one-handed weapon and a light weapon. You can choose to wield one end of a double weapon two-handed, but it cannot be used as a double weapon when wielded in this way—only one end of the weapon can be used in any given round), Trip (You can use a trip weapon to make trip attacks. If you are tripped during your own trip attempt, you can drop the weapon to avoid being tripped).";
        tempDamageType = "B or P";
        tempDescription = "A gnome hooked hammer is a double weapon - an ingenious tool with a hammer head at one end of its haft and a long, curved pick at the other. The hammer's blunt head is a bludgeoning weapon that deasl 1d6 points of damage (x3 crit). Its hook is a piercing weapon that deals 1d4 points of damage (x4 crit). You can use either head as the primary head of the weapon. Gnomes treat hooked hammers as martial weapons.";

        Item hammerGnomeHooked = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.HammerGnomeHooked))
        {
            AppLibary.itemDictionary.Add(AppLibary.HammerGnomeHooked, hammerGnomeHooked);
        }
        //End Hamme, gnome spiked

        //Sword, two-bladed
        tempType = "Weapon, Two-Handed Melee Wapon";
        tempitemName = "Sword, Two-Bladed";
        tempCost = 100;
        tempDamageS = "1d6/1d6";
        tempDamageM = "1d8/1d8";
        tempCritical = "19-20/x2";
        tempRange = 0;
        tempWeight = 10;
        tempSpecial = "Double (You can use a double weapon to fight as if fighting with two weapons, but if you do, you incur all the normal attack penalties associated with fighting with two weapons, just as if you were using a one-handed weapon and a light weapon. You can choose to wield one end of a double weapon two-handed, but it cannot be used as a double weapon when wielded in this way—only one end of the weapon can be used in any given round).";
        tempDamageType = "S";
        tempDescription = "A two-bladed sword is a double wepaon - twin blades extend form either side of a central, short haft, allowing the wielder to attack with graceful but deadly flourishes.";

        Item swordTwoBladed = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.SwordTwoBladed))
        {
            AppLibary.itemDictionary.Add(AppLibary.SwordTwoBladed, swordTwoBladed);
        }
        //Sword, two-bladed

        //Urgrosh, dwarven
        tempType = "Weapon, Two-Handed Melee Wapon";
        tempitemName = "Urgrosh, Dwarven";
        tempCost = 50;
        tempDamageS = "1d6/1d4";
        tempDamageM = "1d8/1d6";
        tempCritical = "x3";
        tempRange = 0;
        tempWeight = 12;
        tempSpecial = "Double (You can use a double weapon to fight as if fighting with two weapons, but if you do, you incur all the normal attack penalties associated with fighting with two weapons, just as if you were using a one-handed weapon and a light weapon. You can choose to wield one end of a double weapon two-handed, but it cannot be used as a double weapon when wielded in this way—only one end of the weapon can be used in any given round), Brace (If you use a readied action to set a brace weapon against a charge, you deal double damage on a successful hit against a charging creature).";
        tempDamageType = "P or S";
        tempDescription = "A dwarven urgrosh is a double weapon - an axe head and spear point on opposite ends of a long haft. The urgrosh's axe head is a slashing weapon that deals 1d8 points of damage. Its spear head is a piercing weapon that deals 1d6 points of damage. You can use either head as the primary weapon. The other becomes the off-hand weapon. If you use an urgrosh against a charging character, the spear head is the part of the weapon that does damage. Dwarves treat dwarven urgroshes as martial weapons.";

        Item urgroshDwarven = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.UrgroshDwarven))
        {
            AppLibary.itemDictionary.Add(AppLibary.UrgroshDwarven, urgroshDwarven);
        }
        //End Urgrosh, dwarven

        //Bolas
        tempType = "Weapon, Ranged";
        tempitemName = "Bolas";
        tempCost = 5;
        tempDamageS = "1d3";
        tempDamageM = "1d4";
        tempCritical = "x2";
        tempRange = 20;
        tempWeight = 2;
        tempSpecial = "Nonleathal (this weapon does nonleathal damage), Trip (You can use a trip weapon to make trip attacks. If you are tripped during your own trip attempt, you can drop the weapon to avoid being tripped).";
        tempDamageType = "B";
        tempDescription = "A bolas is a pair of weights, connected by a thin rope or coard. You can use this weapon to make a ranged trip attack against an opponent. You can't be tripped during your own trip attempt when using a bolas.";

        Item bolas = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Bolas))
        {
            AppLibary.itemDictionary.Add(AppLibary.Bolas, bolas);
        }
        tempSpecial = "";
        //End Bolas

        //Crossbow Hand
        tempType = "Weapon, Ranged";
        tempitemName = "Crossbow, Hand";
        tempCost = 100;
        tempDamageS = "1d3";
        tempDamageM = "1d4";
        tempCritical = "19-20/x2";
        tempRange = 30;
        tempWeight = 2;
        tempDamageType = "P";
        tempDescription = "You can draw a hand crossbow back by hand. Loading a hand crossbow is a move action that provokes attacks of opportunity. You can shoot, but not load, a hand crossbow with one hand at no penalty. You can shoot a hand crossbow with each hand but you take a penalty on attack rolls as if attackign with two light weapons.";

        Item crossbowHand = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.CrossbowHand))
        {
            AppLibary.itemDictionary.Add(AppLibary.CrossbowHand, crossbowHand);
        }
        //End Crossbow Hand

        //Crossbow Repeating heavy
        tempType = "Weapon, Ranged";
        tempitemName = "Crossbow, Repeating Heavy";
        tempCost = 400;
        tempDamageS = "1d8";
        tempDamageM = "1d10";
        tempCritical = "19-20/x2";
        tempRange = 120;
        tempWeight = 12;
        tempDamageType = "P";
        tempDescription = "The repeating crossbow (wether light or heavy) holds 5 crossbow bolts. As long as it hols bolts, you can reload it by pulling the reloading lever (a free action). Loading a new case of 5 bolts is a full round action that provokes attacks of opportunity. You can fire a repeating crossbow with one hand or fire a reapeating crossbow in each hand in the same manner as you would a normal crossbow of the same size. However, you must fire the wapon with two hands in order to use the reloading lever, and you must use two hands to load a new case of bolts.";

        Item crossbowRepeatingHeavy = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.CrossbowRepeatingHeavy))
        {
            AppLibary.itemDictionary.Add(AppLibary.CrossbowRepeatingHeavy, crossbowRepeatingHeavy);
        }
        //End crossbow reapeating heavy

        //Crossbow repeating light
        tempType = "Weapon, Ranged";
        tempitemName = "Crossbow, Repeating Light";
        tempCost = 250;
        tempDamageS = "1d6";
        tempDamageM = "1d8";
        tempCritical = "19-20/x2";
        tempRange = 80;
        tempWeight = 6;
        tempDamageType = "P";
        tempDescription = "The repeating crossbow (wether light or heavy) holds 5 crossbow bolts. As long as it hols bolts, you can reload it by pulling the reloading lever (a free action). Loading a new case of 5 bolts is a full round action that provokes attacks of opportunity. You can fire a repeating crossbow with one hand or fire a reapeating crossbow in each hand in the same manner as you would a normal crossbow of the same size. However, you must fire the wapon with two hands in order to use the reloading lever, and you must use two hands to load a new case of bolts.";

        Item crossbowRepeatingLight = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.CrossbowRepeatingLight))
        {
            AppLibary.itemDictionary.Add(AppLibary.CrossbowRepeatingLight, crossbowRepeatingLight);
        }
        //End crossbow repeating light

        //Net
        tempType = "Weapon, Ranged";
        tempitemName = "Net";
        tempCost = 20;
        tempDamageS = "";
        tempDamageM = "";
        tempCritical = "";
        tempRange = 10;
        tempWeight = 6;
        tempSpecial = "An entangled creature can escape with a DC 20 Escape Artist check (a full-round action). The net has 5 hit points and can be burst with a DC 25 Strength check (also a full-round action). A net is useful only against creatures within one size category of you. A net must be folded to be thrown effectively. The first time you throw your net in a fight, you make a normal ranged touch attack roll. After the net is unfolded, you take a –4 penalty on attack rolls with it. It takes 2 rounds for a proficient user to fold a net and twice that long for a non-proficient one to do so.";
        tempDamageType = "P";
        tempDescription = "When you throw a net, you make a ranged touch attack against your target. A net’s maximum range is 10 feet. If you hit, the target is entangled. An entangled creature takes a –2 penalty on attack rolls and a –4 penalty on Dexterity, can move at only half speed, and cannot charge or run. If you control the trailing rope by succeeding on an opposed Strength check while holding it, the entangled creature can move only within the limits that the rope allows. If the entangled creature attempts to cast a spell, it must make a concentration check with a DC of 15 + the spell’s level or be unable to cast the spell. ";

        Item net = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Net))
        {
            AppLibary.itemDictionary.Add(AppLibary.Net, net);
        }
        //End Net

        //Shuriken
        tempType = "Weapon, Ranged";
        tempitemName = "Shuriken";
        tempCost = 1;
        tempDamageS = "1";
        tempDamageM = "1d2";
        tempCritical = "x2";
        tempRange = 10;
        tempWeight = 0.5f;
        tempSpecial = "Monk (A monk weapon can be used by a monk to perform a flurry of blows).";
        tempDamageType = "P";
        tempDescription = "A shuriken is a small piece of metal with sharpened edges, designed for throwing. A shuriken can't be used as a melee weapon. Although they are thrown weapons, shuriken are treated as ammunition for the purposes of drawing them, crafting masterwork or tohter wize special versions of them. and what happens to them after they are thrown. The cost is for 5 of them.";

        Item shuriken = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.Shuriken))
        {
            AppLibary.itemDictionary.Add(AppLibary.Shuriken, shuriken);
        }
        //End Shuriken

        //Sling staff, Halfling
        tempType = "Weapon, Ranged";
        tempitemName = "Sling Staff, Halfling";
        tempCost = 20;
        tempDamageS = "1d6";
        tempDamageM = "1d8";
        tempCritical = "x3";
        tempRange = 80;
        tempWeight = 3;
        tempDamageType = "P";
        tempDescription = "Made from a specially designed sling attached to a short club, a halfling sling staff can be use dby a proficient wielder to devastating effect. Your Strength modfier applies to damage rolls when you use a halfling sling staff, just as it does for thrown weapons. You can fire, but not load a halfling sling staff with one hand. Loading is a move action that requires two hands and provokes attacks of opportunity. You can hurl ordinary stones, but they take a -4 penalty on attack rolls, and deal damage as if the weapon were designed for a creature one size category smaller than you. A halfling sling staff can be used as a simple weapon that deals bludgeoning damge equal to that of a club of its size. Halflings treat halfling sling staves as martial weapons.";

        Item slingStaffHalfling = new Item(tempType, tempitemName, tempCost, tempDamageS, tempDamageM, tempCritical, tempRange, tempWeight, tempDamageType, tempSpecialAbility, tempOther, tempDescription);
        if (!AppLibary.itemDictionary.ContainsKey(AppLibary.SlingStaffHalfling))
        {
            AppLibary.itemDictionary.Add(AppLibary.SlingStaffHalfling, slingStaffHalfling);
        }
        //End Sling staff, halfling
        #endregion Exotic Weapons
        #endregion Weapons

        #region Armor

        #region Light Armor

        #endregion Light Armor


        #endregion Armor



        #endregion ItemInitalization
    }
}
