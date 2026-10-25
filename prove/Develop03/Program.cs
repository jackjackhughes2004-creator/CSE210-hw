using System;
using System.Collections.Generic;

class Program
{
    // I exceeded the requirements by having the program only hide words that haven't been hidden yet.
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("Alma", 22, 15, 18, "15 And it came to pass that after Aaron had expounded these things unto him, the king said: What shall I do that I may have this eternal life of which thou hast spoken? Yea, what shall I do that I may be born of God, having this wicked spirit rooted out of my breast, and receive his Spirit, that I may be filled with joy, that I may not be cast off at the last day? Behold, said he, I will give up all that I possess, yea, I will forsake my kingdom, that I may receive this great joy. But Aaron said unto him: If thou desirest this thing, if thou wilt bow down before God, yea, if thou wilt repent of all thy sins, and will bow down before God, and call on his name in faith, believing that ye shall receive, then shalt thou receive the hope which thou desirest. And it came to pass that when Aaron had said these words, the king did bow down before the Lord, upon his knees; yea, even he did prostrate himself upon the earth, and cried mightily, saying: O God, Aaron hath told me that there is a God; and if there is a God, and if thou art God, wilt thou make thyself known unto me, and I will give away all my sins to know thee, and that I may be raised from the dead, and be saved at the last day. And now when the king had said these words, he was struck as if he were dead.");

        int choice = 1;
        while (choice != 2)
        {
            Console.Clear();
            scripture.GetDisplayText();
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden.");
                break;
            }

            Console.WriteLine("1. Continue");
            Console.WriteLine("2. Quit");
            Console.Write("Please Choose a Number: ");
            
            string input = Console.ReadLine();
            
            if (!int.TryParse(input, out choice))
            {
                choice = -1;
            }

            if (choice == 1)
            {
                scripture.HideRandomWords(3);
            }
            else if (choice == 2)
            {
                break;
            }
            else
            {   
                Console.WriteLine("");
                Console.WriteLine("Unrecognized Input. Please try again.");
                Console.WriteLine("");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}