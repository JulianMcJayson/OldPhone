namespace OldPhone.Phone
{
    /// <summary>
    /// Handle Phone pad customization
    /// </summary>
    public class PhonePad
    {
        /// <summary>
        /// Represents the mapping of numeric keys on a phone keypad to their corresponding
        /// characters based on the number of presses.
        /// </summary>
        /// <remarks>
        /// it's a readonly property that contains char as a key to the inner dictionary
        /// with int is pad count and value is display character
        /// example user hits numpad 2, 2 times, it will be "b" character.
        /// </remarks>
        public Dictionary<char, Dictionary<int, string>> NumPads { get; } = new(){
            {'1', new Dictionary<int, string> { {1, "#" }, {2, "&"}, {3, "("} }},
            {'2', new Dictionary<int, string> { {1, "a"}, {2,"b"}, {3, "c"} }},
            {'3', new Dictionary<int, string> { {1, "d"}, {2, "e"},{3, "f"} }},
            {'4', new Dictionary<int, string> { {1, "g"}, {2, "h"}, {3, "i"} }},
            {'5', new Dictionary<int, string> { {1, "j"}, {2, "k"}, {3, "l"} }},
            {'6', new Dictionary<int, string> { {1, "m"}, {2, "n"}, {3, "o"} }},
            {'7', new Dictionary<int, string> { {1, "p"}, {2, "q"}, {3, "r"}, {4, "s"} }},
            {'8', new Dictionary<int, string> { {1, "t"}, {2, "u"}, {3, "v"} }},
            {'9', new Dictionary<int, string> { {1, "w"}, {2, "x"}, {3, "y"}, {4, "z"} }},
            {'0', new Dictionary<int, string> {{1," " }}},
            {' ', new Dictionary<int, string> {{1,"" }}},
            {'*', new Dictionary<int, string> {{1,"" }}},
            {'#', new Dictionary<int, string> {{1,"" }}},
        };
    }
}

