using RPS;

string[] data = File.ReadAllLines("data.txt");
int opponent = 0;
int myPlay = 0;
int points = 0;

foreach (string line in data)
{
    string[] info = line.Split(" ");
    switch(info[0])
    {
        case "A":
            opponent = (int) Play.Rock;
            break;
        case "B":
            opponent = (int) Play.Paper;
            break;
        case "C":
            opponent = (int) Play.Scissors;
            break;
        default:
            break;
    }
    switch(info[1])
    {
        case "X":
            myPlay = (int) Play.Rock;
            points += 1;
            break;
        case "Y":
            myPlay = (int) Play.Paper;
            points += 2;
            break;
        case "Z":
            myPlay = (int) Play.Scissors;
            points += 3;
            break;
        default:
            break;
    }
    if(opponent.Equals(myPlay))
    {
        points += 3;
    }
    else if((opponent + 1) % 3 == myPlay)
    {
        points += 6;
    }
}
   Console.WriteLine(points);
