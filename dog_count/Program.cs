int distance = 10000; 
int time = 0;
int count = 0;
int FirstFriendSpeed = 1;
int SecondFriendSpeed = 2;
int DogSpeed = 5;  

while (distance > 10)
{
    int friend = 2;
    if (friend == 2)
    {
        time = distance / (FirstFriendSpeed + DogSpeed);
        friend = 2;
    }
    else time = distance / (SecondFriendSpeed + DogSpeed);
    friend = 1;
 
 distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * time;
 count = count + 1;
} 
Console.Write("собака пробежала ");
Console.WriteLine(count); 
Console.WriteLine("раз");