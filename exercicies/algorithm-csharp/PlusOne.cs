public class Solution {
    public int[] PlusOne(int[] digits) {
       //int[] plusfinal = new int[digits.Length];
       int n = digits.Length;
       for(int i = n - 1; i >= 0; i--){
           if(digits[i] < 9){
               digits[i]++;
               return digits;
           } else{
               digits[i] = 0;
           }
       }
        int[] plusfinal = new int[n + 1];
        plusfinal[0] = 1;
        return plusfinal;
    }
}
// esse algoritmo parece ser tranquilo, quando você pensa que só está envolvendor de verificar no última posição do array e adiconar +1 a esse valor
// mas o jeito certo para se análisar, percorrer o array de trás para frente, basicamente pegamos o tamanho dele e percorremos do tamanho -1 -1 -1 por aí vai.
// por exemplo temos um array do tamanho 3 {2, 3, 4} logo na posição do index 3 será o 4 então pegamos apartir dele, verificamos se ele é menor porque se for só aumentar +1 passando
// de 4 para 5, então terá novo valor dele, depois retornamos agora {2, 3, 5}
// mas temos uma possibilidade se a ultima  a casa for nove, por exemplo {7, 8, 9} então cairemos no else logo essa casa passará a ter valor de 0
// e no index onde estava o 8 passará a ser 9 ficando {7,9,0} foi algo que me encucou não tinha entendido essa parte, mas explicando aqui ajudou a refrescar.
// no ultimo caso se todos na posicao do array for nove o como por exemplo {9, 9 , 9} logo o output será {1, 0, 0, ,0}