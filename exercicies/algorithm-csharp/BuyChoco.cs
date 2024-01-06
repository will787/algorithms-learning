public class Solution {
    public int BuyChoco(int[] prices, int money) {
        int dispesa = money;
        int count = 0;

        Array.Sort(prices);
        for(int j = 0; j < prices.Length; j++){
            if(dispesa >= prices[j]){
                dispesa -= prices[j];
                count++;
                if(count == 2){
                    return(dispesa);
                }
            }
        }
        return(money);
    }
}
/*
 esse algoritmo me deu uma confusão, por conta dos parametros na hora de setar eles no array trouxe uma dificuldade que era de pegar/*
 os chocolates mais baratos, como tava vindo em ordem aleatoria {10, 3, 5, 1, 8} e o dinheiro sei lá sendo = 15;
 ele fazia a compra assim que chegava nos que ele podia, na teoria ele é o consumidor que tem o dinheiro mas nem ao menos ordena as possibilidades
 bom basicamente  esse era eu tentando organizar o algoritmo. Tinha me tocado só depois para usar Array.sort(prices); 
 basicamente ele ordena o array. Deixando do menor para o maior, então assim que ele encontrar as duas combinações possíveis
 ele retorna o valor de troco resultando na subtração da compra dos dois chocolates. O count ali só pra entrar na validação
 contar o chocolate, ele só precisava no caso de dois, os dois mais baratos e que encaixasse no orçamento dele
 mas tinha uma condição para comprar os dois chocolates, ou comprava os dois ou nenhum
 */