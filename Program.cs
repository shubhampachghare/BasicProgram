
using BasicProgram;

public class Program
{
    static void Main(string[] args)
    {
        FlipCoin flipCoin = new FlipCoin();
        flipCoin.flipCoin();
        LeapYear leapYear = new LeapYear();
        leapYear.leapYear();
        PowerOfTwo powerOfTwo = new PowerOfTwo();
        powerOfTwo.powerOfTwo();
        HarmonicNumber harmonicNumber = new HarmonicNumber();
        harmonicNumber.harmonicNumber();
    }
}