/*
    Create a Console Application that asks the user
    for their name. Welcome me(Tim) as professor
    or anyone else as student. Make sure that "TIM"
    also gets called professor
 
 */

Console.Write("What is your name: ");
string name = Console.ReadLine();

//switch (name.ToLower())
//{
//    case "tim":
//        Console.WriteLine("Welcome Professor");
//        break;
//    default:
//        Console.WriteLine("Welcome Student");
//        break;
//}


if(name.ToLower() == "tim")
{
    Console.WriteLine("Welcome Professor");
} else
{
    Console.WriteLine("Welcome Student");
}
Console.ReadLine();