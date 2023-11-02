#include <stdio.h>

int climbStairs(int n)
{
    if(n <= 1)
    {
        return(1);
    } else {
        int ways[n + 1];
        ways[0] = 1;
        ways[1] = 1;
    
        int i = 2;
        while(i <= n)
        {
            ways[i] = ways[n - 1] + ways[n - 2];
            i++;
        }

        return ways[n];
    }
}
