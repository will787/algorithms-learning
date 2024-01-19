public class Solution {

    public bool IsPalindrome(int x){
        if(x < 0 || (x % 10 == 0 && x != 0))
            return(false);
        
        int reversed = 0;
        while(x > reversed){
            reversed = reversed * 10 + x % 10;
            x /= 10;
        }
        return x == reversed || x == reversed / 10;
    }
}

/*
Esse é uma verificação para ver se nosso número é um polindromo
fazendo uma reversão nesse número, se ele é input por exemplo
de "int x : 121" ele será um polindromo porque na ordem invertida dele
ele ficará também 121 mas no caso de um input (x: 10) não será um polindromo
pois na ordem invertida ele ficará 01; onde retornará falso
*/