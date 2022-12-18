internal class Point
    {

    public int point;



    public Point() { 


    Console.WriteLine("Balinizi daxil edin");
    this.point = int.Parse(Console.ReadLine());


    }




    public void bal()
    {
        while (point < 0 || point > 100)
        {
            Console.WriteLine("Balinizi dogru daxil edin");
            this.point = int.Parse(Console.ReadLine());
        }




    }


    public void point1()
    {

        if (50 < point)
        {
            Console.WriteLine("Telebe Mezun olub");
            if (point > 80)
            {
                Console.WriteLine("Telebe ikinci imtahana daxil ola biler");
            }
            else
            {
                Console.WriteLine("Telebe ikinci imtahana daxil ola bilmez");
            }

        }
        else
        {
            Console.WriteLine($"Telebe {point} bal yigdigi ucun mezun ola bilmeyib");
        }
    }

}

