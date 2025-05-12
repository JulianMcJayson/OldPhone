# Old Phone Challenge
A C# console application that simulates typing on a classic mobile numpad and converts input into English words.

Dotnet version: 9.0

## Project structure 
<pre>
📁 OldPhone
├── 📁 OldPhone
│   ├── Program.cs
│   └── 📁 Phone
│       ├── Pad.cs
│       ├── PhonePad.cs
│       └── PhoneManager.cs
├── 📁 OldPhoneTest
    └── PhoneTests.cs
</pre>

## Documentation
This short & sweet document is for both users and developers.

### User
Clone the project:
```bash
git clone https://github.com/JulianMcJayson/OldPhone
cd ./OldPhone/OldPhone
dotnet run
```
### Developer
This project contains:
- `PhoneManager` (main class)
- `PhonePad` (keypad layout and mappings)
- `PadPair` (record type to store key and press count)

You can create your own PhonePad with custom key mappings (1–9). Special keys like 0, *, and # maintain reserved behaviors.

Example usage:
```cs
var phonePad = new PhonePad();
var newPhone = new PhoneManager(phonePad);
var output = newPhone.OldPhonePad("4433555 555666#"); // Output: HELLO
```

## Developer
Jaratphong Meethamkaewkla, 2025 :man_technologist:
 
___
