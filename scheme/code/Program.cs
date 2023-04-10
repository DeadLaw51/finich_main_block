
void Print(string[] array ){
    for(int i = 0; i < array.Length ; i++){
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void Proba(string[] arr1, string[] arr2){
    int y = 0;
    for(int i = 0 ; i < arr1.Length ; i++){
        if( arr1[i].Length <= 3 ){
            arr2[y] = arr1[i];
            y++;
        }
    }
}

string[] arr1 = new string[5] {"123", "23", "hello", "world", "res"};
string[] arr2 = new string[arr1.Length];
Proba(arr1,arr2);
Print(arr2);