// Julius Cipher is a type of cipher which relates all the lowercase alphabets to their numerical position in the alphabet, i.e., value of a is 1, value of b is 2, value of z is 26 and similarly for the rest of them.
// Little Chandan is obsessed with this Cipher and he keeps converting every single string he gets, to the final value one gets after the multiplication of the Julius Cipher values of a string. Arjit is fed up of Chandan's silly activities, so he decides to at least restrict Chandan's bad habits.
// So, he asks Chandan not to touch any string which is a palindrome (reads from the left and the right the same), otherwise he is allowed to find the product of the Julius Cipher values of the string.
// Input: 
// The first line of every test case contains a string, S.
// Output: 
// Print the value if the string is not a palindrome, otherwise print Palindrome - where value is equal to the product of all the characters of Julius Cipher values.
// Constraints:  
// 1<=length of the string<=10
// Note:
// The string will contain only lowercase letters.
// SAMPLE INPUT
// zazaz
// goodarjit
// SAMPLE OUTPUT
// Palindrome
// 204120000

var testString = "goodarjit";

char[] chars = new char[25];
if (testString.Length >= 1 && testString.Length <= 10)
{
    bool isPalindrome = false;
    List<char> chrs = new List<char>();
    for (int i = 0, j = 1; i < testString.Length; i++, j++)
    {

        if (testString[i] == testString[testString.Length - j])
        {
            isPalindrome = true;
        }
        else
        {
            chrs.Add(testString[i]);
            isPalindrome = false;
        }

    }

    if (isPalindrome)
    {
        Console.WriteLine($"{isPalindrome}: {testString}");
    }
    else
    {
        long prod = 1;
        foreach (var ch in chrs)
        {
            prod *= CharPosition(ch);
        }
        Console.WriteLine(prod);

    }
   

}

int CharPosition(char ch)
{
    return ch - 'a' + 1;
}