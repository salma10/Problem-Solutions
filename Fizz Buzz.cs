public IList<string> FizzBuzz(int n) {
        IList<string> List_Of_FizzBuzz =  new List<string>();  
        
        string element = string.Empty;
        
        for(int i=1; i <= n; i++)
        {
            if(i%3 == 0 && i%5 == 0)
            {
                element = "FizzBuzz";
            }
            else if(i%3 == 0)
            {
                element = "Fizz";
            }
            else if(i%5 == 0)
            {
                element = "Buzz";
            }
            else
            {
                element = Convert.ToString(i);
            }
            
            List_Of_FizzBuzz.Add(element);
        }
        return List_Of_FizzBuzz;
    }
