using OldPhone.Phone;

namespace OldPhoneTest
{
    public class UnitTest1
    {
        private readonly PhoneManager _phone = new(new PhonePad());
        [Fact]
        public void NormalCase1()
        {
            var output = _phone.OldPhonePad("33#");
            Assert.Equal("E", output);
        }
        
        [Fact]
        public void NormalCase2()
        {
            var output = _phone.OldPhonePad("227*#");
            Assert.Equal("B", output);
        }

        [Fact]
        public void NormalCase3()
        {
            var output = _phone.OldPhonePad("4433555 555666#");
            Assert.Equal("HELLO", output);
        }
        
        [Fact]
        public void NormalCase4()
        {
            var output = _phone.OldPhonePad("8 88777444666*664#");
            Assert.Equal("TURING", output);
        }
        
        [Fact]
        public void NormalCase5()
        {
            var output = _phone.OldPhonePad("002200333");
            Assert.Equal("  B  F", output);
        }
        
        [Fact]
        public void FailCase1()
        {
            Assert.Throws<KeyNotFoundException>(() => _phone.OldPhonePad("$"));
        }
        
        [Fact]
        public void FailCase2()
        {
            Assert.Throws<NullReferenceException>(() =>
            {
                var newPhone = new PhoneManager(null!);
                newPhone.OldPhonePad("*");
            });
        }
        
        [Fact]
        public void EmptyCase()
        {
            var output = _phone.OldPhonePad("");
            Assert.Empty(output);
        }
    }
}

