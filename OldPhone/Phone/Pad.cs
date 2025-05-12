namespace OldPhone.Phone
{
    /// <summary>
    /// Represents a generic pairing of a keypad key and associated time or count.
    /// This structure is used to encapsulate the information of a phone keypad press.
    /// </summary>
    /// <param name="Key">The character representing the key pressed on the keypad, and it's associated with TKey</param>
    /// <param name="Time">The associated counter that the user presses for the key, and it's associated with TValue</param>
    public record PadPair<TKey, TValue>(TKey Key, TValue Time);
}
