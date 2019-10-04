public int CalPoints(string[] ops) {
        Stack points = new Stack();
        int sum = 0;
        
        for(int i =0; i < ops.Length; i++)
        {
            if(ops[i] == "C" && points.Count != 0)
               {
                    sum = sum - (int)points.Pop();
               }               
            else if(ops[i] == "D")
               {
                   int point = (int)points.Peek();
                   points.Push(point * 2);
                   sum = sum + (point * 2);
               }
            else if(ops[i] == "+" && points.Count != 0)
               {
                   int last =  (int)points.Pop();
                   int second_last = points.Count != 0 ? (int)points.Peek() : 0;
                   points.Push(last);
                   points.Push(last + second_last);
                   sum = sum + last + + second_last;
               }
            else
               {
                   int point = Convert.ToInt32(ops[i]);
                   points.Push(point);
                   sum = sum + point;
               }
        }
        
        return sum;
    }
