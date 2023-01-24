bool LinearSearch(int[] arr, int n){
    for (int i = 0; i < arr.Length; i++){
        if (arr[i] == n){
            return true;
        }
    }

    return false;
}

bool LinearSearchRecursive(int[] arr, int n, int index = 0){
    if (index >= arr.Length){
        return false;
    }

    if (arr[index] == n){
        return true;
    }

    return LinearSearchRecursive(arr, n, index + 1);
}

int[] array = {1,20,32,102,5,3,8,10};
Console.WriteLine(LinearSearch(array, 5) ? "Sayı bulundu" : "Sayı bulunamadı");
Console.WriteLine(LinearSearch(array, 11) ? "Sayı bulundu" : "Sayı bulunamadı");
Console.WriteLine(LinearSearchRecursive(array, 12) ? "Sayı bulundu" : "Sayı bulunamadı");
Console.WriteLine(LinearSearchRecursive(array, 8) ? "Sayı bulundu" : "Sayı bulunamadı");
