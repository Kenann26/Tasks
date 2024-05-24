        int number = 12;
        
        if (number<=1)
        {
         Console.WriteLine($"{number}:Eded ne sade ne de murekkeb ededdir" );
         }
        else 
        {
            int Count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Count++;
            }
        }

        if (Count == 2)
        {
            Console.WriteLine("Eded sade ededdir");
        }
        else
        {
            Console.WriteLine("Eded murekkeb ededdir");
        }  
        }
    

