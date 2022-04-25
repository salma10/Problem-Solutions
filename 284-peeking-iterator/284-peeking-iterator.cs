// C# IEnumerator interface reference:
// https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerator?view=netframework-4.8

class PeekingIterator {
    
    private IEnumerator<int> vector1; 
    private int? next = null;
    // iterators refers to the first element of the array.
    public PeekingIterator(IEnumerator<int> iterator) {
        vector1 = iterator;
        next = vector1.Current;
        // initialize any member here.
    }
    
    // Returns the next element in the iteration without advancing the iterator.
    public int Peek() {
        return (int)next;
    }
    
    // Returns the next element in the iteration and advances the iterator.
    public int Next() {
        if(next == null)
            throw new Exception();
        
        int toReturn = (int)next;
        next = null;
        if (vector1​.MoveNext()) {
            next = vector1.Current;
        }
        return toReturn;
        
    }
    
    // Returns false if the iterator is refering to the end of the array of true otherwise.
    public bool HasNext() {
            return next != null;
    }
}