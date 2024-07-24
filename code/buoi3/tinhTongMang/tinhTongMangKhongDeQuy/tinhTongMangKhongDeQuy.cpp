#include <stdio.h>
#include <stdlib.h>
#include <stdio.h>

int sumArray(int arr[], int n) {
    int sum = 0;
    for (int i = 0; i < n; i++) {
        sum += arr[i];
    }
    return sum;
}

int main() {
    int n = 5;
    int arr[] = { 1, 2, 3, 4, 5 }; // Mảng từ 1 đến n
    int sum = sumArray(arr, n);
    printf("Tổng các phần tử trong mảng là: %d\n", sum);
    return 0;
}


