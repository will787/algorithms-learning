public class Solution {
    public int MyAtoi(string s) {
        int sign = 1;
        int i = 0;
        int result = 0;
        while(i < s.Length && ((s[i] >= 9 && s[i] <= 13) || s[i] == 32))
            i++;

        if(i < s.Length && (s[i] == '-' || s[i] == '+')){
            sign = (s[i] == '-') ? -1 : 1;
            i++;
        }
        while(i < s.Length && s[i] >= '0' && s[i] <= '9')
        {
            int digit = s[i] - '0';
            if(result > int.MaxValue / 10 || (result == int.MaxValue / 10 
            && digit > int.MaxValue % 10)){
                return (sign == 1) ? int.MaxValue : int.MinValue;
            }
            result = result * 10 + digit;
            i++;
        }
        return(result * sign);
    } 
}