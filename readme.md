# Old Phone Challenge
Console Application for converting numpads to the English world.

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
This is short & sweet document for both users and developers.
### User
- use `git clone https://github.com/JulianMcJayson/OldPhone`
- `cd` to the `./OldPhone/OldPhone`
- finally run command `dotnet run`.
### Developer
This project has 3 class 1 record
+ `PhoneManager` (Class)
+ `PhonePad` (Class)
+ `PadPair` (Record)

you can create your own PhonePad with key-value such as 1-9 but some spacial like `0`, `*`, or `#` remain the same.\
this is an use case example.
```
var phonePad = new PhonePad();
var newPhone = new PhoneManager(phonePad);
var output = newPhone.OldPhonePad(input);
```
## Developer
Jaratphong Meethamkaewkla :man_technologist:
