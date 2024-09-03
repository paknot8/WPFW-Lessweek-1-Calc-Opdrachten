class SomInt
{
    // Properties
    public int Value { get; private set; }

    // Constructor with 1 value
    public SomInt(int Value)
    {
        this.Value = Value;
        this.Value = Value * 4;
    }

    // Constructor with addition: Addition (Adds two numbers to each other)
    public SomInt(int number1, int number2)
    {
        Value = number1 + number2;
    }

    // Constructor to addition two SomInts
    public SomInt(SomInt somInt1, SomInt somInt2)
    {
        Value = somInt1.Value + somInt2.Value;
    }
}