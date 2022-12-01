
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
        PrimeFactorization primeFactorization = new PrimeFactorization();
        primeFactorization.primeFactorization();
        QuotientAndReminder quotientAndReminder = new QuotientAndReminder();
        quotientAndReminder.quotientAndReminder();
        SwapTwoNumber swapTwoNumber = new SwapTwoNumber();
        swapTwoNumber.swapTwoNumber();
        EvenOddNumber evenOddNumber = new EvenOddNumber();
        evenOddNumber.evenOddNumber();
        VowelOrConstatnt vowelOrConstatnt = new VowelOrConstatnt();
        vowelOrConstatnt.vowelOrConstant();
        LargestThreeNumber largestThreeNumber = new LargestThreeNumber();
        largestThreeNumber.largestThreeNumber();
    }
}