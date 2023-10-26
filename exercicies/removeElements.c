int removeElement(int* nums, int numsSize, int val){ 
    int i = 0;
    int newSize = numsSize;
    if(newSize == 0)
        return(0);
    int j;
    while(i < newSize)
    {
        if(nums[i] == val){
            newSize--;
            j = i;
            while(j < newSize){
                nums[j]  = nums[j + 1];
                j++;
            }
            i--;
        }
        i++; 
    }
    return newSize;
}
#include <stdio.h>
int main(void) {
    int nums[] = {1, 2, 2, 2, 3, 1, 4, 5};
    int len = sizeof(nums) / sizeof(nums[0]);  // Calcula o tamanho do array corretamente
    int val = 2;
    int newLen = removeElement(nums, len, val);

    printf("Novo tamanho do array: %d\n", newLen);

    // Imprima o array modificado, se desejar
    printf("Array modificado: ");
    for (int i = 0; i < newLen; i++) {
        printf("%d ", nums[i]);
    }
    printf("\n");
}
