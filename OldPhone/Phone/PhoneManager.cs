namespace OldPhone.Phone
{
    /// <summary>
    /// Main app for old phone convert.
    /// </summary>
    public class PhoneManager(PhonePad pad)
    {
        /// <summary>
        /// Main function for passing user input and convert to word in uppercase safely.
        /// </summary>
        /// <param name="input">User Input</param>
        /// <returns>String result that represents a word in uppercase.</returns>
        public string OldPhonePad(string input)
        {
            //Init the result.
            var result = string.Empty;
            //Safety first.
            try
            {
                //Clean the input before passing the Numpad Pattern.
                var cleanInput = CleanInput(input);
                //Loop through every clean input element.
                foreach (var pad1 in cleanInput)
                {
                    //Add the Numpad character to the result.
                    result += pad.NumPads[pad1.Key][pad1.Time];
                }
            }
            //If it's fail, It will automatically catch and display the exception by category.
            catch (Exception e)
            {
                if (e is KeyNotFoundException)
                    Console.WriteLine("Input Error : " + e.Message);
                else
                    Console.WriteLine("Unexpected Error : " + e.Message);

                throw;
            }
            //Convert to upper character
            result = result.ToUpper();
            //Return the real result to the Main function.
            return result;
        }

        /// <summary>
        /// Cleans and processes the input string to format it into a list of PadPair objects,
        /// which represent the key pressed and the number of times it was pressed on an old-style phone keypad.
        /// </summary>
        /// <param name="input">User Input</param>
        /// <returns>List of PadPair, Key and User press count</returns>
        private List<PadPair<char, int>> CleanInput(string input)
        {
            //Replace # with empty string and trim white-space for reducing a workload.
            input = input.Replace("#", "");
            input = input.Trim();
            //List for storage a PadPair.
            var result = new List<PadPair<char,int>>();
            //Pad counter each number.
            var countKey = 1;
            //Right Pointer always starts at left + 1.
            var right = 1;
            //Left Pointer always starts at the first element of 0 index-based.
            var left = 0;
            
            //Two pointers technique move only left var, and right var finding a stop condition, End at the size of input.
            while (left < input.Length)
            {
                //A condition for checking is *, and then remove the element before.
                if (input[left] == '*' && left > 0)
                {
                    //Remove the element before '*'
                    result.RemoveAt(result.Count - 1);
                    //Update Pointer
                    left++;
                    right++;
                    continue;
                }
                
                //A condition for checking is 0, and then add space if in the case.
                if (input[left] == '0')
                {
                    //Add Space to the list, but this has to separate due to make it simple in the main function.
                    result.Add(new PadPair<char, int>(input[left], 1));
                    //Update Pointer
                    left++;
                    right++;
                    continue;
                }
                
                //Stop condition when left is difference to a right pointer.
                while (right < input.Length && input[left] == input[right])
                {
                    if(countKey >= pad.NumPads[input[left]].Count) countKey = 1;
                    //Update the counter and only the right pointer to finding the end of the same character.
                    countKey++;
                    right++;
                }
                
                //Add Character with Time to the list
                result.Add(new PadPair<char, int>(input[left], countKey));
                
                //Update Pointer
                left = right;
                right = left + 1;
                countKey = 1;
            }
            
            //Return result list.
            return result;
        }
    }
}

