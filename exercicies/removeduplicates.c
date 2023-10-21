/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   removeduplicates.c                                 :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: wivieira <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2023/10/21 11:31:37 by wivieira          #+#    #+#             */
/*   Updated: 2023/10/21 11:31:43 by wivieira         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

int removeDuplicados(int* nums, int numsSize){
    if(numsSize == 0)
        return(0);
    int k = 1;
    int i = 1;
    while(i < numsSize)
    {
        if(nums[i] != nums[i -1])
        {
            nums[k] = nums[i];
            k++;
        }
        i++;
    }
    return(k);
}

#include <stdio.h>

int main(void){
int nums[] = {0, 0, 1, 1, 1, 2, 2, 3, 3, 4};
int tamanho = sizeof(nums) / sizeof(nums[0]);

int k = removeDuplicados(nums, tamanho);
printf("%i\n", k);
}
