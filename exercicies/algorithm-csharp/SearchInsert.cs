public class Solution {
    public int SearchInsert(int[] nums, int target) {
        for(int i = 0; i < nums.Length; i++){
            if(target == nums[i]){
                return(i);
            }
        }
        for(int k = 0; k < nums.Length; k++){
            if(nums[k] > target){
                return(k);
            }
        }

        for(int j = nums.Length - 1; j >= 0; j--){
            if(nums[j] < target){
                return(j + 1);
            }
        }
        return(0);
    }
}

/*  talvez tenha complicado as coisas mas fiz de um jeito um pouco bruto para descobrir os casos possíveis
    o primeiro for é basicamente se caso realmente tiver a posição do index, então  ele irá percorrer o array
    se encontrar ele irá retornar a posição onde estava o respectivo target, que é o que procuramos.

    no terceiro for ele irá procurar o número então temos [1, 3, 4] e ele está procurando nosso target = 2
    logo devemos saber depois de qual número ele deverá vir, que é o 1
    verificamos se no array ele é maior que nosso target e será ali que deverá estar
    no caso na posição do 3, seria ali onde ele deveria estar.

    o terceiro for é com a ideia que ele não achou o target, mas devemos saber onde deveria estar o número na posição
    onde ele deverá estar do array, por exemplo se tiver um arrays [1,2, 3] e nosso target é = 4 percorrendo de trás pra frente
    achamos o valor mais rápido, olhamos se nessa última posição do array é o 3 for menor que 4 ele concluirá que deve estar na posição posição
    que será o próximo index no caso 2 + 1, lembrando que o index começa com 0;
*/