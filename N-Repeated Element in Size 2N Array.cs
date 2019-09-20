public int RepeatedNTimes(int[] A) {
        int len = A.Length;
        int result = A.GroupBy(c => c).Where(grp => grp.Count() == len/2).Select(grp => grp.Key).SingleOrDefault();
        return result;
    }
