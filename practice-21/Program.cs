string line1 = Console.ReadLine();
string line2 = Console.ReadLine();

string[] line1Arr = line1.Split(' ');
int[] vactor1 = Array.ConvertAll(line1Arr, int.Parse);
string[] line2Arr = line2.Split(' ');
int[] vactor2 = Array.ConvertAll(line2Arr, int.Parse);

float deltaX = vactor1[0] - vactor2[0];
float deltaY = vactor1[1] - vactor2[1];
float deltaZ = vactor1[2] - vactor2[2];

float distance = (float) Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);

Console.WriteLine(distance.ToString("0.00"));