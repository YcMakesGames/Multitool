using System;
using System.IO;

namespace MultiToolThingy
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose the function you would like ");
            Console.WriteLine("1. Calculator");
            Console.WriteLine("2. Timer");
            Console.WriteLine("3. memify a sentence");
            Console.WriteLine("4. mind game");
            Console.WriteLine("5. NoteBook");

            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                Console.Clear();  
                Calculator();
                break;
                case 2:
                Console.Clear();
                Timer();
                break;
                
                case 3:
                Console.Clear();
                memify();
                break;
                
                case 4:
                LowerOrHigher();
                break;
                case 5:
                Console.Clear();
                NoteBook();
                break;
                
                default:
                Console.WriteLine("Error");
                
                break;
            }

            Console.ReadLine();
            
        }
        static void Calculator(){

            char symb;
            float num1;
            float num2;
            float res;

            Console.WriteLine("Enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Enter the symbol (* or / or + or -)");
            symb = Convert.ToChar(Console.ReadLine()); 

            switch (symb){
            case '+':
            res = num1 + num2;
            Console.WriteLine("So the result is "+res);
            break;
            
            case '-':
            res = num1 - num2;
            Console.WriteLine("So the result is "+res);
            break;

            case '*':
            res = num1 * num2;
            Console.WriteLine("So the result is "+res);
            break;

            case '/':
            res = num1 / num2;
            Console.WriteLine("So the result is "+res);
            break;

            default:
            Console.WriteLine("error");
            Main();
            break;    
            }  
            Console.WriteLine("Calculation is done, do you wanna go back?");
            string Answer3 = Console.ReadLine();
            if(Answer3 == "yes")
            {
                Console.Clear();  
                Main();
                
                  
            }else{
                Console.WriteLine("press enter again to close to program");
            }
                      

            





            Console.ReadLine();
        }
        static void memify(){
            Console.WriteLine("Enter the text you want to memify (mAkE iT lIkE tHiS)");
            string dudy = Console.ReadLine();
            for (int i = 0; i < dudy.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(char.ToUpper(dudy[i]));
                }
                else
                {
                    Console.Write(char.ToLower(dudy[i]));
                }
            }
            Console.WriteLine("                                                            ");
            Console.WriteLine("Memification is done, Do you wanna go back to the main menu?");
            string bruhmomento = Console.ReadLine();
             if(bruhmomento == "yes")
            {
                Console.Clear();  
                Main();
                
                  
            }else{
                Console.WriteLine("press enter again to close to program");
            }
            
            

            Console.ReadLine();
        }
        static void Timer(){
            Console.WriteLine("Enter the time you want");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            while (a > 0)
            {
                Console.WriteLine($"remaining time: {a}");
                System.Threading.Thread.Sleep(1000);
                a--;
                Console.Clear();
            }
            
            

            Console.WriteLine("Timer is done, do you want to go back? Answer with yes or no");
            string answer = Console.ReadLine();

            if(answer == "yes"){
                Main();
            }
            if( answer == "no"){
                Console.WriteLine("Press enter again to close the application");

            }
            Console.ReadLine();
        }
        static void LowerOrHigher(){
            
            int lmfao123 = 1;
                       
            
            Console.WriteLine("Welcome to higher or lower!");
            Console.WriteLine("I will get a number between two numbers of your choice (example, a number between 1 and 900) and you're gonna try to guess it. You can choose 2 type of difficuly");
            Console.WriteLine("Either infinte tries (which is easy) or limited number of tries, the limited number of tries you can either choose the number or make it random!");
            Console.WriteLine("Press enter again to start the game");
            
            
            while(lmfao123 == 1){
            if(Console.ReadKey(true).Key == ConsoleKey.Enter){
                Console.Clear();
                lmfao123--;
            }
            }
            Console.WriteLine("let the games begin!");
            Console.Clear();
            caseOneTwo();
           

        }
        static void caseOneTwo(){
            int NumberOfTries = 5;
            
            int TriesUsed = 0; 
            int thingy = 1;
           
            Console.WriteLine("choose the first number(the big one) (btw the recommended numbers are 100 and 1)");
            int firstNum = 0;
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose the second number(da small number)");
            int secondNum = 0;
            secondNum = Convert.ToInt32(Console.ReadLine());

            if(firstNum - secondNum == 0 ||firstNum - secondNum == 1 || firstNum - secondNum == 2 || firstNum - secondNum == 3|| firstNum - secondNum == 4 || firstNum - secondNum == 5){
                Console.Clear();
                Console.WriteLine("If you see this then the anti cheat kicked in, The program with restart");
                System.Threading.Thread.Sleep(1000);
                LowerOrHigher();
            }

            Random guessedNum = new Random();
            int TwoGuessedNum = guessedNum.Next(secondNum, firstNum);


            
            



            
            while(thingy == 1){
            Console.WriteLine($"write a number between {firstNum} and {secondNum}.");
            int answer = Convert.ToInt32(Console.ReadLine());
            
            if (answer == TwoGuessedNum)
            {
                Console.WriteLine($"You got it :), the number of tries used was {TriesUsed}");
                thingy--;
            }else if (answer > TwoGuessedNum)
            {
                NumberOfTries--;
                TriesUsed++;
                Console.WriteLine($"your answer is higher, you got {NumberOfTries} tries left");
                
            }else if(answer < TwoGuessedNum)
            {
                NumberOfTries--;
                TriesUsed++;
                Console.WriteLine($"your answer is lower, you got {NumberOfTries} tries left");

                
            
            }if((TriesUsed - NumberOfTries) == TriesUsed){
                Console.WriteLine($"The number was {TwoGuessedNum}");
                thingy--;
            }
            }Console.WriteLine("Do you want to go back? if yes type yes if no type no");
            string Answer4 = Console.ReadLine();

            if (Answer4 == "yes"){
                Console.Clear();
                Main();
            }else{

            }
            

            
            


        }
        static void NoteBook(){
            
            Console.WriteLine("Welcome to the notebook feature!");
            Console.WriteLine("How to setup(don't worry it's really simple)");
            Console.WriteLine("Just make a text file in your desktop called 'NoteBook' and add 5 text files to it,  ");
            Console.WriteLine("Name them all 'note1' 'note2' 'note3' 'note4' ' note5' ");
            Console.WriteLine("press enter if you are done.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("What do you want to do");
            Console.WriteLine("1. Write in a note");
            Console.WriteLine("2. Reset a note(Make it empty)");
            Console.WriteLine("Type one of the numbers");


            int inputed = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (inputed){
                case 1:
                WriteTheNote();

                break;
                case 2:
                DeleteTheNote();

                break;
                default:
                Console.WriteLine("Error, restarting program on your command");
                RestartOnError();
                break;
            }
            
        }   
        static void RestartOnError(){
                Main();
            }
        static void WriteTheNote(){
                Console.WriteLine("Choose the note");
                Console.WriteLine("1 or 2 or 3 or 4 or 5");
                int choiceGrade = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("You have chosen, now the console will clear and you can");
                Console.WriteLine("Now write all you want (btw if you're adding new text make sure to put a space at first)");
                Console.WriteLine("Press enter to start");
                Console.ReadLine();
                Console.Clear();
                string inputedString = Console.ReadLine();
                // change the "YoussefCraft" to your user's name.
                switch (choiceGrade){
                    case 1:
                    File.AppendAllText(@"C:\Users\YoussefCraft\Desktop\NoteBook\Note1.txt", inputedString);
                    break;
                    case 2:
                    File.AppendAllText(@"C:\Users\YoussefCraft\Desktop\NoteBook\Note2.txt", inputedString);
                    break;
                    case 3:
                    File.AppendAllText(@"C:\Users\YoussefCraft\Desktop\NoteBook\Note3.txt", inputedString);
                    break;
                    case 4:
                    File.AppendAllText(@"C:\Users\YoussefCraft\Desktop\NoteBook\Note4.txt", inputedString);
                    break;
                    case 5:
                    File.AppendAllText(@"C:\Users\YoussefCraft\Desktop\NoteBook\Note5.txt", inputedString);
                    break;
                }
                Console.Clear();
                Console.WriteLine("Do you want to go back now that you have written what you wanted?");
                string answerofquetion = Console.ReadLine();

                if(answerofquetion == "yes"){
                    RestartOnError();
                }else{

                }
                

                

            }
        static void DeleteTheNote(){

                Console.WriteLine("Which note do you wanna delete");
                int answertoquestion = Convert.ToInt32(Console.ReadLine());
                switch(answertoquestion){
                    case 1:
                    Console.WriteLine("Do you really wanna delete this? press enter for yes");
                    Console.ReadKey();
                    Console.WriteLine("It is now done");
                    File.WriteAllText(@"C:\Users\YoussefCraft\Desktop\NoteBook\Note1.txt","");
                    break;
                    case 2:
                    Console.WriteLine("Do you really wanna delete this? press enter for yes");
                    Console.ReadKey();
                    Console.WriteLine("It is now done");
                    File.WriteAllText(@"C:\Users\YoussefCraft\Desktop\NoteBook\Note2.txt","");
                    break;
                    case 3:
                    Console.WriteLine("Do you really wanna delete this? press enter for yes");
                    Console.ReadKey();
                    Console.WriteLine("It is now done");
                    File.WriteAllText(@"C:\Users\YoussefCraft\Desktop\NoteBook\Note3.txt","");
                    break;
                    case 4:
                    Console.WriteLine("Do you really wanna delete this? press enter for yes");
                    Console.ReadKey();
                    Console.WriteLine("It is now done");
                    File.WriteAllText(@"C:\Users\YoussefCraft\Desktop\NoteBook\Note4.txt","");
                    break;
                    case 5:
                    Console.WriteLine("Do you really wanna delete this? press enter for yes");
                    Console.ReadKey();
                    Console.WriteLine("It is now done");
                    File.WriteAllText(@"C:\Users\YoussefCraft\Desktop\NoteBook\Note5.txt","");
                    break;
                }
                Console.ReadLine();

                Console.Clear();



                
            } 
        
    }
}
