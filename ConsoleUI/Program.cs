
using Methods;

Dictionary<string, int> guests = new Dictionary<string, int>();
string moreGuests = "";
string guest = "";
int invited = 0;
bool isValidInvited = false;
string invitedText = "";
int totalInvited = 0;

ConsoleMethods.WelcomeUser();

do
{
    guest = ConsoleMethods.GetInfoFromConsole("What's your name? ");
    isValidInvited = false;
    while (!isValidInvited)
    {
        invitedText = ConsoleMethods.GetInfoFromConsole("How many are you? ");
        isValidInvited = int.TryParse(invitedText, out invited);
    }
    guests.Add(guest, invited);
    moreGuests = ConsoleMethods.GetInfoFromConsole("Are there more guests (y/n)? ");
    Console.WriteLine();
} while (moreGuests.ToLower() != "n");

foreach (var item in guests)
{
    Console.WriteLine($"{item.Key}: {item.Value} guests.");
    totalInvited += item.Value;
}
Console.WriteLine();
Console.WriteLine($"There are {totalInvited} people invited.");




