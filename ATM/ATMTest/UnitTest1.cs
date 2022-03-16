using System;
using Xunit;
using ATM;

namespace ATMTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestviewBalance()
        {
            Assert.Equal(Program.Balance, Program.ViewBalance());
        }
        [Fact]
        public void Testdepositlessthanzero()
        {
            Assert.Equal(Program.Balance, Program.Deposit(-10));
        }
        [Fact]
        public void Testwithdrawgraterthanbalance()
        {
            Assert.Equal(Program.Balance, Program.withDraw(600));
        }
        [Fact]
        public void Testwithdrawlessthanzero()
        {
            Assert.Equal(Program.Balance, Program.withDraw(-10));
        }
    }
}
