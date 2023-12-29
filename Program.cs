

string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
string[]rsvps = new string[10];
int count = 0;

RSVP("Rebecca", 1, "none", true);
RSVP("Nadia", 2, "Nuts", true);
RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false); // Linn är med eftersom hon är false på inviteOnly
RSVP("Tony", inviteOnly: true, allergies: "Jackfruit", partySize: 1); // Tony är inte med för hans namn finns inte på listan
RSVP("Noor", 4, "none", false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();
//Bra att namnege argument, exempel 3e anropet
// Alla argument behöver inte namnges, exempel 4e anropet
// Namn argumenten är namnlösa och måste skrivas i rätt ordning
/* void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
Valfria parametrar med standardvärden. Kan då anropa metod utan att ange värden. Exempel RSVP("Rebecca"); */
void RSVP(string name, int partySize, string allergies, bool inviteOnly)

{
    if (inviteOnly)
    {
        bool found = false;
        foreach (string guest in guestList)
        {
            if (guest.Equals(name))
            {
                found = true;
                break;
            }
        }
        if(!found)
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
            return;
        }
    }
    rsvps[count] = $"name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}