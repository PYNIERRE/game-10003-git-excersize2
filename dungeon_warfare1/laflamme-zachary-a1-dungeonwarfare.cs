using System.ComponentModel.Design;
using System.Runtime.InteropServices;
// initial stats
int coin = 0;
int health = 3;
int maxhealth = 3;
bool unscathed = true;
bool dead = false;

Console.WriteLine("* Look around?\n* [y/n]"); // y actually does not exist as an option! set it as else like everything else to save on inputs

string input = Console.ReadLine();
if (input.Contains("y")) // gonna find a better way to read for the letter so that it looks for it in the readline instead of. looking for the readline to JUST be y
{   // introduction
    Console.WriteLine("* You are a small skeleton, alone in a wistful field. (any key to continue) "); Console.ReadLine(); //setting the scene
    Console.WriteLine("* The grey grass below you gristles, stray crumbs of grass chips and leaf bits flying with the same gust that flows through you. \nThere is a dense cloud of ash and mist surrounding you, blocking your direct view of the horizon on all sides..."); Console.ReadLine();
    Console.WriteLine("* There's a harsh and bitter, almost pitted smell in the air -- kind of like the casing of an urn. \nIf you weren't a cacophany of hollow bones, you'd probably sneeze!"); Console.ReadLine();
    Console.WriteLine("* You can't remember when you last had memory.. Or even thoughts for that matter. Odd!");
}
else
{   // skip
    Console.WriteLine("* Scanning the surrounding is for losers anyways. You're tough boned. (any key to continue)");  
}   // witch intro
Console.ReadLine();
Console.WriteLine("* You start roaming the path you know best before you know it. A large, tall, horrible \nstone tower is now apparent where you stand, looming far above you -- it's dark silhouette now piercing the smog, and casting over your frail, pale bones."); Console.ReadLine();
Console.WriteLine("*A sudden shrill, rough voice startles you from behind. You frantically swing behind you.\n\"You're quite far out for someone like yourself, little guy. Haven't seen one of you out here.\""); Console.ReadLine();
Console.WriteLine("* It's a tall, large green witch.\nShe's fully equipped with a tattered black robe, a buckle, and a floppy pointed hat.\nShe's holding a decently sized log in her hands with an axe strapped around her shoulder. Hardened and ready for battle."); Console.ReadLine();
Console.WriteLine("\"Who are you, little one?\""); Console.ReadLine();
Console.WriteLine("[ENTER NAME]");
string name = Console.ReadLine();
Console.WriteLine("* You try to speak, but no words cross your barren teeth."); Console.ReadLine();
Console.WriteLine("\"" +name+ "...  Did someone give you a name?\"\n* [n/n]");
input = Console.ReadLine();
if (input == "")
{
    Console.WriteLine("\"A confused little guy. I see.\"");
}
else
{
    Console.WriteLine("* You almost attempt to say no.. Ah, no vocal chords, right. You shake your head.\n\"Hmm. Someone had to've cast a spell on you. Normally skeletons don't have consciousness..?\""); Console.ReadLine();
}
Console.WriteLine("\"Well, I figure you'll need some help little buddy. I can't accompany you, but I can give you this.\""); Console.ReadLine();
Console.WriteLine("<< You got a coin pouch! It holds 20¢. >>"); Console.ReadLine();
bool coinpouch = true; //note 4 later, can be stolen by thief and given to merchant. storage method of holding coins! without it you cant store coins on your bones
coin += 20;
Console.WriteLine("\"Give that whole pouch to the merchant if you see em'. Tell him I said hi, and to stop being such a bucket-head on his 'sides' debate. I'm not fighting anymore.\""); Console.ReadLine();
Console.WriteLine("* The lone witch starts hunkering away into the fog."); Console.ReadLine();
Console.WriteLine("[1] Nod and wave\n[2] Stare");
string choicestring = Console.ReadLine();
int choice = int.Parse (choicestring);
if (choice == 1)
{
    Console.WriteLine("* You affirm, waving at the witch goodbye, appreciatively."); Console.ReadLine();
    Console.WriteLine("* She waves back, trekking into the unknown.");
}
else if (choice == 2)
{
    Console.WriteLine("* You simply stare at the witch as she leaves."); Console.ReadLine();
    Console.WriteLine("* She shakes her head, descending once more into the monochrome haze.");
}
else 
{
    Console.WriteLine("* You couldn't think of anything to do, so you just sat there. She leaves."); Console.ReadLine();
    Console.WriteLine("* You were so focused on finding other thoughts.. that your coin pouch fell out of your ribcage and trinkled a couple coins into the grass. You hurriedly pick it up."); Console.ReadLine();
    coin = coin-2; //note to self make this a random variable from 2 to 5
    Console.WriteLine("<< You now have "+(coin)+ "¢. (-2) >>");
}
Console.ReadLine();
Console.WriteLine("* You ready yourself to enter the monolith. You feel whatever's causing everything weird would be at the root of it. Here you go!"); Console.ReadLine();
Console.Clear();
// monolith
// 2 sets, maybe 3 if i find the extra time                                         ----------------------------------------------------------------------------------------------------------
// 3 different multi choice options, and a special encounter at the end (i.e. thief)                    ^ creating underline for fancy text                                                   d <- text for sans serif measurement
Console.WriteLine("░▒▓██████████████▓▒░ ░▒▓██████▓▒░░▒▓███████▓▒░ ░▒▓██████▓▒░░▒▓█▓▒░      ░▒▓█▓▒░▒▓████████▓▒░▒▓█▓▒░░▒▓█▓▒░ \r\n░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░  ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░ \r\n░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░  ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░ \r\n░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░  ░▒▓█▓▒░   ░▒▓████████▓▒░ \r\n░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░  ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░ \r\n░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░  ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░ \r\n░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░░▒▓██████▓▒░░▒▓█▓▒░░▒▓█▓▒░░▒▓██████▓▒░░▒▓████████▓▒░▒▓█▓▒░  ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░ \r\n                                                                                                          \r\n----------------------------------------------------------------------------------------------------------\nSTAGE DEMO");
Console.WriteLine("* You are now in the monolith. You hear chaos above you, but the only way to proceed is up the surrounding spiral stairs. The steps are miscolored."); Console.ReadLine();
Console.WriteLine("You feel like you should proceed with caution.");
Console.WriteLine("  1  2  3  4  5"+"\n");
Console.WriteLine("^ ▓▓ ░░ ▓▓ ▓▓ ██ ^");
Console.WriteLine("| ▓▓ ▓▓ ██ ▓▓ ▓▓ |");
Console.WriteLine("| ██ ▓▓ ▓▓ ▓▓ ▒▓ |");
Console.WriteLine("| ▓▓ ▓▒ ▓▓ ██ ▓▓ |");
Console.WriteLine("| ▓▓ ▓▓ ██ ▓▓ ░░ |");
Console.WriteLine("        ()  <- you");
Console.WriteLine("Maybe you should pre-plan your path? [ENTER ORDER]");
input = Console.ReadLine();
if (input == "34135")
{
    Console.WriteLine("* You tiptoe across different bricks, correctly weighing their riskiness and condition.");
}
else
{
    Console.WriteLine("* You have no idea what you're doing. Curse you hand-eye coordination!!!"); Console.ReadLine();
    Console.WriteLine("* An arrow emerges from the wall, hitting you straight in the skull. Ow!");
    health -= 1;
    if (unscathed == true)
        unscathed = false;
    Console.WriteLine(health+"/"+maxhealth);
}
Console.ReadLine();
Console.WriteLine("* You continue on your path."); Console.ReadLine();
Console.Clear();
Console.WriteLine("* You come up to the peak of a corner. (░░)");
Console.WriteLine("* You are now in a dark, narrow hallway. There lies platforms ahead of you, and a small, hurtful pit of spikes below. (░░)");
Console.WriteLine("    ------------->");
Console.WriteLine("▓▓▓▓░░▓▓░░▓▓░░▓▓▓▓");
Console.WriteLine("▓▓▓▓░░▓▓░░▓▓░░▓▓▓▓");
Console.WriteLine("▓▓()░░▓▓░░▓▓░░▓▓▓▓");
Console.WriteLine("▓▓▓▓░░▓▓░░▓▓░░▓▓▓▓");
Console.WriteLine("▓▓▓▓░░▓▓░░▓▓░░▓▓▓▓");
Console.WriteLine("    ------------->");
Console.WriteLine("These are gonna be some pretty long jumps. You should be precise with how far you want to move.");
input = Console.ReadLine();
if (input == ("2"))
{
    Console.WriteLine("▓▓▓▓░░▓▓░░▓▓░░▓▓▓▓");
    Console.WriteLine("▓▓▓▓░░▓▓░░▓▓░░▓▓▓▓");
    Console.WriteLine("▓▓▓▓░░()░░▓▓░░▓▓▓▓");
    Console.WriteLine("▓▓▓▓░░▓▓░░▓▓░░▓▓▓▓");
    Console.WriteLine("▓▓▓▓░░▓▓░░▓▓░░▓▓▓▓");
    input = Console.ReadLine();
    if (input == ("2"))
    {
        Console.WriteLine("▓▓▓▓░░▓▓░░▓▓░░▓▓▓▓");
        Console.WriteLine("▓▓▓▓░░▓▓░░▓▓░░▓▓▓▓");
        Console.WriteLine("▓▓▓▓░░▓▓░░()░░▓▓▓▓");
        Console.WriteLine("▓▓▓▓░░▓▓░░▓▓░░▓▓▓▓");
        Console.WriteLine("▓▓▓▓░░▓▓░░▓▓░░▓▓▓▓");
        input = Console.ReadLine();
        if (input == ("2"))
        {
            Console.WriteLine("* You cross the gaps with relative ease.");
        }
    }
}
else
{
    Console.WriteLine("* You clumsily slip and fall down into the spikes. Ouch!\n You get up and dust yourself off in the midst of this sharp field."); Console.ReadLine();
    health -= 1;
    if (unscathed == true)
    {
        unscathed = false;
    }
}
Console.WriteLine(health + "/" + maxhealth);
Console.WriteLine("* Moving on!"); Console.ReadLine();
Console.WriteLine("* You continue down the halls into a living room. There seems to be a..!?! Whats that noise??"); Console.ReadLine();
Console.WriteLine("TO BE CONTINUED... GAME SUCCESS"); Console.ReadLine();
if (unscathed == true)
    Console.WriteLine("BONUS ACHIEVEMENT: Unscathed");


//death sequences down here
