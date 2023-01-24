/*
Techie Delight(https://www.techiedelight.com/sort-binary-array-linear-time/)
adresinde bulunan algoritmanın çözümü

Soru:
İkili bir dizi verildiğinde, onu doğrusal zaman ve sabit uzayda sıralayın. 
Çıktı, tüm sıfırları ve ardından tümünü yazdırmalıdır.
Input:  { 1, 0, 1, 0, 1, 0, 0, 1 }
Output: { 0, 0, 0, 0, 1, 1, 1, 1 }
*/

void SortBinaryArray(int[] arr){
    int zeroCount = 0;

    //0 sayısı bulunur
    foreach (int i in arr){
        if (i == 0){
            zeroCount += 1;
        }
    }
    
    //Dizinin başından itibaren 0 sayısı kadar dönüşüm yapılır
    for (int j = 0; j < zeroCount; j++){
        arr[j] = 0;
    }

    //Kalan öğeler 1 yapılır
    for (int k = arr.Length - zeroCount; k < arr.Length; k++){
        arr[k] = 1;
    }

    Array.ForEach(arr, Console.WriteLine);
}

int[] exampleInput = {1,0,1,0,1,0,0,1};
SortBinaryArray(exampleInput);
