namespace IntegerCalculator
{
    public interface IntCalculator
    {
        int Result { get; }

        void Reset();
        
        void Add(int x);
        
        void Subtract(int x);
        
        void Multiply(int x);
        
        void Divide(int x);
        
        void Modulus(int x);
    }
}