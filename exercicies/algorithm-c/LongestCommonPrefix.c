#include <stdio.h>
#include <stdlib.h>

// char* longestCommonPrefix(char** strs, int strsSize) {
//     char *result;
//     int idx;
//     int args;
//     int i;
//     if(!strs)
//         return (NULL);
//      args = 0;
//     while(**strs)
//     {
//         i = 0;
//         idx = 0;
//         while((strs[args][idx]))
//             {
//             if(strs[args][idx] == strs[args + 1][idx] && idx < strsSize){
//                 result[i] == strs[args][idx];
//                 i++;
//             }
//             else if(strs[args][idx] != strs[args + 1][idx] || (idx == strsSize)){
//                 return(result);
//             }
//             else
//             {
//                 free(result);
//                 return(NULL);
//             }
//             idx++;
//         }
//         args++;
//         strs++;
//     }
//     return(result);
// }


char* longestCommonPrefix(char** strs, int strsSize) {
    int idx;
    int args;
    char *result;

    idx = 0;
    args = 0;
    while (**strs)
    {
        while (strs[args][idx])
            idx++;
            printf("%i\n", idx);
        break;
    }
    result = malloc(sizeof(idx));
    args = 0;
    idx = 0;
    while (*strs[idx] < strsSize)
    {
        result[idx] = strs[args][idx];
        idx++; 
    }
    result[idx] = '\0';
    return(result);
}

int main(void)
{
	char *strs[] = {"william , will, willson"};
	char **final = strs;
    printf("%s\n", longestCommonPrefix(final, 3)); 
}