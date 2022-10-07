
Random r = new Random();
string[] peoplesnames = new string[1000];
string[] firstnames = new string[10]{"jack ", "john ", "billy ", "calvin ", "mike ", "tony ", "francis ", "simon ", "chris ", "frank "};
string[] middlenames = new string[10]{"james ", "kade ", "theone ", "jean ", "jr ", "kane ", "braxton ", "mack ", "sue ", "riche " };
string[] lastnames = new string[10]{"callaway ", "smith ", "joseph ", "gabbagoul ", "schempp ", "beevers ", "largo ", "commanche ", "lee ", "cantor "};
string[] jobs = new string[]{"teacher ", "driver ", "sidewalk counter", "bomb maker ", "professional child wrangler ", "cowboy ", "sweat shop owner ", "door stopper ", "comedian ", "my therapist ",};
double[] Decimal = new double[]{.25,.5,.75};
int Counter = 0;

for (int x = 0; x < firstnames.Length ; x++)
{
    for ( int y = 0; y < middlenames.Length ; y++)
    {
        for (int z = 0; z < lastnames.Length ; z++)
        {
            int randomdecimal = r.Next(0,3);
            int random = r.Next(0, 5);
            int randomwages = r.Next(7,80);
            double wages = (double)randomwages;
            wages = wages + Decimal[randomdecimal];
            peoplesnames[x] = firstnames[x] + middlenames[y] + lastnames[z] + jobs[random];
            Counter++;
            Console.WriteLine($"{Counter}: {peoplesnames[x]}: Hourly wage: ${wages} Yearly income: ${wages*40*50} ");

        }
    }
}
