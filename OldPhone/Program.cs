using OldPhone.Phone;

namespace OldPhone
{
    class Program
    {
        private static void Main(string[] args)
        {
            //just input
            var input = Console.ReadLine();
            
            //Check nullable if input is not null
            if (input != null)
            {
                var phonePad = new PhonePad();
                var phone = new PhoneManager(phonePad);
                var output = phone.OldPhonePad(input);
                Console.WriteLine(output);
            }
        }
    }
}

