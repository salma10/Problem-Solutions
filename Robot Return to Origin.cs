public bool JudgeCircle(string moves) {
        
        int Left = moves.Count(x => x == 'L');
        int Right = moves.Count(x => x == 'R');
        int Up = moves.Count(x => x == 'U');
        int Down = moves.Count(x => x == 'D');
        
        return (Left == Right) && (Up == Down);
    }
