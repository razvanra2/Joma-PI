<Query Kind="Program" />

void Main()
{
	Random rnd = new Random();
	
	var pointsInCircle = 0;
	var totalPoints = 0;
	
	while(true)
	{
		var px = rnd.NextDouble();
		var py = rnd.NextDouble();
		
		var distToOrigin = Math.Sqrt((px - 0) * (px - 0) + (py - 0) * (py - 0));
		
		if (distToOrigin < 1)
		{
			pointsInCircle++;		
		}
		totalPoints++;

		var pi = (pointsInCircle / (double) totalPoints) * 4.0;
		pi.Dump("crt approximation of pi:");
	}
}
