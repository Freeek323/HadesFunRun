using System;
using System.Linq;

namespace HadesFunRun
{
	class Program
	{
        //Methods
        static string Choice(string[] fill) // Method which takes an array as an argument
        {
            Random random = new Random(); // creates a random generator
            int num = random.Next(fill.Length); // chooses a random number dependant on the length of the array's length
            string choice = fill[num]; // applies that number to the list from the same array
            return choice; // returns the choice!
        }
        static void MirrorColour(string[] x, string y) // Method which takes an array AND a string as arguments
            {
                if (Array.IndexOf(x, y) == 1) // Searches array with string.
                {
                    Console.ForegroundColor = ConsoleColor.Green; // Applies Green text colour to those that sit at the end of the array
                    Console.WriteLine(y);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red; // Applies Red text colour to those that sit at the start of the array
                    Console.WriteLine(y);
                }
            }

        static void Main(string[] args)
        {
        //Arrays

            //Object Arrays
            string[] startingkeepsake = new string[8] { "Adamant Arrow (Artemis)", "Blood Filled Vial (Ares)", "Conch Shell (Poseidon)", "Eternal Rose (Aphrodite)", "Frostbitten Horn (Demeter)", "Overflowing Cup (Dionysus)", "Owl Pendant (Athena)", "Thunder Signet (Zeus)" };
            string[] keepsakes = new string[25] { "Black Shawl (Nyx)", "Bone Hourglass (Charon)", "Broken Spearpoint (Patroclus)", "Chtonic Coin Purse (Hypnos)", "Cosmic Egg (Chaos)", "Distant Memory (Orpheus)", "Evergreen Acorn (Eurydice)", "Harpy Feather Duster (Dusa)", "Lambent Plume (Hermes)", "Lucky Tooth (Skelly)", "Myrmidon Bracer (Achilles)", "Old Spiked Collar (Cerberus)", "Pierced Butterfly (Thanatos)", "Pom Blossom (Persephone)", "Shattered Shackle (Sisyphus)", "Sigil of the Dead (Hades)", "Skull Earing (Megaera)", "Adamant Arrow (Artemis)", "Blood Filled Vial (Ares)", "Conch Shell (Poseidon)", "Eternal Rose (Aphrodite)", "Frostbitten Horn (Demeter)", "Overflowing Cup (Dionysus)", "Owl Pendant (Athena)", "Thunder Signet (Zeus)" };
            string[] companions = new string[6] { "Antos", "Battie", "Fidi", "Mort", "Rib", "Shady" };
            string[] rules = new string[23] { "I am Speed: Dash only, no weapon use at all", "Ka-Pow!: Attack only, no Special or Casting allowed. Dash is allowed but NO upgrades are permitted", "But Mum said I was!: Special only, no Attack or Casting allowed. Dash is allowed but NO upgrades are permitted", "Hogwarts: Cast only, no Attack or Special allowed. Dash is allowed but NO upgrades are permitted", "Concrete Shoes: No Dashing! Attack, Special and Cast allowed, but Dashing is not!", "Free Bird: You must visit all 5 wings in the Temple Of Styx", "Minor Inconvenience: You must kill Theseus before Asterius", "My Precious: Your Obols counter must show $1000+ at some point during the run, instant loss if you get to Final Boss and never hit $1000", "All Nail, no Strike: You are not allowed to gain any Hammer upgrades", "Favouritism: All boons must be from the same god (you must sell asap if forced to gain another)", "The Man with the Green Cap: You must destroy all pots in each visited chamber", "Heartless: You may not increase your max life on purpose. (This includes letting Thanatos win if visited)", "The Purge: You must sell all items everytime you visit a Pool of Purging", "Fire Sale: You must buy all items from Wells of Charon, in order top down", "Limited Love: You are only allowed one boon from each god (If you are forced to take anymore, you must sell them)", "On your Own: Not allowed to use Companions or Calls", "External Input: Player's must choose boons for eachother when they are presented (Screen Sharing Heavily Recommended)", "Swap it up: Swap to the opposite control system that you usually use (MKB / Controller) (If playing on switch, Swap Dpad/Joystick)", "Poor Intent: You must avoid all means of earning $ Obols", "Gold Digger: You are not allowed to buy anything (Except the Diamond/Blood in the final Charon Shop)", "Das alot: Instant win if you hit $2000+ Obols", "Boss Run: All players enter each Boss at the same time. Whoever kills a boss first gets a point, Most points at the end of the final boss wins. Tiebreaker is who had the least boons", "God Giveth, God taketh away: If you defeat a boss first, you must force the other players to sell a boon of your choosing. All players must wait in the Fountain rooms before proceeding to the next floors together."};
            string[] subrules = new string[18] { "Free Bird: You must visit all 5 wings in the Temple Of Styx", "Minor Inconvenience: You must kill Theseus before Asterius", "My Precious: Your Obols counter must show $1000+ at some point during the run, instant loss if you get to Final Boss and never hit $1000", "All Nail, no Strike: You are not allowed to gain any Hammer upgrades", "Favouritism: All boons must be from the same god (you must sell asap if forced to gain another)", "The Man with the Green Cap: You must destroy all pots in each visited chamber", "Heartless: You may not increase your max life on purpose. (This includes letting Thanatos win if visited)", "The Purge: You must sell all items everytime you visit a Pool of Purging", "Fire Sale: You must buy all items from Wells of Charon, in order top down", "Limited Love: You are only allowed one boon from each god (If you are forced to take anymore, you must sell them)", "On your Own: Not allowed to use Companions or Calls", "External Input: Player's must choose boons for eachother when they are presented (Screen Sharing Heavily Recommended)", "Swap it up: Swap to the opposite control system that you usually use (MKB / Controller) (If playing on switch, Swap Dpad/Joystick)", "Poor Intent: You must avoid all means of earning $ Obols", "Gold Digger: You are not allowed to buy anything (Except the Diamond/Blood in the final Charon Shop)", "Das alot: Instant win if you hit $2000+ Obols", "Boss Run: All players enter each Boss at the same time. Whoever kills a boss first gets a point, Most points at the end of the final boss wins. Tiebreaker is who had the least boons", "God Giveth, God taketh away: If you defeat a boss first, you must force the other players to sell a boon of your choosing. All players must wait in the Fountain rooms before proceeding to the next floors together." };
            string[] rulerandomiser = new string[2];
            //Weapon Arrays
            string[] infernalarms = new string[24] { "Chaos - Aegis (Shield)", "Beuwulf - Aegis (Shield)", "Zagreus - Aegis (Shield)", "Zeus - Aegis (Shield)", "Chiron - Coronacht (Bow)", "Hera - Coronacht (Bow)", "Rama - Coronacht (Bow)", "Zagreus - Coronacht (Bow)", "Eris - Exagryph (Rail)", "Hestia - Exagryph (Rail)", "Lucifer - Exagryph (Rail)", "Zagreus - Exagryph (Rail)", "Demeter - Malphon (Fists)", "Gilgamesh - Malphon (Fists)", "Talos - Malphon (Fists)", "Zagreus - Malphon (Fists)", "Arthur - Stygius (Sword)", "Nemesis - Stygius (Sword)", "Poseidon - Stygius (Sword)", "Zagreus - Stygius (Sword)", "Achilles - Varatha (Spear)", "Gyan Yu - Varatha (Spear)", "Hades - Varatha (Spear)", "Zagreus - Varatha (Spear)" };
            string[] aegis = new string[4] { "Chaos - Aegis (Shield)", "Beuwulf - Aegis (Shield)", "Zagreus - Aegis (Shield)", "Zeus - Aegis (Shield)" };
            string[] coronacht = new string[4] { "Chiron - Coronacht (Bow)", "Hera - Coronacht (Bow)", "Rama - Coronacht (Bow)", "Zagreus - Coronacht (Bow)" };
            string[] exagryph = new string[4] { "Eris - Exagryph (Rail)", "Hestia - Exagryph (Rail)", "Lucifer - Exagryph (Rail)", "Zagreus - Exagryph (Rail)"};
            string[] malphon = new string[4] { "Demeter - Malphon (Fists)", "Gilgamesh - Malphon (Fists)", "Talos - Malphon (Fists)", "Zagreus - Malphon (Fists)"};
            string[] stygius = new string[4] {  "Arthur - Stygius (Sword)", "Nemesis - Stygius (Sword)", "Poseidon - Stygius (Sword)", "Zagreus - Stygius (Sword)"};
            string[] varatha = new string[4] { "Achilles - Varatha (Spear)", "Gyan Yu - Varatha (Spear)", "Hades - Varatha (Spear)", "Zagreus - Varatha (Spear)" };
            string[] randomiser = new string[4]; // After each Keepsake is picked, it is added into this array which is re-searched on every pick to make sure there are no duplicates.
            //Mirror of Night Arrays
            string[] mi1 = new string[2] { "Shadow Presence", "Fiery Presence" };
            string[] mi2 = new string[2] { "Chthonic Vitality", "Dark Regeneration" };
            string[] mi3 = new string[2] { "Death Defiance", "Stubborn Defiance" };
            string[] mi4 = new string[2] { "Greater Reflex", "Ruthless Reflex" };
            string[] mi5 = new string[2] { "Boiling Blood", "Abyssal Blood" };
            string[] mi6 = new string[2] { "Infernal Soul", "Stygian Soul" };
            string[] mi7 = new string[2] { "Deep Pockets", "Golden Touch" };
            string[] mi8 = new string[2] { "Thick Skin", "High Confidence" };
            string[] mi9 = new string[2] { "Privileged Status", "Family Favourite" };
            string[] mi10 = new string[2] { "Olympian Favour", "Dark Foresight" };
            string[] mi11 = new string[2] { "Gods' Pride", "Gods' Legacy" };
            string[] mi12 = new string[2] { "Fated Authority", "Fated Persuasion" };
            //Heat Arrays
            int[][] heat = new int[][]
            {
                new int[] {}, // 0
                new int[] {1,2,3,4,5}, // Hard Labor 1
                new int[] {1,2,3,4}, // Lasting Consequences 2
                new int[] {1,2}, // Convenience Fee 3
                new int[] {1,2,3}, // Jury Summons 4
                new int[] {1,3,6,10}, // Extreme Measures 5
                new int[] {1,2}, // Calisthenics Program 6
                new int[] {2,5}, // Benefits Package 7
                new int[] {2}, // Middle Management 8
                new int[] {2}, // Underworld Customs 9
                new int[] {3,6}, // Forced Overtime 10
                new int[] {1}, // Heightened Security 11
                new int[] {2,4,6,8}, // Routine Inspection 12
                new int[] {1,2}, // Damage Control 13
                new int[] {2,5}, // Approval Process 14
                new int[] {1,3,6} // Tight Deadline 15
            };
            //Objects
        start: int weaponchoice = 0;
            int minheat = 0;
            int maxheat = 0;
            int weaponset = 1;
            string godboon;
            string ruleset = "n";
            string subrulechoice = "n";
            string secondaryrule;
            string multirun = "0";
            string ks1, ks2, ks3, ks4;
            string m1 = Choice(mi1);
            string m2 = Choice(mi2);
            string m3 = Choice(mi3);
            string m4 = Choice(mi4);
            string m5 = Choice(mi5);
            string m6 = Choice(mi6);
            string m7 = Choice(mi7);
            string m8 = Choice(mi8);
            string m9 = Choice(mi9);
            string m10 = Choice(mi10);
            string m11 = Choice(mi11);
            string m12 = Choice(mi12);



         //Starting Message
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to Hades Fun Run!, any feedback/issues, please contact me on my Discord - https://discord.gg/SYJE3md - Freeek"); // Starting Message
            Console.WriteLine();

                // Gamemode Selection 

            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please type in what gamemode you'd like to play, or click enter for quick start (1-8 heat)");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1 - Custom Game --- Starting Keepsake, Infernal Arms Lock, Custom Heat Level, Meme Rules, Multiple Weapon Runs ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("2 - Quick Start 8-16 Heat");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("3 - Quick Start 16-32 Heat");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("4 - Quick Start 32+ Heat");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            string gamechoice = Convert.ToString(Console.ReadLine());
            if (gamechoice == "1")
            {
                goto GameChoice1;
            }
            if (gamechoice == "2")
            {
                godboon = "y";
                weaponchoice = 0;
                minheat = 8;
                maxheat = 16;
                goto GameChoice234;

            }
            if (gamechoice == "3")
            {
                godboon = "y";
                weaponchoice = 0;
                minheat = 16;
                maxheat = 32;
                goto GameChoice234;

            }
            if (gamechoice == "4")
            {
                godboon = "y";
                weaponchoice = 0;
                minheat = 32;
                maxheat = 63;
                goto GameChoice234;
            }
            godboon = "y";
            weaponchoice = 0;
            minheat = 1;
            maxheat = 8;
            goto GameChoice234;


        //Custom Game 

                // Rules
        GameChoice1: Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Do you want to add any rules? y/n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("eg; Dash only!");
            Console.ForegroundColor = ConsoleColor.White;
        Rules: ruleset = Convert.ToString(Console.ReadLine());
            if (ruleset != "y" && ruleset != "n")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That wasn't a y or n, boyo"); // This ensures they type y or n
                Console.ForegroundColor = ConsoleColor.White;
                goto Rules;
            }
            Console.WriteLine();
            if (ruleset == "y")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Would you like to add a secondary rule? y/n");
            SubRule: subrulechoice = Convert.ToString(Console.ReadLine());
                if (subrulechoice != "y" && subrulechoice != "n")
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That wasn't a y or n, boyo"); // This ensures they type y or n
                    Console.ForegroundColor = ConsoleColor.White;
                    goto SubRule;
                }
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            //Starting Boon Check

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Do you want to force a God boon for the first floor (Tartarus) y/n");
            Console.ForegroundColor = ConsoleColor.White;
        Godboon: godboon = Convert.ToString(Console.ReadLine());
            if (godboon != "y" && godboon != "n") { 
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That wasn't a y or n, boyo"); // This ensures they type y or n
                Console.ForegroundColor = ConsoleColor.White;
                goto Godboon;  }
            Console.WriteLine();

