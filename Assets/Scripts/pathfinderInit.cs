using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// *HasPrereq = look at later, skill has prereq 


public class pathfinderInit : MonoBehaviour {

    string tempName = "";
    string tempFeature = "";
    string tempDescription = "";
    string tempSpecial = "";
    string tempNormal = "";
    Image tempTable = null;

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


}
