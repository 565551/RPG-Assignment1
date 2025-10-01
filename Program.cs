using System.Data;

namespace RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Title = "Write and WriteLine examples";
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.Write("Write example 01");
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("WriteLine example 02");
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.Write("Write example 03");
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Write("Write example 04");
            //Console.ForegroundColor = ConsoleColor.Magenta;
            //Console.WriteLine("WriteLine example 05");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("WriteLine example 06");

            int Ivelostitwithyou = 0;

            Console.WriteLine("hello, welcome to my world");


            Console.WriteLine($"Please enter your name");
            string newName = Console.ReadLine();


            Console.WriteLine("you have been chosen to save this world from the plague that has befallen it");

            Console.WriteLine("before you leave you need to accept this responsibilty");
            bool doyouaccept = (false);
            while (doyouaccept == false && Ivelostitwithyou < 5)
            {
                Console.WriteLine("do you accept? (Y/N) ");

                string accept = Console.ReadLine();

                accept = accept.ToUpper();
                accept = accept.Substring(0, 1);

                if (accept == "Y")
                {
                    doyouaccept = true;
                    Console.WriteLine($"well done {newName}, many have come before you but you are the first to accept this misson");
                    Console.WriteLine("this won't be an easy mission");
                    Console.WriteLine("you will encounter people all across the world and some of them might decide to join you and help you with the mission");

                    Console.WriteLine("when you leave you find yourself infront of 2 paths, one path going left and one path going right (L/R)");
                    bool doyougoleft = (false);
                    while (doyougoleft == false);
                    {
                        accept = Console.ReadLine();

                        accept = accept.ToUpper();
                        accept = accept.Substring(0, 1);

                        if (accept == "L")
                        {
                            Console.WriteLine("you head down the left path which leads into an open field and you see a little village near the middle of the field");

                            Console.WriteLine("you go to the village");

                            Console.WriteLine("do you enter the village (Y/N)");
                            bool doyouenter = (false);
                            while (doyouenter == false);
                            {
                                accept = Console.ReadLine();

                                accept = accept.ToUpper();
                                accept = accept.Substring(0, 1);

                                if (accept == "Y")
                                {
                                    Console.WriteLine("you enter the village and you notice that even though you heared people talking and working before you enter you can't see or hear anyone anymore");

                                    Console.WriteLine("you start calling out for people to know if anybody is here but nobody answers so you decide to go to the horse stables and when you get there you can see that the stable door is slightly open so you look in and see a girl standing by the horses, do you open the door to talk to the girl (Y/N)");
                                    bool doyoutalk = (false);
                                    while (doyoutalk == false) ;
                                    {
                                        accept = Console.ReadLine();

                                        accept = accept.ToUpper();
                                        accept = accept.Substring(0, 1);

                                        if (accept == "Y")
                                        {
                                            Console.WriteLine("you slowly open the door and then enter after that you say hello to the girl who is startled by your sudden apperence");
                                            Console.WriteLine("she demands to know how you are and why you are here");
                                            Console.WriteLine("you tell her that you were just looking for other people and then you saw the door slightly open so you diceided to enter and that you dont want to harm her");
                                            Console.WriteLine("say tells you that the village has been weary of outsiders because someone once tried to bring the plague into the village which sent the entire village into panic");
                                            Console.WriteLine("she also says that the plague doesn't seem t affect animals");

                                            Console.WriteLine("you ask her why it doesnt seem to infect animals");

                                            Console.WriteLine("she tells  you that the plague doesn't affect animals because it was caused by a dector trying to cure one of their patients of an unknow dieasie which cause the patient to throw up blood but when it cam in contact with the oxygen in the air it turned into the plague");

                                            Console.WriteLine("you ask her how does she know if it was the oxygen in the air or not");

                                            Console.WriteLine("she tells you that the plague cant survive in an environment without oxygen");

                                            Console.WriteLine("you ask her does anyone know how to stop the plague");

                                            Console.WriteLine("she tells you that apparently there is a cluster of the plague where it first started and if the plague heart is detroyed then the plague will stop for good");

                                            Console.WriteLine("you say to her so if someone destroys the plague heart then all of the plague is destroyed");
                                            Console.WriteLine("you say to her I'll go and destroy the plague heart because I believe that I was choosen for this mission");

                                            Console.WriteLine("she says that she beliveves in me and she gives me three bags the first on for food, the second for holding items and a third one just incase i lose one of the other two and she also give me a cantien to store water in");

                                            Console.WriteLine("you thank her for the stuff she gave you and you leave the village");
                                        }

                                        Console.WriteLine("after you leave the village you see a tower in the distance");

                                        Console.ForegroundColor = ConsoleColor.Blue;

                                        MakeTower();




                                        Console.WriteLine("do you knock (Y/N)");
                                        bool doyouknock = (false);
                                        while (doyouknock == false) ;
                                        {

                                            accept = Console.ReadLine();

                                            accept = accept.ToUpper();
                                            accept = accept.Substring(0, 1);

                                            if (accept == "Y")
                                            {
                                                Console.WriteLine("you decide to knock on the door and you hear someone telling you to enter, as you enter you can see the ammount of scrolls that lines the walls, you hear that same voice telling you to come up the stairs, as you go up you can see a bright light coming from the room above");
                                                Console.WriteLine("you see who looks to be a wizard before you and he says to you 'i see you have a great journey ahead of you i can help with that journey so long as you help me with one small thing first");

                                                Console.WriteLine("do you want to help the wizard (Y/N)");
                                                bool doyouhelp = (false);
                                                while (doyouhelp == false) ;
                                                {

                                                    accept = Console.ReadLine();

                                                    accept = accept.ToUpper();
                                                    accept = accept.Substring(0, 1);

                                                    if (accept == "Y")
                                                    {
                                                        Console.WriteLine("the wizard thanks you and then starts describing to you what you have to do to help him, he tells you that you must collect some of the plague but you cant collect a plagued object for him to study and in reture he will teach you a magic spell that will majorly help you in your journey");

                                                        Console.WriteLine("after hearing what you have to do the wizard gives you a magic bag which can resist the plague for a short amount of time when something plagued is put into it allowing you to carry something plagued back to the wizard so he can study it");

                                                        Console.WriteLine("the wizard tells you where you can find some plague and he gives you a map to help you get there easier");

                                                        Console.WriteLine("the map leads you to a cave that on first inspection seems harmless but the deeper in you go the darker it gets, you eventually find some of the plague and you dont know how to get it in the bag but you see that some small stalactites that are quite lose that have been plagued so you start throwing small rocks at it to try to knock it loose, it starts to cruble so you hold the bag out to collect soe small ocks that are plagued");
                                                        Console.WriteLine("you head back to the wizards tower to give him the bag with the plagued rocks for him to study");

                                                        Console.WriteLine("you enter the wizards tower again and say that you're back and that you have what he needs");
                                                        Console.WriteLine("the wizard comes running down the stairs and grabs the bag from my handand runs back upstairs and starts studying the plague I walk up after him and ask why what am i going to get inreturn");
                                                        Console.WriteLine("the wizard say that he needed the plague to study it so he could make a potion to be able to allow someone to grow a resistance to the plague");
                                                        Console.WriteLine("the wizard says it will take all night to study it and make the potion");
                                                        Console.WriteLine("the wizard tells you to get some rest");
                                                        Console.WriteLine("you wake up the next day and see that the wizard is still making the potion and he then tells you that it is taking longer than expected because the sample was just barely enough but it is still enough");
                                                        Console.WriteLine("the wizard asks you to go collect some more for him and in returne he will teach you a spell that can create weapons and tools out of mana");
                                                        Console.WriteLine(" you agree and leave the tower to go back to the cave and collect even more plague");
                                                    }
                                                }
                                            }
                                            else
                                            {

                                            }
                                        }
                                    }

                                }

            else
            { 
                if (Ivelostitwithyou <= 4)
                {
                    Console.WriteLine("you said no CHOOSE AGAIN");
                    Ivelostitwithyou += 1;
                }
                    else
                    {
                        Ivelostitwithyou += 1;
                    }
            }
                            }
                        }
                        Console.WriteLine("Because you did not choose what I wanted you die");
                    }
                }
            }
        
    
    

        static void MakeTower()
        {

            Console.WriteLine(@"
                    

                                   @                                
                                  @@@                               
                                 @@@@@                              
                                @@@@@@@                             
                               @@@@@@@@@                            
                              @@@@@@@@@@@                           
                             @@@@@@@@@@@@@                          
                            @@@@@@@@@@@@@@@                         
                           @@@@@@@@@@@@@@@@@                        
                          @@@@@@@@@@@@@@@@@@@                       
                         @@@@@@@@@@@@@@@@@@@@@                      
                        @@@@@@@@@@@@@@@@@@@@@@@                     
                       @@@@@@@@@@@@@@@@@@@@@@@@@");

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine(@"                          +++++++++++++                          
                             +  ++++++++++                          
                             +  ++++++++++                          
                             +++++++++++++                          
                             +++++++++++++                          
                             +++++++++++++                          
                             +++++++++++++                          
                             +++++++++++++                          
                             +++++++++++++                          
                             +++++++++++++                          
                             +++++++++++++                          
                             ++++++++++  +                          
                             ++++++++++  +                          
                             +++++++++++++                          
                             +++++++++++++                          
                             +++++++++++++                          
                             +++++++++++++                          
                             +++++++++++++                          
                             +++++++++++++                          
                             +++++++++++++                          
                             +  ++++++++++                          
                             +  ++++++++++                          
                             +++++++++++++                          
                             +++++++++++++                          
                             +++++++++++++                          
                             +++++++++++++                          
                             +++  ++++++++                          
                             ++    +++++++                          
                             ++    +++++++                          
                             ++    +++++++                          
                             ++    +++++++                          
                             ++    +++++++                          
                             ++    +++++++
                       ");
        }

        }
    }
}
