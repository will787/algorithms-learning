#include <stdlib.h>
#include <stdio.h>

void reverseString(char* s, int sSize) {
    
    char *revString;
    int i;    
    int j;

    revString = malloc((sSize + 1) * sizeof(char));
    if(!revString){
        return ;
      }
    i = sSize - 1;
    j = 0;
    while(i >= 0){
       revString[j] = s[i];
        i--;
        j++;
    }
    revString[j] = '\0';
    i = 0;
    while(revString[i])
    {
      s[i] = revString[i];
      i++;
    }
    free(revString);
}


int main() {
  char string[] = "williamson";
  reverseString(string, 4);
  printf("%s\n", string);
  return 0;
}