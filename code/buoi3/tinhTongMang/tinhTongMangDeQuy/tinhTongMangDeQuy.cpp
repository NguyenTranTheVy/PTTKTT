#include <stdio.h>
#include <stdlib.h>

int divideAndConquerSum(int arr[], int n) {
	int sum = 0;
	for (int i = 0; i < n; i++) {
		sum += arr[i];
	}
	return sum;
}

int main() {
	int n;
	printf("Nhap so luong phan tu trong mang: ");
	scanf("%d", &n);
	int *arr = (int*)malloc(n * sizeof(int)); // Cấp phát động mảng
	if (arr == NULL) {
		printf("Khong du bo nho de cap phat mang\n");
		return 1;
	}
	printf("Nhap cac phan tu trong mang:\n");
	for (int i = 0; i < n; i++) {
		scanf("%d", &arr[i]);
	}
	int result = divideAndConquerSum(arr, n);
	printf("Tong cua mang la: %d\n", result);

	free(arr); // Giải phóng bộ nhớ

	return 0;
}
