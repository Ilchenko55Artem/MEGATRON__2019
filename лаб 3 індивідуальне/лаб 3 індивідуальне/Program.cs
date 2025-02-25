using System;

namespace MoneyApp
{
    abstract class Pair
    {
        public abstract Pair Add(Pair other);
        public abstract Pair Subtract(Pair other);
        public abstract Pair Multiply(int multiplier);
        public abstract Pair Divide(int divisor);
        public abstract void Display();
    }

    class Money : Pair
    {
        private long hryvnias;
        private byte kopecks;

        public Money(long hryvnias, byte kopecks)
        {
            this.hryvnias = hryvnias;
            this.kopecks = kopecks;
        }

        public override Pair Add(Pair other)
        {
            if (other is Money otherMoney)
            {
                long totalKopecks = this.hryvnias * 100 + this.kopecks + otherMoney.hryvnias * 100 + otherMoney.kopecks;
                return new Money(totalKopecks / 100, (byte)(totalKopecks % 100));
            }
            throw new InvalidOperationException("Cannot add different types of pairs.");
        }

        public override Pair Subtract(Pair other)
        {
            if (other is Money otherMoney)
            {
                long totalKopecks = this.hryvnias * 100 + this.kopecks - (otherMoney.hryvnias * 100 + otherMoney.kopecks);
                if (totalKopecks < 0) throw new InvalidOperationException("Result of subtraction cannot be negative.");
                return new Money(totalKopecks / 100, (byte)(totalKopecks % 100));
            }
            throw new InvalidOperationException("Cannot subtract different types of pairs.");
        }

        public override Pair Multiply(int multiplier)
        {
            long totalKopecks = (this.hryvnias * 100 + this.kopecks) * multiplier;
            return new Money(totalKopecks / 100, (byte)(totalKopecks % 100));
        }

        public override Pair Divide(int divisor)
        {
            if (divisor == 0) throw new DivideByZeroException("Cannot divide by zero.");
            long totalKopecks = (this.hryvnias * 100 + this.kopecks) / divisor;
            return new Money(totalKopecks / 100, (byte)(totalKopecks % 100));
        }

        public override void Display()
        {
            Console.WriteLine($"{hryvnias} грн {kopecks} коп.");
        }
    }

    class MoneyWithCoins : Pair
    {
        private int bills;
        private int coins;

        public MoneyWithCoins(int bills, int coins)
        {
            this.bills = bills;
            this.coins = coins;
        }

        public override Pair Add(Pair other)
        {
            if (other is MoneyWithCoins otherMoney)
            {
                return new MoneyWithCoins(this.bills + otherMoney.bills, this.coins + otherMoney.coins);
            }
            throw new InvalidOperationException("Cannot add different types of pairs.");
        }

        public override Pair Subtract(Pair other)
        {
            if (other is MoneyWithCoins otherMoney)
            {
                if (this.bills < otherMoney.bills || (this.bills == otherMoney.bills && this.coins < otherMoney.coins))
                    throw new InvalidOperationException("Result of subtraction cannot be negative.");
                return new MoneyWithCoins(this.bills - otherMoney.bills, this.coins - otherMoney.coins);
            }
            throw new InvalidOperationException("Cannot subtract different types of pairs.");
        }

        public override Pair Multiply(int multiplier)
        {
            return new MoneyWithCoins(this.bills * multiplier, this.coins * multiplier);
        }

        public override Pair Divide(int divisor)
        {
            if (divisor == 0) throw new DivideByZeroException("Cannot divide by zero.");
            return new MoneyWithCoins(this.bills / divisor, this.coins / divisor);
        }

        public override void Display()
        {
            Console.WriteLine($"{bills} купюр(и) і {coins} монет.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var money1 = new Money(100, 50);
            var money2 = new Money(200, 75);
            var resultMoney = (Money)money1.Add(money2);
            resultMoney.Display();

            var moneyWithCoins1 = new MoneyWithCoins(5, 10);
            var moneyWithCoins2 = new MoneyWithCoins(3, 8);
            var resultMoneyWithCoins = (MoneyWithCoins)moneyWithCoins1.Add(moneyWithCoins2);
            resultMoneyWithCoins.Display();
        }
    }
}
