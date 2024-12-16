using System;
namespace Inheritance___Class_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elf elf = new Elf("Legolas", 2931, ElfRoleEnum.GiftWrapper);
            Elf elf1 = new Elf("Gimli", 139, ElfRoleEnum.ToyMaker);
            Elf elf2 = new Elf("Frodo", 33, ElfRoleEnum.Both);
            Santa santa = new Santa("Santa Claus", 1000);
            Gift gift = new Gift("Toy", "Timmy");
            Boolean giftAdded = santa.AddGift(gift);
            if (giftAdded)
            {
                gift.Wrap();
                gift.Describe();
            } else
            {
                Console.WriteLine("Gift not added");
            }
            
            
            Console.WriteLine(santa.DeliverGifts());

            Console.WriteLine(elf.Work());
        }
    }
}