                //All Weapons or specific weapon check
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Do you want to play with a specific weapon? y/n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-Aspect is still randomised");
            Console.WriteLine("-Disables multi-weapon runs");
            Console.ForegroundColor = ConsoleColor.White;
        Weapon: string weapon = Convert.ToString(Console.ReadLine());
            if (weapon != "y" && weapon != "n") {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That wasn't a y or n, boyo"); // This ensures they type y or n 
                Console.ForegroundColor = ConsoleColor.White;
                goto Weapon; }
            if (weapon == "n")
            {
                weaponset = 1;
            }
                if (weapon == "y")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("What's the Infernal Arm of Choice?");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Stygius (Sword) - 1");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Varatha (Spear) - 2");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Aegis (Shield)  - 3");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Coronacht (Bow) - 4");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Malphon (Fists) - 5");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Exagryph (Rail) - 6");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Please type 1-6 and hit enter...");
                Console.ForegroundColor = ConsoleColor.White;
            WeaponChoice: weaponchoice = Convert.ToInt32(Console.ReadLine());
                if (weaponchoice > 6 || weaponchoice < 1)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That wasn't 1-6, boyo, go again"); // This ensures they type a number between 1 to 6
                    Console.ForegroundColor = ConsoleColor.White;
                    goto WeaponChoice;
                }
            }
            if (weaponchoice > 0)
            {
                goto HeatChoiceStart;
            }

                // Multi Weapon Run
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Do you want to play a multi-weapon run? If so, type the number you would like, otherwise click enter");
            Console.ForegroundColor = ConsoleColor.White;
            multirun = Convert.ToString(Console.ReadLine());
            if (multirun == "" || multirun == "n")
            {
                multirun = "0";
                    }





                // Min and Max Heat
              HeatChoiceStart:  Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Turning on the heat? y/n");
            Console.ForegroundColor = ConsoleColor.White;
        HeatChoice: string heatchoice = Convert.ToString(Console.ReadLine());
            if (heatchoice != "y" && heatchoice != "n"){
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That wasn't a y or n, boyo"); // This ensures they type y or n
                Console.ForegroundColor = ConsoleColor.White;
                goto HeatChoice;}
            Console.WriteLine();
            if (heatchoice == "y")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Max heat? (1-63)");
                Console.ForegroundColor = ConsoleColor.White;
            MaxHeat:  maxheat = Convert.ToInt32(Console.ReadLine());
                if (maxheat > 63 || maxheat < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That wasn't 1-63, boyo, go again"); // This ensures they type a number between 1 to 63
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    goto MaxHeat;
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Minimum heat? (1-63)");
                Console.ForegroundColor = ConsoleColor.White;
            MinHeat:  minheat = Convert.ToInt32(Console.ReadLine());
                if (minheat > 63 || minheat < 0)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That wasn't 1-63, boyo, go again"); // This ensures they type a number between 1 to 63
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    goto MinHeat;
                }
                if (minheat > maxheat)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Come on now boyo, Minimum Heat can't be larger than Max Heat, have another whack at it."); // This ensures they type a number between 1 to 63
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    goto MinHeat;
                }
            }

        //Result Screen
        GameChoice234:


                // Heat Setup
        reset: Random random = new Random();
            repeat: int chosenheatlevel = random.Next(minheat, maxheat);
                int RI = 0;
                int totalheat = 0; // Total Intensity
                int r = 0;
                int another = 0;
                int indheat = 0;
                int[] heatrandomiser = new int[100];
                string[] finalheatchoices = new string[17];
                while (totalheat != chosenheatlevel)
                {
                heatstart: Random rdm = new Random();
                    another++;
                    if (another > 100000)
                    {
                        Array.Clear(heatrandomiser, 0, heatrandomiser.Length);
                        Array.Clear(finalheatchoices, 0, finalheatchoices.Length);
                        goto reset;
                    };
                    int pact = rdm.Next(heat.Length); // Chooses a pact of punishment to start with
                    if (r == 15)
                    {
                        Array.Clear(heatrandomiser, 0, heatrandomiser.Length);
                        Array.Clear(finalheatchoices, 0, finalheatchoices.Length);
                        goto reset;
                    };
                    if (heatrandomiser.Contains(pact)) // array is already assigned 0, so 0 always skips back to start, 1-15 are let through
                    { goto heatstart; }
                    int pactlevel = (random.Next(heat[pact].Length)); // Chooses a pact of punishment level
                                                                   //optimisation of higher heat level choices
                    if (chosenheatlevel >= 22 && pactlevel == 0 && totalheat < chosenheatlevel - 5)
                    {
                        pactlevel++;
                        if (pact == 8 || pact == 9 || pact == 11)
                        { pactlevel--; }
                    }
                    if (chosenheatlevel >= 32 && pactlevel == 1 && totalheat < chosenheatlevel - 5)
                    {
                        pactlevel++;
                        if (pact == 3 || pact == 6 || pact == 7 || pact == 10 || pact == 13 || pact == 14)
                        { pactlevel--; }
                    }
                    if (chosenheatlevel >= 42 && pactlevel == 2 && totalheat < chosenheatlevel - 5)
                    {
                        pactlevel++;
                        if (pact == 4 || pact == 15)
                        { pactlevel--; }
                    }
                    if (chosenheatlevel >= 52 && pactlevel == 3 && totalheat < chosenheatlevel - 5)
                    {
                        pactlevel++;
                        if (pact == 2 || pact == 5 || pact == 12)
                        { pactlevel--; }
                    }
                    if (chosenheatlevel >= 62 && pactlevel == 4 && totalheat < chosenheatlevel - 5)
                    {
                        pactlevel++;
                        if (pact == 1)
                        { pactlevel--; }
                    }
                    indheat = (heat[pact][pactlevel]); // Individual Heat Level
                    if ((indheat + totalheat) > chosenheatlevel)
                    { goto heatstart; }
                    totalheat = totalheat + indheat;
                    heatrandomiser[r] = pact;
                    r++;

                    switch (pact)
                    {
                        case 1:
                            finalheatchoices[0] = ("Hard Labor Lvl" + " " + (pactlevel + 1) + "           " + "(+" + indheat + " " + "heat)"); // 14
                            break;
                        case 2:
                            finalheatchoices[1] = ("Lasting Consequences Lvl" + " " + (pactlevel + 1) + " " + "(+" + indheat + " " + "heat)"); // 24
                            break;
                        case 3:
                            finalheatchoices[2] = ("Convenience Fee Lvl" + " " + (pactlevel + 1) + "      " + "(+" + indheat + " " + "heat)"); // 19
                            break;
                        case 4:
                            finalheatchoices[3] = ("Jury Summons Lvl" + " " + (pactlevel + 1) + "         " + "(+" + indheat + " " + "heat)"); //17
                            break;
                        case 5:
                            finalheatchoices[4] = ("Extreme Measures Lvl" + " " + (pactlevel + 1) + "     " + "(+" + indheat + " " + "heat)"); // 21
                            break;
                        case 6:
                            finalheatchoices[5] = ("Calisthenics Program Lvl" + " " + (pactlevel + 1) + " " + "(+" + indheat + " " + "heat)"); // 25
                            break;
                        case 7:
                            finalheatchoices[6] = ("Benefits Package Lvl" + " " + (pactlevel + 1) + "     " + "(+" + indheat + " " + "heat)"); // 21
                            break;
                        case 8:
                            finalheatchoices[7] = ("Middle Management" + "     " + "     " + "(+" + indheat + " " + "heat)"); // 22
                            break;
                        case 9:
                            finalheatchoices[8] = ("Underworld Customs" + "     " + "    " + "(+" + indheat + " " + "heat)"); // 23
                            break;
                        case 10:
                            finalheatchoices[9] = ("Forced Overtime Lvl" + " " + (pactlevel + 1) + "      " + "(+" + indheat + " " + "heat)"); // 20
                            break;
                        case 11:
                            finalheatchoices[10] = ("Heightened Security" + "     " + "   " + "(+" + indheat + " " + "heat)"); // 24
                            break;
                        case 12:
                            finalheatchoices[11] = ("Routine Inspection Lvl" + " " + (pactlevel + 1) + "   " + "(+" + indheat + " " + "heat)"); // 23
                            RI = indheat / 2;
                            break;
                        case 13:
                            finalheatchoices[12] = ("Damage Control Lvl" + " " + (pactlevel + 1) + "       " + "(+" + indheat + " " + "heat)"); // 19
                            break;
                        case 14:
                            finalheatchoices[13] = ("Approval Process Lvl" + " " + (pactlevel + 1) + "     " + "(+" + indheat + " " + "heat)"); // 21
                            break;
                        case 15:
                            finalheatchoices[14] = ("Tight Deadline Lvl" + " " + (pactlevel + 1) + "       " + "(+" + indheat + " " + "heat)"); // 19
                            break;
                    }
                    if (totalheat == chosenheatlevel)
                    { break; }
                }


                // Rules
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("~~~~~ Rules ~~~~~");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            if (ruleset == "y")
            {
                rulerandomiser[0] = Choice(rules);
                Console.WriteLine(rulerandomiser[0]);
                Console.WriteLine();
                if (subrulechoice == "y")
                {
                secondaryrule: secondaryrule = Choice(subrules);
                    if (secondaryrule == rulerandomiser[0])
                    {
                        goto secondaryrule;
                    }
                    rulerandomiser[1] = secondaryrule;
                    Console.WriteLine(rulerandomiser[1]);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
            }


                // Mirror of night
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("~~~~~ Mirror Of Night ~~~~~"); 
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            if (RI == 4) {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Routine Inspection Lvl 4 Selected");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            if (RI == 3) {
                MirrorColour(mi1, m1);
                MirrorColour(mi2, m2);
                MirrorColour(mi3, m3);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Routine Inspection Lvl 3 Selected");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            if (RI == 2) {
                MirrorColour(mi1, m1);
                MirrorColour(mi2, m2);
                MirrorColour(mi3, m3);
                MirrorColour(mi4, m4);
                MirrorColour(mi5, m5);
                MirrorColour(mi6, m6);
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Routine Inspection Lvl 2 Selected");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            if (RI == 1) {
                MirrorColour(mi1, m1);
                MirrorColour(mi2, m2);
                MirrorColour(mi3, m3);
                MirrorColour(mi4, m4);
                MirrorColour(mi5, m5);
                MirrorColour(mi6, m6);
                MirrorColour(mi7, m7);
                MirrorColour(mi8, m8);
                MirrorColour(mi9, m9);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Routine Inspection Lvl 1 Selected");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
            }
            if (RI == 0)
            {
                MirrorColour(mi1, m1);
                MirrorColour(mi2, m2);
                MirrorColour(mi3, m3);
                MirrorColour(mi4, m4);
                MirrorColour(mi5, m5);
                MirrorColour(mi6, m6);
                MirrorColour(mi7, m7);
                MirrorColour(mi8, m8);
                MirrorColour(mi9, m9);
                MirrorColour(mi10, m10);
                MirrorColour(mi11, m11);
                MirrorColour(mi12, m12);
            }

            Console.WriteLine();

                // Infernal Arm
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("~~~~~ Infernal Arm ~~~~~");  
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();

            switch (weaponchoice)
            {
                case 0:
                    Console.WriteLine("Aspect of " + Choice(infernalarms));
                        int multirunconvert = Int32.Parse(multirun);
                    if (weaponset == 1)
                    {
                        for (int runcount = 2; runcount <= multirunconvert; runcount++)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine(("(Run" + runcount + ")  " + "Aspect of " + Choice(infernalarms)));
                        }
                    }
                    break;
                case 1:
                    Console.WriteLine("Aspect of " + Choice(stygius));
                    break;
                case 2:
                    Console.WriteLine("Aspect of " + Choice(varatha));
                    break;
                case 3:
                    Console.WriteLine("Aspect of " + Choice(aegis));
                    break;
                case 4:
                    Console.WriteLine("Aspect of " + Choice(coronacht));
                    break;
                case 5:
                    Console.WriteLine("Aspect of " + Choice(malphon));
                    break;
                case 6:
                    Console.WriteLine("Aspect of " + Choice(exagryph));
                    break;
            }
            Console.WriteLine();


                // Companion
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("~~~~~ Companion ~~~~~"); 
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Console.WriteLine(Choice(companions));
            Console.WriteLine();

                // Keepsakes
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("~~~~~ Keepsakes ~~~~~"); 
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            if (godboon == "y"){
                ks1 = Choice(startingkeepsake);
                randomiser[0] = ks1;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Tartarus");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(ks1);
                Console.WriteLine();
            }
            else
            {
                ks1 = Choice(keepsakes);
                randomiser[0] = ks1;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Tartarus");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(ks1);
            }

        ks2: ks2 = Choice(keepsakes);
            if (randomiser.Contains(ks2)){
                goto ks2;}
            randomiser[1] = ks2;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Asphodel");
        Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(ks2);
            Console.WriteLine();
        ks3: ks3 = Choice(keepsakes);
            if (randomiser.Contains(ks3)){
                goto ks3;}
            randomiser[2] = ks3;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Elysium");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(ks3);
            Console.WriteLine();
        ks4: ks4 = Choice(keepsakes);
            if (randomiser.Contains(ks4)){
                goto ks4;}
            randomiser[3] = ks4;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Temple of Styx");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(ks4);
            Console.WriteLine();

                //Pacts of Punishment
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("~~~~~ Pacts of Punishment ~~~~~");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Chosen Heat Level: " + chosenheatlevel);
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            for (int fhc = 0; fhc <= heat.Length; fhc++)
            {
                Console.WriteLine(finalheatchoices[fhc]);
            }

            Console.WriteLine();
            Console.WriteLine();

                //Repeat and Restart
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Click Enter to run the randomiser again with the same settings, type r to begin again");
            string restart = Convert.ToString(Console.ReadLine());
            if (restart == "r")
            {
                goto start;
            }
            m1 = Choice(mi1);
            m2 = Choice(mi2);
            m3 = Choice(mi3);
            m4 = Choice(mi4);
            m5 = Choice(mi5);
            m6 = Choice(mi6); // Settings reset for repeat
            m7 = Choice(mi7);
            m8 = Choice(mi8);
            m9 = Choice(mi9);
            m10 = Choice(mi10);
            m11 = Choice(mi11);
            m12 = Choice(mi12);
            goto repeat;



        }
	}
}
